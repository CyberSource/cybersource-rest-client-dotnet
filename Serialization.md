[![Generic badge](https://img.shields.io/badge/SERIALIZATION-DEPENDENCY%20INJECTION-GREEN.svg)](https://shields.io/)

# JSON Serialization in CyberSource REST Client SDK (.NET)

The SDK serializes request payloads and deserializes API responses using `System.Text.Json`.

By default it applies its own tuned `JsonSerializerOptions`, but you can now **inject your own `JsonSerializerOptions`** into the SDK. This lets you control naming policies, converters, null-handling, and other serialization behavior without forking or subclassing the SDK.

There are two ways to customize the options:

* **Direct construction** — pass options (or post-configure callbacks) through the `Configuration` object / `MerchantNetworkSettings`. Best for callers that build the SDK by hand.
* **Dependency injection** — register the SDK's serialization pipeline with `Microsoft.Extensions.DependencyInjection` and customize it through the standard `IOptions`/`IOptionsMonitor` contracts. Best for hosts already using DI.

Either way, the SDK preserves your settings and converters but always layers a small set of **SDK invariants** on top so CyberSource models serialize and deserialize correctly (see [How the Options Are Resolved](#how-the-options-are-resolved)).

## What Changed

Previously the SDK's `System.Text.Json` options were fixed internally. Serialization is now driven by options that the caller can optionally supply:

* You can pass `JsonSerializerOptions` into the `Configuration` object (or onto `MerchantNetworkSettings`). The options are propagated to `ApiClient`.
* Serialization (request bodies) and deserialization (responses) can be configured **independently** — they never share a `JsonSerializerOptions` instance.
* You can register **post-configure callbacks** that run against the effective options at `ApiClient` construction time, either through the fluent `MerchantNetworkSettings` extensions or through the DI options pipeline.
* A first-class **DI entry point** — `IServiceCollection.AddSerialization()` — registers SDK-owned options wrappers (`SdkSerializerOptions`, `SdkDeserializerOptions`) so you can customize either track with `services.Configure<T>(...)` / `services.PostConfigure<T>(...)` and have the SDK resolve them via `IOptionsMonitor<T>`.
* If no options are supplied, the SDK falls back to its built-in defaults, so **existing behavior is unchanged** unless you opt in.
* Your injected options (serialization **and** deserialization) are *merged* with the SDK invariants rather than used as-is — the SDK preserves your settings and converters but forces the behavior it requires (see [How the Options Are Resolved](#how-the-options-are-resolved)).

## SDK Default Options

When you do not inject options, the SDK uses these built-in defaults:

* **Serialization** — `JsonSerializerDefaults.Web` (camelCase property names) with `DefaultIgnoreCondition = WhenWritingNull` (null properties are omitted), plus the model-extensibility conflict guard and the converters required to serialize CyberSource models.
* **Deserialization** — `JsonSerializerDefaults.Web` with `WhenWritingNull`, plus the converters required to deserialize CyberSource models (`ProtectedConstructorConverterFactory`, `StringOrNumberConverter`, `BooleanOrStringConverter`).

## Injecting Serializer Options

### Option 1 — Dictionary-based `Configuration` constructor

Pass your options via the `serializationOptions` and/or `deserializationOptions` parameters.

```csharp
using CyberSource.Client;
using System.Text.Json;
using System.Text.Json.Serialization;

// Example: keep the SDK's camelCase naming but add a custom converter.
var serializationOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
{
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    Converters = { new MyCustomConverter() }
};

var deserializationOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
{
    Converters = { new MyCustomConverter() }
};

var merchantConfig = new Configuration().GetConfiguration();

var configuration = new Configuration(
    merchConfigDictObj: merchantConfig,
    serializationOptions: serializationOptions,
    deserializationOptions: deserializationOptions);
```

### Option 2 — Full dependency injection

Hosts using `Microsoft.Extensions.DependencyInjection` can wire the SDK's JSON options pipeline through the standard `IOptions`/`IOptionsMonitor` contracts. Call `AddSerialization()` to register the SDK-owned wrapper types (`SdkSerializerOptions`, `SdkDeserializerOptions`) and the SDK's mandatory post-configures, then customize either track with `Configure<T>` / `PostConfigure<T>`:

```csharp
using CyberSource.Client;
using CyberSource.Utilities.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var services = new ServiceCollection();

// Register the SDK serialization pipeline.
services.AddSerialization();

// Customize either track. Consumer callbacks run BEFORE the SDK invariants,
// so the SDK's mandatory converters / ignore-condition / resolver always win.
services.PostConfigure<SdkSerializerOptions>(o => o.Options.WriteIndented = true);
services.Configure<SdkDeserializerOptions>(o => o.Options.PropertyNameCaseInsensitive = true);

using var provider = services.BuildServiceProvider();

// Resolve the monitors and attach them to the SDK.
var serializerMonitor = provider.GetRequiredService<IOptionsMonitor<SdkSerializerOptions>>();
var deserializerMonitor = provider.GetRequiredService<IOptionsMonitor<SdkDeserializerOptions>>();

var configuration = new Configuration(
    merchConfigDictObj: merchantConfig,
    serializerOptionsMonitor: serializerMonitor,
    deserializerOptionsMonitor: deserializerMonitor);
```

* `AddSerialization()` is **idempotent** — repeated calls do not stack duplicate registrations.
* When a monitor is attached, the SDK reads `CurrentValue.Options` from it and **ignores** the direct-injection surface (`SerializationOptions` / `DeserializationOptions` and their post-configure lists) for that track.

## How the Options Are Resolved

When an `ApiClient` is constructed from a `Configuration`, it resolves each JSON options track independently. The two tracks — serialization, and deserialization — never share a `JsonSerializerOptions` instance.

For the **serialization** and **deserialization** tracks the resolution order is:

1. **Options monitor** — if a DI-resolved `IOptionsMonitor<SdkSerializerOptions>` / `IOptionsMonitor<SdkDeserializerOptions>` is attached, its `CurrentValue.Options` is used (the options pipeline has already run all consumer and SDK post-configures). The SDK defensively re-applies its invariants so the guarantee is registration-order independent.
2. **Direct options + post-configures** — otherwise the caller's injected options are used as the seed (or the SDK default when absent), any registered post-configure callbacks run next, and finally the SDK invariants run last.

The SDK invariants always run after consumer post-configures, so they win any conflict.

| Concern | If a monitor is attached | If options are injected directly | If nothing is injected |
| --- | --- | --- | --- |
| Serialization (request bodies) | Uses monitor `CurrentValue.Options`, with the SDK serialization invariants re-applied | Uses a **copy** of your options, then post-configures, then the SDK serialization invariants | Uses the SDK default serialization options |
| Deserialization (responses) | Uses monitor `CurrentValue.Options`, with the SDK deserialization invariants re-applied | Uses a **copy** of your options, then post-configures, then the SDK deserialization invariants | Uses the SDK default deserialization options |

### Serialization invariants

When your serialization options are resolved, the SDK starts from a **copy** of your options (so your settings and converters are preserved) and then forces the following SDK-required invariants:

* **`DefaultIgnoreCondition = WhenWritingNull`** — null properties are omitted from request bodies.
* **A `TypeInfoResolver` carrying the model-extensibility conflict guard** — this validates the object graph at serialization time so a JSON field is never emitted twice (once as a typed property and once via `SetExtraField`). See [Model-Extensions.md](Model-Extensions.md).
* **The SDK's required converters** (`ProtectedConstructorConverterFactory`, `StringOrNumberConverter`, `BooleanOrStringConverter`) are layered in idempotently, skipping any converter type you already supplied.

### Deserialization invariants

Injected deserialization options are **no longer used as-is**. The SDK starts from a **copy** of your options and forces:

* **`DefaultIgnoreCondition = WhenWritingNull`**.
* **The SDK's required converters** (`ProtectedConstructorConverterFactory`, `StringOrNumberConverter`, `BooleanOrStringConverter`) are layered in idempotently, skipping any converter type you already supplied.

The `TypeInfoResolver` conflict guard is **not** forced on the deserialization track — it is a serialize-time invariant and would be inert on the read path.

## Notes

* Serialization and deserialization options are independent — you may inject one, both, or neither.
* Injected options are used across all API clients created from the same `Configuration`.
* The SDK layers its required converters onto **both** tracks automatically (idempotently), so you no longer need to add `ProtectedConstructorConverterFactory`, `StringOrNumberConverter`, or `BooleanOrStringConverter` yourself for either serialization or deserialization. Any converter type you already supplied is preserved and not duplicated.
* You cannot override the SDK invariants (the required converters, `WhenWritingNull`, and — for serialization — the conflict-guard `TypeInfoResolver`); they are required for CyberSource models to work correctly and always run last.
* If you inject no options, the SDK behaves exactly as before — no changes are required for existing integrations.

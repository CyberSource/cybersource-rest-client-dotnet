[![Generic badge](https://img.shields.io/badge/MODEL-EXTENSIBILITY-GREEN.svg)](https://shields.io/)

# Model Extensibility in the CyberSource REST Client SDK (.NET)

The SDK is **code-generated** from the CyberSource OpenAPI specification, so every model
exposes a typed property for each field the spec defines. The live API, however, often
**adds or changes fields before a new SDK version is generated and released**. Until now that
left a gap: you could not send or read a field the current SDK didn't model without forking
the SDK, hand-editing generated code, or doing fragile string manipulation on JSON.

These changes close that gap. Every generated model now inherits a small, supported API that
lets you **send unmapped fields** on any request and **read unmapped fields** on any response —
at any nesting level, with no forking and no code generation on your side.

---

## What Changed (at a glance)

| Change | Consumer impact |
| --- | --- |
| All generated models inherit a new `ModelExtensions` base class | Every request/response model gains extra-field methods automatically |
| `SetExtraField` / `GetExtraField<T>` / `TryGetExtraField<T>` | Send and read fields not modeled by this SDK version, at any depth |
| Unmapped response fields are captured during deserialization | Fields the API returns but the model doesn't declare are no longer dropped |
| Serialize-time conflict guard | Prevents accidentally sending the same JSON field twice |
| Extra fields participate in `Equals` / `GetHashCode` / `ToString` | Two models are equal only if their typed **and** extra fields match |
| Extra-field values are masked in logs (`ToString()` / `ToJson()`) | Sensitive data added via `SetExtraField` is redacted like typed properties |

> #### **NOTE: Nothing you already have breaks.** If you do not call the new methods, the SDK behaves exactly as before.

---

## The New API

Every model exposes three methods (from the `ModelExtensions` base class):

```csharp
void  SetExtraField(string jsonPropertyName, object value);
T     GetExtraField<T>(string jsonPropertyName);
bool  TryGetExtraField<T>(string jsonPropertyName, out T value);
```

You interact **only** through these methods. There is no public dictionary to manage and
nothing extra shows up in IntelliSense.

### 1. Send a field the SDK doesn't model — `SetExtraField`

Attach a field that has no typed property, at any level of the request object graph. The
field is written into the JSON body **on that specific object**.

```csharp
var request = new CreatePaymentRequest();

// top-level field
request.SetExtraField("customFlag", true);

// nested field — added to the nested object's JSON, no root-path navigation
request.OrderInformation.AmountDetails.SetExtraField("surcharge", "2.50");
request.OrderInformation.SetExtraField("shippingPriority", "express");
```

Produces:

```json
{
  "orderInformation": {
    "amountDetails": { "totalAmount": "100.00", "currency": "USD", "surcharge": "2.50" },
    "shippingPriority": "express"
  },
  "customFlag": true
}
```

Accepted `value` types: primitives, strings, complex objects / anonymous types, arrays, and
`JsonElement` tokens. Complex values serialize into proper **nested JSON** (not a quoted
string). A null or empty property name throws `ArgumentNullException`.

**Sending an explicit `null`:** an unmapped field set to `null` is treated as "absent" — it is
not emitted. To clear a value you have set, call `SetExtraField(name, null)`.

### 2. Read any returned field — `GetExtraField<T>`

Read a field the API returned by its JSON name, even when the model has no typed property for
it. The generic parameter drives conversion from JSON to your .NET type.

```csharp
ApiResponse<RiskV1DecisionsPost201Response> response = api.CreateDecisionManager(...);

// unmapped field returned by the API
string newIndicator = response.Data.RiskInformation.GetExtraField<string>("newIndicator");

// same field, type-converted (JSON "95" -> int 95)
int newScore = response.Data.RiskInformation.GetExtraField<int>("newScore");

// safe variant — never throws, returns false when missing/unconvertible
if (response.Data.RiskInformation.TryGetExtraField<string>("newFlag", out var flag))
{
    // use flag
}
```

- Works at **any nesting level** — each nested model exposes its own unmapped fields.
- Performs **type conversion** to `T` (including `string↔number` and `string↔bool`).
- Returns `default(T)` when the field is absent (no exception for the common "not found" case).
- `TryGetExtraField<T>` returns `false` instead of throwing when the field is missing or
  cannot be converted.

Supported `T`: primitives and value types (`string`, numerics, `bool`, `DateTime`, `Guid`,
enums, and their `Nullable<T>` forms), collections (`T[]`, `List<T>`,
`Dictionary<string,T>`), model/POCO classes, and raw `JsonElement`.

> **Known limitation:** a nested object that maps to **no** typed property anywhere is stored
> as raw JSON — there is no model instance to call `GetExtraField` on. Read it directly as a
> `JsonElement` (`parent.GetExtraField<JsonElement>("nested").GetProperty("inner")`) or
> deserialize the whole nested object into your own type via `GetExtraField<MyPoco>("nested")`.

### 3. Subclass a model for typed extensions (optional)

Models are `public partial` and not `sealed`, so you can subclass a request model and add your
own `[JsonPropertyName]` properties for compile-time typing / IntelliSense on new top-level
fields. Serialization is based on the **runtime type**, so your subclass properties appear in
the JSON automatically.

---

## Conflict Policy — one JSON field, one value

Because the SDK now merges typed properties and extra fields into one JSON body, it protects
you from accidentally sending the **same field twice**. For a given JSON name on a given
object:

| Typed property | Extra field via `SetExtraField` | Result |
| --- | --- | --- |
| `null` | value of the same/assignable type | written **through to the typed property** |
| `null` | value of a **different** type | kept as a **datatype override** (your value wins) |
| already set (non-null) | any | **throws** `InvalidOperationException` at `SetExtraField` |
| set non-null **after** an override | override present | **throws** at serialization time |
| `null` | `null` | property cleared, nothing emitted |

In short: you may override a field via `SetExtraField` **only while its typed property is
null**. If you set both to non-null values, the SDK throws rather than silently emitting a
duplicate key. This is a new runtime error you could encounter only if you set the same field
both ways — set it one way.

---

## Behavioral Changes to Be Aware Of

These are consequences of the changes that existing code may observe:

- **Equality now includes extra fields.** `Equals` and `GetHashCode` compare the typed
  properties **and** the extra-field store (by semantic JSON value: objects order-independent,
  arrays in order, numbers by value). Two models that differ only in extra fields are no longer
  considered equal.
- **`ToString()` and `ToJson()` show extra fields, masked.** Extra-field values are rendered in
  diagnostics with the same sensitive-data masking that typed properties receive, so secrets
  added via `SetExtraField` are not logged in the clear.
- **Unmapped response fields are retained.** Previously, JSON properties with no matching model
  property were dropped during deserialization. They are now captured so `GetExtraField<T>`
  can read them.

---

## Upgrade Safety (zero breaking change)

The API is designed so that when a **future SDK version adds a typed property** for a field you
previously accessed via `SetExtraField` / `GetExtraField`, your existing code keeps working
without modification:

- `GetExtraField<T>("x")` returns the value whether `x` is currently unmapped (read from the
  extra-field store) **or** later becomes a typed property (read from that property). The lookup
  is by JSON name, so the call site never changes.
- `SetExtraField("x", v)` keeps working after `x` becomes a real property: a same-type value is
  written through to the property, a different-type value becomes a datatype override.

You can therefore adopt these methods today and migrate to typed properties later at your own
pace — or never.

---

## Relationship to Serializer Configuration

This feature composes with the injectable `JsonSerializerOptions` described in
[Serialization.md](Serialization.md). However you customize serialization — whether by supplying
your own options directly on the `Configuration` / `MerchantNetworkSettings`, registering
post-configure callbacks, or wiring the SDK's DI pipeline via `AddSerialization()` — the SDK
**merges** your options with the required extensibility invariants. Your naming policy and
converters are preserved, while the SDK forces `DefaultIgnoreCondition = WhenWritingNull` and the
serialize-time conflict guard (`TypeInfoResolver`) on top so extra-field validation still runs
across the whole object graph. These invariants always run last, so they cannot be overridden.
You do not need to configure anything to use `SetExtraField` / `GetExtraField`.

---

## Summary

You can now send and read fields the current SDK version doesn't model — on any request or
response, at any nesting depth — using `SetExtraField`, `GetExtraField<T>`, and
`TryGetExtraField<T>`, without forking the SDK. Existing integrations are unaffected unless you
opt in, and code written against these methods survives future SDK upgrades that add the
corresponding typed properties.

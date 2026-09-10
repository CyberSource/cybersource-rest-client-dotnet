[![Generic badge](https://img.shields.io/badge/LOGGING-DEPENDENCY%20INJECTION-GREEN.svg)](https://shields.io/)

# Logging in CyberSource REST Client SDK (.NET)

The SDK's logging is built on top of [`Microsoft.Extensions.Logging`](https://learn.microsoft.com/dotnet/core/extensions/logging) (MEL), the standard logging abstraction for .NET.

Instead of the SDK owning its own logging configuration file, you now **inject your application's logger** into the SDK through dependency injection. This lets the SDK's log output flow through the exact same logging pipeline, providers, filters, and sinks that the rest of your application already uses (Console, NLog, Serilog, Application Insights, etc.).

## What Changed

Previously the SDK read an `NLog.config` file and created its own `NLog` loggers internally. Logging is now driven entirely by an `ILoggerFactory` that the caller supplies:

* The SDK depends only on `Microsoft.Extensions.Logging.Abstractions` — it does **not** impose a specific logging provider.
* You pass an `ILoggerFactory` into the `Configuration` object. The factory is propagated to `MerchantLegacySettings`, `MerchantNetworkSettings`, `ApiClient`, and every `ApiBase`-derived API client.
* If no factory is supplied, the SDK falls back to `NullLoggerFactory.Instance`, so **logging is a no-op by default** and there is nothing to turn off in production.
* Sensitive data masking is **always applied automatically** by the SDK before anything is logged. There is no longer an `enableMasking` toggle to configure.

## Setup

Add a `Microsoft.Extensions.Logging` provider package to your **application** project (the SDK itself only references the abstractions). Choose the provider that matches your logging stack, for example:

* `Microsoft.Extensions.Logging.Console` — console output
* `NLog.Extensions.Logging` — NLog
* `Serilog.Extensions.Logging` — Serilog

Install your chosen provider with the Package Manager, `dotnet add package`, or the [NuGet page](https://www.nuget.org/) for that package.

## Injecting a Logger

### Dictionary-based `Configuration` constructor

Pass your `ILoggerFactory` via the `loggerFactory` parameter.

```csharp
using CyberSource.Client;
using Microsoft.Extensions.Logging;

// Create a logger factory (Console shown here; use any provider you like).
using ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .SetMinimumLevel(LogLevel.Debug) // Debug is required to see HTTP request/response logs
        .AddConsole();
});

var merchantConfig = new Configuration().GetConfiguration();

var configuration = new Configuration(
    merchConfigDictObj: merchantConfig,
    loggerFactory: loggerFactory);
```

### Using the ASP.NET Core / Generic Host DI container

If your application already resolves an `ILoggerFactory` from `IServiceProvider`, simply pass it through:

```csharp
public class PaymentService
{
    private readonly Configuration _configuration;

    public PaymentService(ILoggerFactory loggerFactory)
    {
        _configuration = new Configuration(
            merchConfigDictObj: merchantConfig,
            loggerFactory: loggerFactory);
    }
}
```

### Full dependency injection with `EnsureLoggerFactory()`

When you build `Configuration` from resolved container services, register the SDK's logging dependency with `EnsureLoggerFactory()` so the container-based constructor can receive an `ILoggerFactory` through constructor injection — you no longer have to pass it in by hand:

```csharp
using CyberSource.Client;
using CyberSource.Utilities.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

var services = new ServiceCollection();

// Register your logging providers as usual (Console shown here; use any provider).
services.AddLogging(builder => builder.SetMinimumLevel(LogLevel.Debug).AddConsole());

// Register the SDK serialization + logging dependencies.
services.AddSerialization();
services.EnsureLoggerFactory();

using var provider = services.BuildServiceProvider();

var configuration = new Configuration(
    merchantCredentialSettings: credentialSettings,
    merchantMLESettings: mleSettings,
    merchantNetworkSettings: networkSettings,
    merchantLegacySettings: legacySettings,
    serializerOptionsMonitor: provider.GetRequiredService<IOptionsMonitor<SdkSerializerOptions>>(),
    deserializerOptionsMonitor: provider.GetRequiredService<IOptionsMonitor<SdkDeserializerOptions>>(),
    loggerFactory: provider.GetRequiredService<ILoggerFactory>(),
    httpClientFactory: null); // see HttpClientDependencyInjection.md to also inject transport
```

* `EnsureLoggerFactory()` **preserves** any `ILoggerFactory` you already registered (for example via `AddLogging(...)`). Only when none exists does it register a `NullLoggerFactory.Instance` fallback, so the container-based constructor always resolves a non-null factory.
* `EnsureLoggerFactory()` is **idempotent** — repeated calls do not stack duplicate registrations.
* Passing a `null` `loggerFactory` to the constructor falls back to `NullLoggerFactory.Instance`, keeping logging a no-op.
* The resolved factory is applied to `MerchantLegacySettings` and used to create the `MerchantNetworkSettings` logger, so the entire SDK surface shares the container-configured pipeline.

## Using NLog as the Provider

NLog is still fully supported — it is now wired in as a standard `Microsoft.Extensions.Logging` provider rather than being configured inside the SDK. Add the `NLog.Extensions.Logging` package, keep your `NLog.config` in your application, and register NLog with the logger factory:

```csharp
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

using ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .SetMinimumLevel(LogLevel.Debug)
        .AddNLog(); // reads NLog.config from the application directory
});

var configuration = new Configuration(
    merchConfigDictObj: merchantConfig,
    loggerFactory: loggerFactory);
```

Refer to the [NLog configuration documentation](https://nlog-project.org/config/) for details on targets, layouts, and rules. Ensure the `NLog.config` file's **`Copy To Output Directory`** property is set to **`Copy Always`**, or add the following to your project file:

```xml
<ItemGroup>
    <None Update="NLog.config">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
</ItemGroup>
```

## Log Categories

The SDK creates loggers using the following category names (the fully-qualified type names). Use these categories to filter SDK log output independently from your application's logs:

| Category | Emitted by |
| --- | --- |
| `CyberSource.Client.ApiClient` | HTTP request/response headers, status codes, bodies, and (de)serialization errors |
| `CyberSource.Api.ApiBase` | Base API client operations (shared by all generated API classes) |

Example of filtering by category when creating the factory:

```csharp
using ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .AddConsole()
        // Only honor SDK client logs at Debug and above; everything else at Warning.
        .AddFilter("CyberSource.Client.ApiClient", LogLevel.Debug)
        .AddFilter(null, LogLevel.Warning);
});
```

## Log Levels

| Level | What the SDK logs |
| --- | --- |
| `Debug` | HTTP request headers and body, HTTP response status code, response headers and body |
| `Error` | JSON serialization/deserialization exceptions, file-write failures, and invalid-operation conditions |

> To see the full HTTP request/response diagnostic output, the effective minimum level for the SDK categories must be `Debug` (or lower). In production this is typically raised to `Warning` or `Error`.

## Sensitive Data Masking

Masking is **built into the SDK and always on** — you no longer enable it through a configuration flag. Before any header or body is logged, the SDK runs it through its masking utilities so that sensitive values are replaced with `***` in the log output.

Masked fields include (non-exhaustive):

* Card number / PAN and any field named `number`
* Card security code (CVV / CVN) and `securityCode`
* Card expiration month and year
* Account number and bank routing number
* Passwords, secrets, secret keys, API keys, client secrets
* Tokens (access, refresh, transient, ID, one-time-password, etc.), JWT IDs, and signatures
* Cryptograms and encrypted request/response payloads
* PII such as SSN, email, first/last name, and phone number

## Notes

* Logging is disabled by default (`NullLoggerFactory`). No SDK log output is produced until you inject a real `ILoggerFactory`.
* The `ILoggerFactory` you inject is reused across the `Configuration` and all API clients created from it, so a single factory configures logging for the entire SDK surface.
* Because logging goes through `Microsoft.Extensions.Logging`, you control levels, filters, formatting, and destinations entirely through your chosen provider's standard configuration — not through the SDK.

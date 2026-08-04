[![Generic badge](https://img.shields.io/badge/HTTPCLIENT-DEPENDENCY%20INJECTION-GREEN.svg)](https://shields.io/)

# HttpClient Injection in CyberSource REST Client SDK (.NET)

The SDK sends every request through RestSharp, which in turn uses an `HttpClient`.

You can now **inject your own `HttpClient` or `IHttpClientFactory`** into the SDK through dependency injection, giving you full control over the underlying transport — handler configuration, proxy, client certificates, connection pooling, and lifetime — and letting the SDK participate in a modern `Microsoft.Extensions.DependencyInjection` HTTP pipeline.

## What Changed

Previously the SDK always built and pooled its own `HttpClient` internally. HTTP transport is now resolved from options the caller can optionally supply:

* You pass an `HttpClient` and/or an `IHttpClientFactory` into the `Configuration` object (or onto `MerchantNetworkSettings`). They are propagated to the `ApiClient`'s RestSharp client.
* If neither is supplied, the SDK falls back to its **internally managed, pooled client**, so **existing behavior is unchanged** unless you opt in.
* The SDK never disposes a caller-supplied client — you own its lifetime.

## Transport Ownership Modes

The SDK chooses a transport using the following precedence (highest first):

| Priority | Injected value | Behavior |
| --- | --- | --- |
| 1 | `HttpClient` | Wrapped and used directly. Never cached or disposed by the SDK. The caller owns and configures the handler, proxy, client certificates, connection pooling, and timeout. The SDK's own proxy/certificate/pool settings are **ignored** for this client. |
| 2 | `IHttpClientFactory` | `CreateClient()` is called per request. Never disposed by the SDK; the factory owns handler pooling and rotation. Only consulted when no `HttpClient` was injected. **Recommended** for `Microsoft.Extensions.DependencyInjection` consumers. |
| 3 | Neither | The SDK's internally managed `StandardSocketsHttpHandler`-backed client is used, with connection pooling and TTL/size-based eviction. This is the default, backward-compatible path. |

## Injecting an HttpClient or Factory

### Option 1 — Dictionary-based `Configuration` constructor

Pass your transport via the `httpClient` and/or the `httpClientFactory` parameters.

```csharp
using CyberSource.Client;
using System.Net.Http;

var merchantConfig = new Dictionary<string, string>
{
    { "authenticationType", "http_signature" },
    { "merchantID", "your_merchant_id" },
    { "runEnvironment", "apitest.cybersource.com" },
    { "merchantKeyId", "your_key_id" },
    { "merchantsecretKey", "your_shared_secret" }
};

// (a) Inject a caller-owned HttpClient.
var httpClient = new HttpClient(); // configure handler/proxy/certs/timeout as needed
var configuration = new Configuration(
    merchConfigDictObj: merchantConfig,
    httpClient: httpClient);

// (b) Inject an IHttpClientFactory.
var configurationFromFactory = new Configuration(
    merchConfigDictObj: merchantConfig,
    httpClientFactory: myHttpClientFactory);
```

### Option 2 — Pre-configured settings constructor

Attach the transport to `MerchantNetworkSettings` using the fluent `AddHttpClient` / `AddHttpClientFactory` extension methods, then pass the settings into `Configuration`:

```csharp
using CyberSource.Client;
using System.Net.Http;

var network = new MerchantNetworkSettings(merchantNetworkDictionary)
    .AddHttpClient(httpClient);                       // caller-owned HttpClient
    // or:
    // .AddHttpClientFactory(httpClientFactory);

var configuration = new Configuration(
    merchantCredentialSettings: credentialSettings,
    merchantMLESettings: mleSettings,
    merchantNetworkSettings: network,
    merchantLegacySettings: legacySettings);
```

Both extension methods return the same `IMerchantNetworkSettings` instance so calls can be chained, and each is a no-op if the underlying settings object is not mutable. Passing `null` to `AddHttpClient` clears the injection and restores SDK-managed behavior.

### Using `IHttpClientFactory` with the DI container

In an ASP.NET Core / Generic Host application, register a client and resolve the factory from `IServiceProvider`:

```csharp
// Startup / Program.cs
services.AddHttpClient("cybersource", client =>
{
    client.Timeout = TimeSpan.FromSeconds(100);
})
.ConfigurePrimaryHttpMessageHandler(() => new SocketsHttpHandler
{
    MaxConnectionsPerServer = 100,
    PooledConnectionLifetime = TimeSpan.FromMinutes(5)
});
```

```csharp
// Where you build Configuration
public class PaymentService
{
    private readonly Configuration _configuration;

    public PaymentService(IHttpClientFactory httpClientFactory)
    {
        _configuration = new Configuration(
            merchConfigDictObj: merchantConfig,
            httpClientFactory: httpClientFactory);
    }
}
```

This is the recommended approach: `IHttpClientFactory` handles handler pooling and rotation, avoiding both socket exhaustion and stale-DNS issues.

## Notes

* **The SDK never disposes an injected `HttpClient` or a client resolved from an injected factory** — lifetime is entirely the caller's responsibility.
* When you inject an `HttpClient`, the SDK's own proxy, client-certificate, and connection-pool settings on `MerchantNetworkSettings` are **not** applied — configure those on your `HttpMessageHandler` directly.
* The `HttpClient` takes precedence over the `IHttpClientFactory`; if both are supplied, the factory is not consulted.
* If you inject nothing, the SDK behaves exactly as before, using its internally pooled `StandardSocketsHttpHandler`-backed client with TTL/size-based eviction. No changes are required for existing integrations.

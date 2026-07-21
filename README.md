
# .NET Client SDK for the CyberSource REST API

The CyberSource .NET Standard client provides convenient access to the [CyberSource REST API](https://developer.cybersource.com/api/reference/api-reference.html) from your .NET application.

## Target Frameworks

* .NET Framework 4.6.1
* .NET Standard 2.0
* .NET Standard 2.1
* .NET 8.0

## Installation

* Nuget Package Manager

```default
PM>  Install-Package CyberSource.Rest.Client
```

## Account Registration and Configuration

* Account Registration

Follow the first step mentioned in [Getting Started with CyberSource REST SDKs](https://developer.cybersource.com/hello-world/rest-api-sdks.html#gettingstarted) to create a sandbox account.

* Configuration

Follow the second step mentioned in [Getting Started with CyberSource REST SDKs](https://developer.cybersource.com/hello-world/rest-api-sdks.html#gettingstarted) to configure the SDK by inputting your credentials.

***Please note that this is for reference only. Ensure to store the credentials in a more secure manner.***

## How to Use

To get started using this SDK, it is highly recommended to download our sample code repository:

* Cybersource .NET Sample Code Repository (on GitHub) <!-- [Cybersource .NET Sample Code Repository (on GitHub)](https://github.com/CyberSource/cybersource-rest-samples-dotnet) -->

In that repository, we have comprehensive sample codes for all common uses of our APIs.

Additionally, you can find details and examples of how our API is structured in our API Reference Guide:

* [Developer Center API Reference](https://developer.cybersource.com/api/reference/api-reference.html)

The API Reference Guide provides examples of what information is needed for a particular request and how that information would be formatted. Using those examples, you can easily determine what methods would be necessary to include that information in a request using this SDK.

## Example using .NET Framework 4.6.1 Sample Code Application

* Add [CyberSource REST Client](https://github.com/CyberSource/cybersource-rest-samples-dotnet/blob/master/Cybersource.Rest.Samples.Net461/Cybersource.Rest.Samples.Net461.csproj#L33) into your .NET project.

* Configure your credentials in [`Configuration.cs` file](https://github.com/CyberSource/cybersource-rest-samples-dotnet/blob/master/Shared/Source/Configuration.cs#L14-L52)

* Use the stored crdentials to create an instance of [`CyberSource.Client.Configuration`](https://github.com/CyberSource/cybersource-rest-samples-dotnet/blob/master/Shared/Source/Samples/Payments/Payments/SimpleAuthorizationInternet.cs#L94-L95).

* Create an instance of the [API Controller](https://github.com/CyberSource/cybersource-rest-samples-dotnet/blob/master/Shared/Source/Samples/Payments/Payments/SimpleAuthorizationInternet.cs#L97) using the instance of `CyberSource.Client.Configuration`.

* Use the created API instance to call CyberSource APIs. For example [SimpleAuthorizationInternet](https://github.com/CyberSource/cybersource-rest-samples-dotnet/blob/master/Shared/Source/Samples/Payments/Payments/SimpleAuthorizationInternet.cs#L98).

For more detailed examples, refer to the [cybersource-rest-samples-dotnet](https://github.com/CyberSource/cybersource-rest-samples-dotnet) repository.

### Switching between the sandbox environment and the production environment

Cybersource maintains a complete sandbox environment for testing and development purposes. This sandbox environment is an exact duplicate of our production environment with the transaction authorization and settlement process simulated.

By default, this SDK is configured to communicate with the sandbox environment. To switch to the production environment, set the `runEnvironment` property in the SDK Configuration, as shown in [Sample Configuration file](https://github.com/CyberSource/cybersource-rest-samples-dotnet/blob/master/Shared/Source/Configuration.cs).

```csharp
    // For TESTING use
    _configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");

    // For PRODUCTION use
    // _configurationDictionary.Add("runEnvironment", "api.cybersource.com");
```

API credentials are different for each environment, so be sure to switch to the appropriate credentials when switching environments.

### Logging

[![Generic badge](https://img.shields.io/badge/LOGGING-NEW-GREEN.svg)](https://shields.io/)

The logging framework makes use of NLog, and standardizes the logging so that it can be integrated with the logging in the client application.

More information about this new logging framework can be found in this file : [Logging.md](Logging.md)

## Features

### Message Level Encryption (MLE) Feature

[![Generic badge](https://img.shields.io/badge/MLE-NEW-GREEN.svg)](https://shields.io/)

This feature provides an implementation of Message Level Encryption (MLE) for APIs provided by CyberSource, integrated within our SDK. This feature ensures secure communication by encrypting messages at the application level before they are sent over the network.

More information about this new MLE feature can be found in this file : [MLE.md](MLE.md)

### JWT Authentication with Symmetric Key (Shared Secret / HS256 HMAC-SHA256) Support

[![Generic badge](https://img.shields.io/badge/JWT_SHARED_SECRET-NEW-GREEN.svg)](https://shields.io/)

> **⚠️ HTTP Signature Deprecation Notice:** HTTP Signature authentication (`HTTP_SIGNATURE`) is being deprecated.
> 
> JWT with Shared Secret (HS256 / HMAC-SHA256) is the **recommended migration path** — it uses the **same** `merchantKeyId` and `merchantsecretKey` credentials, requires only two property changes, and enables MLE (Message Level Encryption) support that HTTP Signature does not provide.

JWT authentication now supports two key types, configurable via the `jwtKeyType` property:

| `jwtKeyType` | Algorithm | Credentials Required |
|--------------|-----------|----------------------|
| `P12` (default) | RS256 (asymmetric, RSA-SHA256) | `keysDirectory`, `keyFilename`, `keyAlias`, `keyPass` |
| `SHARED_SECRET` | HS256 (symmetric, HMAC-SHA256) | `merchantKeyId`, `merchantsecretKey` |

The default value is `P12`, which preserves full backward compatibility with existing configurations.

#### Configuration for JWT with P12 (default — no changes needed)

```csharp
_configurationDictionary.Add("authenticationType", "JWT");
_configurationDictionary.Add("merchantID", "your_merchant_id");
_configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
// jwtKeyType defaults to P12 if omitted
_configurationDictionary.Add("keyAlias", "your_merchant_id");
_configurationDictionary.Add("keyPass", "your_merchant_id");
_configurationDictionary.Add("keyFilename", "your_merchant_id");
_configurationDictionary.Add("keysDirectory", @"path\to\p12\directory");
```

#### Configuration for JWT with Shared Secret

```csharp
_configurationDictionary.Add("authenticationType", "JWT");
_configurationDictionary.Add("merchantID", "your_merchant_id");
_configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
_configurationDictionary.Add("jwtKeyType", "SHARED_SECRET");
_configurationDictionary.Add("merchantKeyId", "your_key_id");
_configurationDictionary.Add("merchantsecretKey", "your_base64_encoded_shared_secret");
```

> **Note:** When `jwtKeyType` is set to `SHARED_SECRET`, the P12-related properties (`keysDirectory`, `keyFilename`, `keyAlias`, `keyPass`) are not required and will be ignored. Conversely, when using `P12`, the `merchantKeyId` and `merchantsecretKey` properties are not required for JWT authentication.

#### Migrating from HTTP Signature to JWT with Shared Secret (HS256 / HMAC-SHA256)

If you are currently using HTTP Signature authentication, migrating to JWT with Shared Secret requires only **two property changes** — your credentials remain the same:

```csharp
// BEFORE (HTTP Signature — deprecated)
_configurationDictionary.Add("authenticationType", "HTTP_SIGNATURE");
_configurationDictionary.Add("merchantKeyId", "your_key_id");
_configurationDictionary.Add("merchantsecretKey", "your_shared_secret");

// AFTER (JWT with Shared Secret / HS256 HMAC-SHA256 — recommended)
_configurationDictionary.Add("authenticationType", "JWT");             // changed
_configurationDictionary.Add("jwtKeyType", "SHARED_SECRET");           // added — uses HS256 (HMAC-SHA256)
_configurationDictionary.Add("merchantKeyId", "your_key_id");          // same
_configurationDictionary.Add("merchantsecretKey", "your_shared_secret"); // same
```

#### Using MLE with Shared Secret Credentials

MLE (Message Level Encryption) is fully supported with the `SHARED_SECRET` key type. When using `jwtKeyType=SHARED_SECRET` with MLE, you must provide the MLE public certificate separately via the `mleForRequestPublicCertPath` property, since there is no P12 file to auto-extract the MLE certificate from.

The request MLE public certificate can be downloaded from the CyberSource Business Center:

- **Test**: <https://businesscentertest.cybersource.com/ebc2>
- **Production**: <https://businesscenter.cybersource.com/ebc2>

```csharp
_configurationDictionary.Add("authenticationType", "JWT");
_configurationDictionary.Add("merchantID", "your_merchant_id");
_configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
_configurationDictionary.Add("jwtKeyType", "SHARED_SECRET");
_configurationDictionary.Add("merchantKeyId", "your_key_id");
_configurationDictionary.Add("merchantsecretKey", "your_base64_encoded_shared_secret");

// Request MLE configuration
_configurationDictionary.Add("enableRequestMLEForOptionalApisGlobally", "true");
_configurationDictionary.Add("mleForRequestPublicCertPath", @"C:\path\to\mle\public\cert.pem");
```

For more details on MLE configuration options (including Response MLE), see [MLE.md](MLE.md).

### MetaKey Support

A Meta Key is a single key that can be used by one, some, or all merchants (or accounts, if created by a Portfolio user) in the portfolio.

The Portfolio or Parent Account owns the key and is considered the transaction submitter when a Meta Key is used, while the merchant owns the transaction.

Merchant IDs continue to be able to create keys for themselves, even if a Meta Key is generated.

MetaKey works with all three authentication types: HTTP Signature, JWT (P12), and JWT with Shared Secret.

Further information on MetaKey can be found in [New Business Center User Guide](https://developer.cybersource.com/library/documentation/dev_guides/Business_Center/New_Business_Center_User_Guide.pdf).

## How to Contribute

* Fork the repo and create your branch from `master`.
* If you've added code that should be tested, add tests.
* Ensure the test suite passes.
* Submit your pull request! (Ensure you have [synced your fork](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/syncing-a-fork) with the original repository before initiating the PR).

## Need Help?

For any help, you can reach out to us at our [Discussion Forum](https://community.developer.cybersource.com/t5/cybersource-APIs/bd-p/api).

## Disclaimer

CyberSource may allow Customer to access, use, and/or test a CyberSource product or service that may still be in development or has not been market-tested (“Beta Product”) solely for the purpose of evaluating the functionality or marketability of the Beta Product (a “Beta Evaluation”). Notwithstanding any language to the contrary, the following terms shall apply with respect to Customer’s participation in any Beta Evaluation (and the Beta Product(s)) accessed thereunder: The Parties will enter into a separate form agreement detailing the scope of the Beta Evaluation, requirements, pricing, the length of the beta evaluation period (“Beta Product Form”). Beta Products are not, and may not become, Transaction Services and have not yet been publicly released and are offered for the sole purpose of internal testing and non-commercial evaluation. Customer’s use of the Beta Product shall be solely for the purpose of conducting the Beta Evaluation. Customer accepts all risks arising out of the access and use of the Beta Products. CyberSource may, in its sole discretion, at any time, terminate or discontinue the Beta Evaluation. Customer acknowledges and agrees that any Beta Product may still be in development and that Beta Product is provided “AS IS” and may not perform at the level of a commercially available service, may not operate as expected and may be modified prior to release. CYBERSOURCE SHALL NOT BE RESPONSIBLE OR LIABLE UNDER ANY CONTRACT, TORT (INCLUDING NEGLIGENCE), OR OTHERWISE RELATING TO A BETA PRODUCT OR THE BETA EVALUATION (A) FOR LOSS OR INACCURACY OF DATA OR COST OF PROCUREMENT OF SUBSTITUTE GOODS, SERVICES OR TECHNOLOGY, (B) ANY CLAIM, LOSSES, DAMAGES, OR CAUSE OF ACTION ARISING IN CONNECTION WITH THE BETA PRODUCT; OR (C) FOR ANY INDIRECT, INCIDENTAL OR CONSEQUENTIAL DAMAGES INCLUDING, BUT NOT LIMITED TO, LOSS OF REVENUES AND LOSS OF PROFITS.

## License

This repository is distributed under a proprietary license.

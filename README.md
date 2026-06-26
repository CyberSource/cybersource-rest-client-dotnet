
# .NET Client SDK for the CyberSource REST API

## Description

The CyberSource .NET client provides convenient access to the [CyberSource REST API](https://developer.cybersource.com/api/reference/api-reference.html) from your .NET application.

## System Requirements

* .NET Framework 4.8

## Installation

* Nuget Package Manager

```bash
PM>  Install-Package CyberSource.Rest.Client
```

## Account Registration and Configuration

* Account Registration

Follow the first step mentioned in [Getting Started with CyberSource REST SDKs](https://developer.cybersource.com/hello-world/rest-api-sdks.html#gettingstarted) to create a sandbox account.

* Configuration

Follow the second step mentioned in [Getting Started with CyberSource REST SDKs](https://developer.cybersource.com/hello-world/rest-api-sdks.html#gettingstarted) to configure the SDK by inputting your credentials.

***Please note that this is for reference only. Ensure to store the credentials in a more secure manner.***

## How to Use

To get started using this SDK, it's highly recommended to download our sample code repository:

* [Cybersource C# Sample Code Repository (on GitHub)](https://github.com/CyberSource/cybersource-rest-samples-csharp)

In that respository, we have comprehensive sample code for all common uses of our API:

Additionally, you can find details and examples of how our API is structured in our API Reference Guide:

* [Developer Center API Reference](https://developer.cybersource.com/api/reference/api-reference.html)

The API Reference Guide provides examples of what information is needed for a particular request and how that information would be formatted. Using those examples, you can easily determine what methods would be necessary to include that information in a request using this SDK.

## Example using Sample Code Application

* Add [CyberSource REST client](https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/cfd0c4e996c4d991eef5e06f6c8c520e3354e8c2/cybersource-rest-samples-csharp.csproj#L43C5-L45C17) into your .NET project, add it as a dependency. If you're using NuGet package manager, include this in your [packages.config](https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/cfd0c4e996c4d991eef5e06f6c8c520e3354e8c2/packages.config#L4C3-L4C87) file.

* Configure your credentials in [Configuration File](https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/cfd0c4e996c4d991eef5e06f6c8c520e3354e8c2/Source/Configuration.cs#L12C9-L48C10)

* Use the stored crdentials to create an instance of [clientConfig](https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/cfd0c4e996c4d991eef5e06f6c8c520e3354e8c2/Source/Samples/Payments/Payments/SimpleAuthorizationInternet.cs#L87C17-L88C111).

* Create an instance [API](https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/cfd0c4e996c4d991eef5e06f6c8c520e3354e8c2/Source/Samples/Payments/Payments/SimpleAuthorizationInternet.cs#L90) using the clientConfig.

* Use the created ApiClient instance to call CyberSource APIs. For example [SimpleAuthorizationInternet](https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/cfd0c4e996c4d991eef5e06f6c8c520e3354e8c2/Source/Samples/Payments/Payments/SimpleAuthorizationInternet.cs#L91).

For more detailed examples, refer to the [cybersource-rest-samples-csharp](https://github.com/CyberSource/cybersource-rest-samples-csharp) repository.


### Switching between the sandbox environment and the production environment

Cybersource maintains a complete sandbox environment for testing and development purposes. This sandbox environment is an exact duplicate of our production environment with the transaction authorization and settlement process simulated. By default, this SDK is configured to communicate with the sandbox environment. To switch to the production environment, set the `runEnvironment` property in the SDK Configuration.  See our sample at [the Configuration.cs class in the Sample Codes repository](https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/master/src/Configuration.cs).

```csharp
    // For TESTING use
    _configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
    // For PRODUCTION use
    // _configurationDictionary.Add("runEnvironment", "api.cybersource.com");
```

API credentials are different for each environment, so be sure to switch to the appropriate credentials when switching environments.

### Logging

[![Generic badge](https://img.shields.io/badge/LOGGING-NEW-GREEN.svg)](https://shields.io/)

Since v0.0.1.14, a new logging framework has been introduced in the SDK. This new logging framework makes use of NLog, and standardizes the logging so that it can be integrated with the logging in the client application.

More information about this new logging framework can be found in this file : [Logging.md](Logging.md)

## Features

### Message Level Encryption (MLE) Feature
[![Generic badge](https://img.shields.io/badge/MLE-NEW-GREEN.svg)](https://shields.io/)

This feature provides an implementation of Message Level Encryption (MLE) for APIs provided by CyberSource, integrated within our SDK. This feature ensures secure communication by encrypting messages at the application level before they are sent over the network.

More information about this new MLE feature can be found in this file : [MLE.md](MLE.md)

### JWT Authentication with Symmetric Key (Shared Secret / HS256 HMAC-SHA256) Support

[![Generic badge](https://img.shields.io/badge/JWT_SHARED_SECRET-NEW-GREEN.svg)](https://shields.io/)

> **⚠️ HTTP Signature Deprecation Notice:** HTTP Signature authentication (`http_Signature`) is being deprecated. JWT with Shared Secret (HS256 / HMAC-SHA256) is the **recommended migration path** — it uses the **same** `merchantKeyId` and `merchantsecretKey` credentials, requires only two property changes, and enables MLE (Message Level Encryption) support that HTTP Signature does not provide.

JWT authentication now supports two key types, configurable via the `jwtKeyType` property:

| `jwtKeyType` | Algorithm | Credentials Required |
|---|---|---|
| `P12` (default) | RS256 (asymmetric, RSA-SHA256) | `keysDirectory`, `keyFileName`, `keyAlias`, `keyPass` |
| `SHARED_SECRET` | HS256 (symmetric, HMAC-SHA256) | `merchantKeyId`, `merchantsecretKey` |

The default value is `P12`, which preserves full backward compatibility with existing configurations.

#### Configuration for JWT with P12 (default — no changes needed)

```csharp
_configurationDictionary.Add("authenticationType", "jwt");
_configurationDictionary.Add("merchantID", "your_merchant_id");
_configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
// jwtKeyType defaults to P12 if omitted
_configurationDictionary.Add("keyAlias", "your_merchant_id");
_configurationDictionary.Add("keyPass", "your_merchant_id");
_configurationDictionary.Add("keyFileName", "your_merchant_id");
_configurationDictionary.Add("keysDirectory", "path/to/p12/directory");
```

#### Configuration for JWT with Shared Secret

```csharp
_configurationDictionary.Add("authenticationType", "jwt");
_configurationDictionary.Add("merchantID", "your_merchant_id");
_configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
_configurationDictionary.Add("jwtKeyType", "SHARED_SECRET");
_configurationDictionary.Add("merchantKeyId", "your_key_id");
_configurationDictionary.Add("merchantsecretKey", "your_base64_encoded_shared_secret");
```

> **Note:** When `jwtKeyType` is set to `SHARED_SECRET`, the P12-related properties (`keysDirectory`, `keyFileName`, `keyAlias`, `keyPass`) are not required and will be ignored. Conversely, when using `P12`, the `merchantKeyId` and `merchantsecretKey` properties are not required for JWT authentication.

#### Migrating from HTTP Signature to JWT with Shared Secret (HS256 / HMAC-SHA256)

If you are currently using HTTP Signature authentication, migrating to JWT with Shared Secret (symmetric key, HS256 / HMAC-SHA256) requires only **two property changes** — your credentials remain the same:

```csharp
// BEFORE (HTTP Signature — deprecated)
_configurationDictionary.Add("authenticationType", "http_Signature");
_configurationDictionary.Add("merchantKeyId", "your_key_id");
_configurationDictionary.Add("merchantsecretKey", "your_shared_secret");

// AFTER (JWT with Shared Secret / HS256 HMAC-SHA256 — recommended)
_configurationDictionary.Add("authenticationType", "jwt");            // changed
_configurationDictionary.Add("jwtKeyType", "SHARED_SECRET");           // added — uses HS256 (HMAC-SHA256)
_configurationDictionary.Add("merchantKeyId", "your_key_id");          // same
_configurationDictionary.Add("merchantsecretKey", "your_shared_secret"); // same
```

For a complete migration guide with sample code, see the [Cybersource C# Sample Code Repository](https://github.com/CyberSource/cybersource-rest-samples-csharp).

#### Using MLE with Shared Secret Credentials

MLE (Message Level Encryption) is fully supported with the `SHARED_SECRET` key type. This allows merchants who use shared secret credentials (instead of a P12 certificate) to still leverage MLE for secure communication.

When using `jwtKeyType=SHARED_SECRET` with MLE, you must provide the MLE public certificate separately via the `mleForRequestPublicCertPath` property, since there is no P12 file to auto-extract the MLE certificate from. The request MLE public certificate can be downloaded from the CyberSource Business Center:

- **Test**: <https://businesscentertest.cybersource.com/ebc2>
- **Production**: <https://businesscenter.cybersource.com/ebc2>

```csharp
_configurationDictionary.Add("authenticationType", "jwt");
_configurationDictionary.Add("merchantID", "your_merchant_id");
_configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");
_configurationDictionary.Add("jwtKeyType", "SHARED_SECRET");
_configurationDictionary.Add("merchantKeyId", "your_key_id");
_configurationDictionary.Add("merchantsecretKey", "your_base64_encoded_shared_secret");

// Request MLE configuration
_configurationDictionary.Add("enableRequestMLEForOptionalApisGlobally", "true");
_configurationDictionary.Add("mleForRequestPublicCertPath", "/path/to/mle/public/cert.pem");

// Response MLE is also supported — see MLE.md for full configuration
// _configurationDictionary.Add("enableResponseMleGlobally", "true");
// _configurationDictionary.Add("responseMlePrivateKeyFilePath", "/path/to/private/key.p12");
// _configurationDictionary.Add("responseMlePrivateKeyFilePassword", "password");
```

For more details on MLE configuration options (including Response MLE), see [MLE.md](MLE.md).

### MetaKey Support

A Meta Key is a single key that can be used by one, some, or all merchants (or accounts, if created by a Portfolio user) in the portfolio.

The Portfolio or Parent Account owns the key and is considered the transaction submitter when a Meta Key is used, while the merchant owns the transaction.

MIDs continue to be able to create keys for themselves, even if a Meta Key is generated.

MetaKey works with all three authentication types: HTTP Signature, JWT (P12), and JWT with Shared Secret.

#### MetaKey with HTTP Signature (⚠️ Deprecated)

```csharp
_configurationDictionary.Add("authenticationType", "http_Signature");
_configurationDictionary.Add("merchantID", "your_transacting_merchant_id");
_configurationDictionary.Add("merchantKeyId", "your_metakey_portfolio_KeyId");
_configurationDictionary.Add("merchantsecretKey", "your_metakey_portfolio_shared_secret_key");
_configurationDictionary.Add("portfolioID", "your_portfolio_id");
_configurationDictionary.Add("useMetaKey", "true");
```

#### MetaKey with JWT (P12)

```csharp
_configurationDictionary.Add("authenticationType", "jwt");
_configurationDictionary.Add("merchantID", "your_transacting_merchant_id");
_configurationDictionary.Add("keyAlias", "your_portfolio_id");
_configurationDictionary.Add("keyPass", "your_metakey_portfolio_p12File_password");
_configurationDictionary.Add("keyFileName", "your_metakey_portfolio_p12FileName");
_configurationDictionary.Add("keysDirectory", "path/to/p12/directory");
_configurationDictionary.Add("portfolioID", "your_portfolio_id");
_configurationDictionary.Add("useMetaKey", "true");
```

#### MetaKey with JWT Shared Secret (Recommended)

```csharp
_configurationDictionary.Add("authenticationType", "jwt");
_configurationDictionary.Add("jwtKeyType", "SHARED_SECRET");
_configurationDictionary.Add("merchantID", "your_transacting_merchant_id");
_configurationDictionary.Add("merchantKeyId", "your_metakey_portfolio_KeyId");
_configurationDictionary.Add("merchantsecretKey", "your_metakey_portfolio_shared_secret_key");
_configurationDictionary.Add("portfolioID", "your_portfolio_id");
_configurationDictionary.Add("useMetaKey", "true");
```

> **Note:** MetaKey with JWT Shared Secret uses the same MetaKey credentials as HTTP Signature but authenticates via JWT, enabling MLE support.

#### Response MLE with MetaKey

When Response MLE is enabled (`enableResponseMleGlobally=true`) and MetaKey is in use (`useMetaKey=true`), the Response MLE configuration must use the **portfolio's** response MLE key — not the transacting merchant's. Specifically:

- `responseMlePrivateKeyFilePath` (or the `responseMlePrivateKey` object) must point to the **portfolio's** response MLE private key.
- `responseMleKID` — the KID value associated with the **portfolio's** response MLE certificate.
  - **Optional** when `responseMlePrivateKeyFilePath` points to a CyberSource-generated P12 file — the SDK will automatically fetch the KID from the P12 file.
  - **Required** when using PEM format files (`.pem`, `.key`, `.p8`) or when providing `responseMlePrivateKey` object directly.

```csharp
_configurationDictionary.Add("authenticationType", "jwt");
_configurationDictionary.Add("jwtKeyType", "SHARED_SECRET");
_configurationDictionary.Add("merchantID", "your_transacting_merchant_id");
_configurationDictionary.Add("merchantKeyId", "your_metakey_portfolio_KeyId");
_configurationDictionary.Add("merchantsecretKey", "your_metakey_portfolio_shared_secret_key");
_configurationDictionary.Add("portfolioID", "your_portfolio_id");
_configurationDictionary.Add("useMetaKey", "true");
_configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");

// Response MLE — use the portfolio's response MLE key, not the transacting merchant's
_configurationDictionary.Add("enableResponseMleGlobally", "true");
_configurationDictionary.Add("responseMlePrivateKeyFilePath", "/path/to/portfolio/response/mle/private/key.p12");
_configurationDictionary.Add("responseMlePrivateKeyFilePassword", "portfolio_private_key_password");
// responseMleKID is optional when using a CyberSource-generated P12 file (auto-fetched from P12)
// Required when using PEM files or responseMlePrivateKey object
// _configurationDictionary.Add("responseMleKID", "your_portfolio_response_mle_kid");
```

> **Important:** In MetaKey mode, the portfolio is the transaction submitter. The response is encrypted using the portfolio's MLE certificate, so the decryption key must also be the portfolio's. See [MLE.md](MLE.md) for full details on when `responseMleKID` is required vs optional.

Further information on MetaKey can be found in [New Business Center User Guide](https://developer.cybersource.com/library/documentation/dev_guides/Business_Center/New_Business_Center_User_Guide.pdf).

### OAuth Support

OAuth enables service providers to securely share access to customer data without sharing password data.

The CyberSource OAuth2.0 Authorization Server (or API Auth Service) will issue access tokens (based on merchant user credentials) to CyberSource or third-party Applications. These applications can access CyberSource APIs on the merchant's behalf, using the access tokens.

During application registration, third-party application developers are issued a `client_id` and optionally a `client_secret` (if they can be considered a confidential client, for example a web application).

These values will be used when the merchant application wants to request an access token and/or a refresh token. This is explained in more detail in [Requesting the Access and Refresh Tokens](https://developer.cybersource.com/api/developer-guides/OAuth/cybs_extend_intro/obtaining_access_refresh_tokens.html).

For more detailed information on OAuth, refer to the documentation at [Cybersource OAuth 2.0](https://developer.cybersource.com/api/developer-guides/OAuth/cybs_extend_intro.html).

In order to use OAuth, set the run environment to OAuth enabled URLs. OAuth only works in these run environments.

```csharp
    // For TESTING use
    _configurationDictionary.Add("runEnvironment", "api-matest.cybersource.com")
    // For PRODUCTION use
    // _configurationDictionary.Add("runEnvironment", "api-ma.cybersource.com")
```

## Additional Information

### IMPORTANT FOR v0.0.1.30, v0.0.1.31, v0.0.1.32

CyberSource is aware of an issue with these versions of the SDK caused by the tight coupling of the version of RestSharp with the SDK. The packaging information has not been updated to reflect the correct constraints for RestSharp. 

**This issue will get resolved from the upcoming version onwards.**

To resolve the issue in these three versions, run the following command from the Package Manager Console:

`Install-Package RestSharp -Version 108.0.3`

You may also want to execute the following command to upgrade the Authentication SDK to the correct version:

`Install-Package CyberSource.Authentication -Version 0.0.0.16`

## How to Contribute

* Fork the repo and create your branch from `master`.
* If you've added code that should be tested, add tests.
* Ensure the test suite passes.
* Submit your pull request! (Ensure you have [synced your fork](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/working-with-forks/syncing-a-fork) with the original repository before initiating the PR).

## Need Help?

For any help, you can reach out to us at our [Discussion Forum](https://community.developer.cybersource.com/t5/cybersource-APIs/bd-p/api).

## Disclaimer

CyberSource may allow Customer to access, use, and/or test a CyberSource product or service that may still be in development or has not been market-tested (“Beta Product”) solely for the purpose of evaluating the functionality or marketability of the Beta Product (a “Beta Evaluation”). Notwithstanding any language to the contrary, the following terms shall apply with respect to Customer’s participation in any Beta Evaluation (and the Beta Product(s)) accessed thereunder): The Parties will enter into a separate form agreement detailing the scope of the Beta Evaluation, requirements, pricing, the length of the beta evaluation period (“Beta Product Form”). Beta Products are not, and may not become, Transaction Services and have not yet been publicly released and are offered for the sole purpose of internal testing and non-commercial evaluation. Customer’s use of the Beta Product shall be solely for the purpose of conducting the Beta Evaluation. Customer accepts all risks arising out of the access and use of the Beta Products. CyberSource may, in its sole discretion, at any time, terminate or discontinue the Beta Evaluation. Customer acknowledges and agrees that any Beta Product may still be in development and that Beta Product is provided “AS IS” and may not perform at the level of a commercially available service, may not operate as expected and may be modified prior to release. CYBERSOURCE SHALL NOT BE RESPONSIBLE OR LIABLE UNDER ANY CONTRACT, TORT (INCLUDING NEGLIGENCE), OR OTHERWISE RELATING TO A BETA PRODUCT OR THE BETA EVALUATION (A) FOR LOSS OR INACCURACY OF DATA OR COST OF PROCUREMENT OF SUBSTITUTE GOODS, SERVICES OR TECHNOLOGY, (B) ANY CLAIM, LOSSES, DAMAGES, OR CAUSE OF ACTION ARISING IN CONNECTION WITH THE BETA PRODUCT; OR (C) FOR ANY INDIRECT, INCIDENTAL OR CONSEQUENTIAL DAMAGES INCLUDING, BUT NOT LIMITED TO, LOSS OF REVENUES AND LOSS OF PROFITS.

## License

This repository is distributed under a proprietary license.


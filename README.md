# .NET Client SDK for the CyberSource REST API

The CyberSource .NET client provides convenient access to the [CyberSource REST API](https://developer.cybersource.com/api/reference/api-reference.html) from your .NET application.

The library fully refactored and updated to support .NET Standard 2.0. Updated project structure, naming of namespaces, dependencies, NuGet package definition and many more. Fixed at least API code to download reports and to search available reports.

For authentication it also fully rebuild and created clean project with support of .NET Standard 2.0 without internal dependencies and problems related to initializing objects and other things.
Created repository - [CyberSource.Authentication](https://github.com/Digiman/CyberSource.Authentication).

## Requirements

To make sure that library can be built it needed to install locally SDK:
* .NET Core SDK 2.0+ - to allow develop and build .NET Standard 2.0 applications. 

Also by default usually framework installing with Visual Studio instance.
* .NET Framework 4.6.1 - to support libraries build with .NET Standard 2.0.

## Installation

* Nuget Package Manager

```
PM>  Install-Package CyberSource.RestClient
```

**Note: This package is not put to NuGet. It's only after a lot of refactoring and need to bne completely finished and put it after this.**

**Note: Ideally it need to create a builds and automated scripts to build and push library to NuGet from this GitHub repository.**

## Registration & Configuration

Use of this SDK and the CyberSource APIs requires having an account on our system. You can find details of getting a test account and creating your keys [here](https://developer.cybersource.com/api/developer-guides/dita-gettingstarted/registration.html).

Remember this SDK is for use in server-side .NET applications that access the CyberSource REST API and credentials should always be securely stored and accessed appropriately. 

## SDK Usage Examples and Sample Code

To get started using this SDK, it's highly recommended to download our sample code repository:
* [Cybersource C# Sample Code Repository (on GitHub)](https://github.com/CyberSource/cybersource-rest-samples-csharp)

In that respository, we have comprehensive sample code for all common uses of our API:

Additionally, you can find details and examples of how our API is structured in our API Reference Guide:
* [Developer Center API Reference](https://developer.cybersource.com/api/reference/api-reference.html)

The API Reference Guide provides examples of what information is needed for a particular request and how that information would be formatted. Using those examples, you can easily determine what methods would be necessary to include that information in a request using this SDK.

### Switching between the sandbox environment and the production environment

Cybersource maintains a complete sandbox environment for testing and development purposes. This sandbox environment is an exact duplicate of our production environment with the transaction authorization and settlement process simulated. By default, this SDK is configured to communicate with the sandbox environment. To switch to the production environment, set the `runEnvironment` property in the SDK Configuration.  See our sample at https://github.com/CyberSource/cybersource-rest-samples-csharp/blob/master/src/Configuration.cs.  

```csharp
// For TESTING use
_configurationDictionary.Add("runEnvironment", "cybersource.environment.sandbox");
// For PRODUCTION use
// _configurationDictionary.Add("runEnvironment", "cybersource.environment.production");
```

API credentials are different for each environment, so be sure to switch to the appropriate credentials when switching environments.

## License

This repository is distributed under a proprietary license.

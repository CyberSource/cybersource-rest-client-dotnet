# CyberSource.Model.TmsNetworkTokenServicesAmericanExpressTokenService
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableService** | **bool?** | Indicates if the service for network tokens for the American Express card association are enabled | [optional] 
**EnableTransactionalTokens** | **bool?** | Indicates if network tokens for the American Express card association are enabled for transactions | [optional] 
**TokenRequestorId** | **string** | Token Requestor ID provided by American Express during the registration process for the Tokenization Service  Pattern: ^[0-9]{11}\\\\z$\&quot; Min Length: 11 Max Length: 11 Example: \&quot;12345678912\&quot;  | [optional] 
**SeNumber** | **string** | SE Number assigned by American Express for the merchant&#39;s account  Pattern: \&quot;^[0-9]{11}\\\\z$\&quot; Min Length: 10 Max Length: 10 Example: \&quot;9876543212\&quot;  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


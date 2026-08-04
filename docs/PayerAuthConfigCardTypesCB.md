# CyberSource.Model.PayerAuthConfigCardTypesCB
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestorId** | **string** | The value is for 3DS2.0 and is a Directory Server assigned 3DS Requestor ID value. If this field is passed in request, it will override Requestor Id value that is configured on the Merchant&#39;s profile. | [optional] 
**Enabled** | **bool?** |  | [optional] [default to true]
**Currencies** | [**List&lt;PayerAuthConfigCardTypesVerifiedByVisaCurrencies&gt;**](PayerAuthConfigCardTypesVerifiedByVisaCurrencies.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


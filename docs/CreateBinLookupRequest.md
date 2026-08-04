# CyberSource.Model.CreateBinLookupRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientReferenceInformation** | [**Binv1binlookupClientReferenceInformation**](Binv1binlookupClientReferenceInformation.md) |  | [optional] 
**PaymentInformation** | [**Binv1binlookupPaymentInformation**](Binv1binlookupPaymentInformation.md) |  | [optional] 
**TokenInformation** | [**Binv1binlookupTokenInformation**](Binv1binlookupTokenInformation.md) |  | [optional] 
**ProcessingInformation** | [**Binv1binlookupProcessingInformation**](Binv1binlookupProcessingInformation.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


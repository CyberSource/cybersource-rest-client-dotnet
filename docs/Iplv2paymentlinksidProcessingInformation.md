# CyberSource.Model.Iplv2paymentlinksidProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LinkType** | **string** | linkType defines what type of link you want to create.  Possible Values:   - &#x60;PURCHASE&#x60;   - &#x60;DONATION&#x60;  | [optional] 
**RequestPhone** | **bool?** | Collect the payers phone number during the payment. | [optional] [default to false]
**RequestShipping** | **bool?** | Collect the payers shipping address during the payment. | [optional] [default to false]

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


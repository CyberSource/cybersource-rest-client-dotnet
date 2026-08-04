# CyberSource.Model.PtsV2PaymentsPost201ResponseProcessorInformationCustomer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PersonalIdResult** | **string** | Personal identifier result. This field is supported only for Redecard in Brazil for CyberSource Latin American Processing. If you included &#x60;buyerInformation.personalIdentification[].ID&#x60; in the request, this value indicates whether or not &#x60;buyerInformation.personalIdentification[].ID&#x60; matched a value in a record on file. Returned only when the personal ID result is returned by the processor.  Possible values:   - &#x60;Y&#x60;: Match  - &#x60;N&#x60;: No match  - &#x60;K&#x60;: Not supported  - &#x60;U&#x60;: Unknown  - &#x60;Z&#x60;: No response returned **Note** CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America.The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


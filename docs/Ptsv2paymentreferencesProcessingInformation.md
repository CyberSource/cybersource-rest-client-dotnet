# CyberSource.Model.Ptsv2paymentreferencesProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SessionType** | **string** | Will have 2 values, &#39;U&#39; (Update) , &#39;N&#39; (New). Any other values will be rejected. Default will be &#39;N&#39;  | [optional] 
**PaymentFlowMode** | **string** | Whether merchant wants to pass the flow Inline or want to invoke Klarna Hosted Page  | [optional] 
**ActionList** | **List&lt;string&gt;** | Possible values are one or more of follows:   - &#x60;AP_SESSIONS&#x60;: Use this when Alternative Payment Sessions service is requested.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.InlineResponse2014ProcessingInformationPayoutsOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcquirerMerchantId** | **string** | This field identifies the card acceptor for defining the point of service terminal in both local and interchange environments. An acquirer assigns this value for a merchant&#39;s involvement in a transaction. Depending on the acquirer and merchant billing and reporting requirements, this code can represent a merchant, a specific merchant location, or a specific merchant location terminal. Acquiring Institution Identification Code uniquely identifies the merchant. This value from the original is required in any subsequent messages, include reversals, chargebacks, and representments.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


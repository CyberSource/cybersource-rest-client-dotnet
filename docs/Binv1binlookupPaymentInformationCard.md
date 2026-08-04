# CyberSource.Model.Binv1binlookupPaymentInformationCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | The customer&#39;s payment card number, also known as the Primary Account Number (PAN). You can also use this field for encoded account numbers.  #### FDMS Nashville Required. String (19)  #### GPX Required if &#x60;pointOfSaleInformation.entryMode&#x3D;keyed&#x60;. However, this field is optional if your account is configured for relaxed requirements for address data and expiration date. **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.  #### All other processors Required if &#x60;pointOfSaleInformation.entryMode&#x3D;keyed&#x60;. However, this field is optional if your account is configured for relaxed requirements for address data and expiration date. **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


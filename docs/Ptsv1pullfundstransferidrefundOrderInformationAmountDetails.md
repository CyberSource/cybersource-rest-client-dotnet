# CyberSource.Model.Ptsv1pullfundstransferidrefundOrderInformationAmountDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalAmount** | **string** | Length: &lt;&#x3D;12. Up to 3 decimal places.   Type: String, with a non-negative double format.  The total amount of the AFT refund including all fees.   a. an amount that is &lt;&#x3D; the totalAmount of the original AFT   b. The amount of the transaction, inclusive of all fees assessed for the transaction, including currency conversion fees.       Minimum Value: Field must be greater than zero: minimum value is the smallest amount in any given currency.   c. Multiple successful reversals &amp; refunds of the original AFT transaction are allowed but the sum of the transaction amounts must not total more than the original AFT totalAmount.  | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


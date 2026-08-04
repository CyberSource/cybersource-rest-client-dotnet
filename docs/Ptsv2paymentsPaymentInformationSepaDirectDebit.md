# CyberSource.Model.Ptsv2paymentsPaymentInformationSepaDirectDebit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reference** | **string** | Mandate reference as returned on the first transaction in the sequence  | [optional] 
**SignatureDate** | **string** | Date of the initial transaction, format is YYYY-MM-DD. Date can be taken from the finaltimestamp of the SUCCEEDED notification for the first transaction in the sequence.  | [optional] 
**Url** | **string** | Valid URL pointing to the SEPA mandate, needs to be accessible by our risk and compliance department.  | [optional] 
**Type** | **string** | Sequence type of the direct debit, defaults to \&quot;oneOff\&quot;. Valid values: oneOff The direct debit is executed once. first First direct debit in a series of recurring ones.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


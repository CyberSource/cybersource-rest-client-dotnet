# CyberSource.Model.TssV2TransactionsGet200ResponsePaymentInformationIssuerInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | This field contains the issuer name.  | [optional] 
**Country** | **string** | This field contains [2-character ISO Country Codes](http://apps.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf) for the issuer.  | [optional] 
**BinLength** | **string** | This field contains the length of the BIN.  | [optional] 
**PhoneNumber** | **string** | This field contains the customer service phone number for the issuer.  | [optional] 
**TransactionInformation** | **string** | In a Mastercard Transaction, this field contains the unique identifier (Transaction Link ID) for the first transaction in a transaction life cycle.  This ID is crucial for maintaining continuity and linking subsequent operations to the original transaction.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


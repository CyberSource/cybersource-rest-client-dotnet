# CyberSource.Model.InlineResponse2014OrderInformationAmountDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthorizedAmount** | **string** | Amount that was authorized.  | [optional] 
**Currency** | **string** | Currency used for the order. Use the three-character ISO Standard Currency Codes.  | [optional] 
**ExchangeRate** | **string** | The rate of conversion of the currency given in the request.  | [optional] 
**TotalAmount** | **string** | Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  | [optional] 
**SettlementAmount** | **string** | This is a multicurrency field. It contains the transaction amount, converted to the currency used to bill the cardholder&#39;s account.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


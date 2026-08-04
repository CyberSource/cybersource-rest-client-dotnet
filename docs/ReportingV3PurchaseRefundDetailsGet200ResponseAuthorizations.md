# CyberSource.Model.ReportingV3PurchaseRefundDetailsGet200ResponseAuthorizations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestId** | **string** | An unique identification number assigned by CyberSource to identify the submitted request. | [optional] 
**TransactionReferenceNumber** | **string** | Authorization Transaction Reference Number | [optional] 
**Time** | **DateTime?** | Authorization Date | [optional] 
**AuthorizationRequestId** | **string** | Authorization Request Id | [optional] 
**Amount** | **string** | Authorization Amount | [optional] 
**CurrencyCode** | **string** | Valid ISO 4217 ALPHA-3 currency code | [optional] 
**Code** | **string** | Authorization Code | [optional] 
**Rcode** | **string** | Authorization RCode | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


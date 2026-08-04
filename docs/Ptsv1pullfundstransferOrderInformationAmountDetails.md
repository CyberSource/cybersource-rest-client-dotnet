# CyberSource.Model.Ptsv1pullfundstransferOrderInformationAmountDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalAmount** | **string** | The total amount of the funds transfer including all fees.  This value cannot be negative.   You can include a decimal point (.), but no other special characters.  | 
**Currency** | **string** | Use a 3-character alpha currency code for currency of the sender.  ISO standard currencies: [http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)    Currency must be supported by the processor.  | 
**ServiceFee** | **string** | When present, this field contains the sender&#39;s surcharge as assessed by the originator. Values in this field must be in the same currency and format as defined in the amount field.  | [optional] 
**ForeignExchangeFee** | **string** | When present, this field contains the sender&#39;s foreign exchange markup fee (markup above the wholesale or VisaNet exchange rate as assessed by the originator). Values in this field must be in the same currency and format as defined in the amount field.  | [optional] 
**Surcharge** | [**Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge**](Ptsv2paymentsOrderInformationAmountDetailsOctsurcharge.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


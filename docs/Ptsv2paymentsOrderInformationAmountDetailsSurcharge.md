# CyberSource.Model.Ptsv2paymentsOrderInformationAmountDetailsSurcharge
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **string** | The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking. The issuer can provide information about the surcharge amount to the customer.  If the amount is positive, then it is a debit for the customer. If the amount is negative, then it is a credit for the customer.  **NOTE**: This field is supported only for CyberSource through VisaNet (CtV) for Payouts. For CtV, the maximum string length is 8.  #### PIN debit Surcharge amount that you are charging the customer for this transaction. If you include a surcharge amount in the request, you must also include the surcharge amount in the value for &#x60;orderInformation.amountDetails.totalAmount&#x60;.  Optional field for transactions that use PIN debit credit or PIN debit purchase.  | [optional] 
**Description** | **string** | Merchant-defined field for describing the surcharge amount. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


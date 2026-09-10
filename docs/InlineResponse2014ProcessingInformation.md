# CyberSource.Model.InlineResponse2014ProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessApplicationId** | **string** | Payouts transaction type.  Possible Values: - &#x60;AA&#x60; - Account to account - &#x60;AB&#x60; - Business to Business - &#x60;PP&#x60; - Person to person - &#x60;TU&#x60; - Top-up for enhanced prepaid loads - &#x60;WT&#x60; - Wallet transfer - &#x60;BI&#x60; - Bank Initiated - &#x60;FT&#x60; - Funds Transfer - &#x60;FD&#x60; - Funds Disbursement - &#x60;GD&#x60; - Government Disbursement - &#x60;PD&#x60; - Payroll Disbursement - &#x60;LA&#x60; - Liquid Assets - &#x60;CP&#x60; - Card Bill Payment - &#x60;MP&#x60; - Non-card Bill Payment - &#x60;CD&#x60; - Cash Deposit - &#x60;CI&#x60; - Cash in - &#x60;CO&#x60; - Cash out - &#x60;GP&#x60; - Gambling Payment - &#x60;LO&#x60; - Loyalty and Offers - &#x60;MD&#x60; - Merchant Disbursement - &#x60;MI&#x60; - Merchant Initiated OCT for Faster Refund - &#x60;OG&#x60; - Online Gambling - &#x60;OT&#x60; - Own Account Transfer - &#x60;PS&#x60; - Payment for goods and services - &#x60;RP&#x60; - Request-To-Pay Service  | [optional] 
**CommerceIndicator** | **string** | Type of transaction.  | [optional] 
**PayoutsOptions** | [**InlineResponse2014ProcessingInformationPayoutsOptions**](InlineResponse2014ProcessingInformationPayoutsOptions.md) |  | [optional] 
**ReconciliationId** | **string** | CyberSource or merchant generated transaction reference number. This is sent to the processor and is echoed back in the response to the merchant. This is This value is used for reconciliation purposes.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


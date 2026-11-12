# CyberSource.Model.Riskv1decisionsProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionList** | **List&lt;string&gt;** | - Use &#x60;CONSUMER_AUTHENTICATION&#x60; to use Payer Authentication along with Decision Manager. For any other value, only Decision Manager will run. - Use &#x60;WATCHLIST_SCREENING&#x60;  when you want to call Watchlist Screening service.  | [optional] 
**BusinessApplicationId** | **string** | Required for AFT and OCT transactions.  Given below is a list of all the BAI values available. However, the processors may support only few specific BAI values.  - AA : Account-to-account  - BB : Supplier Payments - BI : Bank-Initiated P2P Money Transfer - BP : Non-Card Bill Pay/Bill Pay - CD : Cash Deposit - CP : Credit card Bill Payment - FD : Funds disbursement  - FT : Funds transfer - GD : Government Disbursement - GP : Gambling payout (non-online gambling) - LO : Loyalty credits and rebates - MD : Merchant Settlement - OG : Online Gambling Payout - PD : Payroll and pension disbursement - PP : Person-to-Person or Peer-to-Peer - TU : Top up, prepaid load - WT : Digital wallet   | [optional] 
**PurposeOfPayment** | **string** | This field is applicable for AFT and OCT transactions. For list of supported values, please refer to Developer Guide.  | [optional] 
**PreAuthStatus** | **string** | Outcome of a pre-authorization process. Used when processing payment outside of CyberSource and sent to Decision Manager post-authorisation. Possible values: Approved, Rejected, Hold.  | [optional] 
**PreAuthResponseCode** | **string** | Alphanumeric code returned by the issuer or payment gateway during the pre-authorization stage of a transaction.  | [optional] 
**AuthorizationOptions** | [**Riskv1decisionsProcessingInformationAuthorizationOptions**](Riskv1decisionsProcessingInformationAuthorizationOptions.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.PtsV2PaymentsRefundPost201ResponseErrorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reason** | **string** | The reason of the status.  Possible values:  - AVS_FAILED  - CONTACT_PROCESSOR  - EXPIRED_CARD  - PROCESSOR_DECLINED  - INSUFFICIENT_FUND  - STOLEN_LOST_CARD  - ISSUER_UNAVAILABLE  - UNAUTHORIZED_CARD  - CVN_NOT_MATCH  - EXCEEDS_CREDIT_LIMIT  - INVALID_CVN  - BLOCKED_BY_CARDHOLDER  - DECLINED_CHECK  - BLACKLISTED_CUSTOMER  - SUSPENDED_ACCOUNT  - PAYMENT_REFUSED  - CV_FAILED  - INVALID_ACCOUNT  - GENERAL_DECLINE  - INVALID_MERCHANT_CONFIGURATION  - DECISION_PROFILE_REJECT  - SCORE_EXCEEDS_THRESHOLD  - PENDING_AUTHENTICATION  - ACH_VERIFICATION_FAILED  - DECISION_PROFILE_REVIEW  - CONSUMER_AUTHENTICATION_REQUIRED  - CONSUMER_AUTHENTICATION_FAILED  - ALLOWABLE_PIN_RETRIES_EXCEEDED  - PROCESSOR_ERROR  - CUSTOMER_WATCHLIST_MATCH  - ADDRESS_COUNTRY_WATCHLIST_MATCH  - EMAIL_COUNTRY_WATCHLIST_MATCH  - IP_COUNTRY_WATCHLIST_MATCH  - DAGGREJECTED  - DAGGDENIED  - DSYSREJECTED  | [optional] 
**Message** | **string** | The detail message related to the status and reason listed above. | [optional] 
**Details** | [**List&lt;PtsV2PaymentsPost201ResponseErrorInformationDetails&gt;**](PtsV2PaymentsPost201ResponseErrorInformationDetails.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


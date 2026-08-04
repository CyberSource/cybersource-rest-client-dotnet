# CyberSource.Model.Rbsv1subscriptionsProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommerceIndicator** | **string** | &gt; This field is ignored when you provide the &#x60;subscriptionInformation.originalTransactionId&#x60; or update the subscription.  Commerce Indicator is a way to identify the type of transaction. Some payment card companies use this information when determining discount rates.  Valid values: - &#x60;MOTO&#x60; - &#x60;RECURRING&#x60; - &#x60;INTERNET&#x60;  Please add the ecommerce indicator based on the rules defined by your gateway/processor. Some gateways may not accept the Commerce Indicator &#x60;RECURRING&#x60; with a Zero Dollar Authorization, that is done for subscriptions starting at a future date.  | [optional] 
**AuthorizationOptions** | [**RbsAuthorizationOptions**](RbsAuthorizationOptions.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


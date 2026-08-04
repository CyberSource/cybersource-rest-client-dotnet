# CyberSource.Model.SAConfigNotificationsCustomerNotifications
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomReceiptPageEnabled** | **bool?** | Toggles the custom receipt page, where merchants can receive the results of the transaction and display appropriate messaging. Usually set by web developers integrating to Secure Acceptance. | [optional] 
**ReceiptEmailAddress** | **string** | Email address where a copy of the payer&#39;s receipt email is sent, when notificationReceiptEmailEnabled is true. | [optional] 
**CustomerReceiptEmailEnabled** | **bool?** | Toggles an email receipt sent to the payer&#39;s email address on payment success. | [optional] 
**CustomCancelPage** | **string** | URL to which transaction results are POSTed when the payer clicks &#39;Cancel&#39; on the Hosted Checkout. Triggered when customCancelPageEnabled is true. Usually set by web developers integrating to Secure Acceptance. | [optional] 
**CustomReceiptPage** | **string** | URL to which transaction results are POSTed when the payer requests a payment on the Hosted Checkout. Triggered when customCancelPageEnabled is true. Usually set by web developers integrating to Secure Acceptance. | [optional] 
**CustomCancelPageEnabled** | **bool?** | Toggles the custom cancel page, where merchants can receive notice that the payer has canceled, and display appropriate messaging and direction. Usually set by web developers integrating to Secure Acceptance. | [optional] 
**NotificationReceiptEmailEnabled** | **bool?** | Toggles whether merchant receives a copy of the payer&#39;s receipt email. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


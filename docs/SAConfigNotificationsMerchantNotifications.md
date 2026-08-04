# CyberSource.Model.SAConfigNotificationsMerchantNotifications
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackofficePostEnabled** | **bool?** | Enables Webhook transaction confirmation messages sent to URL defined in backofficePostUrl. Usually enabled by web developers integrating to Secure Acceptance. | [optional] 
**BackofficeEmailAddress** | **string** | Email address to receive transaction confirmation messages. | [optional] 
**BackofficeEmailEnabled** | **bool?** | Enables email transaction confirmation messages, sent to the address specified in backofficeEmailAddress. | [optional] 
**BackofficePostUrl** | **string** | Webhook URL to which transaction confirmation is sent. Usually completed by the web developers integrating to Secure Acceptance. | [optional] 
**CardNumberFormat** | **string** | Format in which the card number should be masked in the notifications.   Valid values: &#x60;1&#x60; - Display first 6 digits only (e.g. \&quot;444433**********\&quot;)  &#x60;2&#x60; - Display last four digits only (e.g. \&quot;************1111\&quot;)  &#x60;3&#x60; - Display First six and last four digits (e.g. \&quot;444433******1111\&quot;)  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


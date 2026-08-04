# CyberSource.Model.Ptsv2refreshpaymentstatusidProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionList** | **List&lt;string&gt;** | Array of actions (one or more) to be included in the payment to invoke bundled services along with payment status.  Possible values are one or more of follows:   - &#x60;AP_STATUS&#x60;: Use this when Alternative Payment check status service is requested.   - &#x60;AP_SESSION_STATUS&#x60;: Use this when Alternative Payment check status service for Paypal, Klarna is requested.   - &#x60;AP_INITIATE_STATUS&#x60;: Use this when Alternative Payment check status service for KCP is requested.   - &#x60;AP_ORDER_STATUS&#x60;: Use this when Alternative Payment check status service for order status request.   - &#x60;AP_AUTH_STATUS&#x60;: Use this when Alternative Payment check status service for auth status request.   - &#x60;AP_CAPTURE_STATUS&#x60;: Use this when Alternative Payment check status service for capture status request.   - &#x60;AP_REFUND_STATUS&#x60;: Use this when Alternative Payment check status service for refund status request.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


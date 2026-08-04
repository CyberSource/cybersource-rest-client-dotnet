# CyberSource.Model.TssV2TransactionsGet200ResponseDeviceInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpAddress** | **string** | IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field.  | [optional] 
**HostName** | **string** | DNS resolved hostname from &#x60;ipAddress&#x60;. | [optional] 
**CookiesAccepted** | **string** | Whether the customer&#39;s browser accepts cookies. This field can contain one of the following values: - &#x60;yes&#x60;: The customer&#39;s browser accepts cookies. - &#x60;no&#x60;: The customer&#39;s browser does not accept cookies.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


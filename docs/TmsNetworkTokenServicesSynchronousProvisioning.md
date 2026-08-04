# CyberSource.Model.TmsNetworkTokenServicesSynchronousProvisioning
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool?** | Indicates if network tokens are provisioned synchronously (i.e. as part of the transaction flow) or asychronously (i.e. in parallel to the payment flow)  NOTE: The synchronous provisioning feature is designed exclusively for aggregator merchants.  Direct merchants should not enable synchronous provisioning as TMS manages the asynchronous creation of network tokens for direct clients.   Activation of this feature by direct merchants will lead to latency in the authorization response.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


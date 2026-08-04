# CyberSource.Model.Ptsv2paymentsHostedPaymentInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostName** | **string** | The title of the hosted payment page, displayed in the browser&#39;s tab. If not set, defaults to the title set in the merchant configuration.  | [optional] 
**IpAddress** | **string** | URL of the merchant&#39;s logo to be displayed in Klarna&#39;s hosted payment page. If not set, defaults to the logo set in the merchant configuration.  | [optional] 
**UserAgent** | [**Ptsv2paymentsHostedPaymentInformationUserAgent**](Ptsv2paymentsHostedPaymentInformationUserAgent.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


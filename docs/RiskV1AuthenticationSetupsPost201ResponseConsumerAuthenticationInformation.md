# CyberSource.Model.RiskV1AuthenticationSetupsPost201ResponseConsumerAuthenticationInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **string** | JSON Web Token (JWT) used to authenticate the consumer with the authentication provider, such as, CardinalCommerce or Rupay. Note - Max Length of this field is 2048 characters.  | [optional] 
**ReferenceId** | **string** | This identifier represents cardinal has started device data collection session and this must be passed in Authentication JWT to Cardinal when invoking the deviceDataCollectionUrl.  | [optional] 
**DeviceDataCollectionUrl** | **string** | The deviceDataCollectionUrl is the location to send the Authentication JWT when invoking the Device Data collection process.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


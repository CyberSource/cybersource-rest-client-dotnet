# CyberSource.Model.Iccv1tokensAuthenticatedIdentities
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | **string** | Data related to the authenticated identity. | [optional] 
**Provider** | **string** | Provider of the authenticated identity. | [optional] 
**Id** | **string** | This is a distinctive and non-transparent identifier provided by VISA for correlation purposes in the previous, related API.   Field Mapping when authenticationMethodType is &#39;FIDO2&#39;:     - On Success: FidoResponse.identifier   - On Error: AuthContext.identifier  | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


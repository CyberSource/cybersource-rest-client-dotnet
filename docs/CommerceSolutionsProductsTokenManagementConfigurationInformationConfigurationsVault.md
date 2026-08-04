# CyberSource.Model.CommerceSolutionsProductsTokenManagementConfigurationInformationConfigurationsVault
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultTokenType** | **string** | Default token type to be used. Possible Values:   - &#39;CUSTOMER&#39;  - &#39;PAYMENT_INSTRUMENT&#39;  - &#39;INSTRUMENT_IDENTIFIER&#39;  | [optional] 
**Location** | **string** | Location where the vault will be stored.  Use &#39;IDC&#39; (the Indian Data Centre) when merchant is storing token data in India  or &#39;GDC&#39; (the Global Data Centre) for all other cases.  Possible Values:    - &#39;IDC&#39;   - &#39;GDC&#39;  | [optional] 
**TokenFormats** | [**TmsTokenFormats**](TmsTokenFormats.md) |  | [optional] 
**TokenPermissions** | [**TokenPermissions**](TokenPermissions.md) |  | [optional] 
**SensitivePrivileges** | [**TmsSensitivePrivileges**](TmsSensitivePrivileges.md) |  | [optional] 
**Nullify** | [**TmsNullify**](TmsNullify.md) |  | [optional] 
**NetworkTokenServices** | [**TmsNetworkTokenServices**](TmsNetworkTokenServices.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


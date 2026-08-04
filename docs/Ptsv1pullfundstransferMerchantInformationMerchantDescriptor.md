# CyberSource.Model.Ptsv1pullfundstransferMerchantInformationMerchantDescriptor
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address1** | **string** | First line of merchant&#39;s address.  | [optional] 
**AdministrativeArea** | **string** | The state where the merchant is located.  | [optional] 
**Contact** | **string** | Contact information for the merchant. This field contains additional information for contacting the merchant, such as an additional phone number or a contact name.  | [optional] 
**Country** | **string** | Merchant&#39;s country.  | [optional] 
**County** | **string** | Merchant&#39;s county. Used for US Merchants only.  Send a 3-digit numeric FIPS county code. https://www2.census.gov/programs-surveys/decennial/2010/partners/pdf/FIPS_StateCounty_Code.pdf  | [optional] 
**CustomerServicePhoneNumber** | **string** | Indicates customer service phone number of Merchant.  | [optional] 
**Locality** | **string** | Merchant&#39;s City.  | [optional] 
**Name** | **string** | Merchant&#39;s name.  | [optional] 
**Phone** | **string** | Merchant&#39;s phone.  | [optional] 
**PostalCode** | **string** | Merchant&#39;s postal code.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.Ucv1sessionsDataMerchantInformationMerchantDescriptor
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the merchant&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**AlternateName** | **string** | The alternate name of the merchant&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**Contact** | **string** | Contact information for the merchant.  **Note** These are the maximum data lengths for the following payment processors: - FDCCompass (13) - Paymentech (13)  | [optional] 
**Locality** | **string** | The locality of the merchant&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**Phone** | **string** | The phone number of the merchant&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**Country** | **string** | The country code of the merchant&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**PostalCode** | **string** | The postal code of the merchant&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**AdministrativeArea** | **string** | The administrative area of the merchant&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**Address1** | **string** | The first line of the merchant&#39;s address&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


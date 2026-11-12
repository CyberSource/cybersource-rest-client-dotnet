# CyberSource.Model.Ucv1sessionsDataAggregatorInformationSubMerchant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardAcceptorId** | **string** | Unique identifier assigned by the payment card company to the sub-merchant. | [optional] 
**Id** | **string** | The ID you assigned to your sub-merchant.  American Express Direct: String (20)  | [optional] 
**Name** | **string** | Sub-merchant&#39;s business name.  #### American Express Direct The maximum length of the sub-merchant name depends on the length of the aggregator name. The combined length for both values must not exceed 36 characters.  | [optional] 
**Address1** | **string** | First line of the sub-merchant&#39;s street address.  | [optional] 
**Locality** | **string** | Sub-merchant&#39;s city.  | [optional] 
**AdministrativeArea** | **string** | Sub-merchant&#39;s state or province.  | [optional] 
**Region** | **string** | Sub-merchant&#39;s region.  **Example**\\ &#x60;NE&#x60; indicates that the sub-merchant is in the northeast region.  | [optional] 
**PostalCode** | **string** | Partial postal code for the sub-merchant&#39;s address.  | [optional] 
**Country** | **string** | Sub-merchant&#39;s country. Use the [ISO Standard Country Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf).  | [optional] 
**Email** | **string** | Sub-merchant&#39;s email address.  **Maximum length for processors**   - American Express Direct: 40  | [optional] 
**PhoneNumber** | **string** | Sub-merchant&#39;s telephone number.  **Maximum length for procesors**   - American Express Direct: 20  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.UnifiedriskCustomerPersonalIdentification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateOfBirth** | **string** | The customer&#39;s date of birth. **Format**: &#x60;YYYYMMDD&#x60;.This field is a &#x60;pass-through&#x60;, which means that CyberSource ensures that the value is eight numeric characters but otherwise does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor. | [optional] 
**FirstName** | **string** | The customer&#39;s first name. | [optional] 
**LastName** | **string** | The customer&#39;s last name. | [optional] 
**Email** | **string** | The customer&#39;s email address. | [optional] 
**Phone** | **string** | The customer&#39;s phone number. | [optional] 
**PhoneNumber** | **string** | The customer&#39;s mobile or primary phone number used for contact or SMS-based verification, preferably in E.164 format (e.g., +15551234567) | [optional] 
**WorkPhoneNumber** | **string** | The customer&#39;s work or office phone number used as an alternative contact method for identity verification purposes | [optional] 
**TaxId** | **string** | The customer&#39;s government-issued tax identification number used for regulatory compliance and identity verification (e.g., SSN in the US, NIF in Spain, PAN in India) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


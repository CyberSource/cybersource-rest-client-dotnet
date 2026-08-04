# CyberSource.Model.ReportingV3ConversionDetailsGet200ResponseConversionDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantReferenceNumber** | **string** | Merchant reference number of a merchant | [optional] 
**ConversionTime** | **DateTime?** | Date of conversion | [optional] 
**RequestId** | **string** | Cybersource Transation request id | [optional] 
**OriginalDecision** | **string** | Original decision | [optional] 
**NewDecision** | **string** | New decision | [optional] 
**Reviewer** | **string** | User name of the reviewer | [optional] 
**ReviewerComments** | **string** | Comments of the reviewer | [optional] 
**Queue** | **string** | Name of the queue | [optional] 
**Profile** | **string** | Name of the profile | [optional] 
**Notes** | [**List&lt;ReportingV3ConversionDetailsGet200ResponseNotes&gt;**](ReportingV3ConversionDetailsGet200ResponseNotes.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


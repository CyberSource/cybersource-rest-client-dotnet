# CyberSource.Model.CardProcessingConfigCommonAcquirer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstitutionId** | **string** | Identifier of the acquirer. This number is usually assigned by Visa. Applicable for VPC, GPX (gpx), CMCIC (cmcic), EFTPOS, CB2A, CUP, American Express Direct (amexdirect) and Six (six) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Min. Length&lt;/th&gt;&lt;th&gt;Max. Length&lt;/th&gt;&lt;th&gt;Regex&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp, cp, hybrid&lt;/td&gt;&lt;td&gt;Yes&lt;/td&gt;&lt;td&gt;1&lt;/td&gt;&lt;td&gt;13&lt;/td&gt;&lt;td&gt;^[0-9]+$&lt;/td&gt;&lt;td&gt;1111&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt;  | [optional] 
**InterbankCardAssociationId** | **string** | Number assigned by MasterCard to banks to identify the member in transactions. Applicable for VPC and GPX (gpx) processors. | [optional] 
**DiscoverInstitutionId** | **string** | Assigned by Discover to identify the acquirer. Applicable for VPC and GPX (gpx) processors. | [optional] 
**UnionPayInstitutionId** | **string** | Assigned by China Union Pay to identify the acquirer. Applicable for VPC processors. | [optional] 
**DinersClubInstitutionId** | **string** | Assigned by Diners Club to identify the acquirer. Applicable for VPC processors. | [optional] 
**CountryCode** | **string** | ISO 4217 format. Applicable for VPC, GPX (gpx), EFTPOS, RUPAY, Prisma (prisma) and CUP processors. | [optional] 
**FileDestinationBin** | **string** | The BIN to which this capturefile is sent. This field must contain a valid BIN. Applicable for VPC and GPX (gpx) processors. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


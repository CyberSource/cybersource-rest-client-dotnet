# CyberSource.Model.Ptsv1pushfundstransferSenderInformationPersonalIdentification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Processor(35)  | [optional] 
**PersonalIdType** | **string** | This tag will denote whether the tax ID is a business or individual tax ID when personal ID Type contains the value of TXIN (Tax identification).  The valid values are: - &#x60;B&#x60; (Business) - &#x60;I&#x60; (Individual)  | [optional] 
**Type** | **string** | This tag will contain the type of sender identification. The valid values are:  - &#x60;BTHD&#x60;: (Date of birth) - &#x60;CUID&#x60;: (Customer identification (unspecified)) - &#x60;NTID&#x60;: (National identification) - &#x60;PASN&#x60;: (Passport number) - &#x60;DRLN&#x60;: (Driver license) - &#x60;TXIN&#x60;: (Tax identification) - &#x60;CPNY&#x60;: (Company registration number) - &#x60;PRXY&#x60;: (Proxy identification) - &#x60;SSNB&#x60;: (Social security number) - &#x60;ARNB&#x60;: (Alien registration number) - &#x60;LAWE&#x60;: (Law enforcement identification) - &#x60;MILI&#x60;: (Military identification) - &#x60;TRVL&#x60;: (Travel identification (non-passport)) - &#x60;EMAL&#x60;: (Email) - &#x60;PHON&#x60;: (Phone number)  | [optional] 
**IssuingCountry** | **string** | Issuing country of the identification. The field format should be a 2 character ISO 3166-1 alpha-2 country code.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


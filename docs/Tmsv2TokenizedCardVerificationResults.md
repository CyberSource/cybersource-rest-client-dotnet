# CyberSource.Model.Tmsv2TokenizedCardVerificationResults
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SecurityCode** | **string** | Indicates whether the security code (CVV/CVC) was verified by the issuer during the provisioning request. Supported only for VTS tokens.  Possible Values: - MATCH: Verified, CVV2 data matched. - NO_MATCH: Verified, CVV2 data did not match. - NOT_SUPPORTED: Verification not supported by card issuer. - SKIPPED: Verification was not performed.  | [optional] 
**Address** | **string** | Indicates whether the billing address was verified by the issuer during the provisioning request. Supported only for VTS tokens.  Possible Values: - MATCH: Verified, address and postal code data matched. - PARTIAL_MATCH: Verified, either address data matched or postal code data matched. - PARTIAL_MATCH_FORMAT_UNSUPPORTED: Verified, either address data matched or postal code data matched, but the other could not be verified due to format issues. - NO_MATCH: Verified, address and postal code data did not match. - NOT_SUPPORTED: Verification not supported by card issuer. - SKIPPED: Verification was not performed.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


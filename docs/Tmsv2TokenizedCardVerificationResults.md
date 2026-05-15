# CyberSource.Model.Tmsv2TokenizedCardVerificationResults
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SecurityCode** | **string** | Indicates whether the security code (CVV/CVC) was verified by the issuer during the provisioning request. Supported only for VTS tokens.  Possible Values: - MATCH: Verified, CVV2 data matched. - NO_MATCH: Verified, CVV2 data did not match. - NOT_SUPPORTED: Verification not supported by card issuer. - SKIPPED: Verification was not performed.  | [optional] 
**Address** | **string** | Indicates whether the billing address was verified by the issuer during the provisioning request. Supported only for VTS tokens.  Possible Values: - MATCH: Verified, address and postal code data matched. - PARTIAL_MATCH: Verified, either address data matched or postal code data matched. - PARTIAL_MATCH_FORMAT_UNSUPPORTED: Verified, either address data matched or postal code data matched, but the other could not be verified due to format issues. - NO_MATCH: Verified, address and postal code data did not match. - NOT_SUPPORTED: Verification not supported by card issuer. - SKIPPED: Verification was not performed.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


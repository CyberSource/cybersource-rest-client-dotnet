# CyberSource.Model.Acpv1tokensAssuranceData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VerificationType** | **string** | Type of the verification data.   Possible values:   - &#x60;CARDHOLDER&#x60; (Default)   - &#x60;DEVICE&#x60;  | [optional] 
**VerificationEntity** | **string** | Entity performing the verification.   Possible value:     - &#x60;10&#x60; - VISA (Default)  | [optional] 
**VerificationEvents** | **List&lt;string&gt;** | Event where the verification occurred.   Possible values:     - &#x60;01&#x60; - Payment transaction   - &#x60;02&#x60; - Add card/Card enrollment   - &#x60;03&#x60; - Profile access   - &#x60;04&#x60; - Account verification  | [optional] 
**VerificationMethod** | **string** | Method of the verification.   Possible values:     - &#x60;02&#x60; - App-based authentication   - &#x60;04&#x60; - One-time passcode   - &#x60;21&#x60; - Visa Token Service step-up: Device binding   - &#x60;22&#x60; - Visa Token Service step-up: Cardholder verification   - &#x60;23&#x60; - FIDO2  | 
**VerificationResults** | **string** | Result of the verification.   Possible values:     - &#x60;01&#x60; - Verified   - &#x60;02&#x60; - Not Verified   - &#x60;03&#x60; - Not performed   - &#x60;04&#x60; - Not required   - &#x60;21&#x60; - Not allowed  | 
**VerificationTimestamp** | **string** | Date and time the verification occurred. UTC time in Unix epoch format. | 
**AuthenticationContext** | [**Acpv1tokensAuthenticationContext**](Acpv1tokensAuthenticationContext.md) |  | [optional] 
**AuthenticatedIdentities** | [**Acpv1tokensAuthenticatedIdentities**](Acpv1tokensAuthenticatedIdentities.md) |  | [optional] 
**AdditionalData** | **string** | Additional data related to assurance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.Ptsv2paymentsConsumerAuthenticationInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cavv** | **string** | Cardholder authentication verification value (CAVV). | [optional] 
**CavvAlgorithm** | **string** | Algorithm used to generate the CAVV for Visa Secure or the UCAF authentication data for Mastercard Identity Check.  | [optional] 
**EciRaw** | **string** | Raw electronic commerce indicator (ECI). For the description and requirements, see \&quot;Payer Authentication,\&quot; page 180. | [optional] 
**ParesStatus** | **string** | Payer authentication response status. For the description and requirements, see \&quot;Payer Authentication,\&quot; page 180.  | [optional] 
**VeresEnrolled** | **string** | Verification response enrollment status. For the description and requirements, see \&quot;Payer Authentication,\&quot; page 180. | [optional] 
**Xid** | **string** | Transaction identifier. For the description and requirements, see \&quot;Payer Authentication,\&quot; page 180. | [optional] 
**UcafAuthenticationData** | **string** | Universal cardholder authentication field (UCAF) data.  For the description and requirements, see \&quot;Payer Authentication,\&quot; page 180.  | [optional] 
**UcafCollectionIndicator** | **string** | Universal cardholder authentication field (UCAF) collection indicator.  For the description and requirements, see \&quot;Payer Authentication,\&quot; page 180.  **CyberSource through VisaNet**\\ The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR7 - Position: 5 - Field: Mastercard Electronic Commerce Indicators—-UCAF Collection Indicator  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


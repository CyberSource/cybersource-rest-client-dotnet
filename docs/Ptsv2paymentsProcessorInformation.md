# CyberSource.Model.Ptsv2paymentsProcessorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PreApprovalToken** | **string** | Token received in original session service. | [optional] 
**AuthorizationOptions** | [**Ptsv2paymentsProcessorInformationAuthorizationOptions**](Ptsv2paymentsProcessorInformationAuthorizationOptions.md) |  | [optional] 
**Reversal** | [**Ptsv2paymentsProcessorInformationReversal**](Ptsv2paymentsProcessorInformationReversal.md) |  | [optional] 
**Network** | [**Ptsv2paymentsProcessorInformationReversalNetwork**](Ptsv2paymentsProcessorInformationReversalNetwork.md) |  | [optional] 
**AuthApprovalToken** | **string** | Interoperability Token received by merchant for Authorization API. Field for merchant to send Klarna Advantage Plus authorization approval token for Auth API call.  | [optional] 
**SupplementaryTransactionData** | **string** | Supplementary transaction data for Klarna Advantage Plus. Fields to capture Interoperability Data from Merchant and transfer to Klarna for Authorization/Sale/Re-Auth/Capture APIs.  | [optional] 
**ResponseSourceCode** | **string** | Field contains the response source code that identifies the source.  | [optional] 
**CedpVerifiedIndicator** | **string** | Merchant Commercial Enhanced Data Program (CEDP) verified indicator for capture/bill requests.  This field is used when the client is doing authorization with a different gateway and capture/settlement with CyberSource.  This field flows in ISO field 34, DSID 02 tag DA, in AN, EBCDIC format.  Possible values: - &#x60;Y&#x60;: Merchant CEDP verified  #### Used by **Capture Request** Request field for force capture/bill support when auth is done with a different gateway.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


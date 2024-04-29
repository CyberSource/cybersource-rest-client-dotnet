# CyberSource.Model.ECheckConfigCommonInternalOnlyProcessors
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableCCS** | **bool?** | *NEW* Flag to indicate whether the processor is migrated to the Common Connectivity Services Platform. Applicable for VPC and amexdirect processors.  | [optional] 
**TerminalId** | **string** | *NEW* The &#39;Terminal Id&#39; aka TID, is an identifier used for with your payments processor. Depending on the processor and payment acceptance type this may also be the default Terminal ID used for Card Present and Virtual Terminal transactions. Applicable for VPC processors.  | [optional] 
**Enable15anTransactionReferenceNumber** | **bool?** | *NEW* This ensures the transaction reference # contains an identifier that can be viewed in CYBS | [optional] [default to true]
**PortalSupportedPaytypes** | **string** | *NEW* This is used by the EBC2 application | [optional] [default to "CHECK"]
**SettlementMethod** | **Object** | *NEW* | [optional] 
**VerificationLevel** | **Object** | *NEW* | [optional] 
**SetCompletedState** | **bool?** | *Moved* When set to Yes we will automatically update transactions to a completed status X-number of days after the transaction comes through; if no failure notification is received. When set to No means we will not update transaction status in this manner. For BAMS/Bank of America merchants, they should be set to No unless we are explicitly asked to set a merchant to YES. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


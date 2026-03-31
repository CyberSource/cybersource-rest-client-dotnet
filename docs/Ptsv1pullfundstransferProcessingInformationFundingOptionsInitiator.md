# CyberSource.Model.Ptsv1pullfundstransferProcessingInformationFundingOptionsInitiator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OriginatorInitiatedTransaction** | [**Ptsv1pullfundstransferProcessingInformationFundingOptionsInitiatorOriginatorInitiatedTransaction**](Ptsv1pullfundstransferProcessingInformationFundingOptionsInitiatorOriginatorInitiatedTransaction.md) |  | [optional] 
**Type** | **string** | This field indicates whether the transaction is a originator-initiated transaction or sender-initiated transaction.  Valid values: - &#x60;sender&#x60; - &#x60;originator&#x60;  Conditional field. If value in this field is &#x60;originator&#x60;, this field is mandatory for originator-initated transactions.  | [optional] 
**StoredCredentialUsed** | **bool?** | Indicates to an issuing bank whether an originator-initiated transaction came from a card that was already stored on file.  Possible values: - &#x60;True&#x60; &#x3D; originator-initiated transaction came from a card that was already stored on file - &#x60;False&#x60; &#x3D;  originator-initiated transaction came from a card that was not stored on file  Conditional for MITCOF transactions  | [optional] 
**CredentialStoredOnFile** | **bool?** | Flag that indicates whether the transaction is the first originator-initiated transaction in a series, which means that the customer initiated the previous transaction.   Possible values: - &#x60;True&#x60;: First originator-initiated transaction - &#x60;False&#x60;: Not the first originator-initiated transaction  Conditional for MITCOF transactions  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


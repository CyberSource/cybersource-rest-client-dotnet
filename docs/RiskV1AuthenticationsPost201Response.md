# CyberSource.Model.RiskV1AuthenticationsPost201Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**PtsV2IncrementalAuthorizationPatch201ResponseLinks**](PtsV2IncrementalAuthorizationPatch201ResponseLinks.md) |  | [optional] 
**Id** | **string** | An unique identification number to identify the submitted request. It is also appended to the endpoint of the resource.  On incremental authorizations, this value with be the same as the identification number returned in the original authorization response.  #### PIN debit Returned for all PIN debit services.  | [optional] 
**SubmitTimeUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by authorization service.  #### PIN debit Time when the PIN debit credit, PIN debit purchase or PIN debit reversal was requested.  Returned by PIN debit credit, PIN debit purchase or PIN debit reversal.  | [optional] 
**SubmitTimeLocal** | **string** | Time that the transaction was submitted in local time. | [optional] 
**Status** | **string** | The status for payerAuthentication 201 enroll and validate calls. Possible values are: - &#x60;AUTHENTICATION_SUCCESSFUL&#x60; - &#x60;PENDING_AUTHENTICATION&#x60; - &#x60;INVALID_REQUEST&#x60; - &#x60;AUTHENTICATION_FAILED&#x60;  | [optional] 
**Message** | **string** | The message describing the reason of the status. Value is: - The cardholder is enrolled in Payer Authentication. Please authenticate the cardholder before continuing with the transaction.  | [optional] 
**ClientReferenceInformation** | [**RiskV1DecisionsPost201ResponseClientReferenceInformation**](RiskV1DecisionsPost201ResponseClientReferenceInformation.md) |  | [optional] 
**OrderInformation** | [**RiskV1DecisionsPost201ResponseOrderInformation**](RiskV1DecisionsPost201ResponseOrderInformation.md) |  | [optional] 
**ConsumerAuthenticationInformation** | [**RiskV1DecisionsPost201ResponseConsumerAuthenticationInformation**](RiskV1DecisionsPost201ResponseConsumerAuthenticationInformation.md) |  | [optional] 
**ErrorInformation** | [**RiskV1AuthenticationsPost201ResponseErrorInformation**](RiskV1AuthenticationsPost201ResponseErrorInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


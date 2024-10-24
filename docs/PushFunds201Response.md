# CyberSource.Model.PushFunds201Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identification number to identify the submitted request. It is also appended to the endpoint of the resource.  | [optional] 
**SubmitTimeUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;  **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  | [optional] 
**Status** | **string** | The status of the submitted transaction.  Possible values: - AUTHORIZED - DECLINED - SERVER_ERROR - INVALID_REQUEST - PARTIAL_AUTHORIZED  | [optional] 
**ReconciliationId** | **string** | Cybersource or merchant generated transaction reference number. This is sent to the processor and is echoed back in the response to the merchant. This is This value is used for reconciliation purposes.  | [optional] 
**ClientReferenceInformation** | [**PushFunds201ResponseClientReferenceInformation**](PushFunds201ResponseClientReferenceInformation.md) |  | [optional] 
**RecipientInformation** | [**PushFunds201ResponseRecipientInformation**](PushFunds201ResponseRecipientInformation.md) |  | [optional] 
**MerchantInformation** | [**PushFunds201ResponseMerchantInformation**](PushFunds201ResponseMerchantInformation.md) |  | [optional] 
**ErrorInformation** | [**PushFunds201ResponseErrorInformation**](PushFunds201ResponseErrorInformation.md) |  | [optional] 
**ProcessorInformation** | [**PushFunds201ResponseProcessorInformation**](PushFunds201ResponseProcessorInformation.md) |  | [optional] 
**OrderInformation** | [**PushFunds201ResponseOrderInformation**](PushFunds201ResponseOrderInformation.md) |  | [optional] 
**PaymentInformation** | [**PushFunds201ResponsePaymentInformation**](PushFunds201ResponsePaymentInformation.md) |  | [optional] 
**ProcessingInformation** | [**PushFunds201ResponseProcessingInformation**](PushFunds201ResponseProcessingInformation.md) |  | [optional] 
**Links** | [**PushFunds201ResponseLinks**](PushFunds201ResponseLinks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


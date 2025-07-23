# CyberSource.Model.Ptsv2intentsProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessingInstruction** | **string** | The instruction to process an order. - default value: &#39;NO_INSTRUCTION&#39; - &#39;ORDER_SAVED_EXPLICITLY&#39;  | [optional] 
**AuthorizationOptions** | [**Ptsv2intentsProcessingInformationAuthorizationOptions**](Ptsv2intentsProcessingInformationAuthorizationOptions.md) |  | [optional] 
**ActionList** | **List&lt;string&gt;** | Array of actions (one or more) to be included in the order to invoke bundled services along with order. Possible values: - &#x60;AP_ORDER&#x60;: Use this when Alternative Payment Order service is requested.  | [optional] 
**HighRiskTransactionFlag** | **string** | Indicates if the transaction is flagged as high risk.  | [optional] 
**TransactionRetry** | **string** | Indicates if the transaction is a retry.  | [optional] 
**LastOneHrTransactionCount** | **string** | The number of transactions in the last one hour.  | [optional] 
**LastOneDayTransactionCount** | **string** | The number of transactions in the last one day.  | [optional] 
**LastThreeMonthsTxnCount** | **string** | The number of transactions in the last three months.  | [optional] 
**TotalTransactionCount** | **string** | The total number of transactions.  | [optional] 
**PinVerification** | **string** | Indicates if PIN verification is required.  | [optional] 
**FaceIdVerification** | **string** | Indicates if face ID verification is required.  | [optional] 
**UserPassedVerification** | **string** | Indicates if the user passed verification.  | [optional] 
**IpAddress** | **string** | The IP address of the user.  | [optional] 
**TransactionDate** | **string** | The date of the transaction.  | [optional] 
**Tangible** | **string** | Indicates if the transaction involves tangible goods.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


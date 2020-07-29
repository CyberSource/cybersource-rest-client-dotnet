# CyberSource.Model.TssV2TransactionsGet200ResponseApplicationInformationApplications
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the CyberSource transaction type (such as CC settlement or CC authorization) that the merchant wants to process in a transaction request. More than one transaction type can included in a transaction request. Each transaction type separately returns their own status, reasonCode, rCode, and rFlag messages.  | [optional] 
**Status** | **string** | The description for this field is not available. | [optional] 
**ReasonCode** | **string** | 3-digit reason code that indicates why the customer profile payment succeeded or failed. | [optional] 
**RCode** | **string** | Indicates whether the service request was successful. Possible values:  - &#x60;-1&#x60;: An error occurred. - &#x60;0&#x60;: The request was declined. - &#x60;1&#x60;: The request was successful.  | [optional] 
**RFlag** | **string** | One-word description of the result of the application.  | [optional] 
**ReconciliationId** | **string** | Reference number that you use to reconcile your CyberSource reports with your processor reports.  | [optional] 
**RMessage** | **string** | Message that explains the reply flag for the application.  | [optional] 
**ReturnCode** | **int?** | The description for this field is not available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


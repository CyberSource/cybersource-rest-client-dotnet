# CyberSource.Model.TssV2TransactionsGet200ResponseApplicationInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the submitted transaction. | [optional] 
**ReasonCode** | **string** | Indicates the reason why a request succeeded or failed and possible action to take if a request fails.  For details, see the appendix of reason codes in the documentation for the relevant payment method.  | [optional] 
**RCode** | **string** | Indicates whether the service request was successful. Possible values:  - &#x60;-1&#x60;: An error occurred. - &#x60;0&#x60;: The request was declined. - &#x60;1&#x60;: The request was successful.  | [optional] 
**RFlag** | **string** | One-word description of the result of the application.  | [optional] 
**Applications** | [**List&lt;TssV2TransactionsGet200ResponseApplicationInformationApplications&gt;**](TssV2TransactionsGet200ResponseApplicationInformationApplications.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


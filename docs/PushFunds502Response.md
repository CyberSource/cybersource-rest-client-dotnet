# CyberSource.Model.PushFunds502Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identification number to identify the submitted request. It is also appended to the endpoint of the resource.  | [optional] 
**SubmitTimeUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60;  **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  | [optional] 
**Status** | **string** | Possible values: - SERVER_ERROR  | [optional] 
**Reason** | **string** | The reason of the status.  Possible values: - SYSTEM_ERROR - SERVICE_TIMEOUT  | [optional] 
**Message** | **string** | The detail message related to the status and reason listed above.  Possible values: - Error - General system failure. - The request was received, but a service did not finish running in time.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


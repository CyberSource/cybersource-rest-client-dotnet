# CyberSource.Model.KmsV2KeysSymPost201ResponseKeyInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrganizationId** | **string** | Merchant Id  | [optional] 
**ReferenceNumber** | **string** | Reference number is a unique identifier provided by the client along with the organization Id. This is an optional field provided solely for the client’s convenience. If client specifies value for this field in the request, it is expected to be available in the response.  | [optional] 
**KeyId** | **string** | Key Serial Number  | [optional] 
**Key** | **string** | value of the key  | [optional] 
**Status** | **string** | The status of the key.  Possible values:  - FAILED  - ACTIVE  | [optional] 
**ExpirationDate** | **string** | The expiration time in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**Message** | **string** | message in case of failed key | [optional] 
**ErrorInformation** | [**KmsV2KeysSymPost201ResponseErrorInformation**](KmsV2KeysSymPost201ResponseErrorInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.KmsV2KeysSymGet200ResponseKeyInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrganizationId** | **string** | Merchant Id  | [optional] 
**KeyId** | **string** | Key serial number  | [optional] 
**Status** | **string** | The status of the key.  Possible values:  - FAILED  - ACTIVE  - INACTIVE  - EXPIRED  | [optional] 
**ExpirationDate** | **string** | The expiration time in UTC.  | [optional] 
**Message** | **string** | message in case of failed key  | [optional] 
**ErrorInformation** | [**KmsV2KeysSymPost201ResponseErrorInformation**](KmsV2KeysSymPost201ResponseErrorInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.Acpv1tokensDeviceInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserAgent** | **string** | Base64 Encoded userAgent string of the connecting client application, with no padding.   User agent string of the connecting client application.   Conditionality:   - Required for browsers - Optional for non-browsers  | [optional] 
**ApplicationName** | **string** | Name of the connecting client application. | 
**FingerprintSessionId** | **string** | Device Fingerprinting Session identifier. | 
**Country** | **string** | ISO 3166-1 alpha-2 country code. The country where the Consumer is accessing the service from. | [optional] 
**DeviceData** | [**Acpv1tokensDeviceInformationDeviceData**](Acpv1tokensDeviceInformationDeviceData.md) |  | 
**IpAddress** | **string** | IP address of the consumer&#39;s device. | 
**ClientDeviceId** | **string** | Unique identifier of the consumer&#39;s device. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


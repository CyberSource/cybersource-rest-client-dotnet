# CyberSource.Model.InlineResponse20011Devices
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReaderId** | **string** |  | [optional] 
**SerialNumber** | **string** |  | [optional] 
**Model** | **string** |  | [optional] 
**Make** | **string** |  | [optional] 
**HardwareRevision** | **string** |  | [optional] 
**Status** | **string** | Status of the device. Possible Values:   - &#39;ACTIVE&#39;   - &#39;INACTIVE&#39;  | [optional] 
**StatusChangeReason** | **string** | Reason for change in status. | [optional] 
**MerchantId** | **string** | ID of the merchant to whom this device is assigned. | [optional] 
**AccountId** | **string** | ID of the account to whom the device assigned. | [optional] 
**TerminalCreationDate** | **DateTime?** | Timestamp in which the device was created. | [optional] 
**TerminalUpdationDate** | **DateTime?** | Timestamp in which the device was updated/modified. | [optional] 
**PaymentProcessorToTerminalMap** | [**InlineResponse20011PaymentProcessorToTerminalMap**](InlineResponse20011PaymentProcessorToTerminalMap.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


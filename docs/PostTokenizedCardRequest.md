# CyberSource.Model.PostTokenizedCardRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountReferenceId** | **string** | An identifier provided by the issuer for the account. **Required when source is ISSUER.**  | [optional] 
**ConsumerId** | **string** | Identifier of the consumer within the wallet. Maximum 24 characters for VTS. | [optional] 
**CreatePanInstrumentIdentifier** | **bool?** | Specifies whether the Instrument Identifier should be created (true) or not (false) with the PAN provided for the Network Token Provision request. Possible Values: - &#x60;true&#x60;: The InstrumentIdentifier should be created. - &#x60;false&#x60;: The InstrumentIdentifier should not be created.  | [optional] 
**Source** | **string** | Source of the card details. Possible Values: - ONFILE - TOKEN - ISSUER  | 
**Card** | [**Tmsv2tokenizedcardsCard**](Tmsv2tokenizedcardsCard.md) |  | [optional] 
**Passcode** | [**Tmsv2tokenizedcardsPasscode**](Tmsv2tokenizedcardsPasscode.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.ECheckConfigFeaturesAccountValidationServiceProcessors
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AvsAccountOwnershipService** | **bool?** | *NEW* Determined in WF eTicket if account has opted into the Account Ownership Service. | [optional] 
**AvsAccountStatusService** | **bool?** | *NEW* Determined in WF eTicket if account has opted into the Account Status Service. | [optional] 
**AvsSignedAgreement** | **bool?** | *NEW* Taken from Addendum Agreement Column in boarding form. | [optional] 
**AvsCalculatedResponseBehavior** | **Object** | *NEW* | [optional] 
**AvsAdditionalId** | **string** | *NEW* Also known as the Additional ID. Taken from the boarding form. | [optional] 
**EnableAvs** | **bool?** | *NEW* | [optional] [default to true]
**AvsEntityId** | **string** | *NEW* Also known as the AVS Gateway Entity ID. | [optional] 
**AvsResultMode** | **Object** | *NEW* | [optional] 
**EnableAvsTokenCreation** | **bool?** | *NEW* Applicable if the merchant wants to run AVS on token creation requests only. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


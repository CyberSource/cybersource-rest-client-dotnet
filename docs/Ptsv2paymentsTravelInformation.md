# CyberSource.Model.Ptsv2paymentsTravelInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Duration** | **string** | Duration of the auto rental or lodging rental.  #### Auto rental This field is supported for Visa, MasterCard, and American Express. **Important** If this field is not included when the &#x60;processingInformation.industryDataType&#x60; is auto rental, the transaction is declined.  | [optional] 
**Agency** | [**Ptsv2paymentsTravelInformationAgency**](Ptsv2paymentsTravelInformationAgency.md) |  | [optional] 
**AutoRental** | [**Ptsv2paymentsTravelInformationAutoRental**](Ptsv2paymentsTravelInformationAutoRental.md) |  | [optional] 
**Lodging** | [**Ptsv2paymentsTravelInformationLodging**](Ptsv2paymentsTravelInformationLodging.md) |  | [optional] 
**Transit** | [**Ptsv2paymentsTravelInformationTransit**](Ptsv2paymentsTravelInformationTransit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


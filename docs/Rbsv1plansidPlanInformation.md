# CyberSource.Model.Rbsv1plansidPlanInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Plan code is an optional field, If not provided system generates and assign one  | [optional] 
**Name** | **string** | Plan name  | [optional] 
**Description** | **string** | Plan description  | [optional] 
**Status** | **string** | Updating to &#x60;DRAFT&#x60; is not allowed from &#x60;ACTIVE&#x60; and &#x60;INACTIVE&#x60; status.  Plan Status:  - &#x60;DRAFT&#x60;  - &#x60;ACTIVE&#x60;  - &#x60;INACTIVE&#x60;  | [optional] 
**BillingPeriod** | [**GetAllPlansResponsePlanInformationBillingPeriod**](GetAllPlansResponsePlanInformationBillingPeriod.md) |  | [optional] 
**BillingCycles** | [**Rbsv1plansPlanInformationBillingCycles**](Rbsv1plansPlanInformationBillingCycles.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


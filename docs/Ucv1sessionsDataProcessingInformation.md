# CyberSource.Model.Ucv1sessionsDataProcessingInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReconciliationId** | **string** | The reconciliation ID | [optional] 
**PurposeOfPayment** | **string** | This field is applicable for AFT and OCT transactions.  For list of supported values, please refer to Developer Guide.  | [optional] 
**AuthorizationOptions** | [**Ucv1sessionsDataProcessingInformationAuthorizationOptions**](Ucv1sessionsDataProcessingInformationAuthorizationOptions.md) |  | [optional] 
**RecurringOptions** | [**Ucv1sessionsDataProcessingInformationRecurringOptions**](Ucv1sessionsDataProcessingInformationRecurringOptions.md) |  | [optional] 
**BankTransferOptions** | [**Ucv1sessionsDataProcessingInformationBankTransferOptions**](Ucv1sessionsDataProcessingInformationBankTransferOptions.md) |  | [optional] 
**BusinessApplicationId** | **string** | The business application Id&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**CommerceIndicator** | **string** | The commerce indicator&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**ProcessingInstruction** | **string** | The processing instruction&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


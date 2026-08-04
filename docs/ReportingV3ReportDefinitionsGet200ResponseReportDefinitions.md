# CyberSource.Model.ReportingV3ReportDefinitionsGet200ResponseReportDefinitions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**ReportDefinitionId** | **int?** | | Id  |         Definition Class          | | - -- | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- | | 210 | TransactionRequestClass           | | 211 | PaymentBatchDetailClass           | | 212 | ExceptionDetailClass              | | 213 | ProcessorSettlementDetailClass    | | 214 | ProcessorEventsDetailClass        | | 215 | FundingDetailClass                | | 216 | AgingDetailClass                  | | 217 | ChargebackAndRetrievalDetailClass | | 218 | DepositDetailClass                | | 219 | FeeDetailClass                    | | 220 | InvoiceSummaryClass               | | 221 | PayerAuthDetailClass              | | 222 | ConversionDetailClass             | | 225 | BillableTransactionsDetailClass   | | 270 | JPTransactionDetailClass          | | 271 | ServiceFeeDetailClass             | | 310 | GatewayTransactionRequestClass    | | 400 | DecisionManagerEventDetailClass   | | 401 | DecisionManagerDetailClass        | | 410 | FeeSummaryClass                   | | 420 | TaxCalculationClass               | | 520 | POSTerminalExceptionClass         | | 620 | SubscriptionDetailClass           | | 630 | StandardBillingDataPackageClass   | | 706 | StandardMonthlyFeeClass           |  | [optional] 
**ReportDefintionName** | **string** |  | [optional] 
**SupportedFormats** | **List&lt;string&gt;** |  | [optional] 
**Description** | **string** |  | [optional] 
**DefaultSettings** | [**ReportDefinitionDefaultSettings**](ReportDefinitionDefaultSettings.md) |  | [optional] 
**SubscriptionType** | **string** | &#39;The subscription type for which report definition is required. By default the type will be CUSTOM.&#39; Valid Values: - CLASSIC - CUSTOM - STANDARD  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


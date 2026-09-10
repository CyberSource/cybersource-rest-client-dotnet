# CyberSource.Model.UnifiedriskMerchant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryCode** | **string** | Merchant category code (MCC) related to the type of services or goods the merchant provides for the transaction. It is strongly recommended that this conforms to an international standard such as ISO | [optional] 
**MerchantId** | **string** | Identifier of the merchant in a transaction. This should be fully unique; two different merchants should not have the same merchantId. It is also essential that this merchantId is consistent over time | [optional] 
**Name** | **string** | Name of the merchant in merchantId. This should include enough information to clearly identify the merchant, whenever possible. | [optional] 
**Currency** | **string** | Merchant&#39;s local currency (ISO 4217 3-letter code). Used for currency conversion calculations. | [optional] 
**MerchantDescriptor** | [**UnifiedriskMerchantMerchantDescriptor**](UnifiedriskMerchantMerchantDescriptor.md) |  | [optional] 
**Address** | [**UnifiedriskMerchantAddress**](UnifiedriskMerchantAddress.md) |  | [optional] 
**IndustryOfBusiness** | **string** | Industry sector or vertical the merchant operates in (e.g., RETAIL, HOSPITALITY, HEALTHCARE, FINANCIAL_SERVICES). Provides broader business context beyond the MCC | [optional] 
**Status** | **string** | Current operational status of the merchant account (e.g., ACTIVE, SUSPENDED, TERMINATED, PENDING_REVIEW). Drives eligibility checks during transaction processing | [optional] 
**Type** | **string** | Classification of the merchant&#39;s business type (e.g., SOLE_TRADER, PARTNERSHIP, LIMITED_COMPANY, NON_PROFIT). Used for regulatory and underwriting purposes | [optional] 
**TradingAddress** | [**UnifiedriskMerchantTradingAddress**](UnifiedriskMerchantTradingAddress.md) |  | [optional] 
**ReferenceNumber** | **string** | An external or internal reference number associated with the merchant, used for cross-system reconciliation (e.g., CRM ID, acquirer reference, banking platform reference) | [optional] 
**MerchantDefinedData** | **string** | Free-form merchant-provided data for risk assessment, allowing supplementary information not captured by standard fields (e.g., loyalty tier, custom risk flags) | [optional] 
**MerchantSellerId** | **string** | Unique identifier assigned to this merchant as a seller within a marketplace or platform (e.g., Amazon Marketplace seller ID). Used to distinguish sub-merchants in aggregator models | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


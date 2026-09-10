# CyberSource.Model.UnifiedriskMerchantMerchantDescriptor
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Your merchant name.**Note** For Paymentech processor using Cybersource Payouts, the maximum data length is 22.#### PIN debit Your business name. This name is displayed on the cardholder&#39;s statement. When you include more than one consecutive space, extra spaces are removed.When you do not include this value in your PIN debit request, the merchant name from your account is used. **Important** This value must consist of English characters.Optional field for PIN debit credit or PIN debit pu | [optional] 
**Url** | **string** | Address of company&#39;s website provided by merchant | [optional] 
**Email** | **string** | Primary contact email address of the merchant, used for notifications, dispute communications, and merchant verification purposes | [optional] 
**PhoneNumber** | **string** | Primary phone number of the merchant in E.164 format (e.g., +14155552671), used for contact and identity verification | [optional] 
**RiskProfile** | **string** | Risk classification or category assigned to the merchant based on their industry, transaction patterns, and historical fraud rates (e.g., HIGH, MEDIUM, LOW) | [optional] 
**AuthorizedSignatories** | **string** | Names or identifiers of individuals authorized to sign agreements and take financial actions on behalf of the merchant entity | [optional] 
**CloseDate** | **string** | The date the merchant account was or is scheduled to be closed, in ISO 8601 format (YYYY-MM-DD). Used for tracking merchant lifecycle events | [optional] 
**CountryIncorporated** | **string** | The ISO 3166-1 alpha-3 country code where the merchant business is legally incorporated (e.g., GBR, USA, IND) | [optional] 
**CreditScore** | **int?** | The merchant&#39;s score as assessed by the acquirer or a credit bureau, used for underwriting and risk decisions during merchant onboarding | [optional] 
**DateOfEstablishment** | **string** | The date the merchant&#39;s business was formally established or incorporated, in ISO 8601 format (YYYY-MM-DD). Used for business tenure risk assessment | [optional] 
**DateofOwnershipChange** | **string** | The date of the most recent ownership change for the merchant entity, in ISO 8601 format. Ownership changes can indicate elevated risk and require re-underwriting | [optional] 
**EcommerceSupport** | **string** | Indicates whether the merchant supports e-commerce transactions and the level of online payment capability (e.g., FULL, PARTIAL, NONE) | [optional] 
**ExpectedAverageTicketSize** | [**UnifiedriskMerchantMerchantDescriptorExpectedAverageTicketSize**](UnifiedriskMerchantMerchantDescriptorExpectedAverageTicketSize.md) |  | [optional] 
**ExpectedAnnualSales** | [**UnifiedriskMerchantMerchantDescriptorExpectedAnnualSales**](UnifiedriskMerchantMerchantDescriptorExpectedAnnualSales.md) |  | [optional] 
**ExpectedMonthlySales** | [**UnifiedriskMerchantMerchantDescriptorExpectedMonthlySales**](UnifiedriskMerchantMerchantDescriptorExpectedMonthlySales.md) |  | [optional] 
**LimitType** | **string** | Defines the type of financial limit applied to the merchant (e.g., SINGLE_TRANSACTION, DAILY, MONTHLY, ANNUAL). Used to enforce risk controls during payment processing | [optional] 
**LimitValue** | [**UnifiedriskMerchantMerchantDescriptorLimitValue**](UnifiedriskMerchantMerchantDescriptorLimitValue.md) |  | [optional] 
**Hierarchy** | [**UnifiedriskMerchantMerchantDescriptorHierarchy**](UnifiedriskMerchantMerchantDescriptorHierarchy.md) |  | [optional] 
**PrimaryGoods** | **string** | The primary category of goods or services sold by the merchant (e.g., Electronics, Clothing, Travel Services). Used alongside MCC for granular risk profiling | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


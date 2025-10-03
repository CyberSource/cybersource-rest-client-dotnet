# CyberSource.Model.UnderwritingConfigurationOrganizationInformationBusinessInformationBusinessDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerType** | **string** | Who is the business interacting with? Business to Business, Business to Consumer, Both  Possible values: - B2B - B2C - Both | [optional] 
**PercentageSplitByB2B** | **decimal?** | % Split | [optional] 
**PercentageSplitByB2C** | **decimal?** | % Split | [optional] 
**InteractionTypes** | **string** | Merchant Facing: Face to Face, Card Not Present, Both  Possible values: - F2F - CNP - Both | 
**PercentageSplitByF2F** | **decimal?** | % Split | 
**PercentageSplitByCNP** | **decimal?** | % Split | 
**WhenIsCustomerCharged** | **string** | When is the customer charged?  Possible values: - OneTimeBeforeServiceDelivery - OneTimeAfterServiceDelivery - Other | 
**WhenIsCustomerChargedDescription** | **string** |  | [optional] 
**OfferSubscriptions** | **bool?** | Does Merchant Offer Subscriptions? | 
**MonthlySubscriptionPercent** | **decimal?** | % of business is monthly subscriptions | [optional] 
**QuarterlySubscriptionPercent** | **decimal?** | % of business is quarterly subscriptions | [optional] 
**SemiannualSubscriptionPercent** | **decimal?** | % of business is semi-annual subscriptions | [optional] 
**AnnualSubscriptionPercent** | **decimal?** | % of business is annual subscriptions | [optional] 
**CurrencyType** | **string** | Processing Currency. ISO 4217, 3 characters.  Possible values: - USD - CAD - EUR - GBP - CHF | [optional] 
**EstimatedMonthlySales** | **decimal?** | Merchant&#39;s estimated monthly sales | [optional] 
**AverageOrderAmount** | **decimal?** | Merchant&#39;s average order amount | [optional] 
**LargestExpectedOrderAmount** | **decimal?** | Merchant&#39;s largest expected order amount | [optional] 
**PrimaryAccountUsage** | **string** | Primary purpose of account usage  Possible values: - Paying for goods / services - Repatriating overseas earnings - Intercompany transfers - Collecting funds from clients - Liquidity / FX - Payment to an individual - Investment activity - Property purchase/sale - Other | [optional] 
**SourceOfFunds** | **string** | Source of Funds  Possible values: - Business revenue - External or shareholder investment - Loan, advance or other borrowing - Donations or grants - Inter-company transfers - Proceeds of sales of assests - Other | [optional] 
**ReceiveMoney3rdParties** | **bool?** | Will you recieve money from 3rd parties into your account? | [optional] 
**ReceiveTransactionFrequency** | **string** | Roughly how often do you expect to send or receive transactions?  Possible values: - One-off or infrequently - 1-20 per month - 20-50 per month - 50-100 per month - 100+ per month | [optional] 
**EstimatedMonthlySpend** | **string** | What is your estimated total monthly spend?  Possible values: - &lt;$10,000 - $10,000 - $50,000 - $50,000 - $100,000 - $100,000 - $500,000 - $500,000+ | [optional] 
**CountryTransactions** | **List&lt;string&gt;** |  | [optional] 
**CurrenciesIn** | **List&lt;string&gt;** |  | [optional] 
**CurrenciesOut** | **List&lt;string&gt;** |  | [optional] 
**ProductServicesSubscription** | [**List&lt;UnderwritingConfigurationOrganizationInformationBusinessInformationBusinessDetailsProductServicesSubscription&gt;**](UnderwritingConfigurationOrganizationInformationBusinessInformationBusinessDetailsProductServicesSubscription.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


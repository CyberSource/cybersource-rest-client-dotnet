# CyberSource.Model.UnifiedriskCustomer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantCustomerId** | **string** | Your identifier for the customer.When a subscription or customer profile is being created, the maximum length for this field for most processors is 30. Otherwise, the maximum length is 100.#### Comercio Latino For recurring payments in Mexico, the value is the customer&#39;s contract number. Note Before you request the authorization, you must inform the issuer of the customer contract numbers that will be used for recurring transactions.#### Worldpay VAP For a follow-on credit with Worldpay VA | [optional] 
**Username** | **string** | Specifies the customer account user name. | [optional] 
**HashedPassword** | **string** | The merchant&#39;s password that CyberSource hashes and stores as a hashed password. | [optional] 
**PersonalIdentification** | [**UnifiedriskCustomerPersonalIdentification**](UnifiedriskCustomerPersonalIdentification.md) |  | [optional] 
**EnrollmentDate** | **DateTime?** | The date in which the customer signed up to use Mobile/online banking | [optional] 
**Flags** | **List&lt;string&gt;** | Field to be used for specific customer flags that may determine treatment strategies. This is an array that can include free text values.  For retail customers this may be a vulnerability or a VIP mar  | [optional] 
**CustomerId** | **string** | A unique identifier for the customer. | A unique identifier for the customer. This field should be considered mandatory for the payments solution, but not otherwise. | [optional] 
**Type** | **string** | The customer type. If the identifier in customerId represents an individual, set this attribute to \&quot;Retail\&quot;, if it represents a business, set this attribute to \&quot;Business\&quot;. | [optional] 
**AgentType** | **string** | Type of agent initiating transaction: HUMAN, AI_AGENT, or HYBRID  Possible values: - HUMAN - AI_AGENT - HYBRID | [optional] 
**AgentId** | **string** | Unique identifier for the AI agent acting on behalf of customer | [optional] 
**AgentConfidenceScore** | **decimal?** | Confidence score (0-1) for agent&#39;s alignment with customer preferences | [optional] 
**AgentDelegationScope** | **string** | Scope of authority delegated to agent: discovery, purchase, or full  Possible values: - discovery - purchase - full | [optional] 
**AgentInteractionTimestamp** | **DateTime?** | Timestamp of agent interaction with customer | [optional] 
**IsBusiness** | **bool?** | Whether customer is a business entity | [optional] 
**BusinessName** | **string** | Name of business if customer is a business | [optional] 
**Id** | **string** | The unique id of the customer | [optional] 
**Address** | [**UnifiedriskCustomerAddress**](UnifiedriskCustomerAddress.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


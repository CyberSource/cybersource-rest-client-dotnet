# CyberSource.Model.Ucv1sessionsDataConsumerAuthenticationInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChallengeCode** | **string** | The challenge code&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**MessageCategory** | **string** | The message category&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**AcsWindowSize** | **string** | The acs window size&lt;br&gt;&lt;br&gt;  Optional field: This field cannot be configured through the Merchant Experience screens in the Business Center, but if required should be provided on a per‑transaction basis in the uc/v1/sessions API request.  | [optional] 
**ProductCode** | **string** | Specifies the product code, which designates the type of transaction.&lt;br&gt;&lt;br&gt;  Specify one of the following values for this field:  - AIR: Airline purchase  Important Required for American Express SafeKey (U.S.).  - ACC: Accommodation Rental  - ACF: Account funding  - CHA: Check acceptance  - DIG: Digital Goods  - DSP: Cash Dispensing  - GAS: Fuel  - GEN: General Retail  - LUX: Luxury Retail  - PAL: Prepaid activation and load  - PHY: Goods or services purchase  - QCT: Quasi-cash transaction  - REN: Car Rental  - RES: Restaurant  - SVC: Services  - TBD: Other  - TRA: Travel&lt;br&gt;  **Important** Required for Visa Secure transactions in Brazil. Do not use this request field for any other types of transactions.  | [optional] 
**LanguagePreference** | **string** | Preferred language to be used for cardholder authentication and challenge experiences (subject to issuer/ACS support).  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


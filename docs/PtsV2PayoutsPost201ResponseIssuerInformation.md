# CyberSource.Model.PtsV2PayoutsPost201ResponseIssuerInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OctDomesticParticipantIndicator** | **bool?** | Domestic indicator for Push funds (OCT). If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctCrossBorderParticipantIndicator** | **bool?** | Cross-border indicator for push funds (OCT). If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctMoneyTransferDomesticIndicator** | **bool?** | Indicates whether domestic money transfer OCTs (push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.        Supported for Visa Direct.  | [optional] 
**OctMoneyTransferCrossBorderIndicator** | **bool?** | Indicates whether cross-border money transfer OCTs (push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctMoneyTransferFastFundsDomesticIndicator** | **bool?** | Indicates whether domestic money transfer OCTs (fast push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctMoneyTransferFastFundsCrossBorderIndicator** | **bool?** | Indicates whether cross-border money transfer OCTs (fast push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctMoneyTransferMerchantCountryRestricted** | **bool?** | This field indicates if the recipient issuer can accept push funds (OCT) transactions from the merchant country.  If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctNonMoneyTransferDomesticIndicator** | **bool?** | Indicates whether domestic non-money transfer OCTs (push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctNonMoneyTransferCrossBorderIndicator** | **bool?** | Indicates whether cross-border non-money transfer OCTs (push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctNonMoneyTransferFastFundsDomesticIndicator** | **bool?** | Indicates whether domestic non-money transfer OCTs (fast push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctNonMoneyTransferFastFundsCrossBorderIndicator** | **bool?** | Indicates whether cross-border non-money transfer OCTs (fast push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctOnlineGamblingDomesticIndicator** | **bool?** | Indicates whether domestic gambling OCTs (push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctOnlineGamblingCrossBorderIndicator** | **bool?** | Indicates whether cross-border gambling OCTs (push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctOnlineGamblingFastFundsDomesticIndicator** | **bool?** | Indicates whether domestic gambling OCTs (fast push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**OctOnlineGamblingFastFundsCrossBorderIndicator** | **bool?** | Indicates whether cross-border gambling OCTs (fast push funds) are allowed. If no Funds Transfer Attributes Inquiry data is available for this card account, the field is omitted.   Supported for Visa Direct.  | [optional] 
**ServiceProcessingType** | **string** | This field contains values that identify the service type under which the transaction should be processed. The valid value for the Visa Alias Directory Service is A0 (Alias) and 00 (normal transaction).  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


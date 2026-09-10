# CyberSource.Model.InlineResponse2015PayoutInformationPushFunds
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MoneyTransferFastFundsCrossBorder** | **string** | This field indicates if cross-border money transfer OCTs (fast push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**MoneyTransferFastFundsDomestic** | **string** | This field indicates if domestic money transfer OCTs (fast push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**MoneyTransferCrossBorder** | **string** | This field indicates if cross-border money transfer OCTs (push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**MoneyTransferDomestic** | **string** | This field indicates if domestic money transfer OCTs (push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**NonMoneyTransferFastFundsCrossBorder** | **string** | This field indicates if cross-border non-money transfer OCTs (fast push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**NonMoneyTransferFastFundsDomestic** | **string** | This field indicates if domestic non-money transfer OCTs (fast push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**NonMoneyTransferCrossBorder** | **string** | This field indicates if cross-border non-money transfer OCTs (push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**NonMoneyTransferDomestic** | **string** | This field indicates if domestic non-money transfer OCTs (push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**OnlineGamblingFastFundsCrossBorder** | **string** | This field indicates if cross-border gambling OCTs (fast push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**OnlineGamblingFastFundsDomestic** | **string** | This field indicates if domestic gambling OCTs (fast push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**OnlineGamblingCrossBorder** | **string** | This field indicates if cross-border gambling OCTs (push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**OnlineGamblingDomestic** | **string** | This field indicates if domestic gambling OCTs (push funds) are allowed. Possible values:   - &#x60;Y&#x60;   - &#x60;N&#x60;  | [optional] 
**DomesticParticipant** | **string** | This field indicates if domestic OCTs (push funds) are allowed. Possible values:   - &#x60;true&#x60;   - &#x60;false&#x60;  | [optional] 
**CrossBorderParticipant** | **string** | This field indicates if cross-border OCTs (push funds) are allowed. Possible values:   - &#x60;true&#x60;   - &#x60;false&#x60;  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


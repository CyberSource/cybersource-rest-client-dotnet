# CyberSource.Model.InlineResponse2011PaymentAccountInformationFeatures
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountFundingSource** | **string** | This field contains the account funding source. Possible values:   - &#x60;CREDIT&#x60;   - &#x60;DEBIT&#x60;   - &#x60;PREPAID&#x60;   - &#x60;DEFERRED DEBIT&#x60;   - &#x60;CHARGE&#x60;  | [optional] 
**AccountFundingSourceSubType** | **string** | This field contains the type of prepaid card. Possible values:   - &#x60;Reloadable&#x60;   - &#x60;Non-reloadable&#x60;  | [optional] 
**CardProduct** | **string** | This field contains the type of issuer product. Example values:   - Visa Classic   - Visa Signature   - Visa Infinite  | [optional] 
**MessageType** | **string** | This field contains the type of BIN based authentication. Possible values:   - &#x60;S&#x60;: Single Message   - &#x60;D&#x60;: Dual Message  | [optional] 
**AcceptanceLevel** | **string** | This field contains the acceptance level of the PAN. Possible values:   - &#x60;0&#x60; : Normal   - &#x60;1&#x60; : Monitor   - &#x60;2&#x60; : Refuse   - &#x60;3&#x60; : Not Allowed   - &#x60;4&#x60; : Private   - &#x60;5&#x60; : Test  | [optional] 
**CardPlatform** | **string** | This field contains the type of card platform. Possible values:   - &#x60;BUSINESS&#x60;   - &#x60;CONSUMER&#x60;   - &#x60;COMMERCIAL&#x60;   - &#x60;GOVERNMENT&#x60;  | [optional] 
**ComboCard** | **string** | This field indicates the type of combo card. Possible values:   - 0 (Not a combo card)   - 1 (Credit and Prepaid Combo card)   - 2 (Credit and Debit Combo card)  | [optional] 
**CorporatePurchase** | **bool?** | This field indicates whether the card can be used for corporate purchasing. This field is only applicable for American Express cards. Possible values:   - &#x60;true&#x60;   - &#x60;false&#x60;  | [optional] 
**HealthCard** | **bool?** | This field indicates if the entered card is a healthcare BIN. Currently, this field is only supported for Visa BINs. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;        | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


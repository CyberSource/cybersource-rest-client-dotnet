# CyberSource.Model.TmsBinLookupPaymentAccountInformationFeatures
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountFundingSource** | **string** | This field contains the account funding source. Possible values:   - &#x60;CREDIT&#x60;   - &#x60;DEBIT&#x60;   - &#x60;PREPAID&#x60;   - &#x60;DEFERRED DEBIT&#x60;   - &#x60;CHARGE&#x60;  | [optional] 
**AccountFundingSourceSubType** | **string** | This field contains the type of prepaid card. Possible values:   - &#x60;Reloadable&#x60;   - &#x60;Non-reloadable&#x60;  | [optional] 
**CardProduct** | **string** | This field contains the type of issuer product. Example values:   - Visa Classic   - Visa Signature   - Visa Infinite  | [optional] 
**MessageType** | **string** | This field contains the type of BIN based authentication. Possible values:   - &#x60;S&#x60;: Single Message   - &#x60;D&#x60;: Dual Message  | [optional] 
**AcceptanceLevel** | **string** | This field contains the acceptance level of the PAN. Possible values:   - &#x60;0&#x60; : Normal   - &#x60;1&#x60; : Monitor   - &#x60;2&#x60; : Refuse   - &#x60;3&#x60; : Not Allowed   - &#x60;4&#x60; : Private   - &#x60;5&#x60; : Test  | [optional] 
**CardPlatform** | **string** | This field contains the type of card platform. Possible values:   - &#x60;BUSINESS&#x60;   - &#x60;CONSUMER&#x60;   - &#x60;CORPORATE&#x60;   - &#x60;COMMERCIAL&#x60;   - &#x60;GOVERNMENT&#x60;  | [optional] 
**ComboCard** | **string** | This field indicates the type of combo card. Possible values:   - 0 (Not a combo card)   - 1 (Credit and Prepaid Combo card)   - 2 (Credit and Debit Combo card)   - 3 (Prepaid Credit and Prepaid Debit combo card)  | [optional] 
**CorporatePurchase** | **bool?** | This field indicates if the instrument can be used for corporate purchasing. This field is only applicable for American Express cards. Possible values:   - &#x60;true&#x60;   - &#x60;false&#x60;  | [optional] 
**HealthCard** | **bool?** | This field indicates if the BIN is for healthcare (HSA/FSA). Currently, this field is only supported for Visa BINs. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**SharedBIN** | **bool?** | This field indicates if the BIN is shared by multiple issuers Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**PosDomesticOnly** | **bool?** | This field indicates if the BIN is valid only for POS domestic usage. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**GamblingAllowed** | **bool?** | This field indicates if gambling transactions are allowed on the BIN. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**CommercialCardLevel2** | **bool?** | This field indicates if a transaction on the instrument qualifies for level 2 interchange rates. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**CommercialCardLevel3** | **bool?** | This field indicates if a transaction on the instrument qualifies for level 3 interchange rates. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**ExemptBIN** | **bool?** | This field indicates if a transaction on the instrument qualifies for government exempt interchange fee. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**AccountLevelManagement** | **bool?** | This field indicates if the BIN participates in Account Level Management (ALM). Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**OnlineGamblingBlock** | **bool?** | This field indicates if online gambling is blocked on the BIN. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**AutoSubstantiation** | **bool?** | This field indicates if auto-substantiation is enabled on the BIN. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**FlexCredential** | **bool?** | This field indicates if the instrument is a flex credential. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**ProductId** | **string** | This field contains the Visa-assigned product identifier associated with the BIN. This field is only supported for Visa BINs. Example values:   - Q4   - P   - AX  | [optional] 
**ProductIdSubtype** | **string** | This field contains the Visa-assigned product subtype identifier associated with the BIN. This field is only supported for Visa BINs. Example values:   - BB   - EX   - L2   - C2  | [optional] 
**ThreeDSSupport** | **bool?** | This field indicates if the payment instrument supports 3D Secure authentication. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**SiEligible** | **bool?** | This field indicates if the payment instrument is eligible for Standing Instructions (recurring payments). Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**EmiEligible** | **bool?** | This field indicates if the card is eligible for Equated Monthly Installments (EMI). Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 
**FleetCard** | **bool?** | This field indicates if the BIN is designated for fuel/fleet usage. These specialized BINs support additional Level2/Level 3 transaction data. Possible values:     - &#x60;true&#x60;     - &#x60;false&#x60;  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.Ptsv2paymentsProcessingInformationPurchaseOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsElectronicBenefitsTransfer** | **bool?** | Flag that indicates whether this transaction is an EBT transaction. Possible values: - &#x60;true&#x60; - &#x60;false&#x60;  #### PIN debit Required field for EBT and EBT voucher transactions that use PIN debit credit or PIN debit purchase; otherwise, not used.  | [optional] 
**Type** | **string** | Flag that indicates an EBT voucher transaction. Possible value: - &#x60;EBT_VOUCHER&#x60;: Indicates the PIN debit transaction is an EBT voucher. - &#x60;BUY&#x60; - &#x60;RENT&#x60; - &#x60;BOOK&#x60; - &#x60;SUBSCRIBE&#x60; - &#x60;DOWNLOAD&#x60; - &#x60;ORDER&#x60; - &#x60;CONTINUE&#x60;  #### PIN debit Required field for EBT voucher transactions that use PIN debit purchase; otherwise, not used.  | [optional] 
**EligibilityIndicator** | **string** | This field contains installment data defined by MasterCard. Possible values:   - Y &#x3D; eligible   - N &#x3D; not eligile  | [optional] 
**BenefitAmount** | **string** | Workplace benefit amount. | [optional] 
**BenefitType** | **string** | Workplace benefit type. Possible values: - 70 &#x3D; employee benefit - 4T &#x3D; transportation / transit - 52 &#x3D; general benefit - 53 &#x3D; meal voucher - 54 &#x3D; fuel - 55 &#x3D; ecological / sustainability - 58 &#x3D; philanthropy / patronage / consumption - 59 &#x3D; gift - 5S &#x3D; sport / culture - 5T &#x3D; book / education  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


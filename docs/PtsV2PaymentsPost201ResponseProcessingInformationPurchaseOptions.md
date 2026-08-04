# CyberSource.Model.PtsV2PaymentsPost201ResponseProcessingInformationPurchaseOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EligibilityIndicator** | **string** | This field contains installment data defined by MasterCard. Possible values:   - Y &#x3D; eligible   - N &#x3D; not eligile  | [optional] 
**Type** | **string** | Data mapped received in response from MasterCard. Possible values: - 01 &#x3D; Meal Voucher - Employee Nutrition Program - 02 &#x3D; Food Voucher - Employee Nutrition Program - 03 &#x3D; Culture Voucher - Worker&#39;s Culture Program - 04 &#x3D; Meal Voucher - Consolidation of Labor Laws - 05 &#x3D; Food Voucher - Consolidation of Labor Laws  | [optional] 
**BenefitAmount** | **string** | Workplace benefit amount. | [optional] 
**BenefitType** | **string** | Workplace benefit type. Possible values: - 70 &#x3D; employee benefit - 4T &#x3D; transportation / transit - 52 &#x3D; general benefit - 53 &#x3D; meal voucher - 54 &#x3D; fuel - 55 &#x3D; ecological / sustainability - 58 &#x3D; philanthropy / patronage / consumption - 59 &#x3D; gift - 5S &#x3D; sport / culture - 5T &#x3D; book / education  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


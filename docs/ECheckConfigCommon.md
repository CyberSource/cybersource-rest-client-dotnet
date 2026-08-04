# CyberSource.Model.ECheckConfigCommon
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Processors** | [**Dictionary&lt;string, ECheckConfigCommonProcessors&gt;**](ECheckConfigCommonProcessors.md) |  | [optional] 
**InternalOnly** | [**ECheckConfigCommonInternalOnly**](ECheckConfigCommonInternalOnly.md) |  | [optional] 
**AccountHolderName** | **string** | Mandatory  Name on Merchant&#39;s Bank Account Only ASCII (Hex 20 to Hex 7E)  | 
**AccountType** | **string** | Mandatory  Type of account for Merchant&#39;s Bank Account Possible values: - checking - savings - corporatechecking - corporatesavings  | 
**AccountRoutingNumber** | **string** | Mandatory  Routing number for Merchant&#39;s Bank Account US Account Routing Number  | 
**AccountNumber** | **string** | Mandatory  Account number for Merchant&#39;s Bank Account  | 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


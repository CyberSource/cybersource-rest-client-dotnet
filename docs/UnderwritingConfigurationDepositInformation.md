# CyberSource.Model.UnderwritingConfigurationDepositInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAccountCountry** | **string** | Country of the Bank Account. Two character country code, ISO 3166-1 alpha-2. | [optional] 
**AccountHolderName** | **string** | Name on the Bank Account | [optional] 
**AccountType** | **string** | Type of Account  Possible Values: - CHECKING - SAVINGS - CORPORATECHECKING - CORPORATESAVINGS  | [optional] 
**AccountRoutingNumber** | **string** | Routing Number, IBAN, Swift/BIC, etc | [optional] 
**AccountNumber** | **string** | Account Number | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


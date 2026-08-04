# CyberSource.Model.Ptsv2creditsSenderInformationAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | Account number of the sender of the funds. For Gaming Payment of Winnings transactions this is the merchant account number. * Required for Mastercard Payment of Winnings (POW) transactions. * Must contain only ASCII characters in range 32-122. * Must not be greater than 50 characters. * Required for POW on Barclays.  | [optional] 
**FundsSource** | **string** | Source of funds for the sender. For Gaming Payment of Winnings transactions this is the merchant account type. * Required for Mastercard Payment of Winnings (POW) transactions. * Valid values:   * 00 - Other   * 01 - RTN + Bank Account   * 02 - IBAN   * 03 - Card Account   * 04 - Email   * 05 - PhoneNumber   * 06 - Bank account number (BAN) + Bank Identification Code (BIC)   * 07 - Wallet ID   * 08 - Social Network ID  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


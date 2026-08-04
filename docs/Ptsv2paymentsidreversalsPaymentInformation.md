# CyberSource.Model.Ptsv2paymentsidreversalsPaymentInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentType** | [**Ptsv2paymentsidreversalsPaymentInformationPaymentType**](Ptsv2paymentsidreversalsPaymentInformationPaymentType.md) |  | [optional] 
**MerchantLimitedAcceptanceIndicator** | **string** | Mastercard One Credential merchant limited acceptance indicator. Mastercard One Credential connects multiple Mastercard payment methods and allows cardhollers to access various options and set payment preferences.  This field indicates which Mastercard One Credential funding PAN acceptance brands should NOT be assigned for this transaction.  This field flows in ISO field 34, DSID 02 tag DB, mapped to Mastercard Data Element (DE) 48, Sub element 02, Subfield 01.  Possible values: - &#x60;C&#x60;: Do not assign a Mastercard One Credential funding PAN containing the Mastercard Credit Acceptance Brand for this transaction - &#x60;D&#x60;: Do not assign a Mastercard One Credential funding PAN containing the Debit Mastercard Acceptance Brand for this transaction - &#x60;M&#x60;: Do not assign a Mastercard One Credential funding PAN containing the Maestro Acceptance Brand for this transaction  This field is supported for Authorization reversal request.  #### Used by **Authorization Reversal Request** Optional field.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


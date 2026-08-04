# CyberSource.Model.PtsV2ModifyBillingAgreementPost201ResponseAgreementInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier for the mandate.  | [optional] 
**DateSigned** | **string** | Date the mandate has been signed.  Format YYYYMMdd | [optional] 
**DateCreated** | **string** | Date the mandate has been created.  Format YYYYMMdd | [optional] 
**DateRevoked** | **string** | Date the mandate has been revoked.  Format YYYYMMdd | [optional] 
**Type** | **string** | Identifies the type of schedule as either recurring, one-off, split or usage.  Possible values: - recurring - oneoff - split - usage | [optional] 
**Frequency** | **string** | Regularity with which the event occurs.  Possible values: - annual - monthly - quarterly - semiannual - weekly - daily - adhoc - intraday - fortnightly | [optional] 
**EncodedHtml** | **string** | Base64 encoded html string | [optional] 
**EncodedHtmlPopup** | **string** | Base64 encoded popup html string | [optional] 
**Url** | **string** | URL for redirecting the customer for creating the mandate.  | [optional] 
**TransactionId** | **string** | The Billing Agreement ID returned by processor (PayPal).  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


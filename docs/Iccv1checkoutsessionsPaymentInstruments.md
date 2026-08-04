# CyberSource.Model.Iccv1checkoutsessionsPaymentInstruments
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Client-assigned instrument identifier. | [optional] 
**Type** | **string** | Payment method type (e.g. &#x60;card&#x60;, &#x60;wallet&#x60;). | [optional] 
**HandlerId** | **string** | Payment handler or processor identifier (e.g. &#x60;visa&#x60;). | [optional] 
**HandlerName** | **string** | Human-readable name of the payment handler. | [optional] 
**Brand** | **string** | Card brand (e.g. &#x60;visa&#x60;, &#x60;mastercard&#x60;). | [optional] 
**LastDigits** | **string** | Last 4 digits of the card number for display purposes. | [optional] 
**Token** | **string** | Opaque payment token from the payment provider. | [optional] 
**Credential** | [**Iccv1checkoutsessionsPaymentCredential**](Iccv1checkoutsessionsPaymentCredential.md) |  | [optional] 
**BillingAddress** | [**Iccv1checkoutsessionsPaymentBillingAddress**](Iccv1checkoutsessionsPaymentBillingAddress.md) |  | [optional] 
**Selected** | **bool?** | Whether this instrument is selected for the current session. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


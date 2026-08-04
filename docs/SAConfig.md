# CyberSource.Model.SAConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentProfileId** | **string** | You can group Secure Acceptance profiles under parent profiles. By changing the parent profile, you can update all profiles underneath that parent. Specify the Parent Profile ID here. | [optional] 
**ContactInformation** | [**SAConfigContactInformation**](SAConfigContactInformation.md) |  | [optional] 
**Notifications** | [**SAConfigNotifications**](SAConfigNotifications.md) |  | [optional] 
**Service** | [**SAConfigService**](SAConfigService.md) |  | [optional] 
**PaymentMethods** | [**SAConfigPaymentMethods**](SAConfigPaymentMethods.md) |  | [optional] 
**Checkout** | [**SAConfigCheckout**](SAConfigCheckout.md) |  | [optional] 
**PaymentTypes** | [**SAConfigPaymentTypes**](SAConfigPaymentTypes.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.Iccv1instructionsinstructionIdcredentialsOrderInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountDetail** | [**IccAmountDetail**](IccAmountDetail.md) |  | 
**ShipTo** | [**Iccv1instructionsinstructionIdcredentialsOrderInformationShipTo**](Iccv1instructionsinstructionIdcredentialsOrderInformationShipTo.md) |  | [optional] 
**LineItems** | [**List&lt;Iccv1instructionsinstructionIdcredentialsOrderInformationLineItems&gt;**](Iccv1instructionsinstructionIdcredentialsOrderInformationLineItems.md) |  | [optional] 
**DeliveryMethod** | **string** | (Conditional) An indication of the manner in which the purchased goods are to be delivered   Possible values:     - &#x60;NO_DELIVERY&#x60;   - &#x60;ADDRESS_BILLING&#x60;   - &#x60;ADDRESS_ON_FILE&#x60;   - &#x60;ADDRESS_OTHER&#x60;   - &#x60;PICKUP&#x60;   - &#x60;ELECTRONIC&#x60;  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


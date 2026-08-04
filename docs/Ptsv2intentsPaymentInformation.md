# CyberSource.Model.Ptsv2intentsPaymentInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentType** | [**Ptsv2intentsPaymentInformationPaymentType**](Ptsv2intentsPaymentInformationPaymentType.md) |  | [optional] 
**TokenizedPaymentMethod** | [**Ptsv2intentsPaymentInformationTokenizedPaymentMethod**](Ptsv2intentsPaymentInformationTokenizedPaymentMethod.md) |  | [optional] 
**IndustryType** | **string** | Indicates the industry type. Possible Values: - \&quot;Events\&quot; - \&quot;Ticketing\&quot; - \&quot;Fuel\&quot; - \&quot;GAMING\&quot; - \&quot;DIGITAL GOODS\&quot; - \&quot;TELCO\&quot; - \&quot;Token Service Providers\&quot; - \&quot;Gambling\&quot; - \&quot;CFDs\&quot; - \&quot;car rental\&quot; - \&quot;hotel\&quot; - \&quot;transportation\&quot; - \&quot;travel package\&quot; - \&quot;Cruise Line\&quot; - \&quot;P2P\&quot; - \&quot;Retail\&quot; - \&quot;Food\&quot; - \&quot;Groceries\&quot; - \&quot;Ride Sharing\&quot; - \&quot;Taxi\&quot; - \&quot;Remittance\&quot; - \&quot;Crypto\&quot; - \&quot;Marketplaces\&quot;  | [optional] 
**EWallet** | [**Ptsv2intentsPaymentInformationEWallet**](Ptsv2intentsPaymentInformationEWallet.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


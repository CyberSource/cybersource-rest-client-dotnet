# CyberSource.Model.MerchantRegistrationResponse201
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique merchant identifier (UUID) | 
**MerchantName** | **string** | Doing business as (DBA) name | 
**MerchantUrl** | **string** | Base merchant URL | 
**Vmid** | **string** | Visa Merchant ID | [optional] 
**CryptogramType** | **string** | Authentication cryptogram type  Possible values: - TAVV - DAVV | [optional] 
**PaymentPayloadType** | **string** | Credential delivery format  Possible values: - ENCRYPTED - UNENCRYPTED | [optional] 
**Indicator** | **string** | Transaction processing type  Possible values: - TAP - ACG - BOTH | 
**MerchantMetadata** | **Object** | Additional merchant metadata | [optional] 
**AcceptanceRelationships** | **List&lt;string&gt;** | List of acceptance network relationships | [optional] 
**ProtocolInteractions** | [**List&lt;Iccv1merchantsProtocolInteractions&gt;**](Iccv1merchantsProtocolInteractions.md) | List of protocol interaction configurations (ucp, acp, x402) | [optional] 
**WebIntegrations** | [**Iccv1merchantsWebIntegrations**](Iccv1merchantsWebIntegrations.md) |  | [optional] 
**ApiIntegrations** | [**Iccv1merchantsApiIntegrations**](Iccv1merchantsApiIntegrations.md) |  | [optional] 
**IsActive** | **bool?** | Whether the merchant is active | 
**CreatedAt** | **DateTime?** | Creation timestamp | 
**UpdatedAt** | **DateTime?** | Last update timestamp | 
**Keys** | [**List&lt;MerchantRegistrationResponse201Keys&gt;**](MerchantRegistrationResponse201Keys.md) | List of encryption keys associated with the merchant | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


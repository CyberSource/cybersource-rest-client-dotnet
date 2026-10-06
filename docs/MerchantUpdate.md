# CyberSource.Model.MerchantUpdate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantName** | **string** | Doing business as (DBA) name | [optional] 
**MerchantUrl** | **string** | Base URL of the merchant&#39;s domain. Must use HTTPS and be unique — raises 409 if already registered. | [optional] 
**CryptogramType** | **string** | Authentication cryptogram type used for payment credential generation.  Possible values: - TAVV - DAVV | [optional] 
**PaymentPayloadType** | **string** | Credential delivery format. Set to ***ENCRYPTED*** to enable JWE-encrypted payload delivery — requires an active encryption key. Returns 400 if no active key exists.  Possible values: - ENCRYPTED - UNENCRYPTED | [optional] 
**AcceptanceRelationships** | **List&lt;string&gt;** | List of payment network acceptance relationships (e.g., \&quot;Visa\&quot;). | [optional] 
**ProtocolInteractions** | [**List&lt;Iccv1merchantsProtocolInteractions&gt;**](Iccv1merchantsProtocolInteractions.md) | List of protocol interaction configurations defining the merchant&#39;s endpoint for each supported protocol (ucp, acp, x402). | [optional] 
**WebIntegrations** | [**MerchantRegistrationResponse201WebIntegrations**](MerchantRegistrationResponse201WebIntegrations.md) |  | [optional] 
**ApiIntegrations** | [**MerchantRegistrationResponse201ApiIntegrations**](MerchantRegistrationResponse201ApiIntegrations.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


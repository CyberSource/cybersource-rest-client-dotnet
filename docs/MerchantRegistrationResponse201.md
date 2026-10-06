# CyberSource.Model.MerchantRegistrationResponse201
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique merchant identifier (UUID) | 
**MerchantName** | **string** | Doing business as (DBA) name | 
**MerchantUrl** | **string** | Fully-qualified HTTPS URL of the merchant&#39;s domain | 
**Vmid** | **string** | Visa Merchant ID (VMID) — unique identifier assigned by Visa | [optional] 
**CryptogramType** | **string** | Authentication cryptogram type used for payment credential generation: &#39;TAVV&#39; (Token Authentication Verification Value) or &#39;DAVV&#39; (Device Authentication Verification Value)  Possible values: - TAVV - DAVV | [optional] 
**PaymentPayloadType** | **string** | Credential delivery format: &#39;ENCRYPTED&#39; (JWE-wrapped, requires an active encryption key) or &#39;UNENCRYPTED&#39;  Possible values: - ENCRYPTED - UNENCRYPTED | [optional] 
**Indicator** | **string** | Transaction processing indicator: &#39;TAP&#39; (Trusted Agent Protocol), &#39;ACG&#39; (Agentic Checkout Gateway), or &#39;BOTH&#39;  Possible values: - TAP - ACG - BOTH | 
**MerchantMetadata** | **Object** | Free-form metadata object for additional merchant context | [optional] 
**AcceptanceRelationships** | **List&lt;string&gt;** | List of payment network acceptance relationships (e.g., \&quot;Visa\&quot;) | [optional] 
**ProtocolInteractions** | [**List&lt;Iccv1merchantsProtocolInteractions&gt;**](Iccv1merchantsProtocolInteractions.md) | List of protocol endpoint configurations defining how agents interact with this merchant (ucp, acp, x402) | [optional] 
**WebIntegrations** | [**MerchantRegistrationResponse201WebIntegrations**](MerchantRegistrationResponse201WebIntegrations.md) |  | [optional] 
**ApiIntegrations** | [**MerchantRegistrationResponse201ApiIntegrations**](MerchantRegistrationResponse201ApiIntegrations.md) |  | [optional] 
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


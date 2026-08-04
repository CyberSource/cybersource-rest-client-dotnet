# CyberSource.Model.Ucv1sessionsPaymentConfigurationsGOOGLEPAY
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedAuthMethods** | **List&lt;string&gt;** | When you enable Google Pay on Unified Checkout you can specify optional parameters that define the types of card authentication you receive from Google Pay.&lt;br&gt;&lt;br&gt; By default, Google sends both authentication types.  When the complete mandate is used and Google Pay does not authenticate the transaction, then Unified Checkout completes the authentication request as part of the complete mandate.&lt;br&gt;&lt;br&gt; Possible values: - PAN_ONLY: Google returns primary account number (PAN) values - CRYPTOGRAM_3DS: Google returns fully authenticated network token values.&lt;br&gt;&lt;br&gt;  The allowedPaymentTypes field must also include GOOGLEPAY as shown below for the Google Pay button to show in Unified Checkout:    \&quot;allowedPaymentTypes\&quot;: [\&quot;GOOGLEPAY\&quot;] &lt;br&gt;&lt;br&gt;  Optional field:   This field can be configured through the Merchant Experience Screens in the Business Center.  The configured value may be overridden on a per transaction basis in the uc/v1/sessions API request.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


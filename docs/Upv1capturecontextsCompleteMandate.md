# CyberSource.Model.Upv1capturecontextsCompleteMandate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | This field is used to indicate how a payment should be processed.  Possible values: - AUTH: Use this value when you want to authorize a payment within Unified Checkout without capturing it immediately.  Payment types that initiate an immediate transfer of funds are NOT allowed.  If a capture context request includes a payment type incompatible with this mode, a 400 error will be returned.  A merchant would need to perform their own capture via API where applicable.&lt;br&gt;&lt;br&gt;   - CAPTURE: Use this value when you want to perform a sale within Unified Checkout and capture the payment immediately during the transaction.  Note: Some payment types may return a PENDING status, requiring an additional status check call to determine the final outcome of the payment.&lt;br&gt;&lt;br&gt; - PREFER_AUTH: Use this value to offer multiple alternative payment options during the Unified Checkout experience. This option authorizes the payment without immediate capture, where available.  It will perform a \&quot;CAPTURE\&quot; where an \&quot;AUTH\&quot; is not allowed by the payment type.  Transactions can be AUTHORIZED, CAPTURED, or PENDING.  If an \&quot;AUTH\&quot; is performed, a merchant would need to perform their own capture via API where applicable.  | [optional] 
**Tms** | [**Upv1capturecontextsCompleteMandateTms**](Upv1capturecontextsCompleteMandateTms.md) |  | [optional] 
**DecisionManager** | **bool?** | Configure Unified Checkout to determine whether Decision Manager is invoked during service orchestration.  Possible values:  - True  - False&lt;br&gt;&lt;br&gt;  Setting this value to True indicates that device fingerprinting will be executed to add additional information for risk service Setting this value to False (or not provided) indicates that you do not wish to run device fingerprinting and skip decision manager services.  | [optional] 
**ConsumerAuthentication** | **bool?** | Configure Unified Checkout to determine whether Consumer Authentication is invoked during service orchestration.  Possible values:  - True  - False&lt;br&gt;&lt;br&gt;  Setting this value to True will attempt to perform authentication using the Payer Authentication Service. Setting this value to False (or not provided) indicates that you do not wish to perform authentication using the Payer Authentication Service.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


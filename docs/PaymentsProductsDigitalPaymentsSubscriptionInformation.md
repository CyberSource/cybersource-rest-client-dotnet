# CyberSource.Model.PaymentsProductsDigitalPaymentsSubscriptionInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool?** |  | [optional] 
**SelfServiceability** | **string** | Indicates if the organization can enable this product using self service.  Possible values: - SELF_SERVICEABLE - NOT_SELF_SERVICEABLE - SELF_SERVICE_ONLY | [optional] [default to "NOT_SELF_SERVICEABLE"]
**Features** | [**Dictionary&lt;string, PaymentsProductsDigitalPaymentsSubscriptionInformationFeatures&gt;**](PaymentsProductsDigitalPaymentsSubscriptionInformationFeatures.md) | Allowed values are; &lt;table&gt;    &lt;tr&gt;       &lt;td&gt;visaCheckout&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;       &lt;td&gt;applePay&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;       &lt;td&gt;samsungPay&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;        &lt;td&gt;googlePay&lt;/td&gt;     &lt;/tr&gt; &lt;/table&gt;  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


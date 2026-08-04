# CyberSource.Model.PaymentsProductsAlternativePaymentMethodsConfigurationInformationConfigurations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantCategoryCode** | **string** | Merchant Category Code (MCC) is a four-digit number assigned to a business by credit card companies when the business first starts accepting credit cards as a form of payment. The MCC is used to classify the business by the type of goods or services it provides.  | [optional] 
**Processors** | [**Dictionary&lt;string, AlternativePaymentsProcessorConfiguration&gt;**](AlternativePaymentsProcessorConfiguration.md) | This is a map. The allowed keys are below. Value should be an object containing a sole boolean property - enabled. &lt;table&gt;   &lt;tr&gt;     &lt;td&gt;klarna&lt;/td&gt;   &lt;/tr&gt;   &lt;tr&gt;     &lt;td&gt;payPal&lt;/td&gt;   &lt;/tr&gt;   &lt;tr&gt;     &lt;td&gt;alipay&lt;/td&gt;   &lt;/tr&gt;   &lt;tr&gt;     &lt;td&gt;bancontact&lt;/td&gt;   &lt;/tr&gt;   &lt;tr&gt;     &lt;td&gt;giropay&lt;/td&gt;   &lt;/tr&gt;   &lt;tr&gt;     &lt;td&gt;ideal&lt;/td&gt;   &lt;/tr&gt; &lt;/table&gt;  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


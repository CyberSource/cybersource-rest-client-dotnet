# CyberSource.Model.InlineResponse20019GoogleMerchant
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Upload outcome status: - &#x60;TRIGGERED&#x60; — async upload dispatched; check Google Merchant Center for results - &#x60;FAILED&#x60; — all products failed UCP validation; nothing sent to Google - &#x60;DISABLED&#x60; — Google Merchant integration is disabled for this merchant - &#x60;COMPLETED&#x60; — synchronous validate-and-upload completed   Possible values: - TRIGGERED - FAILED - DISABLED - COMPLETED | [optional] 
**UcpValidCount** | **int?** | Number of products that passed UCP validation and were queued for upload. | [optional] 
**UcpInvalidCount** | **int?** | Number of products that failed UCP validation and were not sent to Google. | [optional] 
**GoogleEnabled** | **bool?** | Whether Google Merchant integration is enabled for this merchant. | [optional] 
**Products** | [**List&lt;InlineResponse20019GoogleMerchantProducts&gt;**](InlineResponse20019GoogleMerchantProducts.md) | Per-product UCP validation and upload results. Populated when at least one product was saved successfully. Null when all products failed ACG-level validation.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


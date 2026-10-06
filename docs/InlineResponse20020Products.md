# CyberSource.Model.InlineResponse20020Products
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemId** | **string** | Unique product identifier / SKU. | [optional] 
**IsEligibleSearch** | **bool?** | When &#x60;true&#x60;, product appears in AI agent discovery results. | [optional] 
**IsEligibleCheckout** | **bool?** | When &#x60;true&#x60;, product can be added to a checkout session. | [optional] 
**Title** | **string** | Product display name. | [optional] 
**Description** | **string** | Product description. | [optional] 
**Url** | **string** | URL to the product page on the merchant&#39;s storefront. | [optional] 
**ImageUrl** | **string** | URL to the primary product image. | [optional] 
**ProductCategory** | **string** | Product category hierarchy (e.g. &#x60;Electronics &gt; Audio &gt; Headphones&#x60;). | [optional] 
**Brand** | **string** | Product brand or manufacturer. | [optional] 
**Material** | **string** | Primary material (relevant for apparel, furniture, etc.). | [optional] 
**Weight** | **string** | Product weight including unit. | [optional] 
**Price** | **decimal?** | Product price as a decimal number. | [optional] 
**Currency** | **string** | ISO 4217 currency code. | [optional] 
**Availability** | **string** | Current stock status.  Possible values: - in_stock - out_of_stock - preorder - pre_order - backorder - unknown | [optional] 
**Color** | **string** | Primary product color. | [optional] 
**Gender** | **string** | Target gender (e.g. \&quot;male\&quot;, \&quot;female\&quot;, \&quot;unisex\&quot;). | [optional] 
**AgeGroup** | **string** | Target age group (e.g. \&quot;adult\&quot;, \&quot;kids\&quot;, \&quot;infant\&quot;). | [optional] 
**ShippingPrice** | **string** | Shipping cost string as provided by the merchant. | [optional] 
**GroupId** | **string** | Product variant group identifier. | [optional] 
**ListingHasVariations** | **bool?** | Whether this listing has product variations (e.g. different sizes or colors). | [optional] 
**SellerName** | **string** | Merchant or seller display name. | [optional] 
**SellerUrl** | **string** | URL to the seller&#39;s storefront. | [optional] 
**ReturnPolicy** | **string** | Merchant return policy text. | [optional] 
**TargetCountries** | **List&lt;string&gt;** | Country codes where this product is available. | [optional] 
**StoreCountry** | **string** | ISO 3166-1 alpha-2 country code of the merchant&#39;s store. | [optional] 
**CreatedAt** | **DateTime?** | ISO 8601 timestamp when this product was first ingested. | [optional] 
**UpdatedAt** | **DateTime?** | ISO 8601 timestamp of the most recent update. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


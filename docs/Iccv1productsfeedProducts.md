# CyberSource.Model.Iccv1productsfeedProducts
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemId** | **string** | Your unique product identifier (SKU). Must be unique within your merchant catalog. Max 100 characters.  | 
**Title** | **string** | Product display name. Max 150 characters. | 
**Description** | **string** | Detailed product description. Max 5000 characters. | 
**Url** | **string** | Canonical URL to the product page on your storefront. Max 1000 characters. | 
**ImageUrl** | **string** | URL to the primary product image. Must be publicly accessible (HTTPS). Max 1000 characters.  | 
**AdditionalImageUrls** | **string** | Optional. Additional product image URLs (comma-separated or single URL). Must be HTTPS. | [optional] 
**VideoUrl** | **string** | Optional. URL to a product video. Must be HTTPS and publicly accessible. | [optional] 
**Model3dUrl** | **string** | Optional. URL to a 3D model asset for the product (GLTF/GLB format preferred). | [optional] 
**Availability** | **string** | Current stock status: - &#x60;in_stock&#x60; — available for immediate purchase - &#x60;out_of_stock&#x60; — temporarily unavailable - &#x60;preorder&#x60; or &#x60;pre_order&#x60; — not yet released - &#x60;backorder&#x60; — out of stock but accepting orders - &#x60;unknown&#x60; — availability status is not determined   Possible values: - in_stock - out_of_stock - preorder - pre_order - backorder - unknown | 
**AvailabilityDate** | **DateTime?** | Optional. Date when the product becomes available (for preorder/backorder). | [optional] 
**ExpirationDate** | **DateTime?** | Optional. Date after which the product listing expires. | [optional] 
**Price** | **double?** | Product price as a positive decimal number. Pair with &#x60;currency&#x60; for full price representation. Must be greater than zero.  | 
**Currency** | **string** | 3-letter ISO 4217 currency code for the product price (e.g. \&quot;USD\&quot;, \&quot;EUR\&quot;, \&quot;GBP\&quot;).  | 
**SalePrice** | **double?** | Optional. Discounted sale price. Only shown when lower than &#x60;price&#x60;. | [optional] 
**SalePriceStartDate** | **DateTime?** | Optional. Start date of the sale price window. | [optional] 
**SalePriceEndDate** | **DateTime?** | Optional. End date of the sale price window. | [optional] 
**UnitPricingMeasure** | **string** | Optional. Unit measure for unit-priced items (e.g. \&quot;1kg\&quot;, \&quot;750ml\&quot;). Used for per-unit price display. | [optional] 
**BaseMeasure** | **string** | Optional. Base measure used for unit pricing comparison (e.g. \&quot;100g\&quot;, \&quot;1L\&quot;). Enables price-per-unit comparison. | [optional] 
**PricingTrend** | **string** | Optional. Pricing trend indicator (e.g. \&quot;dropping\&quot;, \&quot;rising\&quot;). Max 80 characters. | [optional] 
**GeoPrice** | **string** | Optional. Geography-specific pricing overrides (JSON or structured string). | [optional] 
**GeoAvailability** | **string** | Optional. Geography-specific availability overrides (JSON or structured string). | [optional] 
**Brand** | **string** | Product brand or manufacturer name. Max 70 characters. | 
**Gtin** | **string** | Optional. Global Trade Item Number (UPC, EAN, ISBN). Must be 8–14 digits. Required for Google Merchant Center syndication.  | [optional] 
**Mpn** | **string** | Optional. Manufacturer Part Number. Max 70 characters. | [optional] 
**ProductCategory** | **string** | Optional. Product category hierarchy. Used for UCP validation and Google Merchant Center syndication. Max 255 characters.  | [optional] 
**Condition** | **string** | Optional. Product condition. Typical values: &#x60;new&#x60;, &#x60;used&#x60;, &#x60;refurbished&#x60;. Used for UCP syndication and Google Merchant Center feed.  | [optional] 
**Material** | **string** | Optional. Primary material of the product. Max 100 characters. | [optional] 
**Weight** | **string** | Optional. Product weight (e.g. \&quot;1.2kg\&quot;). Max 100 characters. | [optional] 
**Dimensions** | **string** | Optional. Combined dimension string (e.g. \&quot;10x5x3 cm\&quot;). Max 100 characters. | [optional] 
**Length** | **string** | Optional. Product length. | [optional] 
**Width** | **string** | Optional. Product width. | [optional] 
**Height** | **string** | Optional. Product height. | [optional] 
**DimensionsUnit** | **string** | Optional. Unit for dimension values (e.g. \&quot;cm\&quot;, \&quot;in\&quot;). | [optional] 
**ItemWeightUnit** | **string** | Optional. Unit for weight value (e.g. \&quot;kg\&quot;, \&quot;lb\&quot;). | [optional] 
**AgeGroup** | **string** | Optional. Target age group (e.g. \&quot;adult\&quot;, \&quot;kids\&quot;, \&quot;infant\&quot;, \&quot;toddler\&quot;, \&quot;newborn\&quot;). | [optional] 
**Color** | **string** | Optional. Product color. Max 40 characters. | [optional] 
**Size** | **string** | Optional. Product size (e.g. \&quot;M\&quot;, \&quot;42\&quot;, \&quot;XL\&quot;). Max 20 characters. Used for variant filtering. | [optional] 
**SizeSystem** | **string** | Optional. Size standard used (e.g. \&quot;US\&quot;, \&quot;EU\&quot;, \&quot;UK\&quot;, \&quot;AU\&quot;). | [optional] 
**Gender** | **string** | Optional. Target gender (e.g. \&quot;male\&quot;, \&quot;female\&quot;, \&quot;unisex\&quot;). | [optional] 
**GroupId** | **string** | Product variant group ID — links products that are variations of the same item. Max 70 characters.  | 
**ListingHasVariations** | **bool?** | Whether this listing has product variations. | 
**ItemGroupTitle** | **string** | Optional. Display title for the variant group. Max 150 characters. | [optional] 
**OfferId** | **string** | Optional. Merchant-assigned offer identifier for marketplace deduplication. | [optional] 
**VariantDict** | **Dictionary&lt;string, string&gt;** | Optional. Key-value map of variant attribute names to values (e.g. color, size). | [optional] 
**CustomVariant1Category** | **string** | Optional. Custom variant 1 category label. | [optional] 
**CustomVariant1Option** | **string** | Optional. Custom variant 1 option value. | [optional] 
**CustomVariant2Category** | **string** | Optional. Custom variant 2 category label. | [optional] 
**CustomVariant2Option** | **string** | Optional. Custom variant 2 option value. | [optional] 
**CustomVariant3Category** | **string** | Optional. Custom variant 3 category label. | [optional] 
**CustomVariant3Option** | **string** | Optional. Custom variant 3 option value. | [optional] 
**SellerName** | **string** | Merchant or seller display name. Max 70 characters.  | 
**SellerUrl** | **string** | URL to the seller&#39;s storefront. Max 1000 characters. | 
**MarketplaceSeller** | **string** | Optional. Marketplace seller identifier for multi-seller platforms. Max 70 characters. | [optional] 
**SellerPrivacyPolicy** | **string** | Optional. URL to the seller&#39;s privacy policy page. | [optional] 
**SellerTos** | **string** | Optional. URL to the seller&#39;s terms of service page. | [optional] 
**ShippingPrice** | **string** | Optional. Shipping price for this product (e.g. \&quot;5.99 USD\&quot; or \&quot;Free\&quot;). | [optional] 
**DeliveryEstimate** | **DateTime?** | Optional. Estimated delivery date. | [optional] 
**PickupMethod** | **string** | Optional. Available pickup method (e.g. \&quot;in-store\&quot;, \&quot;curbside\&quot;, \&quot;locker\&quot;). | [optional] 
**PickupSla** | **string** | Optional. Pickup SLA commitment (e.g. \&quot;same-day\&quot;, \&quot;2 hours\&quot;, \&quot;next-day\&quot;). | [optional] 
**IsDigital** | **bool?** | Optional. Whether this product is a digital/downloadable item. | [optional] 
**ReturnPolicy** | **string** | Human-readable return policy description. | 
**AcceptsReturns** | **bool?** | Optional. Whether the product is eligible for returns. | [optional] 
**ReturnDeadlineInDays** | **int?** | Optional. Number of days within which a return is accepted. Must be a positive integer. | [optional] 
**AcceptsExchanges** | **bool?** | Optional. Whether the product is eligible for exchanges. | [optional] 
**IsEligibleSearch** | **bool?** | Controls whether this product appears in AI agent product discovery and search results. | 
**IsEligibleCheckout** | **bool?** | Controls whether this product can be added to cart and purchased via AI agents. | 
**PopularityScore** | **double?** | Optional. Numeric popularity score (higher is more popular). | [optional] 
**ReturnRate** | **string** | Optional. Product return rate indicator (e.g. \&quot;low\&quot;, \&quot;medium\&quot;, \&quot;high\&quot;, or \&quot;5%\&quot;). | [optional] 
**Warning** | **string** | Optional. Safety or compliance warning text for the product (e.g. Prop 65, choking hazard). | [optional] 
**WarningUrl** | **string** | Optional. URL to a detailed warning or compliance information page. | [optional] 
**AgeRestriction** | **int?** | Optional. Minimum age required to purchase this product (e.g. 18). | [optional] 
**ReviewCount** | **int?** | Optional. Total number of customer reviews for this product. | [optional] 
**StarRating** | **string** | Optional. Average star rating for this product (e.g. \&quot;4.5\&quot;). | [optional] 
**StoreReviewCount** | **int?** | Optional. Total number of store-level reviews. | [optional] 
**StoreStarRating** | **string** | Optional. Average star rating for the store (e.g. \&quot;4.8\&quot;). | [optional] 
**RelatedProductId** | **string** | Optional. Item ID of a related product (e.g. accessory, replacement). | [optional] 
**RelationshipType** | **string** | Optional. Type of relationship to &#x60;related_product_id&#x60; (e.g. \&quot;accessory\&quot;, \&quot;replacement\&quot;, \&quot;bundle\&quot;).  | [optional] 
**TargetCountries** | **List&lt;string&gt;** | List of ISO 3166-1 alpha-3 country codes where this product is available. | 
**StoreCountry** | **string** | ISO 3166-1 alpha-2 country code of the merchant&#39;s store. Max 2 characters. | 
**QAndA** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | Optional. List of Q&amp;A entries for this product. | [optional] 
**QandA** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | Optional. Alias for &#x60;q_and_a&#x60;. Included for compatibility with alternate field naming conventions. | [optional] 
**Reviews** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** | Optional. List of customer review objects for this product. | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


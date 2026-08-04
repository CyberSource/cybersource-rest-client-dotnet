# CyberSource.Model.Iplv2paymentlinksOrderInformationLineItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductSku** | **string** | Product identifier code. Also known as the Stock Keeping Unit (SKU) code for the product.  For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not set to **default** or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the values related to shipping and/or handling.  | [optional] 
**ProductName** | **string** | For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  | 
**Quantity** | **int?** | Number of units for this order. Must be a non-negative integer.  The default is &#x60;1&#x60;. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  | [optional] 
**UnitPrice** | **string** | Per-item price of the product. This value for this field cannot be negative.  You must include either this field or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  You can include a decimal point (.), but you cannot include any other special characters. The value is truncated to the correct number of decimal places.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either the 1st line item in the order and this field, or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  #### Tax Calculation Required field for U.S., Canadian, international and value added taxes.  #### Zero Amount Authorizations If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.  #### Maximum Field Lengths For GPN and JCN Gateway: Decimal (10) All other processors: Decimal (15)  | [optional] 
**ProductDescription** | **string** | Brief description of item. | [optional] 
**DiscountAmount** | **string** | Discount amount applied to the item. Maximum of 2 decimal places. You may provide either discountAmount or discountPercent (not both). Example: 0.60  | [optional] 
**DiscountPercent** | **string** | Discount rate applied to the item. Maximum of 3 decimal places. You may provide either discountAmount or discountPercent (not both). If you add discountPercent, a discountAmount will be calculated automatically. Example: 5.00 (&#x3D;5.00%)  | [optional] 
**TaxAmount** | **string** | Tax amount applied to the item. This value cannot be negative. Maximum of 2 decimal places. The tax amount and the offer amount must be in the same currency. The tax amount field is additive. If taxAmount is provided but taxRate is not, the taxRate will be calculated. Example: 2.86  | [optional] 
**TaxRate** | **string** | Tax rate applied to the item. Valid range: 1.001% to 99.999%. Maximum of 3 decimal places. If a taxRate is provided but taxAmount is missing or incorrect, the taxAmount based on the given taxRate will be overwritten. Example: 25.00 (&#x3D;25.00%)  | [optional] 
**TotalAmount** | **string** | Total amount for the line item after discount and tax, calculated per single unit. Formula: (unitPrice - discountAmount) + taxAmount. This field is calculated automatically and does not need to be provided in the request. Example: 14.31  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


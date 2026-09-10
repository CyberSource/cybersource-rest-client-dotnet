# CyberSource.Model.UnifiedriskPaymentCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name on the card | [optional] 
**Number** | **string** | Tokenized or masked card number | [optional] 
**CardNetwork** | **string** | Card network: VISA, MASTERCARD, AMEX, etc | [optional] 
**Type** | **string** | Card type: CREDIT, DEBIT, PREPAID etc. | [optional] 
**SubType** | **string** | Card subtype: GOLD, PLATINUM, etc | [optional] 
**Bin** | **string** | Bank Identification Number (first 6 digits) | [optional] 
**ExpirationMonth** | **string** | Card expiration month | [optional] 
**ExpirationYear** | **string** | Card expiration year | [optional] 
**IssueDate** | **DateTime?** | Date card was issued | [optional] 
**IssuerCountry** | **string** | Country where card was issued | [optional] 
**Brand** | **string** | Card network: VISA, MASTERCARD, AMEX, etc | [optional] 
**SequenceNumber** | **int?** | Sequence number for cards with same PAN | [optional] 
**Last4** | **string** | Last 4 digits of card number | [optional] 
**Status** | **string** | Card status: ACTIVE, BLOCKED, CANCELLED | [optional] 
**TokenTransactionType** | **string** | Transaction type that provided the token data | [optional] 
**TokenDetails** | [**UnifiedriskPaymentCardTokenDetails**](UnifiedriskPaymentCardTokenDetails.md) |  | [optional] 
**AddedAtCheckout** | **bool?** | Whether the card was newly entered during checkout | [optional] 
**ParDetails** | [**UnifiedriskPaymentCardParDetails**](UnifiedriskPaymentCardParDetails.md) |  | [optional] 
**ExpiryDate** | **string** | Card expiry date in MMYYYY or MMYY format, used for matching against the expiry date declared during enrollment and to flag expired or about-to-expire cards | [optional] 
**EntityId** | **string** | Unique entity identifier for the card as assigned by the card scheme or token service provider, used for lifecycle and risk management | [optional] 
**BinEntityId** | **string** | Entity identifier linked to the card&#39;s BIN, used to identify the issuing institution or program associated with the card&#39;s BIN range | [optional] 
**SecurityCode** | **string** | Result or presence indicator for Card Security Code (CVV2/CVC2/CID) verification. Indicates whether the security code was present, verified, or matched by the issuer | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


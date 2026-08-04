# CyberSource.Model.PostInstrumentIdentifierEnrollmentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**TmsEmbeddedInstrumentIdentifierLinks**](TmsEmbeddedInstrumentIdentifierLinks.md) |  | [optional] 
**Id** | **string** | The Id of the Instrument Identifier Token.  | [optional] 
**Object** | **string** | The type.  Possible Values: - instrumentIdentifier  | [optional] 
**State** | **string** | Issuers state for the card number. Possible Values: - ACTIVE - CLOSED : The account has been closed.  | [optional] 
**Type** | **string** | The type of Instrument Identifier. Possible Values: - enrollable card - enrollable token  | [optional] 
**Source** | **string** | Source of the card details. Possible Values: - CONTACTLESS_TAP  | [optional] 
**TokenProvisioningInformation** | [**Ptsv2paymentsTokenInformationTokenProvisioningInformation**](Ptsv2paymentsTokenInformationTokenProvisioningInformation.md) |  | [optional] 
**Card** | [**TmsEmbeddedInstrumentIdentifierCard**](TmsEmbeddedInstrumentIdentifierCard.md) |  | [optional] 
**PointOfSaleInformation** | [**TmsPointOfSaleInformation**](TmsPointOfSaleInformation.md) |  | [optional] 
**BankAccount** | [**TmsEmbeddedInstrumentIdentifierBankAccount**](TmsEmbeddedInstrumentIdentifierBankAccount.md) |  | [optional] 
**TokenizedCard** | [**Tmsv2TokenizedCard**](Tmsv2TokenizedCard.md) |  | [optional] 
**Issuer** | [**TmsEmbeddedInstrumentIdentifierIssuer**](TmsEmbeddedInstrumentIdentifierIssuer.md) |  | [optional] 
**ProcessingInformation** | [**TmsEmbeddedInstrumentIdentifierProcessingInformation**](TmsEmbeddedInstrumentIdentifierProcessingInformation.md) |  | [optional] 
**BillTo** | [**TmsEmbeddedInstrumentIdentifierBillTo**](TmsEmbeddedInstrumentIdentifierBillTo.md) |  | [optional] 
**Metadata** | [**TmsEmbeddedInstrumentIdentifierMetadata**](TmsEmbeddedInstrumentIdentifierMetadata.md) |  | [optional] 
**Embedded** | [**TmsEmbeddedInstrumentIdentifierEmbedded**](TmsEmbeddedInstrumentIdentifierEmbedded.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


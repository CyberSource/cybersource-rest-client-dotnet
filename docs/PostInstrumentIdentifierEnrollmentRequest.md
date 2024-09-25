# CyberSource.Model.PostInstrumentIdentifierEnrollmentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**TmsEmbeddedInstrumentIdentifierLinks**](TmsEmbeddedInstrumentIdentifierLinks.md) |  | [optional] 
**Id** | **string** | The Id of the Instrument Identifier Token.  | [optional] 
**Object** | **string** | The type.  Possible Values: - instrumentIdentifier  | [optional] 
**State** | **string** | Issuers state for the card number. Possible Values: - ACTIVE - CLOSED : The account has been closed.  | [optional] 
**Type** | **string** | The type of Instrument Identifier. Possible Values: - enrollable card - enrollable token  | [optional] 
**TokenProvisioningInformation** | [**Ptsv2paymentsTokenInformationTokenProvisioningInformation**](Ptsv2paymentsTokenInformationTokenProvisioningInformation.md) |  | [optional] 
**Card** | [**TmsEmbeddedInstrumentIdentifierCard**](TmsEmbeddedInstrumentIdentifierCard.md) |  | [optional] 
**BankAccount** | [**TmsEmbeddedInstrumentIdentifierBankAccount**](TmsEmbeddedInstrumentIdentifierBankAccount.md) |  | [optional] 
**TokenizedCard** | [**Tmsv2TokenizedCard**](Tmsv2TokenizedCard.md) |  | [optional] 
**Issuer** | [**TmsEmbeddedInstrumentIdentifierIssuer**](TmsEmbeddedInstrumentIdentifierIssuer.md) |  | [optional] 
**ProcessingInformation** | [**TmsEmbeddedInstrumentIdentifierProcessingInformation**](TmsEmbeddedInstrumentIdentifierProcessingInformation.md) |  | [optional] 
**BillTo** | [**TmsEmbeddedInstrumentIdentifierBillTo**](TmsEmbeddedInstrumentIdentifierBillTo.md) |  | [optional] 
**Metadata** | [**TmsEmbeddedInstrumentIdentifierMetadata**](TmsEmbeddedInstrumentIdentifierMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.Tmsv2tokenizeTokenInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Jti** | **string** | TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV).  | [optional] 
**TransientTokenJwt** | **string** | Flex API Transient Token encoded as JWT (JSON Web Token), e.g. Flex microform or Unified Payment checkout result.  | [optional] 
**Customer** | [**Tmsv2tokenizeTokenInformationCustomer**](Tmsv2tokenizeTokenInformationCustomer.md) |  | [optional] 
**ShippingAddress** | [**Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultShippingAddress**](Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultShippingAddress.md) |  | [optional] 
**PaymentInstrument** | [**Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrument**](Tmsv2tokenizeTokenInformationCustomerEmbeddedDefaultPaymentInstrument.md) |  | [optional] 
**InstrumentIdentifier** | [**TmsEmbeddedInstrumentIdentifier**](TmsEmbeddedInstrumentIdentifier.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


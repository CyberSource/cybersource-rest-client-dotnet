# CyberSource.Model.TssV2TransactionsGet200ResponseTokenInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Customer** | [**PtsV2PaymentsPost201ResponseTokenInformationCustomer**](PtsV2PaymentsPost201ResponseTokenInformationCustomer.md) |  | [optional] 
**PaymentInstrument** | [**PtsV2PaymentsPost201ResponseTokenInformationPaymentInstrument**](PtsV2PaymentsPost201ResponseTokenInformationPaymentInstrument.md) |  | [optional] 
**ShippingAddress** | [**PtsV2PaymentsPost201ResponseTokenInformationShippingAddress**](PtsV2PaymentsPost201ResponseTokenInformationShippingAddress.md) |  | [optional] 
**InstrumentIdentifier** | [**TssV2TransactionsGet200ResponsePaymentInformationInstrumentIdentifier**](TssV2TransactionsGet200ResponsePaymentInformationInstrumentIdentifier.md) |  | [optional] 
**Jti** | **string** | TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV).  | [optional] 
**TransientTokenJwt** | **string** | Flex API Transient Token encoded as JWT (JSON Web Token), e.g. Flex microform or Unified Payment checkout result.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


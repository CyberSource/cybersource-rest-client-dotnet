# CyberSource.Model.Ptsv2paymentsidcapturesMerchantInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantDescriptor** | [**Ptsv2paymentsMerchantInformationMerchantDescriptor**](Ptsv2paymentsMerchantInformationMerchantDescriptor.md) |  | [optional] 
**CardAcceptorReferenceNumber** | **string** | Reference number that facilitates card acceptor/corporation communication and record keeping.  | [optional] 
**CategoryCode** | **int?** | The value for this field is a four-digit number that the payment card industry uses to classify merchants into market segments. A payment card company assigned one or more of these values to your business when you started accepting the payment card company&#39;s cards. When you do not include this field in your request, CyberSource uses the value in your CyberSource account.  #### CyberSource through VisaNet The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP01 TCR4 - Position: 150-153 - Field: Merchant Category Code  | [optional] 
**VatRegistrationNumber** | **string** | Your government-assigned tax identification number.  #### Tax Calculation Required field for value added tax only. Not applicable to U.S. and Canadian taxes.  #### CyberSource through VisaNet For CtV processors, the maximum length is 20.  | [optional] 
**ServiceFeeDescriptor** | [**Ptsv2paymentsMerchantInformationServiceFeeDescriptor**](Ptsv2paymentsMerchantInformationServiceFeeDescriptor.md) |  | [optional] 
**TaxId** | **string** | Your Cadastro Nacional da Pessoa Jurídica (CNPJ) number.  This field is supported only for BNDES transactions on CyberSource through VisaNet.  The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP07 TCR6 - Position: 40-59 - Field: BNDES Reference Field 1  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


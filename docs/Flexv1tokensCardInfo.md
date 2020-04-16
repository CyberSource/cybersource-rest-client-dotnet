# CyberSource.Model.Flexv1tokensCardInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardNumber** | **string** | Encrypted or plain text card number. If the encryption type of “None” was used in the Generate Key request, this value can be set to the plaintext card number/Personal Account Number (PAN). If the encryption type of RsaOaep256 was used in the Generate Key request, this value needs to be the RSA OAEP 256 encrypted card number. The card number should be encrypted on the cardholders’ device. The [WebCrypto API] (https://github.com/CyberSource/cybersource-flex-samples/blob/master/java/spring-boot/src/main/resources/public/flex.js) can be used with the JWK obtained in the Generate Key request. | 
**CardExpirationMonth** | **string** | Two digit expiration month | [optional] 
**CardExpirationYear** | **string** | Four digit expiration year | [optional] 
**CardType** | **string** | Card Type. This field is required. Refer to the CyberSource Credit Card Services documentation for supported card types. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


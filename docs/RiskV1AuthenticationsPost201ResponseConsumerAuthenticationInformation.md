# CyberSource.Model.RiskV1AuthenticationsPost201ResponseConsumerAuthenticationInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcsUrl** | **string** | URL for the card-issuing bank’s authentication form that you receive when the card is enrolled. The value can be very large.  | [optional] 
**AuthenticationPath** | **string** | Indicates what displays to the customer during the authentication process. This field can contain one of these values: - &#x60;ADS&#x60;: (Card not enrolled) customer prompted to activate the card during the checkout process. - &#x60;ATTEMPTS&#x60;: (Attempts processing) Processing briefly displays before the checkout process is completed. - &#x60;ENROLLED&#x60;: (Card enrolled) the card issuer’s authentication window displays. - &#x60;UNKNOWN&#x60;: Card enrollment status cannot be determined. - &#x60;NOREDIRECT&#x60;: (Card not enrolled, authentication unavailable, or error occurred) nothing displays to the customer.  The following values can be returned if you are using rules-based payer authentication. - &#x60;RIBA&#x60;: The card-issuing bank supports risk-based authentication, but whether the cardholder is likely to be challenged cannot be determined. - &#x60;RIBA_PASS&#x60;: The card-issuing bank supports risk-based authentication and it is likely that the cardholder will not be challenged to provide credentials, also known as _silent authentication_.  For details about possible values, see &#x60;pa_enroll_authentication_path&#x60; field description and \&quot;Rules-Based Payer Authentication\&quot; in [CyberSource Payer Authentication Using the SCMP API.] (https://apps.cybersource.com/library/documentation/dev_guides/Payer_Authentication_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  | [optional] 
**AuthenticationTransactionId** | **string** | Payer authentication transaction identifier passed to link the check enrollment and validate authentication messages.  | [optional] 
**Cavv** | **string** | Unique identifier generated by the card-issuing bank for Visa, American Express, JCB, Diners Club, and Discover transactions after the customer is authenticated. The value is in base64. When you request the card authorization service, CyberSource automatically converts the value, not the field name, to the format required by your payment processor.  | [optional] 
**CavvAlgorithm** | **string** | Field that is returned only when the CAVV is generated, which occurs when paresStatus contains the values Y (successful authentication) or A (attempted authentication). If you use the ATOS processor, send the value of this field in the &#x60;cavv_algorithm&#x60; request field of the authorization service. This field contains one of these values: - &#x60;2&#x60;: Visa, American Express, JCB, Diners Club, and Discover - &#x60;3&#x60;: Mastercard  | [optional] 
**ChallengeRequired** | **bool?** | Indicates whether a challenge is required to complete authentication (region mandates).  | [optional] 
**EcommerceIndicator** | **string** | Commerce indicator for cards not enrolled. This field contains one of these values: - &#x60;internet&#x60;: Card not enrolled, or card type not supported by payer authentication. No liability shift. - &#x60;js_attempted&#x60;: Card not enrolled, but attempt to authenticate is recorded. Liability shift. - &#x60;js_failure&#x60;: J/Secure directory service is not available. No liability shift. - &#x60;spa&#x60;: Mastercard card not enrolled in the SecureCode program. No liability shift. - &#x60;vbv_attempted&#x60;: Card not enrolled, but attempt to authenticate is recorded. Liability shift. - &#x60;vbv_failure&#x60;: For payment processor Barclays, Streamline, AIBMS, or FDC Germany, you receive this result if Visa’s directory service is not available. No liability shift.  | [optional] 
**Eci** | **string** | Note This field applies only to non-U.S-issued cards.  For enroll, Numeric electronic commerce indicator (ECI) returned only for Visa, American Express, JCB, Diners Club, and Discover transactions when the card is not enrolled. For more information, see \&quot;Interpreting the Reply,\&quot; page 22.  If you are not using the CyberSource payment services, you must send this value to your payment processor in the subsequent request for card authorization. This field contains one of these values: - &#x60;06&#x60;: The card can be enrolled. Liability shift. - &#x60;07&#x60;: The card cannot be enrolled. No liability shift.  For validate, Numeric electronic commerce indicator (ECI) returned only for Visa, American Express, JCB, Diners Club, and Discover transactions. The field is absent when authentication fails. You must send this value to your payment processor in the subsequent request for card authorization. This field contains one of these values: - &#x60;05&#x60;: Successful authentication - &#x60;06&#x60;: Authentication attempted - &#x60;07&#x60;: Failed authentication (No response from the merchant because of a problem.)  | [optional] 
**EciRaw** | **string** | ECI value that can be returned for Visa, Mastercard, American Express, JCB, Diners Club, and Discover. The field is absent when authentication fails. If your payment processor is Streamline, you must pass the value of this field instead of the value of &#x60;eci&#x60; or &#x60;ucafCollectionIndicator&#x60;.  This field can contain one of these values: - &#x60;01&#x60;: Authentication attempted (Mastercard) - &#x60;02&#x60;: Successful authentication (Mastercard) - &#x60;05&#x60;: Successful authentication (Visa, American Express, JCB, Diners Club, and Discover) - &#x60;06&#x60;: Authentication attempted (Visa, American Express, JCB, Diners Club, and Discover)  | [optional] 
**Pareq** | **string** | Payer authentication request (PAReq) message that you need to forward to the ACS. The value can be very large. The value is in base64.  | [optional] 
**ParesStatus** | **string** | Raw result of the authentication check. If you are configured for Asia, Middle East, and Africa Gateway Processing, you need to send the value of this field in your authorization request. This field can contain one of these values: - &#x60;A&#x60;: Proof of authentication attempt was generated. - &#x60;B&#x60;: Bypassed authentication. - &#x60;N&#x60;: Customer failed or canceled authentication. Transaction denied. - &#x60;R&#x60;: Authentication rejected (used for 3D Secure 2.0 transactions only) - &#x60;U&#x60;: Authentication not completed regardless of the reason. - &#x60;Y&#x60;: Customer was successfully authenticated.  | [optional] 
**ProofXml** | **string** | Date and time of the enrollment check combined with the VEReq and VERes elements. If you ever need to show proof of enrollment checking, you may need to parse the string for the information required by the payment card company. The value can be very large. For details about possible values, see the &#x60;pa_enroll_proofxml&#x60; field description in [CyberSource Payer Authentication Using the SCMP API.] (https://apps.cybersource.com/library/documentation/dev_guides/Payer_Authentication_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) - For cards issued in the U.S. or Canada, Visa may require this data for specific merchant category codes. - For cards not issued in the U.S. or Canada, your bank may require this data as proof of enrollment checking for any payer authentication transaction that you re-present because of a chargeback.  | [optional] 
**ProxyPan** | **string** | Encrypted version of the card number used in the payer authentication request message.  | [optional] 
**SpecificationVersion** | **string** | This field contains the 3D Secure version that was used to process the transaction. For example, 1.0.2 or 2.0.0.  | [optional] 
**UcafAuthenticationData** | **string** | AAV is a unique identifier generated by the cardissuing bank for Mastercard SecureCode transactions after the customer is authenticated. The value is in base64. Include the data in the card authorization request.  | [optional] 
**UcafCollectionIndicator** | **decimal?** | For enroll, Returned only for Mastercard transactions. Indicates that authentication is not required because the customer is not enrolled. Add the value of this field to the authorization field ucaf_collection_indicator. This field can contain these values: 0, 1.  For validate, Numeric electronic commerce indicator (ECI) returned only for Mastercard SecureCode transactions. The field is absent when authentication fails. You must send this value to your payment processor in the request for card authorization. This field contain one of these values: - &#x60;0&#x60;: Authentication data not collected, and customer authentication was not completed. - &#x60;1&#x60;: Authentication data not collected because customer authentication was not completed. - &#x60;2&#x60;: Authentication data collected because customer completed authentication.  | [optional] 
**VeresEnrolled** | **string** | Result of the enrollment check. This field can contain one of these values: - &#x60;Y&#x60;: Card enrolled or can be enrolled; you must authenticate. Liability shift. - &#x60;N&#x60;: Card not enrolled; proceed with authorization. Liability shift. - &#x60;U&#x60;: Unable to authenticate regardless of the reason. No liability shift.  **Note** This field only applies to the Asia, Middle East, and Africa Gateway. If you are configured for this processor, you must send the value of this field in your authorization request.  The following value can be returned if you are using rules-based Payer Authentication: - &#x60;B&#x60;: Indicates that authentication was bypassed.  For details, see &#x60;pa_enroll_veres_enrolled&#x60; field description in [CyberSource Payer Authentication Using the SCMP API.] (https://apps.cybersource.com/library/documentation/dev_guides/Payer_Authentication_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm)  | [optional] 
**Xid** | **string** | Transaction identifier generated by CyberSource for successful enrollment or validation checks. Use this value, which is in base64, to match an outgoing PAReq with an incoming PARes. CyberSource forwards the XID with the card authorization service to these payment processors in these cases: - Barclays - Streamline (when the **ecommerceIndicator**&#x60;&#x3D;spa&#x60;)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

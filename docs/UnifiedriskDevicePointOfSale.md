# CyberSource.Model.UnifiedriskDevicePointOfSale
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttendedIndicator** | **bool?** | Card acceptor representative in attendance at the point of service during the transaction. When an acceptor&#39;s terminal is semi-attended (for example, multiple terminals supervised by a single clerk), | [optional] 
**CardDataEntryMode** | **string** | Entry mode of the card data for the transaction; possible values are: CDFL CardOnFile Card information are stored on a file. ICPY ICCProximity ICC contactless proximity MGST MagneticStripe ICCY ICCCon | [optional] 
**CardPresent** | **bool?** | Indicates whether the transaction has been initiated by a card physically present (true) or not (false). | [optional] 
**CardholderActivated** | **bool?** | Indicates whether the automated device was operated solely by the cardholder or not (for example, vending machine, automated fuel dispenser, ATM, kiosk, etc.). | [optional] 
**CardholderPresent** | **string** | Indicates whether the transaction has been initiated in presence of the cardholder or not. It can assume multiple values (e.g. \&quot;cardholder present\&quot;, \&quot;cardholder not present telephone\&quot;, etc). | [optional] 
**ECommerceData** | **string** | This is a free text field that can be used if additional e-commerce data is available. Please note that this field should not contain any cardholder data or sensitive authentication data (SAD), as def | [optional] 
**ECommerceIndicator** | **bool?** | Indicates whether the point of service is an e-commerce one (true) or not (false). When true, the cardPresent field is expected to be set to false. | [optional] 
**IccFallbackIndicator** | **bool?** | Indicates a chip data fallback, where the chip cannot be read due to a technical issue with the chip which results in the technology \&quot;falling back\&quot; from ICC to a magnetic stripe transaction. | [optional] 
**IpAddress** | **string** | IP address of point of service terminal | [optional] 
**MagneticStripeFallbackIndicator** | **bool?** | Indicates a magstripe fallback where the magnetic strip cannot be read which results in the technology \&quot;falling back\&quot; to manually keying the card details into the pos. | [optional] 
**MotoIndicator** | **bool?** | Indicates whether the context of the point of service is a MOTO one (true) or not (false). When true, the cardPresent field is expected to be set to false. | [optional] 
**PartialApprovalSupported** | **bool?** | Indicates whether the point of service supports partial approval or not. true: partial approval is supported false: partial approval is not supported | [optional] 
**SecurityCharacteristics** | **string** | This fields identifies the security characteristics of the communication link in the card acceptance process; possible values are: CETE CardholderEndToEndEncryption CPTE CardholderPointToPointEncrypti | [optional] 
**StorageLocation** | **string** | This field details the location where the payments credentials (tipically a card number or payment token) are stored. This is only applicable to payments where the credentials are stored by or on beha | [optional] 
**UnattendedLevelCategory** | **string** | Card scheme defined transaction category level on an unattended terminal. It identifies the type of terminal. The values are typically mandated by the card scheme being used. Examples for Mastercard a | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


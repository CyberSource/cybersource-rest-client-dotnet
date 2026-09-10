# CyberSource.Model.UnifiedriskDevice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpAddress** | **string** | IPv4 or IPv6 address observed for the customer&#39;s device during the session. | [optional] 
**HostName** | **string** | DNS resolved hostname from &#x60;ipAddress&#x60;. | [optional] 
**AnonymizerInUseFlag** | **bool?** | A flag indicating if the anonymizer was in use during the session. true if the anonymiser was in use, false otherwise. | [optional] 
**AreaCode** | **string** | The device area code captured during the customer session | [optional] 
**BrowserType** | **string** | The device browser type captured during the customer session | [optional] 
**BrowserVersion** | **string** | The device browser version captured during the customer session | [optional] 
**City** | **string** | The device city name captured during the customer session | [optional] 
**ClientTimezone** | **string** | The clientTimeZone captured during the customer session | [optional] 
**ContinentCode** | **string** | The device continent code captured during the customer session | [optional] 
**CookieId** | **string** | The cookie ID used during the customer session | [optional] 
**CountryCode** | **string** | The device country code captured during the customer session | [optional] 
**CountryName** | **string** | The device country name captured during the customer session | [optional] 
**DeviceFingerprint** | **string** | The device fingerprint captured during the customer session by a third party. A device fingerprint is information collected about the software and hardware for the purpose of identification | [optional] 
**DeviceIMEI** | **string** | The IMEI of the device used during the customer session. An IMEI identifies most types of mobile phone (GSM, WCDMA, iDEN), as well as some satellite phones. | [optional] 
**DeviceName** | **string** | The device name given at point of registration | [optional] 
**FlashPlugin** | **string** | The Flash Plugin captured during the customer session, if available. | [optional] 
**HttpHeader** | **string** | The HTTPHeader captured during the customer session | [optional] 
**MetroCode** | **string** | The device metropolitan code captured during the customer session | [optional] 
**MfaSession** | **bool?** | Whether multifactor authentication was used during the session | [optional] 
**MimeTypesPresent** | **string** | The Mime-Type(s) captured during the customer session | [optional] 
**MobileNumberDeviceLink** | **string** | A concatenated string of the mobile number and device ID to establish the link | [optional] 
**NetworkCarrier** | **string** | The Network/carrier captured during the customer session | [optional] 
**OperatingSystem** | **string** | The device Operating System captured during the customer session | [optional] 
**PostalCode** | **string** | The postal code the device is registered to as captured during the customer session. | [optional] 
**ProxyDescription** | **string** | The Proxy type description captured during the customer session | [optional] 
**ProxyType** | **string** | The Proxy type captured during the customer session | [optional] 
**Region** | **string** | The device region code captured during the customer session | [optional] 
**ScreenResolution** | **string** | The screen resolution captured during the customer session | [optional] 
**SessionLatitude** | **decimal?** | Thelatitude captured during the customer session | [optional] 
**SessionLongitude** | **decimal?** | The longitude captured during the customer session | [optional] 
**Timestamp** | **DateTime?** | The timestamp captured during the customer session | [optional] 
**Type** | **string** | The Device Type captured during the customer session | [optional] 
**UserAgentString** | **string** | The UserAgentString captured during the customer session | [optional] 
**DeviceId** | **string** | A unique identifier of the device performing the event, such as the laptop/mobile phone used to log into the online banking. | A unique identifier of the device performing the event, such as the mobil | [optional] 
**DeviceFingerprintProvider** | **string** | Vendor or provider providing device identification/fingerprinting services | [optional] 
**PointOfSale** | [**UnifiedriskDevicePointOfSale**](UnifiedriskDevicePointOfSale.md) |  | [optional] 
**IpAddressV4** | **string** | IPv4 address of the customer&#39;s device captured during the session (e.g., 192.0.2.1). Used for geolocation, anonymizer detection, and IP-based risk signals | [optional] 
**IpAddressV6** | **string** | IPv6 address of the customer&#39;s device captured during the session (e.g., 2001:db8::1). Used for geolocation and risk analysis in IPv6-enabled environments | [optional] 
**DeviceFingerprintVendor** | **string** | Name of the third-party vendor providing device fingerprinting services for this transaction (e.g., ThreatMetrix, InAuth, Kount) | [optional] 
**DeviceEntityId** | **string** | Unique entity identifier assigned to the device by the fingerprinting system, used to track device history and link sessions across transactions | [optional] 
**ReferenceId** | **string** | Session reference ID used to correlate the device fingerprinting session with the transaction. Must match the session ID submitted to the device fingerprinting script | [optional] 
**EncryptedDeviceData** | **string** | Encrypted payload containing device data collected by a 3DS SDK or device intelligence provider. The encryption protects sensitive device attributes during transmission | [optional] 
**DeviceBindingStatus** | **string** | Indicates whether the device is bound to a specific account or cardholder identity. Values such as BOUND, UNBOUND, or UNKNOWN reflect the trust level of the device association | [optional] 
**DeviceBindingStatusSource** | **string** | The source system or process that determined the device binding status (e.g., 3DS_SDK, ISSUER, DEVICE_INTELLIGENCE_PROVIDER) | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


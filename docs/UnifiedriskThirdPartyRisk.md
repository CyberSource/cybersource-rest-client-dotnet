# CyberSource.Model.UnifiedriskThirdPartyRisk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthenticationFailedReason** | **string** | If the user fails authentication, this displays the reason for failure, such as \&quot;user cancel\&quot; or \&quot;challenge response failed\&quot;.  Do not populate if there is no failed authentication. | [optional] 
**AuthenticationMethod** | **string** | The authentication method used by the ThirdParty | [optional] 
**AuthenticationServiceType** | **string** | This field is only populated if the registration event is for an authentication service. It advises the authentication service being registered. | [optional] 
**AuthenticationStatus** | **string** | Indicates the status of the authentication which may be: auth_success, auth_fail, auth_init, or auth_init_in_progress. | [optional] 
**BrowserAnomaly** | **string** | This attribute will be returned with a value of &#39;yes&#39; if an anomaly is detected with the various browser attributes collected during profiling, including Flash, JavaScript and User Agent. | [optional] 
**BrowserCrawlerIdentification** | **string** | The agent, parsed from the http user agent / \&quot;browser\&quot; string, which indicates the client may not be a real browser, e.g. crawler. | [optional] 
**BrowserHTTPInfo** | **string** | The user agent / browser string presented in the HTTP header. | [optional] 
**BrowserHTTPInfoAnomaly** | **string** | Indicates as \&quot;Yes\&quot;if there is an anomaly in the browser string content. | [optional] 
**BrowserInfo** | **string** | The browser determined using a combination of Flash, JavaScript and User Agent. If browser detection was unsuccessful this will be set to \&quot;Unknown\&quot;. | [optional] 
**BrowserLanguage** | **string** | The code for the language that the browser is configured to accept which comes from the HTTP header. | [optional] 
**BrowserLanguageAnomaly** | **string** | Indicates as \&quot;Yes\&quot; if there is an anomaly between the browser language and flash plugin language. This happens when both appear, and none of the browser&#39;s preferred languages is the same as the flash | [optional] 
**BrowserStringMismatch** | **string** | Indicates if there is a mismatch between the javascript user agent string and the HTTP user agent string. | [optional] 
**BrowserVersionId** | **string** | The version of the browser installed. | [optional] 
**DeviceFingerprint** | **string** | Device fingerprint as calculated the ThirdParty. A device fingerprint is information collected about the software and hardware for the purpose of identification. | [optional] 
**DeviceFingerprintFirstSeen** | **DateTime?** | The date that this device was first encountered by ThirdParty | [optional] 
**DeviceFingerprintResult** | **string** | \&quot;not found\&quot; indicates this is the first time ThirdParty has seen this device involved in a transaction; \&quot;success\&quot; indicates that ThirdParty has intelligence on this entity. | [optional] 
**DeviceFingerprintScore** | **decimal?** | The risk score for this device as calculated by the ThirdParty | [optional] 
**DeviceFirstSeenDate** | **DateTime?** | The date that this device was first encountered by ThirdParty, in yyyy-mm-dd format. | [optional] 
**DeviceIdConfidence** | **decimal?** | A number between 0 and 1, representing the probability of the device being correctly identified. | [optional] 
**DeviceMatchResult** | **string** | Indicates whether this device is a new device (\&quot;new\&quot;), whether it was encountered before (\&quot;success\&quot;), and if not enough attributes were gathered to create a device identity (\&quot;not enough attributes\&quot;). | [optional] 
**DeviceRootJailBreak** | **decimal?** | Detects whether a mobile device has Root privileges on Android, or a Jailbroken iOS device. This stores a numerical value that indicates the number of jailbreak/root elements on a device. 0 indicates | [optional] 
**DeviceRootJailBreakReason** | **List&lt;string&gt;** | An array of strings containing additional information that describes the element(s) on the device that triggered the Jailbreak or Root detection. | [optional] 
**DeviceScore** | **decimal?** | The risk score for this device as calculated by the ThirdParty. | [optional] 
**DeviceScoreReason** | **string** | Third party Risk score Reason Code (InAuth, biocatch…etc) | [optional] 
**DigitalId** | **string** | A digital id assigned by the Thirdparty | [optional] 
**DigitalIdConfidence** | **decimal?** | The confidence score returned signifies the level of confidence that the event appears to be matching the behavior from the returned Digital ID. | [optional] 
**DigitalIdTrustScoreRating** | **string** | Trust Score rating associated with the ThirdParty ID which may be one of the following: very_low, low, neutral, high, very_high | [optional] 
**DigitalIdTrustScoreReasonCode** | **string** | Reason codes describing the Trust Score rating (mutiple values). There may be up to 64 characters per entry and there may be an unlimited number of entries. | [optional] 
**LoginVerificationResult** | **string** | \&quot;not found\&quot; indicates this is the first time ThirdParty has seen this login (username) involved in a transaction; \&quot;success\&quot; indicates that ThirdParty has intelligence on this entity. | [optional] 
**LoginVerificationRulesHit** | **List&lt;string&gt;** | An array containing all of the Third Party rules that triggered for login (username) verification. | [optional] 
**LoginVerificationScore** | **decimal?** | The risk score for the login (username) as calculated by the ThirdParty | [optional] 
**NameVerificationResult** | **string** | \&quot;not found\&quot; indicates this is the first time ThirdParty has seen this name involved in a transaction; \&quot;success\&quot; indicates that ThirdParty has intelligence on this entity. | [optional] 
**NameVerificationRulesHit** | **List&lt;string&gt;** | An array containing all of the Third Party rules that triggered for name verification. | [optional] 
**NameVerificationScore** | **decimal?** | The risk score for the name as calculated by the ThirdParty | [optional] 
**OverallAssessment** | **string** | PASS, FAIL | [optional] 
**OverallAssessmentReason** | **string** | This is displayed indicating the reason for failure, such as \&quot;user cancel\&quot; or \&quot;challenge response failed\&quot;. | [optional] 
**PhoneVerificationResult** | **string** | \&quot;not found\&quot; indicates this is the first time ThirdParty has seen this phone involved in a transaction; \&quot;success\&quot; indicates that ThirdParty has intelligence on this entity. | [optional] 
**PhoneVerificationScore** | **decimal?** | The risk score for the phone as calculated by the ThirdParty | [optional] 
**ProfiledDeviceType** | **string** | This indicates the type of device that was profiled, including mobile app, desktop app, or web browser on a desktop or mobile platform. | [optional] 
**ProviderName** | **string** | Name of the third party who&#39;s java script is used to capture and assess session, behaviour biometric use, etc | [optional] 
**RefNumber** | **string** | Third party provider reference number assigned when the Third party assesses session risk and returns results to Customer | [optional] 
**VirtualDeviceIdentification** | **decimal?** | Detects whether a mobile device is running in an Emulator on Android, or a Simulator on iOS. This stores a numerical value that indicates the number of emulator/simulator elements on a device. | [optional] 
**WifiAccuracy** | **float?** | The accuracy of the estimated location, in meters. This represents the radius of a circle around the given location. | [optional] 
**WifiLatitude** | **float?** | The Latitude of the WiFi connection based on BSSID. | [optional] 
**WifiLongitude** | **float?** | The Longitude of the WiFi connection based on BSSID. | [optional] 
**RawData** | [**UnifiedriskThirdPartyRiskRawData**](UnifiedriskThirdPartyRiskRawData.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


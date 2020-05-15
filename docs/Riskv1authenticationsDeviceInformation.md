# CyberSource.Model.Riskv1authenticationsDeviceInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpAddress** | **string** | IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field.  | [optional] 
**RawData** | [**List&lt;Ptsv2paymentsDeviceInformationRawData&gt;**](Ptsv2paymentsDeviceInformationRawData.md) |  | [optional] 
**HttpAcceptBrowserValue** | **string** | Value of the Accept header sent by the customer’s web browser. **Note** If the customer’s browser provides a value, you must include it in your request.  | [optional] 
**HttpAcceptContent** | **string** | The exact content of the HTTP accept header.  | [optional] 
**HttpBrowserLanguage** | **string** | Value represents the browser language as defined in IETF BCP47. Example:en-US, refer  https://en.wikipedia.org/wiki/IETF_language_tag for more details.  | [optional] 
**HttpBrowserJavaEnabled** | **bool?** | A Boolean value that represents the ability of the cardholder browser to execute Java. Value is returned from the navigator.javaEnabled property. Possible Values:True/False  | [optional] 
**HttpBrowserJavaScriptEnabled** | **bool?** | A Boolean value that represents the ability of the cardholder browser to execute JavaScript. Possible Values:True/False. **Note**: Merchants should be able to know the values from fingerprint details of cardholder&#39;s browser.  | [optional] 
**HttpBrowserColorDepth** | **string** | Value represents the bit depth of the color palette for displaying images, in bits per pixel. Example : 24, refer https://en.wikipedia.org/wiki/Color_depth for more details  | [optional] 
**HttpBrowserScreenHeight** | **string** | Total height of the Cardholder&#39;s scree in pixels, example: 864.  | [optional] 
**HttpBrowserScreenWidth** | **string** | Total width of the cardholder&#39;s screen in pixels. Example: 1536.  | [optional] 
**HttpBrowserTimeDifference** | **string** | Time difference between UTC time and the cardholder browser local time, in minutes, Example:300  | [optional] 
**UserAgentBrowserValue** | **string** | Value of the User-Agent header sent by the customer’s web browser. Note If the customer’s browser provides a value, you must include it in your request.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


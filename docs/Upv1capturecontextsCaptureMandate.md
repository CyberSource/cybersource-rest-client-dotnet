# CyberSource.Model.Upv1capturecontextsCaptureMandate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingType** | **string** | Configure Unified Checkout to capture billing address information.  Possible values: - FULL: Capture complete billing address information. - PARTIAL: Capture first name, last name, country and postal/zip code only. - NONE: Capture only first name and last name.  | [optional] 
**RequestEmail** | **bool?** | Configure Unified Checkout to capture customer email address.  Possible values:  - True  - False  | [optional] 
**RequestPhone** | **bool?** | Configure Unified Checkout to capture customer phone number.  Possible values: - True - False  | [optional] 
**RequestShipping** | **bool?** | Configure Unified Checkout to capture customer shipping details.  Possible values: - True - False  | [optional] 
**ShipToCountries** | **List&lt;string&gt;** | List of countries available to ship to.   Use the two-character ISO Standard Country Codes.  | [optional] 
**ShowAcceptedNetworkIcons** | **bool?** | Configure Unified Checkout to display the list of accepted card networks beneath the payment button  Possible values: - True - False  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


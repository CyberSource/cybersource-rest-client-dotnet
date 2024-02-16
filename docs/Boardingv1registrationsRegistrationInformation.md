# CyberSource.Model.Boardingv1registrationsRegistrationInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BoardingRegistrationId** | **string** |  | [optional] 
**SubmitTimeUtc** | **DateTime?** | Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**Status** | **string** | The status of Registration request Possible Values:   - &#39;PROCESSING&#39;: This status is for Registrations that are still in Progress, you can get the latest status by calling the GET endpoint using the Registration Id   - &#39;SUCCESS&#39;: This status is for Registrations that were successfull on every step of the on boarding process.   - &#39;FAILURE&#39;: This status is for Registrations that fail before the Organization was created; please refer to the details section in the reponse for more information.   - &#39;PARTIAL&#39;: This status is for Registrations that created the Organization successfully but fail in at least on step while configuring it; please refer to the details section in the response for more information.  | [optional] 
**BoardingPackageId** | **string** |  | [optional] 
**BoardingFlow** | **string** | Determines the boarding flow for this registration. Possible Values:   - &#39;ENTERPRISE&#39;   - &#39;SMB&#39;   - &#39;ADDPRODUCT&#39;  | [optional] 
**Mode** | **string** | In case mode is not provided the API will use COMPLETE as default Possible Values:   - &#39;COMPLETE&#39;   - &#39;PARTIAL&#39;  | [optional] 
**SalesRepId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


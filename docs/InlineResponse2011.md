# CyberSource.Model.InlineResponse2011
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**SubmitTimeUtc** | **DateTime?** | Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**Status** | **string** | The status of Registration request Possible Values:   - &#39;INITIALIZED&#39;   - &#39;RECEIVED&#39;   - &#39;PROCESSING&#39;   - &#39;SUCCESS&#39;   - &#39;FAILURE&#39;   - &#39;PARTIAL&#39;  | [optional] 
**RegistrationInformation** | [**InlineResponse2011RegistrationInformation**](InlineResponse2011RegistrationInformation.md) |  | [optional] 
**IntegrationInformation** | [**InlineResponse2011IntegrationInformation**](InlineResponse2011IntegrationInformation.md) |  | [optional] 
**OrganizationInformation** | [**InlineResponse2011OrganizationInformation**](InlineResponse2011OrganizationInformation.md) |  | [optional] 
**ProductInformationSetups** | [**List&lt;InlineResponse2011ProductInformationSetups&gt;**](InlineResponse2011ProductInformationSetups.md) |  | [optional] 
**Message** | **string** |  | [optional] 
**Details** | **Dictionary&lt;string, List&lt;Object&gt;&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


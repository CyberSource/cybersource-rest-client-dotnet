# CyberSource.Model.GetSubscriptionsPaymentsResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**GetSubscriptionsPaymentsResponseLinks**](GetSubscriptionsPaymentsResponseLinks.md) |  | [optional] 
**SubmitTimeUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services.  | [optional] 
**TotalCount** | **int?** | Total number of payments returned for the subscription, including both past payments and those specified in scheduledPaymentsCount. | [optional] 
**CyclesCompletedCount** | [**GetSubscriptionsPaymentsResponseCyclesCompletedCount**](GetSubscriptionsPaymentsResponseCyclesCompletedCount.md) |  | [optional] 
**BillingCyclesToSkip** | **List&lt;int?&gt;** | A list of billing cycles that are marked to be skipped. | [optional] 
**SubscriptionPayment** | [**List&lt;GetSubscriptionsPaymentsResponseSubscriptionPayment&gt;**](GetSubscriptionsPaymentsResponseSubscriptionPayment.md) | The list of subscription payment details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.PtsV2PaymentsPost201ResponseRiskInformationInfoCodes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Velocity** | **List&lt;string&gt;** | List of information codes triggered by the order. These information codes were generated when you created the order and product velocity rules and are returned so that you can associate them with the rules.  Returned by Decision Manager service.  | [optional] 
**Address** | **List&lt;string&gt;** | Indicates a mismatch between the customer’s billing and shipping addresses.  Returned by scoring service.  | [optional] 
**CustomerList** | **List&lt;string&gt;** | Indicates that customer information is associated with transactions that are either on the negative or the positive list.  Returned by scoring service.  | [optional] 
**IdentityChange** | **List&lt;string&gt;** | Indicates excessive identity changes. The threshold is variable depending on the identity elements being compared. This field can contain one or more information codes, separated by carets (^).  Returned by scoring service.  | [optional] 
**Internet** | **List&lt;string&gt;** | Indicates a problem with the customer’s email address, IP address, or billing address.  Returned by scoring service.  | [optional] 
**Phone** | **List&lt;string&gt;** | Indicates a problem with the customer’s phone number.  Returned by scoring service.  | [optional] 
**Suspicious** | **List&lt;string&gt;** | Indicates that the customer provided potentially suspicious information.  Returned by scoring service.  | [optional] 
**GlobalVelocity** | **List&lt;string&gt;** | Indicates that the customer has a high purchase frequency.  Returned by scoring service.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


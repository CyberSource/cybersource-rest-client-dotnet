# CyberSource.Model.PtsV2PaymentsPost201ResponseRiskInformationInfoCodes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Velocity** | **List&lt;string&gt;** | List of information codes triggered by the order. These information codes were generated when you created the order and product velocity rules and are returned so that you can associate them with the rules.  | [optional] 
**Address** | **List&lt;string&gt;** | Indicates a mismatch between the customer’s billing and shipping addresses.  | [optional] 
**CustomerList** | **List&lt;string&gt;** | Indicates that customer information is associated with transactions that are either on the negative or the positive list.  | [optional] 
**DeviceBehavior** | **List&lt;string&gt;** | Indicates the device behavior information code(s) returned from device fingerprinting.  | [optional] 
**IdentityChange** | **List&lt;string&gt;** | Indicates excessive identity changes. The threshold is variable depending on the identity elements being compared.  | [optional] 
**Internet** | **List&lt;string&gt;** | Indicates a problem with the customer’s email address, IP address, or billing address.  | [optional] 
**Phone** | **List&lt;string&gt;** | Indicates a problem with the customer’s phone number.  | [optional] 
**Suspicious** | **List&lt;string&gt;** | Indicates that the customer provided potentially suspicious information.  | [optional] 
**GlobalVelocity** | **List&lt;string&gt;** | Indicates that the customer has a high purchase frequency.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


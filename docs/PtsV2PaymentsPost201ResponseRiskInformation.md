# CyberSource.Model.PtsV2PaymentsPost201ResponseRiskInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**PtsV2PaymentsPost201ResponseRiskInformationProfile**](PtsV2PaymentsPost201ResponseRiskInformationProfile.md) |  | [optional] 
**Rules** | [**List&lt;PtsV2PaymentsPost201ResponseRiskInformationRules&gt;**](PtsV2PaymentsPost201ResponseRiskInformationRules.md) |  | [optional] 
**InfoCodes** | [**PtsV2PaymentsPost201ResponseRiskInformationInfoCodes**](PtsV2PaymentsPost201ResponseRiskInformationInfoCodes.md) |  | [optional] 
**Velocity** | [**PtsV2PaymentsPost201ResponseRiskInformationVelocity**](PtsV2PaymentsPost201ResponseRiskInformationVelocity.md) |  | [optional] 
**CasePriority** | **int?** | You receive this field only if you subscribe to the Enhanced Case Management service. The priority level ranges from 1 (highest) to 5 (lowest); the default value is 3. If you do not assign a priority to your rules or to your profiles, the default value is given to the order.  For all possible values, see the &#x60;decision_case_priority&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).  | [optional] 
**LocalTime** | **string** | The customer&#39;s local time (&#x60;hh:mm:ss&#x60;), which is calculated from the transaction request time and the customer&#39;s billing address.  For details, see the &#x60;score_time_local&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/)  | [optional] 
**Score** | [**PtsV2PaymentsPost201ResponseRiskInformationScore**](PtsV2PaymentsPost201ResponseRiskInformationScore.md) |  | [optional] 
**IpAddress** | [**PtsV2PaymentsPost201ResponseRiskInformationIpAddress**](PtsV2PaymentsPost201ResponseRiskInformationIpAddress.md) |  | [optional] 
**Providers** | [**PtsV2PaymentsPost201ResponseRiskInformationProviders**](PtsV2PaymentsPost201ResponseRiskInformationProviders.md) |  | [optional] 
**Travel** | [**PtsV2PaymentsPost201ResponseRiskInformationTravel**](PtsV2PaymentsPost201ResponseRiskInformationTravel.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


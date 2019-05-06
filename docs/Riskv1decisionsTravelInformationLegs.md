# CyberSource.Model.Riskv1decisionsTravelInformationLegs
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Origination** | **string** | Use to specify the airport code for the origin of the leg of the trip, which is designated by the pound (#) symbol in the field name. This code is usually three digits long, for example: SFO &#x3D; San Francisco. Do not use the colon (:) or the dash (-). For airport codes, see the IATA Airline and Airport Code Search. The leg number can be a positive integer from 0 to N. For example: decision_manager_travel_leg0_orig&#x3D;SFO decision_manager_travel_leg1_orig&#x3D;SFO Note In your request, send either the complete route or the individual legs (_leg#_orig and _leg#_dest). If you send all the fields, the complete route takes precedence over the individual legs.  | [optional] 
**Destination** | **string** | Use to specify the airport code for the destination of the leg of the trip, which is designated by the pound (#) symbol in the field name. This code is usually three digits long, for example: SFO &#x3D; San Francisco. Do not use the colon (:) or the dash (-). For airport codes, see the IATA Airline and Airport Code Search. The leg number can be a positive integer from 0 to N. For example: decision_manager_travel_leg0_dest&#x3D;SFO decision_manager_travel_leg1_dest&#x3D;SFO Note In your request, send either the complete route or the individual legs (_leg#_orig and _leg#_dest). If you send all the fields, the complete route takes precedence over the individual legs.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.Riskv1liststypeentriesRiskInformationMarkingDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Notes** | **string** | Notes or details that explain the reasons for adding the transaction to either the positive or negative list. | [optional] 
**Reason** | **string** | Reason for adding the transaction to the negative list. This field can contain one of the following values: - &#x60;fraud_chargeback:&#x60; You have received a fraud-related chargeback for the transaction. - &#x60;non_fraud_chargeback:&#x60; You have received a non-fraudulent chargeback for the transaction. - &#x60;suspected:&#x60; You believe that you will probably receive a chargeback for the transaction. - &#x60;creditback:&#x60; You issued a refund to the customer to avoid a chargeback for the transaction.  | [optional] 
**RecordName** | **string** | Name of the customer&#39;s record entered in the list. For the positive list, it is required if &#x60;action_ code&#x60;&#x3D;&#x60;add_positive&#x60;. If absent from the request, &#x60;ics_risk_update&#x60; creates the value for this field by concatenating the customer&#39;s first and last names. For the negative and the review lists, &#x60;record_name&#x60;, &#x60;customer_firstname&#x60;, and &#x60;customer_lastname&#x60; are optional.  | [optional] 
**Action** | **string** | Indicates whether to add to or remove a customer&#39;s identity from the negative or positive list. This field can contain one of the following values: - add: Add information to the list. - convert: moves the data. - delete: deletes the data from the list.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


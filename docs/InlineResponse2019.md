# CyberSource.Model.InlineResponse2019
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventDate** | **string** | Date that the webhook was delivered | [optional] 
**EventType** | **string** | The event name the webhook was delivered for | [optional] 
**OrganizationId** | **string** | The Organization Identifier. | [optional] 
**Payloads** | [**InlineResponse2019Payloads**](InlineResponse2019Payloads.md) |  | [optional] 
**ProductId** | **string** | The product the webhook was delivered for | [optional] 
**RequestType** | **string** | Identifies the the type of request | [optional] 
**RetryNumber** | **int?** | The number of retry attempts for a given webhook | [optional] 
**TransactionTraceId** | **string** | The identifier for the webhook | [optional] 
**WebhookId** | **string** | The identifier of the subscription | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


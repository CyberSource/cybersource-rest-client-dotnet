# CyberSource.Model.InlineResponse20014ResponseRecord
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Response** | **string** | Valid Values:   * NAN   * NED   * ACL   * CCH   * CUR   * NUP   * UNA   * ERR   * DEC  | [optional] 
**Reason** | **string** |  | [optional] 
**Token** | **string** |  | [optional] 
**InstrumentIdentifierId** | **string** |  | [optional] 
**InstrumentIdentifierCreated** | **string** | Valid Values:   * true   * false  | [optional] 
**CardNumber** | **string** |  | [optional] 
**CardExpiryMonth** | **string** |  | [optional] 
**CardExpiryYear** | **string** |  | [optional] 
**CardType** | **string** |  | [optional] 
**AdditionalUpdates** | [**List&lt;InlineResponse20014ResponseRecordAdditionalUpdates&gt;**](InlineResponse20014ResponseRecordAdditionalUpdates.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.UnifiedriskPaymentWire
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Addenda** | **string** | Additional payment information or remittance data appended to the wire transfer message for beneficiary reconciliation purposes | [optional] 
**AgentToAgentMsg** | **string** | Free-text message transmitted between the originating and receiving financial agents for internal communication or compliance notes | [optional] 
**BusinessFunctionCode** | **string** | Fedwire Business Function Code indicating the specific type of wire transfer (e.g., BTR for bank transfer, FFR for fed funds returned) | [optional] 
**DebtorToCreditorMsg** | **string** | Message from the payer to the payee providing remittance information, invoice references, or payment instructions | [optional] 
**ImadInputCycleDate** | **DateTime?** | Fedwire IMAD (Input Message Accountability Data) input cycle date in YYYYMMDD format, used to uniquely identify outgoing wire messages | [optional] 
**ImadInputSequenceNumber** | **string** | Sequential number within the IMAD cycle identifying this specific wire message within the processing day | [optional] 
**ImadInputSource** | **string** | Source identifier in the IMAD, typically the Federal Reserve district code and routing information of the originating institution | [optional] 
**OfacCheckCompletedFlag** | **string** | Indicates whether OFAC (Office of Foreign Assets Control) sanctions screening has been completed for this wire transfer. Required for regulatory compliance | [optional] 
**OmadOutputCycleDate** | **DateTime?** | Fedwire OMAD (Output Message Accountability Data) output cycle date, used to identify and track the received wire message at the destination institution | [optional] 
**OmadOutputDate** | **DateTime?** | Date component of the OMAD for the received wire, confirming the settlement date at the receiving institution | [optional] 
**OmadOutputDestinationId** | **string** | Destination routing identifier in the OMAD, identifying the Federal Reserve office that delivered the wire message | [optional] 
**OmadOutputSequencer** | **string** | Sequential output identifier in the OMAD, used for uniquely identifying wire messages at the receiving end | [optional] 
**OmadOutputTime** | **int?** | Time component of the OMAD in HHMM format (24-hour), indicating when the wire was delivered to the receiving institution | [optional] 
**SupervisorOverrideFlag** | **string** | Indicates whether a supervisor manually overrode a compliance hold or exception flag on this wire transfer. Overrides require audit logging | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


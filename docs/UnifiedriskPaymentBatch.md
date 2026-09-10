# CyberSource.Model.UnifiedriskPaymentBatch
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchNumber** | **string** | Unique sequential identifier for this batch within the batch file, used for tracking and reconciliation of ACH or BACS batch submissions | [optional] 
**CategoryPurposeDescription** | **string** | Human-readable description of the business purpose for the batch (e.g., \&quot;Payroll\&quot;, \&quot;Vendor Payments\&quot;). Corresponds to the ISO 20022 CategoryPurpose code | [optional] 
**EndOfBatchIndicator** | **bool?** | Indicates this entry is the last record in the current batch. Used to signal batch boundary during file processing | [optional] 
**EndOfFileIndicator** | **bool?** | Indicates this entry is the last record in the entire batch file. Used to trigger final file validation and processing | [optional] 
**EntryDetailRecNum** | **decimal?** | Sequential record number of the entry detail record within the batch, used for file integrity checks and record-level reconciliation | [optional] 
**FileIdModifier** | **string** | Single character modifier (A-Z) used to distinguish multiple batch files submitted on the same day for the same originator | [optional] 
**NumberOfAddendaRecords** | **decimal?** | Count of addenda records associated with this batch entry, used for validating batch completeness during file processing | [optional] 
**ServiceClassCode** | **string** | ACH service class code indicating the type of entries in the batch. Values - \&quot;200\&quot; (mixed), \&quot;220\&quot; (credits only), \&quot;225\&quot; (debits only), \&quot;280\&quot; (automated accounting) | [optional] 
**TotalBatchCountInFile** | **decimal?** | Total number of batches contained in this file, used for file-level control validation and balancing | [optional] 
**TotalBatchEntries** | **decimal?** | Total count of entry detail records within this batch, used for batch-level balancing and reconciliation | [optional] 
**TotalEntryCountInFile** | **decimal?** | Total count of all entry detail records across all batches in the file, used for file-level reconciliation | [optional] 
**TotalEntryHash** | **decimal?** | Arithmetic sum of all routing transit numbers within the batch/file, used as a checksum for routing number validation | [optional] 
**TotalTransitCountInFile** | **decimal?** | Total count of distinct routing transit numbers in the file, used for clearing house validation and routing verification | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


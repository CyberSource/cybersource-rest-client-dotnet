# CyberSource.Model.Ptsv1pushfundstransferProcessingInformationPayoutsOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceCurrency** | **string** | Use a 3-character alpha currency code for source currency of the funds transfer.  Required if sending processingInformation.payoutsOptions.sourceAmount.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf  | [optional] 
**DestinationCurrency** | **string** | Use a 3-character alpha currency code for destination currency of the funds transfer.  Yellow Pepper  Supported for cross border funds transfers.  ISO standard currencies: http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf  | [optional] 
**SourceAmount** | **string** | Source Amount is required in certain markets to identify the transaction amount entered in the sender&#39;s currency code prior to FX conversion by the originating entity.  Format:  Minimum Value: 0  Maximum value: 999999999.99  Allowed fractional digits: 2  | [optional] 
**RetrievalReferenceNumber** | **string** | Unique reference number returned by the processor that identifies the transaction at the network.  | [optional] 
**AccountFundingReferenceId** | **string** | Visa (maxLength of 15) or MasterCard (maxLength of 40) generated transaction identifier (TID) that is unique for each original authorization and financial request.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


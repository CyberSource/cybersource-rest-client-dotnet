# CyberSource.Model.UnifiedriskPaymentCheck
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckNumber** | **string** | Serial number printed on the physical check, used for duplicate detection, check fraud prevention, and reconciliation | [optional] 
**DepositSlipId** | **string** | Unique identifier for the deposit slip associated with the check deposit, used for linking deposited checks to branch transactions | [optional] 
**DepositLocation** | [**UnifiedriskPaymentCheckDepositLocation**](UnifiedriskPaymentCheckDepositLocation.md) |  | [optional] 
**MicrAccountNumber** | **string** | Account number encoded in the MICR (Magnetic Ink Character Recognition) line at the bottom of the check, used for automated account identification | [optional] 
**RoutingTransitNumber** | **string** | Bank routing and transit number (RTN) encoded in the MICR line of the check, identifying the financial institution on which the check is drawn | [optional] 
**SplitDepositFlag** | **bool?** | Indicates whether the check deposit has been split across multiple accounts. Split deposits may indicate structuring or kiting attempts | [optional] 
**SplitAccountId1** | **string** | First destination account ID in a split check deposit, used for tracking the allocation of funds across multiple accounts | [optional] 
**SplitAccountId2** | **string** | Second destination account ID in a split check deposit | [optional] 
**SplitAccountId3** | **string** | Third destination account ID in a split check deposit | [optional] 
**SplitAccountId4** | **string** | Fourth destination account ID in a split check deposit | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


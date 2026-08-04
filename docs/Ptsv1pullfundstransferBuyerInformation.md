# CyberSource.Model.Ptsv1pullfundstransferBuyerInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VatRegistrationNumber** | **string** | Customer&#39;s VAT registration number for the individual sender tax identification.  This field flows in ISO field 104, DSID 63 tag 06.  Visa is recommending the use of the following business application identifier (BAI) values  and merchant category code (MCC) combinations to process domestic bill payments, toll payments,  and business-to-business funding transactions as AFTs in Brazil: - BB (Business-to-business) - BP (Non-card bill payment) - FT (Funds transfer) - WT (Wallet transfer)  MCC: 4784  #### Mapping - SCMP API Field: purchaser_vat_registration_number - Simple Order API Field: invoiceHeader_purchaserVATRegistrationNumber - CCS: customer.vatRegistrationNumber  Optional field.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.Vasv2taxOrderInformationInvoiceDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceDate** | **string** | Date of the tax calculation. Use format YYYYMMDD. You can provide a date in the past if you are calculating tax for a refund and want to know what the tax was on the date the order was placed. You can provide a date in the future if you are calculating the tax for a future date, such as an upcoming tax holiday.  The default is the date, in Pacific time, that the bank receives the request. Keep this in mind if you are in a different time zone and want the tax calculated with the rates that are applicable on a specific date.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# CyberSource.Model.Ptsv2paymentsProcessingInformationRecurringOptions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanPayment** | **bool?** | Flag that indicates whether this is a payment towards an existing contractual loan.  Possible values: - &#x60;true&#x60;: Loan payment - &#x60;false&#x60;: (default) Not a loan payment  | [optional] [default to false]
**FirstRecurringPayment** | **bool?** | Flag that indicates whether this transaction is the first in a series of recurring payments.  This field is supported only for **Atos**, **FDC Nashville Global**, and **OmniPay Direct**.  Possible values:  - &#x60;true&#x60; Indicates this is the first payment in a series of recurring payments  - &#x60;false&#x60; (default) Indicates this is not the first payment in a series of recurring payments.  | [optional] [default to false]

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


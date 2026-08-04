# CyberSource.Model.Ptsv2payoutsSenderInformationAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundsSource** | **string** | Source of funds. Possible values:    Paymentech, CTV, FDC Compass:  - 01: Credit card  - 02: Debit card  - 03: Prepaid card    Paymentech, CTV -  - 04: Cash  - 05: Debit or deposit account that is not linked to a Visa card. Includes checking accounts, savings        accounts, and proprietary debit or ATM cards.  - 06: Credit account that is not linked to a Visa card. Includes credit cards and proprietary lines        of credit.    FDCCompass -   - 04: Deposit Account  **Funds Disbursement**  This value is most likely 05 to identify that the originator used a deposit account to fund the disbursement.  **Credit Card Bill Payment**  This value must be 02, 03, 04, or 05.  | [optional] 
**Number** | **string** | The account number of the entity funding the transaction. It is the sender&#39;s account number. It can be a debit/credit card account number or bank account number.  **Funds disbursements and OCT transactions**  This field is optional.  **All other transactions**  This field is required when the sender funds the transaction with a financial instrument, for example debit card. Length: * FDCCompass (&lt;&#x3D; 19) * Paymentech (&lt;&#x3D; 16)  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


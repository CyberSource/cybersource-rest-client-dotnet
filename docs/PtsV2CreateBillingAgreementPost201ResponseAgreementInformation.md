# CyberSource.Model.PtsV2CreateBillingAgreementPost201ResponseAgreementInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier for the mandate.  | [optional] 
**DateSigned** | **string** | Date the mandate has been signed.  Format YYYYMMdd | [optional] 
**DateCreated** | **string** | Date the mandate has been created.  Format YYYYMMdd | [optional] 
**Type** | **string** | Identifies the type of schedule as either recurring, one-off, split or usage.  Possible values: - recurring - oneoff - split - usage | [optional] 
**Frequency** | **string** | Regularity with which the event occurs.  Possible values: - annual - monthly - quarterly - semiannual - weekly - daily - adhoc - intraday - fortnightly | [optional] 
**OccurrencesPerPeriod** | **int?** | Number of occurrences during the specified period. | [optional] 
**StartDate** | **string** | Start date of the schedule.  Format YYYYMMdd | [optional] 
**EndDate** | **string** | End date of the schedule.  Format YYYYMMdd | [optional] 
**EncodedHtml** | **string** | Base64 encoded html string | [optional] 
**EncodedHtmlPopup** | **string** | Base64 encoded popup html string | [optional] 
**Url** | **string** | URL for redirecting the customer for creating the mandate.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


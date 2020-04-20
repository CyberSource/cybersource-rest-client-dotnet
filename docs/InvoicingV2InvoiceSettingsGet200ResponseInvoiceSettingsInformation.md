# CyberSource.Model.InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantLogo** | **string** | The image file, which must be encoded in Base64 format. Supported file formats are &#x60;png&#x60;, &#x60;jpg&#x60;, and &#x60;gif&#x60;. The image file size restriction is 1 MB. | [optional] 
**MerchantDisplayName** | **string** | The merchant&#39;s display name shown on the invoice. | [optional] 
**CustomEmailMessage** | **string** | The content of the email message that we send to your customers. | [optional] 
**EnableReminders** | **bool?** | Whether you would like us to send an auto-generated reminder email to your invoice recipients. Currently, this reminder email is sent five days before the invoice is due and one day after it is past due. | [optional] 
**HeaderStyle** | [**InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle**](InvoicingV2InvoiceSettingsGet200ResponseInvoiceSettingsInformationHeaderStyle.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


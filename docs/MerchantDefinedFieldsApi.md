# CyberSource.Api.MerchantDefinedFieldsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMerchantDefinedFieldDefinition**](MerchantDefinedFieldsApi.md#createmerchantdefinedfielddefinition) | **POST** /invoicing/v2/{referenceType}/merchantDefinedFields | Create merchant defined field for a given reference type
[**DeleteMerchantDefinedFieldsDefinitions**](MerchantDefinedFieldsApi.md#deletemerchantdefinedfieldsdefinitions) | **DELETE** /invoicing/v2/{referenceType}/merchantDefinedFields/{id} | Delete a MerchantDefinedField by ID
[**GetMerchantDefinedFieldsDefinitions**](MerchantDefinedFieldsApi.md#getmerchantdefinedfieldsdefinitions) | **GET** /invoicing/v2/{referenceType}/merchantDefinedFields | Get all merchant defined fields for a given reference type
[**PutMerchantDefinedFieldsDefinitions**](MerchantDefinedFieldsApi.md#putmerchantdefinedfieldsdefinitions) | **PUT** /invoicing/v2/{referenceType}/merchantDefinedFields/{id} | Update a MerchantDefinedField by ID


<a name="createmerchantdefinedfielddefinition"></a>
# **CreateMerchantDefinedFieldDefinition**
> List<InlineResponse2004> CreateMerchantDefinedFieldDefinition (string referenceType, MerchantDefinedFieldDefinitionRequest merchantDefinedFieldDefinitionRequest)

Create merchant defined field for a given reference type

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateMerchantDefinedFieldDefinitionExample
    {
        public void main()
        {
            var apiInstance = new MerchantDefinedFieldsApi();
            var referenceType = referenceType_example;  // string | The reference type for which merchant defined fields are to be fetched. Available values are Invoice, Purchase, Donation
            var merchantDefinedFieldDefinitionRequest = new MerchantDefinedFieldDefinitionRequest(); // MerchantDefinedFieldDefinitionRequest | 

            try
            {
                // Create merchant defined field for a given reference type
                List&lt;InlineResponse2004&gt; result = apiInstance.CreateMerchantDefinedFieldDefinition(referenceType, merchantDefinedFieldDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantDefinedFieldsApi.CreateMerchantDefinedFieldDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referenceType** | **string**| The reference type for which merchant defined fields are to be fetched. Available values are Invoice, Purchase, Donation | 
 **merchantDefinedFieldDefinitionRequest** | [**MerchantDefinedFieldDefinitionRequest**](MerchantDefinedFieldDefinitionRequest.md)|  | 

### Return type

[**List<InlineResponse2004>**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemerchantdefinedfieldsdefinitions"></a>
# **DeleteMerchantDefinedFieldsDefinitions**
> void DeleteMerchantDefinedFieldsDefinitions (string referenceType, long? id)

Delete a MerchantDefinedField by ID

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeleteMerchantDefinedFieldsDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new MerchantDefinedFieldsApi();
            var referenceType = referenceType_example;  // string | 
            var id = 789;  // long? | 

            try
            {
                // Delete a MerchantDefinedField by ID
                apiInstance.DeleteMerchantDefinedFieldsDefinitions(referenceType, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantDefinedFieldsApi.DeleteMerchantDefinedFieldsDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referenceType** | **string**|  | 
 **id** | **long?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmerchantdefinedfieldsdefinitions"></a>
# **GetMerchantDefinedFieldsDefinitions**
> List<InlineResponse2004> GetMerchantDefinedFieldsDefinitions (string referenceType)

Get all merchant defined fields for a given reference type

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetMerchantDefinedFieldsDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new MerchantDefinedFieldsApi();
            var referenceType = referenceType_example;  // string | The reference type for which merchant defined fields are to be fetched. Available values are Invoice, Purchase, Donation

            try
            {
                // Get all merchant defined fields for a given reference type
                List&lt;InlineResponse2004&gt; result = apiInstance.GetMerchantDefinedFieldsDefinitions(referenceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantDefinedFieldsApi.GetMerchantDefinedFieldsDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referenceType** | **string**| The reference type for which merchant defined fields are to be fetched. Available values are Invoice, Purchase, Donation | 

### Return type

[**List<InlineResponse2004>**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putmerchantdefinedfieldsdefinitions"></a>
# **PutMerchantDefinedFieldsDefinitions**
> List<InlineResponse2004> PutMerchantDefinedFieldsDefinitions (string referenceType, long? id, MerchantDefinedFieldCore merchantDefinedFieldCore)

Update a MerchantDefinedField by ID

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PutMerchantDefinedFieldsDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new MerchantDefinedFieldsApi();
            var referenceType = referenceType_example;  // string | 
            var id = 789;  // long? | 
            var merchantDefinedFieldCore = new MerchantDefinedFieldCore(); // MerchantDefinedFieldCore | 

            try
            {
                // Update a MerchantDefinedField by ID
                List&lt;InlineResponse2004&gt; result = apiInstance.PutMerchantDefinedFieldsDefinitions(referenceType, id, merchantDefinedFieldCore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantDefinedFieldsApi.PutMerchantDefinedFieldsDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referenceType** | **string**|  | 
 **id** | **long?**|  | 
 **merchantDefinedFieldCore** | [**MerchantDefinedFieldCore**](MerchantDefinedFieldCore.md)|  | 

### Return type

[**List<InlineResponse2004>**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


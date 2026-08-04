# CyberSource.Api.MerchantDefinedFieldsApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMerchantDefinedFieldDefinition**](MerchantDefinedFieldsApi.md#createmerchantdefinedfielddefinition) | **POST** /invoicing/v2/{referenceType}/merchantDefinedFields | Create merchant defined field for a given reference type
[**CreatePblMerchantDefinedFieldDefinition**](MerchantDefinedFieldsApi.md#createpblmerchantdefinedfielddefinition) | **POST** /ipl/v2/{referenceType}/merchantDefinedFields | Create a PayByLink merchant defined field for a given reference type
[**DeleteMerchantDefinedFieldsDefinitions**](MerchantDefinedFieldsApi.md#deletemerchantdefinedfieldsdefinitions) | **DELETE** /invoicing/v2/{referenceType}/merchantDefinedFields/{id} | Delete a MerchantDefinedField by ID
[**DeletePblMerchantDefinedFieldsDefinitions**](MerchantDefinedFieldsApi.md#deletepblmerchantdefinedfieldsdefinitions) | **DELETE** /ipl/v2/{referenceType}/merchantDefinedFields/{id} | Delete a PayByLink MerchantDefinedField by ID
[**GetMerchantDefinedFieldsDefinitions**](MerchantDefinedFieldsApi.md#getmerchantdefinedfieldsdefinitions) | **GET** /invoicing/v2/{referenceType}/merchantDefinedFields | Get all merchant defined fields for a given reference type
[**GetPblMerchantDefinedFieldsDefinitions**](MerchantDefinedFieldsApi.md#getpblmerchantdefinedfieldsdefinitions) | **GET** /ipl/v2/{referenceType}/merchantDefinedFields | Get all PayByLink merchant defined fields for a given reference type
[**PutMerchantDefinedFieldsDefinitions**](MerchantDefinedFieldsApi.md#putmerchantdefinedfieldsdefinitions) | **PUT** /invoicing/v2/{referenceType}/merchantDefinedFields/{id} | Update a MerchantDefinedField by ID
[**PutPblMerchantDefinedFieldsDefinitions**](MerchantDefinedFieldsApi.md#putpblmerchantdefinedfieldsdefinitions) | **PUT** /ipl/v2/{referenceType}/merchantDefinedFields/{id} | Update a PayByLink MerchantDefinedField by ID


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

<a name="createpblmerchantdefinedfielddefinition"></a>
# **CreatePblMerchantDefinedFieldDefinition**
> List<InlineResponse2004> CreatePblMerchantDefinedFieldDefinition (string referenceType, MerchantDefinedFieldDefinitionRequest1 merchantDefinedFieldDefinitionRequest)

Create a PayByLink merchant defined field for a given reference type

Creates a merchant defined field for the given reference type (`Purchase` or `Donation`). The field type is independent of the reference type: both `Purchase` and `Donation` support both `Text` and `Select` fields. Set `fieldType` to `Text` or `Select` accordingly. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreatePblMerchantDefinedFieldDefinitionExample
    {
        public void main()
        {
            var apiInstance = new MerchantDefinedFieldsApi();
            var referenceType = referenceType_example;  // string | The reference type for which the merchant defined field is to be created. Available values are Purchase and Donation
            var merchantDefinedFieldDefinitionRequest = new MerchantDefinedFieldDefinitionRequest1(); // MerchantDefinedFieldDefinitionRequest1 | 

            try
            {
                // Create a PayByLink merchant defined field for a given reference type
                List&lt;InlineResponse2004&gt; result = apiInstance.CreatePblMerchantDefinedFieldDefinition(referenceType, merchantDefinedFieldDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantDefinedFieldsApi.CreatePblMerchantDefinedFieldDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referenceType** | **string**| The reference type for which the merchant defined field is to be created. Available values are Purchase and Donation | 
 **merchantDefinedFieldDefinitionRequest** | [**MerchantDefinedFieldDefinitionRequest1**](MerchantDefinedFieldDefinitionRequest1.md)|  | 

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

<a name="deletepblmerchantdefinedfieldsdefinitions"></a>
# **DeletePblMerchantDefinedFieldsDefinitions**
> void DeletePblMerchantDefinedFieldsDefinitions (string referenceType, long? id)

Delete a PayByLink MerchantDefinedField by ID

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class DeletePblMerchantDefinedFieldsDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new MerchantDefinedFieldsApi();
            var referenceType = referenceType_example;  // string | 
            var id = 789;  // long? | 

            try
            {
                // Delete a PayByLink MerchantDefinedField by ID
                apiInstance.DeletePblMerchantDefinedFieldsDefinitions(referenceType, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantDefinedFieldsApi.DeletePblMerchantDefinedFieldsDefinitions: " + e.Message );
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

<a name="getpblmerchantdefinedfieldsdefinitions"></a>
# **GetPblMerchantDefinedFieldsDefinitions**
> List<InlineResponse2004> GetPblMerchantDefinedFieldsDefinitions (string referenceType)

Get all PayByLink merchant defined fields for a given reference type

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetPblMerchantDefinedFieldsDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new MerchantDefinedFieldsApi();
            var referenceType = referenceType_example;  // string | The reference type for which merchant defined fields are to be fetched. Available values are Purchase, Donation and PayByLink. PayByLink returns the merchant defined fields for both Purchase and Donation combined.

            try
            {
                // Get all PayByLink merchant defined fields for a given reference type
                List&lt;InlineResponse2004&gt; result = apiInstance.GetPblMerchantDefinedFieldsDefinitions(referenceType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantDefinedFieldsApi.GetPblMerchantDefinedFieldsDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **referenceType** | **string**| The reference type for which merchant defined fields are to be fetched. Available values are Purchase, Donation and PayByLink. PayByLink returns the merchant defined fields for both Purchase and Donation combined. | 

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

<a name="putpblmerchantdefinedfieldsdefinitions"></a>
# **PutPblMerchantDefinedFieldsDefinitions**
> List<InlineResponse2004> PutPblMerchantDefinedFieldsDefinitions (string referenceType, long? id, MerchantDefinedFieldCore1 merchantDefinedFieldCore)

Update a PayByLink MerchantDefinedField by ID

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class PutPblMerchantDefinedFieldsDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new MerchantDefinedFieldsApi();
            var referenceType = referenceType_example;  // string | 
            var id = 789;  // long? | 
            var merchantDefinedFieldCore = new MerchantDefinedFieldCore1(); // MerchantDefinedFieldCore1 | 

            try
            {
                // Update a PayByLink MerchantDefinedField by ID
                List&lt;InlineResponse2004&gt; result = apiInstance.PutPblMerchantDefinedFieldsDefinitions(referenceType, id, merchantDefinedFieldCore);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MerchantDefinedFieldsApi.PutPblMerchantDefinedFieldsDefinitions: " + e.Message );
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
 **merchantDefinedFieldCore** | [**MerchantDefinedFieldCore1**](MerchantDefinedFieldCore1.md)|  | 

### Return type

[**List<InlineResponse2004>**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


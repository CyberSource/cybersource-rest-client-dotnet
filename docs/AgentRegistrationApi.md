# CyberSource.Api.AgentRegistrationApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateAgentKey**](AgentRegistrationApi.md#activateagentkey) | **POST** /icc/v1/agents/{agentId}/keys/{keyId}/activate | Activate a key
[**AddAgentKey**](AgentRegistrationApi.md#addagentkey) | **POST** /icc/v1/agents/{agentId}/keys | Add a key to an agent
[**GetAgent**](AgentRegistrationApi.md#getagent) | **GET** /icc/v1/agents/{agentId} | Get an agent
[**GetAgentKey**](AgentRegistrationApi.md#getagentkey) | **GET** /icc/v1/agents/{agentId}/keys/{keyId} | Get a key by agent and key ID
[**ListAgentKeys**](AgentRegistrationApi.md#listagentkeys) | **GET** /icc/v1/agents/{agentId}/keys | List keys for an agent
[**RegisterAgent**](AgentRegistrationApi.md#registeragent) | **POST** /icc/v1/agents | Register an agent
[**UpdateAgent**](AgentRegistrationApi.md#updateagent) | **PUT** /icc/v1/agents/{agentId} | Update an agent
[**UpdateAgentKey**](AgentRegistrationApi.md#updateagentkey) | **PUT** /icc/v1/agents/{agentId}/keys/{keyId} | Update a key


<a name="activateagentkey"></a>
# **ActivateAgentKey**
> AddAgentKeyResponse201 ActivateAgentKey (string agentId, string keyId)

Activate a key

**Activate a Key**<br>Activates a deactivated public key, making it available for signature verification.<br><br> Returns **404** if the agent or key is not found, **403** if the agent is deactivated. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ActivateAgentKeyExample
    {
        public void main()
        {
            var apiInstance = new AgentRegistrationApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var keyId = keyId_example;  // string | Unique key identifier

            try
            {
                // Activate a key
                AddAgentKeyResponse201 result = apiInstance.ActivateAgentKey(agentId, keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentRegistrationApi.ActivateAgentKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **keyId** | **string**| Unique key identifier | 

### Return type

[**AddAgentKeyResponse201**](AddAgentKeyResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addagentkey"></a>
# **AddAgentKey**
> AddAgentKeyResponse201 AddAgentKey (string agentId, KeyRequest keyRequest)

Add a key to an agent

**Add a Key to an Agent**<br>Uploads a new public key for the specified agent. The key is created in ***deactivated*** state and must be explicitly activated via `POST /agents/{agentId}/keys/{keyId}/activate` before it can be used.<br><br> Returns **404** if the agent is not found, **403** if the agent is deactivated. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class AddAgentKeyExample
    {
        public void main()
        {
            var apiInstance = new AgentRegistrationApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var keyRequest = new KeyRequest(); // KeyRequest | Key creation request

            try
            {
                // Add a key to an agent
                AddAgentKeyResponse201 result = apiInstance.AddAgentKey(agentId, keyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentRegistrationApi.AddAgentKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **keyRequest** | [**KeyRequest**](KeyRequest.md)| Key creation request | 

### Return type

[**AddAgentKeyResponse201**](AddAgentKeyResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagent"></a>
# **GetAgent**
> AgentRegistrationResponse201 GetAgent (string agentId)

Get an agent

**Get an Agent**<br>Retrieves a single agent by its unique identifier, including all associated public keys.<br><br> Returns **404** if the agent is not found. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetAgentExample
    {
        public void main()
        {
            var apiInstance = new AgentRegistrationApi();
            var agentId = agentId_example;  // string | Unique agent identifier

            try
            {
                // Get an agent
                AgentRegistrationResponse201 result = apiInstance.GetAgent(agentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentRegistrationApi.GetAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 

### Return type

[**AgentRegistrationResponse201**](AgentRegistrationResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagentkey"></a>
# **GetAgentKey**
> AddAgentKeyResponse201 GetAgentKey (string agentId, string keyId)

Get a key by agent and key ID

**Get a Key**<br>Retrieves a specific public key by agent ID and key ID.<br><br> Returns **404** if the agent or key is not found. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class GetAgentKeyExample
    {
        public void main()
        {
            var apiInstance = new AgentRegistrationApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var keyId = keyId_example;  // string | Unique key identifier

            try
            {
                // Get a key by agent and key ID
                AddAgentKeyResponse201 result = apiInstance.GetAgentKey(agentId, keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentRegistrationApi.GetAgentKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **keyId** | **string**| Unique key identifier | 

### Return type

[**AddAgentKeyResponse201**](AddAgentKeyResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listagentkeys"></a>
# **ListAgentKeys**
> ListAgentKeysResponse200 ListAgentKeys (string agentId, int? page = null, int? pageSize = null)

List keys for an agent

**List Keys for an Agent**<br>Returns a paginated list of all public keys associated with the specified agent.<br><br> Returns **404** if the agent is not found. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class ListAgentKeysExample
    {
        public void main()
        {
            var apiInstance = new AgentRegistrationApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var page = 56;  // int? | Page number (1-indexed) (optional)  (default to 1)
            var pageSize = 56;  // int? | Items per page (max 100) (optional)  (default to 30)

            try
            {
                // List keys for an agent
                ListAgentKeysResponse200 result = apiInstance.ListAgentKeys(agentId, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentRegistrationApi.ListAgentKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **page** | **int?**| Page number (1-indexed) | [optional] [default to 1]
 **pageSize** | **int?**| Items per page (max 100) | [optional] [default to 30]

### Return type

[**ListAgentKeysResponse200**](ListAgentKeysResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registeragent"></a>
# **RegisterAgent**
> AgentRegistrationResponse201 RegisterAgent (AgentRequest agentRequest)

Register an agent

**Register an Agent**<br>Registers a new AI agent in the Visa Agent Registry Service (VARS). Once registered, the agent can upload public keys that merchants and Visa services use to verify request signatures.<br><br> **Key Behavior**<br>If an optional `keys` array is included in the request, those keys are created alongside the agent registration in a single operation.<br> Returns **409 Conflict** if an agent with the same domain already exists. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class RegisterAgentExample
    {
        public void main()
        {
            var apiInstance = new AgentRegistrationApi();
            var agentRequest = new AgentRequest(); // AgentRequest | Agent registration request

            try
            {
                // Register an agent
                AgentRegistrationResponse201 result = apiInstance.RegisterAgent(agentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentRegistrationApi.RegisterAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentRequest** | [**AgentRequest**](AgentRequest.md)| Agent registration request | 

### Return type

[**AgentRegistrationResponse201**](AgentRegistrationResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateagent"></a>
# **UpdateAgent**
> AgentRegistrationResponse201 UpdateAgent (string agentId, AgentUpdate agentUpdate)

Update an agent

**Update an Agent**<br>Updates agent information. Only the following fields can be modified: `name`, `domain`, `description`, `contactEmail`, and `agentMetadata`.<br><br> Submitting any other field (e.g., `tokenRequestorId`, `keys`) returns **422 Validation Error**.<br> Returns **404** if the agent is not found, **403** if the agent is deactivated, **409** if the new domain is already registered. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateAgentExample
    {
        public void main()
        {
            var apiInstance = new AgentRegistrationApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var agentUpdate = new AgentUpdate(); // AgentUpdate | Agent update request

            try
            {
                // Update an agent
                AgentRegistrationResponse201 result = apiInstance.UpdateAgent(agentId, agentUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentRegistrationApi.UpdateAgent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **agentUpdate** | [**AgentUpdate**](AgentUpdate.md)| Agent update request | 

### Return type

[**AgentRegistrationResponse201**](AgentRegistrationResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateagentkey"></a>
# **UpdateAgentKey**
> AddAgentKeyResponse201 UpdateAgentKey (string agentId, string keyId, KeyUpdate keyUpdate)

Update a key

**Update a Key**<br>Updates key information. The following fields can be modified: `keyName`, `publicKey`, `algorithm`, and `expirationDate`.<br><br> **Note:** `publicKey` and `algorithm` must always be updated together.<br> Returns **404** if the agent or key is not found, **403** if the agent or key is deactivated, **409** if the new `keyName` already exists. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class UpdateAgentKeyExample
    {
        public void main()
        {
            var apiInstance = new AgentRegistrationApi();
            var agentId = agentId_example;  // string | Unique agent identifier
            var keyId = keyId_example;  // string | Unique key identifier
            var keyUpdate = new KeyUpdate(); // KeyUpdate | Key update request

            try
            {
                // Update a key
                AddAgentKeyResponse201 result = apiInstance.UpdateAgentKey(agentId, keyId, keyUpdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgentRegistrationApi.UpdateAgentKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agentId** | **string**| Unique agent identifier | 
 **keyId** | **string**| Unique key identifier | 
 **keyUpdate** | [**KeyUpdate**](KeyUpdate.md)| Key update request | 

### Return type

[**AddAgentKeyResponse201**](AddAgentKeyResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


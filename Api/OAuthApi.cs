using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuthApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Post Access Token Request
        /// </summary>        
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>        
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>AccessTokenResponse</returns>
        AccessTokenResponse PostAccessTokenRequest(CreateAccessTokenRequest createAccessTokenRequest);

        /// <summary>
        /// Post Access Token Request
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>        
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>ApiResponse of AccessTokenResponse</returns>
        ApiResponse<AccessTokenResponse> PostAccessTokenRequestWithHttpInfo(CreateAccessTokenRequest createAccessTokenRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Post Access Token Request
        /// </summary>        
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>        
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>Task of AccessTokenResponse</returns>
        System.Threading.Tasks.Task<AccessTokenResponse> PostAccessTokenRequestAsync(CreateAccessTokenRequest createAccessTokenRequest);

        /// <summary>
        /// Post Access Token Request
        /// </summary>        
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>        
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>Task of ApiResponse (AccessTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessTokenResponse>> PostAccessTokenRequestAsyncWithHttpInfo(CreateAccessTokenRequest createAccessTokenRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OAuthApi : IOAuthApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OAuthApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OAuthApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            this.Configuration.ApiClient.Configuration = this.Configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CyberSource.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>        
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>AccessTokenResponse</returns>
        public AccessTokenResponse PostAccessTokenRequest(CreateAccessTokenRequest createAccessTokenRequest)
        {
            ApiResponse<AccessTokenResponse> localVarResponse = PostAccessTokenRequestWithHttpInfo(createAccessTokenRequest);
            return localVarResponse.Data;
        }

        
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>        
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>ApiResponse of AccessTokenResponse</returns>
        public ApiResponse<AccessTokenResponse> PostAccessTokenRequestWithHttpInfo(CreateAccessTokenRequest createAccessTokenRequest)
        {            
            // verify the required parameter 'createAccessTokenRequest' is set
            if (createAccessTokenRequest == null)
                throw new ApiException(400, "Missing required parameter 'createAccessTokenRequest' when calling OAuthApi->PostAccessTokenRequest");

            var localVarPath = $"/oauth2/v3/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            if (createAccessTokenRequest != null && createAccessTokenRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createAccessTokenRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createAccessTokenRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostAccessTokenRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccessTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccessTokenResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccessTokenResponse))); // Return statement
        }
        
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>        
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>Task of AccessTokenResponse</returns>
        public async System.Threading.Tasks.Task<AccessTokenResponse> PostAccessTokenRequestAsync(CreateAccessTokenRequest createAccessTokenRequest)
        {
            ApiResponse<AccessTokenResponse> localVarResponse = await PostAccessTokenRequestAsyncWithHttpInfo(createAccessTokenRequest);
            return localVarResponse.Data;

        }

        
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>     
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>Task of ApiResponse (AccessTokenResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccessTokenResponse>> PostAccessTokenRequestAsyncWithHttpInfo(CreateAccessTokenRequest createAccessTokenRequest)
        {
            // verify the required parameter 'createAccessTokenRequest' is set
            if (createAccessTokenRequest == null)
                throw new ApiException(400, "Missing required parameter 'createAccessTokenRequest' when calling OAuthApi->PostAccessTokenRequest");

            var localVarPath = $"/oauth2/v3/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            
            if (createAccessTokenRequest != null && createAccessTokenRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createAccessTokenRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createAccessTokenRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostAccessTokenRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccessTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccessTokenResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccessTokenResponse))); // Return statement
        }

    }
}

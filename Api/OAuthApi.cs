using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;
using NLog;
using AuthenticationSdk.util;

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
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OAuthApi(String basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
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
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
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
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
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
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
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
            Configuration.AddDefaultHeader(key, value);
        }

        
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>        
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>AccessTokenResponse</returns>
        public AccessTokenResponse PostAccessTokenRequest(CreateAccessTokenRequest createAccessTokenRequest)
        {
            logger.Debug("CALLING API \"PostAccessTokenRequest\" STARTED");
            ApiResponse<AccessTokenResponse> localVarResponse = PostAccessTokenRequestWithHttpInfo(createAccessTokenRequest);
            logger.Debug("CALLING API \"PostAccessTokenRequest\" ENDED");
            return localVarResponse.Data;
        }

        
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>        
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>ApiResponse of AccessTokenResponse</returns>
        public ApiResponse<AccessTokenResponse> PostAccessTokenRequestWithHttpInfo(CreateAccessTokenRequest createAccessTokenRequest)
        {            
            // verify the required parameter 'createAccessTokenRequest' is set
            if (createAccessTokenRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'createAccessTokenRequest' when calling OAuthApi->PostAccessTokenRequest");
                throw new ApiException(400, "Missing required parameter 'createAccessTokenRequest' when calling OAuthApi->PostAccessTokenRequest");
            }

            var localVarPath = $"/oauth2/v3/token";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }
            
            if (createAccessTokenRequest != null && createAccessTokenRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createAccessTokenRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createAccessTokenRequest; // byte array
            }

            if (LogUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{LogUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostAccessTokenRequest", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
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
            logger.Debug("CALLING API \"PostAccessTokenRequestAsync\" STARTED");
            ApiResponse<AccessTokenResponse> localVarResponse = await PostAccessTokenRequestAsyncWithHttpInfo(createAccessTokenRequest);
            logger.Debug("CALLING API \"PostAccessTokenRequestAsync\" STARTED");
            return localVarResponse.Data;

        }

        
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>     
        /// <param name="createAccessTokenRequest"></param>
        /// <returns>Task of ApiResponse (AccessTokenResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccessTokenResponse>> PostAccessTokenRequestAsyncWithHttpInfo(CreateAccessTokenRequest createAccessTokenRequest)
        {
            // verify the required parameter 'createAccessTokenRequest' is set
            if (createAccessTokenRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'createAccessTokenRequest' when calling OAuthApi->PostAccessTokenRequest");
                throw new ApiException(400, "Missing required parameter 'createAccessTokenRequest' when calling OAuthApi->PostAccessTokenRequest");
            }

            var localVarPath = $"/oauth2/v3/token";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/x-www-form-urlencoded"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (createAccessTokenRequest != null && createAccessTokenRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createAccessTokenRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createAccessTokenRequest; // byte array
            }

            if (LogUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{LogUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostAccessTokenRequest", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<AccessTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccessTokenResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccessTokenResponse))); // Return statement
        }

    }
}

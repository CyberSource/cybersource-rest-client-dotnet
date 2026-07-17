using CyberSource.Client;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSource.Api
{
    public abstract class ApiBase
    {
        #region Properties
        protected static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Gets the ApiClient instance for making HTTP requests.
        /// </summary>
        protected ApiClient ApiClient { get; private set; }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                return _exceptionFactory;
            }
            set
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                _exceptionFactory = value;
            }
        }

        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            int status = (int)response.StatusCode;
            if (status >= 400) return new ApiException(status, String.Format("Error calling {0}: {1}", methodName, response.Content), response.Content);
            if (status == 0) return new ApiException(status, String.Format("Error calling {0}: {1}", methodName, response.ErrorMessage), response.ErrorMessage);
            return null;
        };
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiBase"/> class.
        /// </summary>
        /// <param name="basePath">The base path of the API.</param>
        [Obsolete("Use the constructor that takes an IConfiguration object instead.")]
        protected ApiBase(string basePath)
        {
            throw new Exception("The constructor that takes a basePath is deprecated. Please use the constructor that takes an IConfiguration object instead.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiBase"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        protected ApiBase(IConfiguration configuration = null)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            ApiClient = new ApiClient(Configuration);

            ExceptionFactory = DefaultExceptionFactory;

            logger ??= LogManager.GetCurrentClassLogger();
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return ApiClient.RestClient.Options.BaseUrl.ToString();
        }

        /// <summary>
        /// Retrieves the status code being set for the most recently executed API request.
        /// </summary>
        /// <returns>Status Code of previous request</returns>
        public int GetStatusCode()
        {
            return this._statusCode ?? 0;
        }

        /// <summary>
        /// Sets the value of status code for the most recently executed API request, in order to be retrieved later.
        /// </summary>
        /// <param name="statusCode">Status Code to be set</param>
        /// <returns></returns>
        public void SetStatusCode(int? statusCode)
        {
            this._statusCode = statusCode;
        }
        #endregion Methods
    }
}

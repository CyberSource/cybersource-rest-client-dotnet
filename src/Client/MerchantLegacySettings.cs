using AuthenticationSdk.util;
using NLog;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;

namespace CyberSource.Client
{
    /// <summary>
    /// Provides legacy merchant settings for backward compatibility with older SDK versions.
    /// Contains HTTP headers, API keys, authentication tokens, timeout, and other legacy configuration properties.
    /// </summary>
    public class MerchantLegacySettings : IMerchantLegacySettings
    {

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantLegacySettings"/> class with default values.
        /// Sets the user agent to the default value.
        /// </summary>
        public MerchantLegacySettings()
        {
            UserAgent = GetUserAgent();
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// Gets or sets the HTTP user agent string.
        /// Used to identify the client application in HTTP requests to the CyberSource API.
        /// </summary>
        /// <value>HTTP user agent string. Default value is "Swagger-Codegen/1.0.0/csharp".</value>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the default HTTP headers to be included in all API requests.
        /// </summary>
        /// <value>A dictionary of header names and values.</value>
        public Dictionary<string, string> DefaultHeader { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets the merchant configuration dictionary containing key/value pairs.
        /// </summary>
        /// <value>A read-only dictionary of merchant configuration values.</value>
        public IReadOnlyDictionary<string, string> MerchantConfigDictionaryObj { get; set; }

        /// <summary>
        /// Gets or sets the HTTP timeout duration in milliseconds for API client requests.
        /// Default value is 100000 milliseconds.
        /// </summary>
        /// <remarks>
        /// This property has been superseded by <see cref="IMerchantNetworkSettings.TimeOut"/>.
        /// If the MerchantConfigDictionaryObj contains a valid "timeout" value, this property is ignored.
        /// </remarks>
        /// <value>Timeout in milliseconds.</value>
        public int TimeOut { get; set; }

        private string _tempFolderPath;

        /// <summary>
        /// Gets or sets the temporary folder path used to store files downloaded from the server.
        /// If not explicitly set, defaults to the system temporary folder (<see cref="Path.GetTempPath()"/>).
        /// Automatically creates the directory if it does not exist.
        /// Ensures the path ends with a directory separator character.
        /// </summary>
        /// <value>The folder path for temporary files. Defaults to system temp folder if not set.</value>
        public string TempFolderPath
        {
            get
            {
                // default to Path.GetTempPath() if _tempFolderPath is not set
                _tempFolderPath ??= Path.GetTempPath();
                return _tempFolderPath;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _tempFolderPath = value;
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value))
                    Directory.CreateDirectory(value);

                // check if the path contains directory separator at the end
                if (value[value.Length - 1] == Path.DirectorySeparatorChar)
                    _tempFolderPath = value;
                else
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
            }
        }

        private const string ISO8601_DATETIME_FORMAT = "o";

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;

        /// <summary>
        /// Gets or sets the date time format string used when serializing in the API client.
        /// </summary>
        /// <remarks>
        /// By default, the format is set to ISO 8601 ("o"). For other format options, see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// 
        /// No validation is performed to ensure that the provided format string is valid.
        /// If a null or empty string is provided, the format reverts to the ISO 8601 default.
        /// </remarks>
        /// <value>The date time format string. Default is ISO 8601 ("o").</value>
        public string DateTimeFormat
        {
            get
            {
                return _dateTimeFormat;
            }
            set
            {
                // Never allow a blank or null string, go back to the default
                _dateTimeFormat = string.IsNullOrEmpty(value) ? ISO8601_DATETIME_FORMAT : value;
            }
        }

        /// <summary>
        /// Gets or sets the NLog logger instance for logging legacy settings configuration and messages.
        /// </summary>
        public static Logger Logger { get; set; }
        #endregion Properties

        #region New Methods
        private string GetUserAgent()
        {
            var assembly = typeof(MerchantNetworkSettings).Assembly;

            var assemblyVersion = MyNewAssemblyHelper.GetAssemblyAttribute<AssemblyFileVersionAttribute>(assembly).Version;

            return "cybs-rest-sdk-dotnet/" + assemblyVersion;
        }
        #endregion New Methods

        #region Legacy Methods
        /// <summary>
        /// Adds or updates a default HTTP header that will be included in all API requests.
        /// </summary>
        /// <param name="key">The name of the HTTP header field.</param>
        /// <param name="value">The value of the HTTP header field.</param>
        public void AddDefaultHeader(string key, string value)
        {
            DefaultHeader[key] = value;
        }
        #endregion Legacy Methods
    }
}

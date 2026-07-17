using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSource.Client
{
    /// <summary>
    /// Defines the contract for legacy merchant settings used for backward compatibility with older SDK versions.
    /// Contains HTTP headers, API keys, authentication tokens, timeout, and other legacy configuration properties.
    /// </summary>
    public interface IMerchantLegacySettings
    {
        /// <summary>
        /// Gets the HTTP user agent string to be sent with API requests.
        /// </summary>
        string UserAgent { get; }

        /// <summary>
        /// Gets or sets the dictionary of default HTTP headers to be included in every API request.
        /// </summary>
        Dictionary<string, string> DefaultHeader { get; set; }

        /// <summary>
        /// Gets the merchant configuration dictionary containing raw configuration key-value pairs loaded from App.Config or custom source.
        /// </summary>
        IReadOnlyDictionary<string, string> MerchantConfigDictionaryObj { get; }

        /// <summary>
        /// Gets the HTTP connection timeout in milliseconds.
        /// </summary>
        int TimeOut { get; }

        /// <summary>
        /// Gets the temporary folder path for storing temporary files during API operations.
        /// </summary>
        string TempFolderPath { get; }

        /// <summary>
        /// Gets the date-time format string to be used when serializing DateTime objects in API requests.
        /// </summary>
        string DateTimeFormat { get; }

        #region Legacy Methods
        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        public void AddDefaultHeader(string key, string value);
        #endregion Legacy Methods
    }
}

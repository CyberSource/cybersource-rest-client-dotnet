using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CyberSource.Utilities.CaptureContext
{
    public static class PublicKeyApiController
    {
        // Only allow alphanumeric characters, hyphens, underscores, and periods in kid values
        private static readonly Regex SafeKidPattern = new Regex(@"^[a-zA-Z0-9._\-]+$", RegexOptions.Compiled);

        private static readonly HttpClient HttpClient = new HttpClient();

        /// <summary>
        /// Fetches the public key JSON from the specified endpoint using HttpClient.
        /// </summary>
        /// <param name="kid">The key ID.</param>
        /// <param name="runEnvironment">The environment domain (e.g., "apitest.cybersource.com").</param>
        /// <returns>JSON string of the public key.</returns>
        public static async Task<string> FetchPublicKeyAsync(string kid, string runEnvironment)
        {
            if (string.IsNullOrWhiteSpace(kid))
            {
                throw new ArgumentException("Key ID (kid) must not be null or empty.", nameof(kid));
            }

            if (!SafeKidPattern.IsMatch(kid))
            {
                throw new ArgumentException("Key ID (kid) contains invalid characters. Only alphanumeric characters, hyphens, underscores, and periods are allowed.", nameof(kid));
            }

            if (string.IsNullOrWhiteSpace(runEnvironment))
            {
                throw new ArgumentException("Run environment must not be null or empty.", nameof(runEnvironment));
            }

            var url = $"https://{runEnvironment}/flex/v2/public-keys/{kid}";

            using (var response = await HttpClient.GetAsync(url).ConfigureAwait(false))
            {
                var content = response.Content == null
                    ? string.Empty
                    : await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException($"Failed to fetch public key. Status: {response.StatusCode}, Error: {content}");
                }

                return content;
            }
        }
    }
}

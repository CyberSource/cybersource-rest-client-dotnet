using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CyberSource.Utilities.CaptureContext
{
    public static class PublicKeyApiController
    {
        /// <summary>
        /// Fetches the public key JSON from the specified endpoint.
        /// </summary>
        /// <param name="kid">The key ID.</param>
        /// <param name="runEnvironment">The environment domain (e.g., "apitest.cybersource.com").</param>
        /// <returns>JSON string of the public key.</returns>
        public static async Task<string> FetchPublicKeyAsync(string kid, string runEnvironment)
        {
            if (string.IsNullOrWhiteSpace(kid))
                throw new ArgumentException("Key ID (kid) must not be null or empty.", nameof(kid));
            if (string.IsNullOrWhiteSpace(runEnvironment))
                throw new ArgumentException("Run environment must not be null or empty.", nameof(runEnvironment));

            var url = $"https://{runEnvironment}/flex/v2/public-keys/{kid}";

            using (var client = new HttpClient())
            using (var response = await client.GetAsync(url).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }
    }
}

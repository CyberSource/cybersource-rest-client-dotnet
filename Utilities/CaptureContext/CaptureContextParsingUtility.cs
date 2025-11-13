using System;
using Newtonsoft.Json.Linq;
using CyberSource.Client;
using Jose;
using CyberSource.Utilities.CaptureContext;
using System.Threading.Tasks;
using AuthenticationSdk.util;

namespace CyberSource.Utilities.CaptureContext
{
    public static class CaptureContextParsingUtility
    {
        public static JObject parseCaptureContextResponse(string jwtToken, Configuration config, bool verifyJWT)
        {
            // Parse JWT Token for any malformations

            JWTUtility.Parse(jwtToken);
            if (!verifyJWT)
            {
                return JObject.Parse(JWT.Payload(jwtToken));
            }
            // Extract 'kid' from JWT header
            var header = JWT.Headers(jwtToken);
            var kid = header.ContainsKey("kid") ? header["kid"].ToString() : null;
            var runEnvironment = config.MerchantConfigDictionaryObj.ContainsKey("runEnvironment") ? config.MerchantConfigDictionaryObj["runEnvironment"] : Constants.HostName;
            if (string.IsNullOrEmpty(kid))
            {
                throw new Exception("JWT token does not contain 'kid' in header");
            }

            string publicKey = "";
            bool isPublicKeyFromCache = false;
            bool isJWTVerified = false;

            try
            {
                publicKey = Cache.GetPublicKeyFromCache(runEnvironment, kid);
                isPublicKeyFromCache = true;
            }
            catch(Exception)
            {
                publicKey = FetchPublicKeyFromApi(kid, runEnvironment).GetAwaiter().GetResult();
            }

            // After fetching publicKey (from cache or API), verify JWT signature
            try
            {
                if (publicKey == null)
                {
                    throw new Exception("Public key is null. No public key is available in the cache or could be retrieved from the API for the specified KID.");
                }

                isJWTVerified = JWTUtility.VerifyJWT(jwtToken, publicKey);
            }
            catch (Exception)
            {
                if (isPublicKeyFromCache)
                {
                    // Try to fetch fresh public key from API and re-verify
                    publicKey = FetchPublicKeyFromApi(kid, runEnvironment).GetAwaiter().GetResult();
                    isJWTVerified = JWTUtility.VerifyJWT(jwtToken, publicKey);
                }
            }

            if (!isJWTVerified)
            {
                throw new Exception("JWT signature verification failed");
            }

            return JObject.Parse(JWT.Payload(jwtToken));
        }

        private static async Task<string> FetchPublicKeyFromApi(string kid, string runEnvironment)
        {
            string publicKey = null;
            try
            {
                publicKey = await PublicKeyApiController.FetchPublicKeyAsync(kid, runEnvironment);
            }
            catch
            {
                throw new Exception("Failed to fetch public key from API");
            }

            Cache.AddPublicKeyToCache(publicKey, runEnvironment, kid);
            return publicKey;
        }
    }
}
using System;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using CyberSource.Client;
using CyberSource.Utilities.CaptureContext;
using System.Threading.Tasks;
using AuthenticationSdk.util;
using AuthenticationSdk.util.jwtExceptions;

namespace CyberSource.Utilities.CaptureContext
{
    public static class CaptureContextParsingUtility
    {
        // Only allow alphanumeric characters, hyphens, underscores, and periods in kid values
        private static readonly Regex SafeKidPattern = new Regex(@"^[a-zA-Z0-9._\-]+$", RegexOptions.Compiled);

        private static async Task<string> FetchPublicKeyFromApi(string kid, string runEnvironment)
        {
            string publicKey = null;
            try
            {
                publicKey = await PublicKeyApiController.FetchPublicKeyAsync(kid, runEnvironment);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            Cache.AddPublicKeyToCache(publicKey, runEnvironment, kid);
            return publicKey;
        }

        #region NEW METHODS
        public static JsonObject parseCaptureContextResponse(string jwtToken, IConfiguration config)
        {
            bool verifyJWT = true;
            // Parse JWT Token for any malformations

            string payLoad = JWTUtility.Parse(jwtToken);
            var jsonPayLoad = JsonNode.Parse(payLoad).AsObject();
            if (!verifyJWT)
            {
                return jsonPayLoad;
            }
            // Extract 'kid' from JWT header

            var header = JWTUtility.GetJwtHeaders(jwtToken);
            var kid = header.ContainsKey("kid") ? header["kid"].ToString() : null;
            if (string.IsNullOrEmpty(kid))
            {
                throw new Exception("JWT token does not contain 'kid' in header");
            }

            if (!SafeKidPattern.IsMatch(kid))
            {
                throw new ArgumentException("Key ID (kid) contains invalid characters. Only alphanumeric characters, hyphens, underscores, and periods are allowed.", "kid");
            }

            var runEnvironment = config.MerchantCredentialSettings.RunEnvironment;

            string publicKey = "";
            bool isPublicKeyFromCache = false;
            bool isJWTVerified = false;

            try
            {
                publicKey = Cache.GetPublicKeyFromCache(runEnvironment, kid);
                isPublicKeyFromCache = true;
            }
            catch (Exception)
            {
                publicKey = FetchPublicKeyFromApi(kid, runEnvironment).GetAwaiter().GetResult();
            }

            // After fetching publicKey (from cache or API), verify JWT signature
            try
            {
                try
                {
                    if (publicKey == null)
                    {
                        throw new Exception("Public key is null. No public key is available in the cache or could be retrieved from the API for the specified KID.");
                    }

                    isJWTVerified = JWTUtility.VerifyJwt(jwtToken, publicKey);
                }
                catch (Exception)
                {
                    if (isPublicKeyFromCache)
                    {
                        // Try to fetch fresh public key from API and re-verify
                        publicKey = FetchPublicKeyFromApi(kid, runEnvironment).GetAwaiter().GetResult();
                        isJWTVerified = JWTUtility.VerifyJwt(jwtToken, publicKey);
                    }
                }

                if (!isJWTVerified)
                {
                    throw new JwtSignatureValidationException("JWT signature verification has failed");
                }
            }
            catch (JwtSignatureValidationException)
            {
                throw;
            }
            catch (InvalidJwkException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            return jsonPayLoad;
        }
        #endregion NEW METHODS
    }
}
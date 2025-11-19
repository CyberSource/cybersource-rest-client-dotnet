using System;
using Newtonsoft.Json.Linq;
using CyberSource.Client;
using CyberSource.Utilities.CaptureContext;
using System.Threading.Tasks;
using AuthenticationSdk.util;
using AuthenticationSdk.util.jwtExceptions;

namespace CyberSource.Utilities.CaptureContext
{
    public static class CaptureContextParsingUtility
    {
        public static JObject parseCaptureContextResponse(string jwtToken, Configuration config, bool verifyJWT)
        {
            // Parse JWT Token for any malformations

            string payLoad = JWTUtility.Parse(jwtToken);
            var jsonPayLoad = JObject.Parse(payLoad);
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

            var runEnvironment = config.MerchantConfigDictionaryObj.ContainsKey("runEnvironment") ? config.MerchantConfigDictionaryObj["runEnvironment"] : Constants.HostName;

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

        private static async Task<string> FetchPublicKeyFromApi(string kid, string runEnvironment)
        {
            string publicKey = null;
            try
            {
                publicKey = await PublicKeyApiController.FetchPublicKeyAsync(kid, runEnvironment);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            Cache.AddPublicKeyToCache(publicKey, runEnvironment, kid);
            return publicKey;
        }
    }
}
using AuthenticationSdk.core;
using System;
using System.Security.Cryptography;

namespace CyberSource.Utilities
{
    public static class JWEUtility
    {
        [Obsolete("This method has been marked as Deprecated and will be removed in coming releases. Use DecryptJWEResponse(RSAParameters, string) instead.", false)]
        public static string DecryptJWEResponse(string encodedResponse, MerchantConfig merchantConfig)
        {
            return AuthenticationSdk.util.JWEUtilty.DecryptUsingPEM(merchantConfig, encodedResponse);
        }

        public static string DecryptJWEResponse(RSAParameters rsaParameters, string encodedResponse)
        {
            return AuthenticationSdk.util.JWEUtilty.DecryptUsingRSAParameters(rsaParameters, encodedResponse);
        }
    }
}

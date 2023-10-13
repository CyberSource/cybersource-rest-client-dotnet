using AuthenticationSdk.core;

namespace CyberSource.Utilities
{
    public static class JWEUtility
    {
        public static string DecryptJWEResponse(string encodedResponse, MerchantConfig merchantConfig)
        {
            return AuthenticationSdk.util.JWEUtilty.DecryptUsingPEM(merchantConfig, encodedResponse);
        }
    }
}

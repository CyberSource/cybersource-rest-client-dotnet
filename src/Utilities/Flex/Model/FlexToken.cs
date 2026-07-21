using System.Collections.Generic;

namespace CyberSource.Utilities.Flex.Model
{
    /// <summary>
    /// Represents the Flex API token response.
    /// </summary>
    public class FlexToken
    {
        /// <summary>
        /// Gets or sets the ID of the key associated with the token.
        /// </summary>
        public string keyId { get; set; }
        
        /// <summary>
        /// Gets or sets the generated token. The token replaces card data and is used as the Subscription ID in the CyberSource Simple Order API or SCMP API.
        /// </summary>
        public string token { get; set; }
        
        /// <summary>
        /// Gets or sets the masked card number.
        /// </summary>
        public string maskedPan { get; set; }
        
        /// <summary>
        /// Gets or sets the card type.
        /// </summary>
        public string cardType { get; set; }
        
        /// <summary>
        /// Gets or sets the UTC date and time in milliseconds at which the signature was generated.
        /// </summary>
        public long timestamp { get; set; }
        
        /// <summary>
        /// Gets or sets the list of follow-on services with which the token may be used.
        /// </summary>
        public IDictionary<string, object> discoverableServices { get; set; }
        
        /// <summary>
        /// Gets or sets which fields from the response make up the data that is used when verifying the response signature.
        /// </summary>
        public string signedFields { get; set; }
        
        /// <summary>
        /// Gets or sets the Flex-generated digital signature. To ensure the values have not been tampered with while passing through the client, verify the signature server-side using the associated Flex API public key.
        /// </summary>
        public string signature { get; set; }
        
        /// <summary>
        /// Gets or sets the embedded object(s).
        /// </summary>
        public IDictionary<string, object> _embedded { get; set; }

        /// <summary>
        /// Constructs a FlexToken instance.
        /// </summary>
        public FlexToken() { }
    }
}

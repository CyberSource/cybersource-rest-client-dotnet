namespace CyberSource.Utilities.Flex.Model
{
    public class FlexPublicKey
    {
        /// <summary>
        /// Gets or sets the unique ID of the key.
        /// </summary>
        public string keyId { get; set; }
    
        /// <summary>
        /// Gets or sets the DER representation of the key.
        /// </summary>
        public FlexDerPublicKey der { get; set; }
        
        /// <summary>
        /// Gets or sets the JSON Web Key representation of the key for use with the Web Crypto API.
        /// </summary>
        public JsonWebKey jwk { get; set; }

        /// <summary>
        /// Default constructor. Use if you wish to set properties individually.
        /// </summary>
        public FlexPublicKey() { }

        /// <summary>
        /// Constructs a FlexPublicKey instance with the specified ID, DER representation and JWK representation.
        /// </summary>
        /// <param name="keyId">The ID</param>
        /// <param name="der">The DER representation</param>
        /// <param name="jwk">The JWK representation</param>
        public FlexPublicKey(string keyId, FlexDerPublicKey der, JsonWebKey jwk)
        {
            this.keyId = keyId;
            this.der = der;
            this.jwk = jwk;
        }

        public override string ToString()
        {
            return System.String.Format("FlexPublicKey[keyId={0}]", keyId);
        }
    }
}

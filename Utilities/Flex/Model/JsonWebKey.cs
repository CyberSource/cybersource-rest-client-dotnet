namespace CyberSource.Utilities.Flex.Model
{
    /// <summary>
    /// Represents a JSON Web Key for use with the Web Crypto API.
    /// </summary>
    public class JsonWebKey
    {
        /// <summary>
        /// Gets or sets the key type.
        /// </summary>
        public string kty { get; set; }
    
        /// <summary>
        /// Gets or sets the key use.
        /// </summary>
        public string use { get; set; }
        
        /// <summary>
        /// Gets or sets the key ID.
        /// </summary>
        public string kid { get; set; }
        
        /// <summary>
        /// Gets or sets the modulus.
        /// </summary>
        public string n { get; set; }
        
        /// <summary>
        /// Gets or sets the exponent.
        /// </summary>
        public string e { get; set; }

        /// <summary>
        /// Default constructor. Use if you wish to set properties individually.
        /// </summary>
        public JsonWebKey() { }

        /// <summary>
        /// Constructs a JsonWebKey instance with the specified key type, key use, key ID, modulus and exponent.
        /// </summary>
        /// <param name="keyType">The key type</param>
        /// <param name="keyUse">The key use</param>
        /// <param name="keyId">The key ID</param>
        /// <param name="modulus">The modulus</param>
        /// <param name="exponent">The exponent</param>
        public JsonWebKey(string keyType, string keyUse, string keyId, string modulus, string exponent)
        {
            this.kty = keyType;
            this.use = keyUse;
            this.kid = keyId;
            this.n = modulus;
            this.e = exponent;
        }
    }
}

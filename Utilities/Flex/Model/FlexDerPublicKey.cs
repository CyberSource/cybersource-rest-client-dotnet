namespace CyberSource.Utilities.Flex.Model
{
    /// <summary>
    /// Represents the public RSA key in DER format.
    /// </summary>
    public class FlexDerPublicKey
    {
        /// <summary>
        /// Gets and sets the public key format.
        /// </summary>
        public string format { get; set; }
        
        /// <summary>
        /// Gets and sets the algorithm with which the key is used.
        /// </summary>
        public string algorithm { get; set; }
        
        /// <summary>
        /// Gets and sets the encoded key specification.
        /// </summary>
        public string publicKey { get; set; }

        /// <summary>
        /// Default constructor. Use if you wish to set properties individually.
        /// </summary>
        public FlexDerPublicKey() { }

        /// <summary>
        /// Constructs a DerPublicKey instance with the supplied format, algorithm and encoded key.
        /// </summary>
        /// <param name="format">The format</param>
        /// <param name="algorithm">The algorithm</param>
        /// <param name="publicKey">The encoded key</param>
        public FlexDerPublicKey(string format, string algorithm, string publicKey)
        {
            this.format = format;
            this.algorithm = algorithm;
            this.publicKey = publicKey;
        }
    }
}

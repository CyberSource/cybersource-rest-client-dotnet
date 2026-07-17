using System.Runtime.Serialization;

namespace CyberSource.Utilities.Flex.Exception
{
    /// <summary>
    /// Exception that is thrown when there is an error performing an internal SDK function.
    /// </summary>
    public class FlexInternalException : FlexException
    {
        public FlexInternalException(string message) : base(message) { }

        public FlexInternalException(string message, System.Exception inner) : base(message, inner) { }

        protected FlexInternalException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}

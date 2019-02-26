using System;

namespace CybsQaScript
{
    public static class Constants
    {
        public static readonly string MessageForIncorrectStatus = "Status is not";

        public static readonly string MessageNullId = "Payment ID is null";

        public static readonly string MessageResponseCode = "Response code validation";

        public static readonly string DateTimeNow = DateTime.Now.ToString("yyyy/MM/dd" + "::" + "HH:mm:ss:fff");
    }
}

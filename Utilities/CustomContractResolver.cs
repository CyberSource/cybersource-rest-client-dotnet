using Newtonsoft.Json.Serialization;

namespace CyberSource.Utilities
{
    public class CustomContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            if (propertyName == "Links")
            {
                return "_links";
            }
            /*if (propertyName == "SdkLinks")
            {
                return "links";
            }*/
            return base.ResolvePropertyName(propertyName);
        }

    }
}

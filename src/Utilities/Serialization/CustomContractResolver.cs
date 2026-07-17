using System.Text.Json;

namespace CyberSource.Utilities.Serialization
{
    public class CustomContractResolver : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            if (name == "Links") { return "_links"; }

            //if (name == "SdkLinks") { return "links"; }

            return name;
        }

    }
}
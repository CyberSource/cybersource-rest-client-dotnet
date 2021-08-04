
namespace CyberSource.Utilities.Flex.Model.Utilities
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.JsonSerializer;
    using CyberSource.Utilities.Flex.Model.TransientTokenModel;
    public class TransientTokenGeneratorUtility {
   
    /**
     * This is the method to extract transient token from given jwt token 
     * @param jwt
     * @return
     */
    public var extractTransientToken(string jwt)
    {
        // split the jwt token into two parts 
        // bearer and token part
        string splitContents[] = jwt.Split(".");
        if(splitContents.length > 1)    
        {
            // decode the base 64 encoded string
            String encodedString  = splitContents[1];
            byte[] data = Convert.FromBase64String(encodedString);
            string decodedString = Encoding.UTF8.GetString(encodedString);
            Newtonsoft.Json.JsonSerializer s = new JsonSerializer();
            var transientTokenModel= s.Deserialize<TransientTokenModel>(new JsonTextReader(new StringReader(decodedString)));
            // return JTI string
            return transientTokenModel;
        }
      
        return null;
    }
}
}

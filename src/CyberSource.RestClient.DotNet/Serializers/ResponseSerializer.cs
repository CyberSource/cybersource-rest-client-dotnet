using System;
using Newtonsoft.Json;

namespace CyberSource.Serializers
{
    public interface IResponseSerializer
    {
        string Serialize(object data);
        object Deserialize(string content, Type type);
    }

    /// <summary>
    /// Simple implementation lof the logic to serialize/deserialize data for responses.
    /// </summary>
    public sealed class ResponseSerializer : IResponseSerializer
    {
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        public string Serialize(object data)
        {
            return JsonConvert.SerializeObject(data, _serializerSettings);
        }

        public object Deserialize(string content, Type type)
        {
            return JsonConvert.DeserializeObject(content, type, _serializerSettings);
        }
    }
}

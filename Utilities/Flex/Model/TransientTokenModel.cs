namespace CyberSource.Utilities.Flex.Model.TransientTokenModel
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class TransientTokenModel
    {
        [JsonProperty("flx")]
        public Flx Flx { get; set; }

        [JsonProperty("ctx")]
        public Ctx[] Ctx { get; set; }

        [JsonProperty("iss")]
        public string Iss { get; set; }

        [JsonProperty("exp")]
        public long Exp { get; set; }

        [JsonProperty("iat")]
        public long Iat { get; set; }

        [JsonProperty("jti")]
        public string Jti { get; set; }
    }

    public partial class Ctx
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("targetOrigins")]
        public Uri[] TargetOrigins { get; set; }

        [JsonProperty("mfOrigin")]
        public Uri MfOrigin { get; set; }
    }

    public partial class Flx
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("origin")]
        public Uri Origin { get; set; }

        [JsonProperty("jwk")]
        public Jwk Jwk { get; set; }
    }

    public partial class Jwk
    {
        [JsonProperty("kty")]
        public string Kty { get; set; }

        [JsonProperty("e")]
        public string E { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("n")]
        public string N { get; set; }

        [JsonProperty("kid")]
        public string Kid { get; set; }
    }
}

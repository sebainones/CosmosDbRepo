using Newtonsoft.Json;

namespace NoSqlApp.Model
{
    public class Address
    {
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "oounty")]
        public string County { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
    }
}
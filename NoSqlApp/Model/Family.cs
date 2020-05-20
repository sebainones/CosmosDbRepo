//using System.Text.Json;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace NoSqlApp.Model
{
    public class Family
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "parents")]
        public Parent[] Parents { get; set; }

        [JsonProperty(PropertyName = "children")]
        public Child[] Children { get; set; }

        [JsonProperty(PropertyName = "address")]
        public Address Address { get; set; }

        [JsonProperty(PropertyName = "isRegistered")]
        public bool IsRegistered { get; set; }

        //public override string ToString()
        //{
        //    return JsonSerializer.Serialize(this);
        //}
    }
}
using Newtonsoft.Json;

namespace NoSqlApp.Model
{
    public class Pet
    {
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }
    }
}
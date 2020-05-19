using Newtonsoft.Json;

namespace NoSqlApp.Model
{
    public class Parent
    {
        [JsonProperty(PropertyName = "familyName")]
        public string FamilyName { get; set; }

        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
    }
}
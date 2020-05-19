using Newtonsoft.Json;

namespace NoSqlApp.Model
{
    public class Child
    {

        [JsonProperty(PropertyName = "familyName")]
        public string FamilyName { get; set; }

        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "grade")]
        public int Grade { get; set; }

        [JsonProperty(PropertyName = "pets")]
        public Pet[] Pets { get; set; }
    }
}
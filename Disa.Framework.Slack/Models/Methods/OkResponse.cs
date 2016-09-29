using Newtonsoft.Json;
using System.ComponentModel;

namespace Models.Models.Methods
{

    public class OkResponse
    {
        [JsonProperty(PropertyName="ok")]
        public bool OK { get; set; }

        [DefaultValue("")]
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Error { get; set; }
    }
}

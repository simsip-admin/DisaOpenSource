using Models.Models.Types;
using Newtonsoft.Json;
using System.ComponentModel;


namespace Models.Models.Methods.Groups
{
    public class GroupsResponse
    {
        [JsonProperty(PropertyName = "ok")]
        public bool Ok { get; set; }

        [DefaultValue("")]
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "group")]
        public Group Group { get; set; }
    }
}

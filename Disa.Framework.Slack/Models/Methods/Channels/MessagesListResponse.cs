using Models.Models.Types;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;


namespace Models.Models.Methods.Channels
{
    public class MessagesListResponse
    {
        [JsonProperty(PropertyName = "ok")]
        public bool Ok { get; set; }

        [DefaultValue("")]
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "latest")]
        public string Latest { get; set; }

        [JsonProperty(PropertyName = "has_more")]
        public bool HasMore { get; set; }

        [JsonProperty(PropertyName = "messages")]
        public List<Message> Messages { get; set; }
    }
}

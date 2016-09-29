using Models.Models.Types;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;


namespace Models.Models.Methods.Channels
{
    public class ChannelsListResponse
    {
        [JsonProperty(PropertyName = "ok")]
        public bool Ok { get; set; }

        [DefaultValue("")]
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "channels")]
        public IList<Channel> Channels { get; set; }
    }
}

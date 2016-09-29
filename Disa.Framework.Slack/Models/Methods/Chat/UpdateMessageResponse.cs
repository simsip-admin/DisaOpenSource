using Models.Models.Types;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Models.Models.Methods.Chat
{

    public class UpdateMessageResponse
    {
        [JsonProperty(PropertyName="ok")]
        public bool OK { get; set; }

        [DefaultValue("")]
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public string Ts { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }


    }
}

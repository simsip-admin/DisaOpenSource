using Models.Models.Types;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Models.Models.Methods.Emoji
{

    public class EmojiListResponse
    {
        [JsonProperty(PropertyName="ok")]
        public bool OK { get; set; }

        [DefaultValue("")]
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Error { get; set; }

        // TODO: emoji field

    }
}

using Newtonsoft.Json;


namespace Models.Models.Types
{
    /// <summary>
    /// Provides information about a channel or groups topic.
    /// </summary>
    public class Topic
    {
        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "value", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Value { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "creator", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Creator { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "last_set", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int LastSet { get; set; }
    }
}

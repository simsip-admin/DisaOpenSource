using Newtonsoft.Json;


namespace Models.Models.Types
{
    /// <summary>
    /// If the message has been edited after posting it will include an edited property, 
    /// including the user ID of the editor, and the timestamp the edit happened. 
    /// 
    /// The original text of the message is not available.
    /// </summary>
    public class Edited
    {
        /// <summary>
        /// The user ID of the editor.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// The timestamp the edit happened.
        /// </summary>
        [JsonProperty(PropertyName = "ts")]
        public string Ts { get; set; }
    }
}

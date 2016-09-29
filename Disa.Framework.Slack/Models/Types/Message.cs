using Newtonsoft.Json;
using System.Collections.Generic;


namespace Models.Models.Types
{
    // TODO: Pinned item

    /// <summary>
    /// A message is delivered from several sources:
    /// They are sent via the Real Time Messaging API when a message is sent to a 
    /// channel to which you subscribe. This message should immediately be displayed
    /// in the client.
    /// 
    /// They are returned via calls to channels.history, im.history or groups.history
    /// 
    /// They are returned as latest property on channel, group and im objects.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// The message type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The message subtype.
        /// </summary>
        [JsonProperty(PropertyName = "subtype")]
        public string Subtype { get; set; }

        /// <summary>
        /// The channel property is the ID of the channel, private group or DM channel 
        /// this message is posted in.
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        /// <summary>
        /// The user property is the ID of the user speaking.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// The Text property is the text spoken
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Ts is the unique (per-channel) timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "ts")]
        public string Ts { get; set; }

        /// <summary>
        /// Messages can also include an Attachments property, containing a list of 
        /// Attachment objects.
        /// </summary>
        [JsonProperty(PropertyName = "attachments", DefaultValueHandling = DefaultValueHandling.Populate)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// If the Message has been edited after posting it will include an Edited property, including 
        /// the user ID of the editor, and the timestamp the edit happened. 
        /// 
        /// The original text of the message is not available. 
        /// </summary>
        [JsonProperty(PropertyName = "edited", DefaultValueHandling = DefaultValueHandling.Populate)]
        public Edited Edited { get; set; }

        /* TODO
        public Group group { get; set; }
        public File file { get; set; }
        public bool hidden { get; set; }
        public string deleted_ts { get; set; }
        public string event_ts { get; set; }

        public bool is_starred { get; set; }

        public List<string> pinned_to { get; set; }

        List<Reaction> reactions { get; set; }
        */
    }
}

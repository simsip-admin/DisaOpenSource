using Newtonsoft.Json;


namespace Models.Models.Types
{
    /// <summary>
    /// An IM object contains information about a direct message channel.
    /// </summary>
    public class Im
    {
        /// <summary>
        /// The Im id. 
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool is_im { get; set; }

        /// <summary>
        /// Each direct message channel is between two users. One of these users is always 
        /// the calling user, the other is indicated by the User property.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// Created is a unix timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public int Created { get; set; }

        /// <summary>
        /// IsUserDeleted will be true if the other user's account has been disabled.
        /// </summary>
        [JsonProperty(PropertyName = "is_user_deleted")]
        public bool IsUserDeleted { get; set; }

        /// <summary>
        /// Some API methods will include extra state information for the channel. IsOpen shows if 
        /// the DM channel is open. LastRead is the timestamp for the last message the calling user
        /// has read in this channel. UnreadCcount is a count of messages that the calling user has
        /// yet to read. Latest is the latest message in the channel.
        /// </summary>
        [JsonProperty(PropertyName = "is_open", DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool IsOpen { get; set; }

        /// <summary>
        /// Some API methods will include extra state information for the channel. IsOpen shows if 
        /// the DM channel is open. LastRead is the timestamp for the last message the calling user
        /// has read in this channel. UnreadCcount is a count of messages that the calling user has
        /// yet to read. Latest is the latest message in the channel.
        /// </summary>
        [JsonProperty(PropertyName = "last_read", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int LastRead { get; set; }

        /// <summary>
        /// Some API methods will include extra state information for the channel. IsOpen shows if 
        /// the DM channel is open. LastRead is the timestamp for the last message the calling user
        /// has read in this channel. UnreadCcount is a count of messages that the calling user has
        /// yet to read. Latest is the latest message in the channel.
        /// </summary>
        [JsonProperty(PropertyName = "unread_count", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int UnreadCount { get; set; }

        /// <summary>
        /// Some API methods will include extra state information for the channel. IsOpen shows if 
        /// the DM channel is open. LastRead is the timestamp for the last message the calling user
        /// has read in this channel. UnreadCcount is a count of messages that the calling user has
        /// yet to read. Latest is the latest message in the channel.
        /// </summary>
        [JsonProperty(PropertyName = "latest", DefaultValueHandling = DefaultValueHandling.Populate)]
        public Message Latest { get; set; }
    }
}

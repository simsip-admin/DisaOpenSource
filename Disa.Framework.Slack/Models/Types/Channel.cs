using Newtonsoft.Json;
using System.Collections.Generic;


namespace Models.Models.Types
{
    /// <summary>
    /// A channel object contains information about a team channel.
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// The Channel id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name parameter indicates the name of the channel, without a leading hash sign.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "is_channel")]
        public bool IsChannel { get; set; }

        /// <summary>
        /// Created is a unix timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public int Created { get; set; }

        /// <summary>
        /// Creator is the user ID of the member that created this channel. 
        /// </summary>
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// IsArchived will be true if the channel is archived.
        /// </summary>
        [JsonProperty(PropertyName = "is_archived")]
        public bool IsArchived { get; set; }

        /// <summary>
        /// IsGeneral will be true if this channel is the "general" channel that includes all regular team members. 
        /// 
        /// In most teams this is called #general but some teams have renamed it.
        /// </summary>
        [JsonProperty(PropertyName = "is_general")]
        public bool IsGeneral { get; set; }

        /// <summary>
        /// IsMember will be true if the calling member is part of the channel.
        /// </summary>
        [JsonProperty(PropertyName = "is_member")]
        public bool IsMember { get; set; }

        /// <summary>
        /// Members is a list of user ids for all users in this channel. 
        /// 
        /// This includes any disabled accounts that were in this channel when they were disabled.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public List<string> Members { get; set; }

        /// <summary>
        /// Provides information about the channel topic.
        /// </summary>
        [JsonProperty(PropertyName = "topic")]
        public Topic Topic { get; set; }

        /// <summary>
        /// Provide information about the channel purpose.
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        public Purpose Purpose { get; set; }

        /// <summary>
        /// The number of members in the channel.
        /// </summary>
        [JsonProperty(PropertyName = "num_members")]
        public int NumMembers { get; set; }

        /// <summary>
        /// LastRead is the timestamp for the last message the calling user has read in this channel. 
        /// 
        /// Some API methods (such as channels.join) will include extra state information for channels when the calling user is a member. 
        /// </summary>
        [JsonProperty(PropertyName = "last_read", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int LastRead { get; set; }
               
        /// <summary>
        /// UnreadCount is a full count of visible messages that the calling user has yet to read. 
        /// 
        /// Some API methods (such as channels.join) will include extra state information for channels when the calling user is a member. 
        /// </summary>
        [JsonProperty(PropertyName = "unread_count", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int UnreadCount { get; set; }
        
        /// <summary>
        /// UnreadCountCisplay is a count of messages that the calling user has yet to read that matter to them (this means it excludes things like join/leave messages). 
        /// 
        /// Some API methods (such as channels.join) will include extra state information for channels when the calling user is a member. 
        /// </summary>
        [JsonProperty(PropertyName = "unread_count_display", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int UnreadCountDisplay { get; set; }
        
        /// <summary>
        /// Latest is the latest message in the channel.
        /// 
        /// Some API methods (such as channels.join) will include extra state information for channels when the calling user is a member. 
        /// </summary>
        [JsonProperty(PropertyName = "latest", DefaultValueHandling = DefaultValueHandling.Populate)]
        public Message Latest { get; set; }
    }
}

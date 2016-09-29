using Newtonsoft.Json;
using System.Collections.Generic;


namespace Models.Models.Types
{
    /// <summary>
    /// A group object contains information about a private group.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// The group id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The Name parameter indicates the name of the group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "is_group")]
        public string IsGroup { get; set; }

        /// <summary>
        ///  Created is a unix timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public int Created { get; set; }

        /// <summary>
        /// Creator is the user ID of the member that created this group. 
        /// </summary>
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// IsArchived will be true if the group is archived.
        /// </summary>
        [JsonProperty(PropertyName = "is_archived")]
        public bool IsArchived { get; set; }

        /// <summary>
        /// IsMpim is a boolean that indicated if a multiparty im (mpim) is being emulated as a group. 
        /// 
        /// For compatibility with older clients, mpims can appear as groups unless rtm.start is called
        /// with mpim_aware=1.
        /// </summary>
        [JsonProperty(PropertyName = "is_mpim")]
        public bool IsMpim { get; set; }

        /// <summary>
        /// Members is a list of user ids for all users in this group. 
        /// 
        /// This includes any disabled accounts that were in this group when they were disabled.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public List<string> members { get; set; }

        /// <summary>
        /// Topic provides information about the group topic.
        /// </summary>
        [JsonProperty(PropertyName = "topic")]
        public Topic Topic { get; set; }

        /// <summary>
        ///  Purpose provides information about the group purpose.
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        public Purpose purpose { get; set; }

        /// <summary>
        /// Some API methods (such as groups.create) will include extra state information for channels when the
        /// calling user is a member. LastRead is the timestamp for the last message the calling user has read
        /// in this channel. UnreadCount is a full count of visible messages that the calling user has yet to read.
        /// UnreadCountDisplay is a count of messages that the calling user has yet to read that matter to them 
        /// (this means it excludes things like join/leave messages). 
        /// </summary>
        [JsonProperty(PropertyName = "last_read", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string LastRead { get; set; }

        /// <summary>
        /// Some API methods (such as groups.create) will include extra state information for channels when the
        /// calling user is a member. LastRead is the timestamp for the last message the calling user has read
        /// in this channel. UnreadCount is a full count of visible messages that the calling user has yet to read.
        /// UnreadCountDisplay is a count of messages that the calling user has yet to read that matter to them 
        /// (this means it excludes things like join/leave messages). 
        /// </summary>
        [JsonProperty(PropertyName = "unread_count", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int UnreadCount { get; set; }

        /// <summary>
        /// Some API methods (such as groups.create) will include extra state information for channels when the
        /// calling user is a member. LastRead is the timestamp for the last message the calling user has read
        /// in this channel. UnreadCount is a full count of visible messages that the calling user has yet to read.
        /// UnreadCountDisplay is a count of messages that the calling user has yet to read that matter to them 
        /// (this means it excludes things like join/leave messages). 
        /// </summary>
        [JsonProperty(PropertyName = "unread_count_display", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int UnreadCountCisplay { get; set; }
        
        /// <summary>
        /// Latest is the latest message in the group.
        /// </summary>
        [JsonProperty(PropertyName = "unread_count_display", DefaultValueHandling = DefaultValueHandling.Populate)]
        public Message Latest { get; set; }
    }
}

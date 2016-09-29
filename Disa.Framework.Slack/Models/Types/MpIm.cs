using Newtonsoft.Json;
using System.Collections.Generic;


namespace Models.Models.Types
{
    
    /// <summary>
    /// A mpim object contains information about a multiparty IM.
    /// </summary>
    public class MpIm
    {
        /// <summary>
        /// The MpIm id.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Id { get; set; }

        /// <summary>
        /// The name parameter indicates the name of the mpim.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// IsMpIm is a boolean that indicated if a multiparty im (mpim) is being emulated as a group. 
        /// 
        /// For compatibility with older clients, mpims can appear as groups unless rtm.start is called 
        /// with mpim_aware=1.
        /// </summary>
        [JsonProperty(PropertyName = "is_mpim")]
        public bool IsMpIm { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "is_group")]
        public bool IsGroup { get; set; }

        /// <summary>
        /// Created is a unix timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public int Created { get; set; }

        /// <summary>
        /// Creator is the user ID of the member that created this MpIm.
        /// </summary>
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Members is a list of user ids for all users in this MpIm. 
        /// 
        /// This includes any disabled accounts that were in this MpIm when they were disabled.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public List<string> members { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "last_read")]
        public string LastRead { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "latest")]
        public Message Latest { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "unread_count")]
        public int UnreadCount { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "unread_count_display")]
        public int UnreadCountDisplay { get; set; }
    }
}

using Newtonsoft.Json;


namespace Models.Models.Types
{
    /// <summary>
    /// A user object contains information about a team member.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The User id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name parameter indicates the username for this user, without a leading @ sign.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// For deactivated users, Deleted will be true.
        /// </summary>
        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// The color field is used in some clients to display a colored username.
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// The profile hash contains as much profile information as the user has supplied - only 
        /// the image_* fields are guaranteed to be included. Data that has not been supplied may
        /// not be present at all, may be null or may contain the empty string ("").
        /// 
        /// The image_* fields will always contain https URLs to square, web-viewable images 
        /// (GIFs, JPEGs or PNGs).
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public Profile Profile { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "is_admin")]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "is_owner")]
        public bool IsOwner { get; set; }


        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "is_primary_owner")]
        public bool IsPrimaryOwner { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "is_restricted")]
        public bool IsRestricted { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "is_ultra_restricted")]
        public bool is_ultra_restricted { get; set; }

        /// <summary>
        /// The has_2fa field describes whether two-step verification is enabled for this user. 
        /// 
        /// This field will always be displayed if you are looking at your own user information. 
        /// If you are looking at another user's information this field will only be displayed 
        /// if you are team admin or owner.
        /// </summary>
        [JsonProperty(PropertyName = "has_2fa", DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool Has2fa { get; set; }
        
        /// <summary>
        /// The two_factor_type field is either app or sms. It will only be present if has_2fa is true.
        /// </summary>
        [JsonProperty(PropertyName = "two_factor_type", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string TwoFactorType { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "has_files", DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool HasFiles { get; set; }
    }
}

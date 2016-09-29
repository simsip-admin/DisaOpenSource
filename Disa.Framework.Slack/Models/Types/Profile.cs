using Newtonsoft.Json;


namespace Models.Models.Types
{
    /// <summary>
    /// The profile hash contains as much profile information as the user has supplied - only 
    /// the image_* fields are guaranteed to be included. 
    /// 
    /// Data that has not been supplied may not be present at all, may be null or may contain 
    /// the empty string ("").
    /// 
    /// The image_* fields will always contain https URLs to square, web-viewable images 
    /// (GIFs, JPEGs or PNGs).
    /// </summary>
    public class Profile
    {
        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "first_name", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string FirstName { get; set; }

        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "last_name", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string LastName { get; set; }

        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "real_name", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string RealName { get; set; }

        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "email", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Email { get; set; }

        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "skype", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Skype { get; set; }

        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "phone", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Phone { get; set; }

        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "image_24")]
        public string Image24 { get; set; }

        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "image_32")]
        public string Image32 { get; set; }

        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "image_48")]
        public string Image48 { get; set; }

        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "image_72")]
        public string Image72 { get; set; }

        /// <summary>
        ///  TODO
        /// </summary>
        [JsonProperty(PropertyName = "image_192")]
        public string Image192 { get; set; }
    }
}

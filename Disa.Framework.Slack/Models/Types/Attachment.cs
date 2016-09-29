using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models.Models.Types
{
    /// <summary>
    /// Messages can have zero or more attachments, defined as an array. 
    /// 
    /// Each hash in that array will contain multiple properties.
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// A plain-text summary of the attachment. 
        /// 
        /// This text will be used in clients that don't show formatted text 
        /// (eg. IRC, mobile notifications) and should not contain any markup.
        /// </summary>
        [JsonProperty(PropertyName = "fallback")]
        public string fallback { get; set; }

        /// <summary>
        /// An optional value that can either be one of good, warning, danger, or any hex color code (eg. #439FE0). 
        /// 
        /// This value is used to color the border along the left side of the message attachment.
        /// </summary>
        [JsonProperty(PropertyName = "color", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Color { get; set; }

        /// <summary>
        /// This is optional text that appears above the message attachment block.
        /// </summary>
        [JsonProperty(PropertyName = "pretext", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string PreText { get; set; }

        /// <summary>
        /// Small text used to display the author's name.
        /// 
        /// The author parameters will display a small section at the top of a message attachment.
        /// </summary>
        [JsonProperty(PropertyName = "author_name", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string AuthorName { get; set; }

        /// <summary>
        /// A valid URL that will hyperlink the author_name text mentioned above. 
        /// Will only work if author_name is present.
        /// 
        /// The author parameters will display a small section at the top of a message attachment.
        /// </summary>
        [JsonProperty(PropertyName = "author_link", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string AuthorLink { get; set; }

        /// <summary>
        /// A valid URL that displays a small 16x16px image to the left of the author_name text. 
        /// Will only work if author_name is present.
        /// 
        /// The author parameters will display a small section at the top of a message attachment.
        /// </summary>
        [JsonProperty(PropertyName = "author_icon", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string AuthorIcon { get; set; }

        /// <summary>
        /// The title is displayed as larger, bold text near the top of a message attachment.
        /// By passing a valid URL in the title_link parameter (optional), the title text will be hyperlinked.
        /// </summary>
        [JsonProperty(PropertyName = "title", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string title { get; set; }

        /// <summary>
        /// The title is displayed as larger, bold text near the top of a message attachment.
        /// By passing a valid URL in the title_link parameter (optional), the title text will be hyperlinked.
        /// </summary>
        [JsonProperty(PropertyName = "title_link", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string title_link { get; set; }

        /// <summary>
        /// This is the main text in a message attachment, and can contain standard message markup. 
        /// 
        /// The content will automatically collapse if it contains 700+ characters or 5+ linebreaks, 
        /// and will display a "Show more..." link to expand the content.
        /// </summary>
        [JsonProperty(PropertyName = "text", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Text { get; set; }

        /// <summary>
        /// Fields are defined as an array, and hashes contained within it will be displayed in a 
        /// table inside the message attachment.
        /// </summary>
        [JsonProperty(PropertyName = "fields", DefaultValueHandling = DefaultValueHandling.Populate)]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// A valid URL to an image file that will be displayed inside a message attachment. 
        /// 
        /// The following formats are currently supported: GIF, JPEG, PNG, and BMP.
        /// 
        /// Large images will be resized to a maximum width of 400px or a maximum height of 500px, 
        /// while still maintaining the original aspect ratio.
        /// </summary>
        [JsonProperty(PropertyName = "image_url", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// A valid URL to an image file that will be displayed as a thumbnail on the right side of a 
        /// message attachment. 
        /// 
        /// The following formats are currently supported: GIF, JPEG, PNG, and BMP.
        ///
        /// The thumbnail's longest dimension will be scaled down to 75px while maintaining the aspect 
        /// ratio of the image. The filesize of the image must also be less than 500 KB.
        /// </summary>
        [JsonProperty(PropertyName = "thumb_url", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string ThumbUrl { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models.Models.Types
{
    // TODO: initial_comment

    /// <summary>
    /// A file object contains information about a file shared with a team.
    /// </summary>
    public class File
    {
        /// <summary>
        /// The file id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The created property is a unix timestamp representing when the file was created.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public int Created { get; set; }
        
        /// <summary>
        /// The timestamp property contains the same data as created, but is deprecated and is 
        /// provided only for backwards compatibility with older clients.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public int Ttimestamp { get; set; }
        
        /// <summary>
        /// The file name.
        /// 
        /// The name parameter may be null for unnamed files.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The title given the file. 
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The MIME type for the file.
        /// 
        /// The mimetype and filetype props do not have a 1-to-1 mapping, as 
        /// multiple different files types ('html', 'js', etc.) share the same mime type. 
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string MimeType { get; set; }

        /// <summary>
        /// The file type for the file.
        /// 
        /// The mimetype and filetype props do not have a 1-to-1 mapping, as 
        /// multiple different files types ('html', 'js', etc.) share the same mime type. 
        /// </summary>
        [JsonProperty(PropertyName = "filetype")]
        public string FileType { get; set; }

        /// <summary>
        /// The pretty_type property contains a human-readable version of the type.
        /// </summary>
        [JsonProperty(PropertyName = "pretty_type")]
        public string PrettyType { get; set; }

        /// <summary>
        /// The user id of the user associated with the file.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// The Mode property contains one of hosted, external, snippet or post.
        /// </summary>
        [JsonProperty(PropertyName = "Mode")]
        public string Mode { get; set; }

        /// <summary>
        /// The Editable property indicates that files are stored in editable mode.
        /// </summary>
        [JsonProperty(PropertyName = "editable")]
        public bool Editable { get; set; }

        /// <summary>
        /// The IsExternal property indicates whether the master copy of a file is stored 
        /// within the system or not. 
        /// 
        /// If the file IsExternal, then the url property will point to the externally-hosted 
        /// master file. Further, the ExternalType property will indicate what kind of external
        /// file it is, e.g. dropbox or gdoc.
        /// </summary>
        [JsonProperty(PropertyName = "is_external")]
        public bool IsExternal { get; set; }

        /// <summary>
        /// the external_type property will indicate what kind of external
        /// file it is, e.g. dropbox or gdoc.
        /// 
        /// The IsExternal property indicates whether the master copy of a file is stored 
        /// within the system or not. If the file IsExternal, then the url property will point to the externally-hosted 
        /// master file. Further, the ExternalType property will indicate what kind of external
        /// file it is, e.g. dropbox or gdoc.
        /// </summary>
        [JsonProperty(PropertyName = "external_type")]
        public string ExternalType { get; set; }

        /// <summary>
        /// The size parameter is the filesize in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }

        /// <summary>
        /// The Url property points to a publically sharable URL directly to the file contents. 
        /// 
        /// Only editable-mode files currently have a UrlDownload parameter. This URL includes 
        /// headers which force a browser download. The Size parameter is the filesize in bytes. 
        /// The UrlPrivate and UrlPrivateDownload props are the same, but require cookie auth to access. 
        /// These URLs should be used by the web client, but can be ignored by other clients.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// The Url property points to a publically sharable URL directly to the file contents. 
        /// 
        /// Only editable-mode files currently have a UrlDownload parameter. This URL includes 
        /// headers which force a browser download. The Size parameter is the filesize in bytes. 
        /// The UrlPrivate and UrlPrivateDownload props are the same, but require cookie auth to access. 
        /// These URLs should be used by the web client, but can be ignored by other clients.
        /// </summary>
        [JsonProperty(PropertyName = "url_download")]
        public string UrlDownload { get; set; }

        /// <summary>
        /// The Url property points to a publically sharable URL directly to the file contents. 
        /// 
        /// Only editable-mode files currently have a UrlDownload parameter. This URL includes 
        /// headers which force a browser download. The Size parameter is the filesize in bytes. 
        /// The UrlPrivate and UrlPrivateDownload props are the same, but require cookie auth to access. 
        /// These URLs should be used by the web client, but can be ignored by other clients.
        /// </summary>
        [JsonProperty(PropertyName = "url_private")]
        public string UrlPrivate { get; set; }

        /// <summary>
        /// The Url property points to a publically sharable URL directly to the file contents. 
        /// 
        /// Only editable-mode files currently have a UrlDownload parameter. This URL includes 
        /// headers which force a browser download. The Size parameter is the filesize in bytes. 
        /// The UrlPrivate and UrlPrivateDownload props are the same, but require cookie auth to access. 
        /// These URLs should be used by the web client, but can be ignored by other clients.
        /// </summary>
        [JsonProperty(PropertyName = "url_private_download")]
        public string UrlPrivateDownload { get; set; }

        /// <summary>
        /// If a thumbnail is available for the file, the URL to a 64x64 pixel will be returned as 
        /// the Thumb64 prop. 
        /// 
        /// The Thumb80 prop (when present) contains the URL of an 80x80 thumb. Unlike the 64px thumb, 
        /// this size is guaranteed to be 80x80, even when the source image was smaller (it's padded 
        /// with transparent pixels). A variable sized thumb will be returned as thumb_360, with its
        /// longest size no bigger than 360 (although it might be smaller depending on the source size). 
        /// Dimensions for this thumb are returned in Thumb360W and Thumb360H. In the case where 
        /// the original image was an animated gif with dimensions greater than 360 pixels, we also 
        /// created an animated thumbnail and pass it as Thumb360Gif.
        /// </summary>
        [JsonProperty(PropertyName = "thumb_64", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Thumb64 { get; set; }

        /// <summary>
        /// If a thumbnail is available for the file, the URL to a 64x64 pixel will be returned as 
        /// the Thumb64 prop. 
        /// 
        /// The Thumb80 prop (when present) contains the URL of an 80x80 thumb. Unlike the 64px thumb, 
        /// this size is guaranteed to be 80x80, even when the source image was smaller (it's padded 
        /// with transparent pixels). A variable sized thumb will be returned as thumb_360, with its
        /// longest size no bigger than 360 (although it might be smaller depending on the source size). 
        /// Dimensions for this thumb are returned in Thumb360W and Thumb360H. In the case where 
        /// the original image was an animated gif with dimensions greater than 360 pixels, we also 
        /// created an animated thumbnail and pass it as Thumb360Gif.
        /// </summary>
        [JsonProperty(PropertyName = "thumb_80", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Thumb80 { get; set; }

        /// <summary>
        /// If a thumbnail is available for the file, the URL to a 64x64 pixel will be returned as 
        /// the Thumb64 prop. 
        /// 
        /// The Thumb80 prop (when present) contains the URL of an 80x80 thumb. Unlike the 64px thumb, 
        /// this size is guaranteed to be 80x80, even when the source image was smaller (it's padded 
        /// with transparent pixels). A variable sized thumb will be returned as thumb_360, with its
        /// longest size no bigger than 360 (although it might be smaller depending on the source size). 
        /// Dimensions for this thumb are returned in Thumb360W and Thumb360H. In the case where 
        /// the original image was an animated gif with dimensions greater than 360 pixels, we also 
        /// created an animated thumbnail and pass it as Thumb360Gif.
        /// </summary>
        [JsonProperty(PropertyName = "thumb_360", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Thumb360 { get; set; }

        /// <summary>
        /// If a thumbnail is available for the file, the URL to a 64x64 pixel will be returned as 
        /// the Thumb64 prop. 
        /// 
        /// The Thumb80 prop (when present) contains the URL of an 80x80 thumb. Unlike the 64px thumb, 
        /// this size is guaranteed to be 80x80, even when the source image was smaller (it's padded 
        /// with transparent pixels). A variable sized thumb will be returned as thumb_360, with its
        /// longest size no bigger than 360 (although it might be smaller depending on the source size). 
        /// Dimensions for this thumb are returned in Thumb360W and Thumb360H. In the case where 
        /// the original image was an animated gif with dimensions greater than 360 pixels, we also 
        /// created an animated thumbnail and pass it as Thumb360Gif.
        /// </summary>
        [JsonProperty(PropertyName = "thumb_360_gif", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Thumb360Gif { get; set; }

        /// <summary>
        /// If a thumbnail is available for the file, the URL to a 64x64 pixel will be returned as 
        /// the Thumb64 prop. 
        /// 
        /// The Thumb80 prop (when present) contains the URL of an 80x80 thumb. Unlike the 64px thumb, 
        /// this size is guaranteed to be 80x80, even when the source image was smaller (it's padded 
        /// with transparent pixels). A variable sized thumb will be returned as thumb_360, with its
        /// longest size no bigger than 360 (although it might be smaller depending on the source size). 
        /// Dimensions for this thumb are returned in Thumb360W and Thumb360H. In the case where 
        /// the original image was an animated gif with dimensions greater than 360 pixels, we also 
        /// created an animated thumbnail and pass it as Thumb360Gif.
        /// </summary>
        [JsonProperty(PropertyName = "thumb_360_w", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int Thumb360W { get; set; }

        /// <summary>
        /// If a thumbnail is available for the file, the URL to a 64x64 pixel will be returned as 
        /// the Thumb64 prop. 
        /// 
        /// The Thumb80 prop (when present) contains the URL of an 80x80 thumb. Unlike the 64px thumb, 
        /// this size is guaranteed to be 80x80, even when the source image was smaller (it's padded 
        /// with transparent pixels). A variable sized thumb will be returned as thumb_360, with its
        /// longest size no bigger than 360 (although it might be smaller depending on the source size). 
        /// Dimensions for this thumb are returned in Thumb360W and Thumb360H. In the case where 
        /// the original image was an animated gif with dimensions greater than 360 pixels, we also 
        /// created an animated thumbnail and pass it as Thumb360Gif.
        /// </summary>
        [JsonProperty(PropertyName = "thumb_360_h", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int Thumb360H { get; set; }

        /// <summary>
        /// The permalink URL points to a single page for the file containing details, comments and a download link. 
        /// </summary>
        [JsonProperty(PropertyName = "permalink")]
        public string Permalink { get; set; }

        /// <summary>
        /// The edit_link is only present for posts and snippets and is the page at which the file can be edited.
        /// </summary>
        [JsonProperty(PropertyName = "edit_link")]
        public string EditLink { get; set; }

        /// <summary>
        /// For posts, a short plain-text preview than can be shown in place of a thumbnail.
        /// 
        /// For snippets, we include a simple preview of the contents (a few truncated lines of 
        /// plaintext), as well as a more complex syntaxed highlighted preview (PreviewHighlight) 
        /// in HTML. The total count of lines in the snippet if returned is Lines, while LinesMore 
        /// contains a count of lines not shown in the preview.
        /// </summary>
        [JsonProperty(PropertyName = "preview", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Preview { get; set; }

        /// <summary>
        /// For posts, a short plain-text preview than can be shown in place of a thumbnail.
        /// 
        /// For snippets, we include a simple preview of the contents (a few truncated lines of 
        /// plaintext), as well as a more complex syntaxed highlighted preview (PreviewHighlight) 
        /// in HTML. The total count of lines in the snippet if returned is Lines, while LinesMore 
        /// contains a count of lines not shown in the preview.
        /// </summary>
        [JsonProperty(PropertyName = "preview_highlight", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string PreviewHighlight { get; set; }

        /// <summary>
        /// For posts, a short plain-text preview than can be shown in place of a thumbnail.
        /// 
        /// For snippets, we include a simple preview of the contents (a few truncated lines of 
        /// plaintext), as well as a more complex syntaxed highlighted preview (PreviewHighlight) 
        /// in HTML. The total count of lines in the snippet if returned is Lines, while LinesMore 
        /// contains a count of lines not shown in the preview.
        /// </summary>
        [JsonProperty(PropertyName = "lines", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int Lines { get; set; }

        /// <summary>
        /// For posts, a short plain-text preview than can be shown in place of a thumbnail.
        /// 
        /// For snippets, we include a simple preview of the contents (a few truncated lines of 
        /// plaintext), as well as a more complex syntaxed highlighted preview (PreviewHighlight) 
        /// in HTML. The total count of lines in the snippet if returned is Lines, while LinesMore 
        /// contains a count of lines not shown in the preview.
        /// </summary>
        [JsonProperty(PropertyName = "lines_more", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int LinesMore { get; set; }

        /// <summary>
        /// If a file is public, the IsPublic flag will be set.
        /// </summary>
        [JsonProperty(PropertyName = "is_public")]
        public bool IsPublic { get; set; }

        /// <summary>
        /// If a file's public URL has been shared, the PublicUrlShared flag will be set.
        /// </summary>
        [JsonProperty(PropertyName = "public_url_shared")]
        public bool PublicUrlShared { get; set; }

        /// <summary>
        /// The Channels array contains the IDs of any channels into which the file is currently shared. 
        /// The Groups array is the same but for private groups. Groups are only returned if the caller 
        /// is a member of that group. Finally, the Ims array is the same but for IM channels. IMs are 
        /// only returned if the caller is a member of that IM channel.
        /// </summary>
        [JsonProperty(PropertyName = "channels", DefaultValueHandling = DefaultValueHandling.Populate)]
        public List<string> Channels { get; set; }

        /// <summary>
        /// The Channels array contains the IDs of any channels into which the file is currently shared. 
        /// The Groups array is the same but for private groups. Groups are only returned if the caller 
        /// is a member of that group. Finally, the Ims array is the same but for IM channels. IMs are 
        /// only returned if the caller is a member of that IM channel.
        /// </summary>
        [JsonProperty(PropertyName = "groups", DefaultValueHandling = DefaultValueHandling.Populate)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// The Channels array contains the IDs of any channels into which the file is currently shared. 
        /// The Groups array is the same but for private groups. Groups are only returned if the caller 
        /// is a member of that group. Finally, the Ims array is the same but for IM channels. IMs are 
        /// only returned if the caller is a member of that IM channel.
        /// </summary>
        [JsonProperty(PropertyName = "ims", DefaultValueHandling = DefaultValueHandling.Populate)]
        public List<string> Ims { get; set; }

        /// <summary>
        /// The NumStars property contains the number of users who have starred this file. It is not present 
        /// if no users have starred it. The IsStarred property is present and true if the calling user has
        /// starred the file, else it is omitted.
        /// </summary>
        [JsonProperty(PropertyName = "num_stars", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int NumStars { get; set; }

        /// <summary>
        /// The NumStars property contains the number of users who have starred this file. It is not present 
        /// if no users have starred it. The IsStarred property is present and true if the calling user has
        /// starred the file, else it is omitted.
        /// </summary>
        [JsonProperty(PropertyName = "is_starred", DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool IsStarred { get; set; }

        /// <summary>
        /// The PinnedTo array contains the IDs of any channels to which the file is currently pinned.
        /// </summary>
        [JsonProperty(PropertyName = "pinned_to", DefaultValueHandling = DefaultValueHandling.Populate)]
        public List<string> PinnedTo { get; set; }

        /// <summary>
        /// The Reactions property contains any reactions that have been added to the file and gives 
        /// information about the type of reaction, the total number of users who added that reaction 
        /// and a (possibly incomplete) list of users who have added that reaction to the file. 
        /// 
        /// The users array in the reactions property might not always contain all users that have 
        /// reacted (we limit it to X users, and X might change), however count will always represent
        /// the count of all users who made that reaction (i.e. it may be greater than users.length). 
        /// If the authenticated user has a given reaction then they are guaranteed to appear in the 
        /// users array, regardless of whether count is greater than users.length or not.
        /// </summary>
        [JsonProperty(PropertyName = "reactions", DefaultValueHandling = DefaultValueHandling.Populate)]
        public List<Reaction> Reactions { get; set; }
    }
}

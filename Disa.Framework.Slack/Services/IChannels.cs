using Models.Models.Methods;
using Models.Models.Methods.Channels;
using Refit;
using System.Threading.Tasks;


namespace Models.Services
{
    /// <summary>
    /// Get info on your team's Slack channels, create or archive channels, 
    /// invite users, set the topic and purpose, and mark a channel as read.
    /// </summary>
    public interface IChannels
    {
        /// <summary>
        /// This method archives a channel.
        /// </summary>
        /// <param name="channel">Channel to archive</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        [Get("/channels.archive")]
        Task<OkResponse> ChannelsArchive(string channel, string token = "");

        /// <summary>
        /// This method is used to create a channel.
        /// </summary>
        /// <param name="name">Name of channel to create</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        [Get("/channels.create")]
        Task<ChannelsResponse> ChannelsCreate(string name, string token = "");

        /// <summary>
        /// This method returns a portion of messages/events from the specified channel. 
        /// 
        /// To read the entire history for a channel, call the method with no latest or 
        /// oldest arguments, and then continue paging using the instructions below.
        /// </summary>
        /// <param name="channel">Channel to fetch history for.</param>
        /// <param name="latest">End of time range of messages to include in results.</param>
        /// <param name="oldest">Start of time range of messages to include in results.</param>
        /// <param name="inclusive">Include messages with latest or oldest timestamp in results.</param>
        /// <param name="count">Number of messages to return, between 1 and 1000.</param>
        /// <param name="unreads">Include unread_count_display in the output?</param>
        /// <param name="token">Authentication token (Requires scope: channels:history)</param>
        /// <returns></returns>
        [Get("/channels.history")]
        Task<MessagesListResponse> ChannelsHistory(string channel, 
                                                   string latest="now", 
                                                   string oldest = "0", 
                                                   int inclusive=0,
                                                   int count=100,
                                                   int unreads=1,
                                                   string token = "");

        /// <summary>
        /// This method returns information about a team channel.
        /// </summary>
        /// <param name="channel">Channel to get info on</param>
        /// <param name="token">Authentication token (Requires scope: channels:read)</param>
        /// <returns></returns>
        [Get("/channels.info")]
        Task<ChannelsResponse> ChannelsInfo(string channel, string token = "");

        /// <summary>
        /// This method is used to invite a user to a channel. 
        /// 
        /// The calling user must be a member of the channel.
        /// </summary>
        /// <param name="channel">Channel to invite user to.</param>
        /// <param name="user">User to invite to channel.</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        [Get("/channels.invite")]
        Task<ChannelsResponse> ChannelsInvite(string channel, string user, string token = "");

        /// <summary>
        /// This method is used to join a channel. 
        /// 
        /// If the channel does not exist, it is created.
        /// </summary>
        /// <param name="name">Name of channel to join</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        [Get("/channels.join")]
        Task<ChannelsResponse> ChannelsJoin(string name, string token = "");

        /// <summary>
        /// This method allows a user to remove another member from a team channel.
        /// </summary>
        /// <param name="channel">Channel to remove user from.</param>
        /// <param name="user">User to remove from channel.</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        Task<OkResponse> ChannelsKick(string channel, string user, string token = "");

        /// <summary>
        /// This method is used to leave a channel.
        /// </summary>
        /// <param name="channel">Channel to leave</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        Task<OkResponse> ChannelsLeave(string channel, string token = "");

        /// <summary>
        /// This method returns a list of all channels in the team. 
        /// This includes channels the caller is in, channels they are not currently in, 
        /// and archived channels. The number of (non-deactivated) members in each channel
        /// is also returned.
        /// </summary>
        /// <param name="excludeArchived">Don't return archived channels.</param>
        /// <param name="token">Authentication token (Requires scope: channels:read)</param>
        /// <returns></returns>
        [Get("/channels.list")]
        Task<ChannelsListResponse> ChannelsList(int excludeArchived=0, string token = "");

        /// <summary>
        /// This method moves the read cursor in a channel.
        /// </summary>
        /// <param name="channel">Channel to set reading cursor in.</param>
        /// <param name="ts">Timestamp of the most recently seen message.</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        [Get("/channels.mark")]
        Task<OkResponse> ChannelsMark(string channel, string ts, string token = "");

        /// <summary>
        /// This method renames a team channel.
        /// 
        /// The only people who can rename a channel are team admins, or the person
        /// that originally created the channel. Others will recieve a "not_authorized" 
        /// error.
        /// </summary>
        /// <param name="channel">Channel to rename</param>
        /// <param name="name">New name for channel.</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        [Get("/channels.rename")]
        Task<ChannelsResponse> ChannelsRename(string channel, string name, string token = "");

        /// <summary>
        /// This method is used to change the purpose of a channel. 
        /// 
        /// The calling user must be a member of the channel.
        /// </summary>
        /// <param name="channel">Channel to set the purpose of</param>
        /// <param name="purpose">The new purpose</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        [Get("/channels.setPurpose")]
        Task<OkResponse> ChannelsSetPurpose(string channel, string purpose, string token = "");

        /// <summary>
        /// This method is used to change the topic of a channel. 
        /// 
        /// The calling user must be a member of the channel.
        /// </summary>
        /// <param name="channel">Channel to set the topic of</param>
        /// <param name="topic">The new topic</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        [Get("/channels.setTopic")]
        Task<OkResponse> ChannelsSetTopic(string channel, string topic, string token = "");

        /// <summary>
        /// This method unarchives a channel. 
        /// 
        /// The calling user is added to the channel.
        /// </summary>
        /// <param name="channel">Channel to unarchive</param>
        /// <param name="token">Authentication token (Requires scope: channels:write)</param>
        /// <returns></returns>
        [Get("/channels.unarchive")]
        Task<OkResponse> ChannelsUnarchive(string channel, string token = "");
    }
}

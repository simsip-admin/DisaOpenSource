using Models.Models.Methods;
using Models.Models.Methods.Channels;
using Models.Models.Methods.Chat;
using Refit;
using System.Threading.Tasks;


namespace Models.Services
{
    /// <summary>
    /// Post chat messages to Slack.
    /// </summary>
    public interface IChat
    {
        /// <summary>
        /// This method deletes a message from a channel.
        /// </summary>
        /// <param name="ts">Timestamp of the message to be deleted</param>
        /// <param name="channel">Channel containing the message to be deleted.</param>
        /// <param name="token">Authentication token (Requires scope: chat:write)</param>
        /// <returns></returns>
        [Get("/chat.delete")]
        Task<OkResponse> ChatDelete(string ts, string channel, string token = "");

        // TODO: Build out rest of parameters
        /// <summary>
        /// This method posts a message to a public channel, private group, or IM channel.
        /// </summary>
        /// <param name="channel">Channel, private group, or IM channel to send message to. Can be an encoded ID, or a name.</param>
        /// <param name="text">Text of the message to send. </param>
        /// <param name="token">Authentication token (Requires scope: chat:write:user)</param>
        /// <returns></returns>
        [Get("/chat.postMessage")]
        Task<PostMessageResponse> ChatPostMessage(string channel, string text, string token = "");

        // TODO: Build out rest of parameters
        /// <summary>
        /// This method updates a message in a channel.
        /// </summary>
        /// <param name="ts">Timestamp of the message to be updated.</param>
        /// <param name="channel">Channel containing the message to be updated.</param>
        /// <param name="text">New text for the message, using the default formatting rules.</param>
        /// <param name="token">Authentication token (Requires scope: chat:write)</param>
        /// <returns></returns>
        [Get("/chat.update")]
        Task<UpdateMessageResponse> ChatUpdateMessage(string ts, string channel, string text, string token = "");

    }
}

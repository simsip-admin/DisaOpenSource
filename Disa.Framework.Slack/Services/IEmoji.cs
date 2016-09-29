using Models.Models.Methods.Emoji;
using Refit;
using System.Threading.Tasks;


namespace Models.Services
{
    public interface IEmoji
    {
        /// <summary>
        /// This method lists the custom emoji for a team.
        /// </summary>
        /// <param name="token">Authentication token (Requires scope: emoji:read)</param>
        /// <returns></returns>
        [Get("/emoji.list")]
        Task<EmojiListResponse> EmojiList(string token = "");
    }
}

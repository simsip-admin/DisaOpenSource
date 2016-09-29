using Models.Models.Methods;
using Models.Models.Methods.Files;
using Refit;
using System.Threading.Tasks;


namespace Models.Services
{
    /// <summary>
    /// Get info on files uploaded to Slack, upload new files to Slack.
    /// </summary>
    public interface IFiles
    {
        /// <summary>
        /// This method deletes a file from your team.
        /// </summary>
        /// <param name="file">ID of file to delete.</param>
        /// <param name="token">Authentication token (Requires scope: files:write:user)</param>
        /// <returns></returns>
        [Get("/files.delete")]
        Task<OkResponse> FilesDelete(string file, string token = "");

        /// <summary>
        /// This method returns information about a file in your team.
        /// </summary>
        /// <param name="file">File to fetch info for</param>
        /// <param name="count">Number of items to return per page.</param>
        /// <param name="page">Page number of results to return.</param>
        /// <param name="token">Authentication token (Requires scope: files:read)</param>
        /// <returns></returns>
        [Get("/files.info")]
        Task<FilesResponse> FilesInfo(string file, int count=100, int page=2, string token = "");

        // TODO: files.list, files.upload


    }
}

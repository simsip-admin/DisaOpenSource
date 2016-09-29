using Models.Models.Methods;
using Models.Models.Methods.Groups;
using Refit;
using System.Threading.Tasks;


namespace Models.Services
{
    /// <summary>
    /// Get info on your team's private groups.
    /// </summary>
    public interface IGroups
    {
        /// <summary>
        /// This method archives a private group.
        /// </summary>
        /// <param name="channel">Private group to archive</param>
        /// <param name="token">Authentication token (Requires scope: groups:write)</param>
        /// <returns></returns>
        [Get("/groups.archive")]
        Task<OkResponse> GroupsArchive(string channel, string token = "");

        /// <summary>
        /// This method closes a private group.
        /// </summary>
        /// <param name="channel">Group to close.</param>
        /// <param name="token">Authentication token (Requires scope: groups:write)</param>
        /// <returns></returns>
        [Get("/groups.close")]
        Task<OkResponse> GroupsClose(string channel, string token = "");

        /// <summary>
        /// This method creates a private group.
        /// </summary>
        /// <param name="name">Name of group to create</param>
        /// <param name="token">Authentication token (Requires scope: groups:write)</param>
        /// <returns></returns>
        [Get("/groups.create")]
        Task<GroupsResponse> GroupsCreate(string name, string token = "");

        /// <summary>
        /// This method takes an existing private group and performs the following steps:
        /// Renames the existing group (from "example" to "example-archived").
        /// Archives the existing group.
        /// Creates a new group with the name of the existing group.
        /// Adds all members of the existing group to the new group.
        /// This is useful when inviting a new member to an existing group while hiding all 
        /// previous chat history from them. In this scenario you can call groups.createChild 
        /// followed by groups.invite.
        /// The new group will have a special parent_group property pointing to the original 
        /// archived group. This will only be returned for members of both groups, so will not 
        /// be visible to any newly invited members.
        /// </summary>
        /// <param name="channel">Group to clone and archive.</param>
        /// <param name="token">Authentication token (Requires scope: groups:write)</param>
        /// <returns></returns>
        [Get("/groups.createChild")]
        Task<GroupsResponse> GroupsCreateChild(string channel, string token = "");

        [Get("/groups.history")]
        Task<GroupsResponse> GroupsHistory(string channel, 
                                           string latest="now",
                                           string oldest="0",
                                           int inclusive=1,
                                           int count=100,

            string token = "");


    }
}

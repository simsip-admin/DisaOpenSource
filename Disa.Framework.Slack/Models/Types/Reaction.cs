using Newtonsoft.Json;
using System.Collections.Generic;


namespace Models.Models.Types
{
    /// <summary>
    /// The reactions property contains any reactions that have been added to the file and 
    /// gives information about the type of reaction, the total number of users who added 
    /// that reaction and a (possibly incomplete) list of users who have added that reaction
    /// to the file. 
    /// 
    /// The users array in the reactions property might not always contain all users that 
    /// have reacted (we limit it to X users, and X might change), however count will always
    /// represent the count of all users who made that reaction (i.e. it may be greater than users.length). 
    /// If the authenticated user has a given reaction then they are guaranteed to appear in the 
    /// users array, regardless of whether count is greater than users.length or not.
    /// </summary>
    public class Reaction
    {
        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "name", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Name { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "count", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int Count { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [JsonProperty(PropertyName = "users", DefaultValueHandling = DefaultValueHandling.Populate)]
        public List<string> Users { get; set; }
    }
}

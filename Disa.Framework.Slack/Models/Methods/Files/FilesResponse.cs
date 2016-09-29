using Models.Models.Types;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;


namespace Models.Models.Methods.Files
{
    public class FilesResponse
    {
        [JsonProperty(PropertyName = "ok")]
        public bool Ok { get; set; }

        [DefaultValue("")]
        [JsonProperty(PropertyName = "error", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "file")]
        public File File { get; set; }
    }
}

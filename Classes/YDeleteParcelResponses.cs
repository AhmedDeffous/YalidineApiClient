using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
    public class YDeleteParcelResponses
    {
        public List<YDeleteParcelResponse> ListDeleteParcelResponses { get; set; } = new List<YDeleteParcelResponse>();
    
        [JsonPropertyName("Success")]
        public bool Success { get; set; } = false;
        [JsonPropertyName("Tag")]
        public string Tag { get; set; } = "Error";

        public override string ToString()
        {
            string s = "";
            foreach (var item in ListDeleteParcelResponses)
            {
                s += item.ToString() + ";\r\n";
            }
            return s;
        }
    }
}

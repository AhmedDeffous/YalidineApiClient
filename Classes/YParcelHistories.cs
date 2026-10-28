using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
 
namespace YalidineApiClient.Classes
{
    public class YParcelHistories
    {
        [JsonPropertyName("has_more")]
        public bool HasMoreData { get; set; }
    
        [JsonPropertyName("total_data")]
        public int TotalYParcelHistorie { get; set; }

        [JsonPropertyName("data")]
        public List<YParcelHistorie> ListParcelHistories { get; set; } = new List<YParcelHistorie>();

        [JsonPropertyName("Success")]
        public bool Success { get; set; } = false;
        [JsonPropertyName("Tag")]
        public string Tag { get; set; } = "Error";

        public override string ToString()
        {
            return $"HasMoreData:{HasMoreData} - TotalYParcelHistorie:{TotalYParcelHistorie}";
        }
    }
}

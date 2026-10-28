using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
 
namespace YalidineApiClient.Classes
{
    public class YWilayas
    {
        [JsonPropertyName("has_more")]
        public bool HasMoreData { get; set; } = false;

        [JsonPropertyName("total_data")]
        public int TotalWilaya { get; set; } = 16;

        [JsonPropertyName("data")]
        public List<YWilaya> ListWilayas { get; set; } = new List<YWilaya>();

        [JsonPropertyName("Success")]
        public bool Success { get; set; } = false;
        [JsonPropertyName("Tag")]
        public string Tag { get; set; } = "Error";
        public override string ToString()
        {
            return $"HasMoreData:{HasMoreData} - TotalWilaya:{TotalWilaya}";
        }
    }
}

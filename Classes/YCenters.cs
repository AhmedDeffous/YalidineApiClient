using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
   public class YCenters
    {
        [JsonPropertyName("has_more")]
        public bool HasMoreData { get; set; }

        [JsonPropertyName("total_data")]
        public int TotalCenters { get; set; }

        [JsonPropertyName("data")]
        public List<YCenter> ListCenters { get; set; } = new List<YCenter>();

        [JsonPropertyName("Success")]
        public bool Success { get; set; } = false;
        [JsonPropertyName("Tag")]
        public string Tag { get; set; } = "Error";

        public override string ToString()
        {
            return $"HasMoreData:{HasMoreData} - TotalCenters:{TotalCenters}";
        }
    }
}

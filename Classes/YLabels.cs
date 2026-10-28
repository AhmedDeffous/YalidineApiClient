using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
 
namespace YalidineApiClient.Classes
{
    public class YLabels
    {
 
        [JsonPropertyName("Labels")]
        public List<byte[]> LYLabels { get; set; } = new List<byte[]>();
       
        [JsonPropertyName("Success")]
        public bool Success { get; set; } = false;

        [JsonPropertyName("Tag")]
        public string Tag { get; set; } = "Error";
        public override string ToString()
        {
            return $"Tag:{Tag} - LabelsCount:{LYLabels.Count}";
        }
    }
}

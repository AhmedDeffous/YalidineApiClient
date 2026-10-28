using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  using System.Text.Json.Serialization;
namespace YalidineApiClient.Classes
{
  

    public class YCreateOneOrderResult
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; } = false;

        [JsonPropertyName("order_id")]
        public string  OrderId { get; set; } = "";

        [JsonPropertyName("tracking")]
        public string  Tracking { get; set; }

        [JsonPropertyName("import_id")]
        public int  ImportId { get; set; } = 0;

        [JsonPropertyName("label")]
        public string  Label { get; set; } = "";

        [JsonPropertyName("labels")]
        public string  Labels { get; set; } = "";

        [JsonPropertyName("message")]
        public string  Message { get; set; } = "";
    }

}

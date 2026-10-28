using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
    public class YCreateOrdersResults
    {
        public Dictionary<string, YCreateOneOrderResult> MyYCreateOrderResults { get; set; } = new Dictionary<string, YCreateOneOrderResult>();
        public bool Success { get; set; } = false;
        [JsonPropertyName("Tag")]
        public string Tag { get; set; } = "Error";

        public override string ToString()
        {
            if (MyYCreateOrderResults == null) MyYCreateOrderResults = new Dictionary<string, YCreateOneOrderResult>();
            string s = "";
            foreach (var item in MyYCreateOrderResults.ToList())
            {
                s += $"OrderId: {item.Value.OrderId} - Tracking:{item.Value.Tracking} - Success {item.Value.Success} - Message:{item.Value.Message}\r\n;";
            }
            return s;
        }
    }
}

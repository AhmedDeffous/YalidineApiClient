using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
    public class YWilaya
    {
        [JsonPropertyName("id")]
        public int WilayaId { get; set; } = -1;

        [JsonPropertyName("name")]
        public string WilayaName { get; set; } = "";

        [JsonPropertyName("zone")]
        public int WilayaZone { get; set; }

        [JsonPropertyName("is_deliverable")]
        public int IsDeliverable { get; set; } =1;

        public override string ToString()
        {
            return $"WilayaId:{this.WilayaId} - WilayaZone:{this.WilayaZone} - WilayaName:{this.WilayaName}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace YalidineApiClient.Classes
{

    public class YCenter
    {
        [JsonPropertyName("center_id")]
        public int CenterId { get; set; } = -1;

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("address")]
        public string Address { get; set; } = "";

        [JsonPropertyName("gps")]
        public string Gps { get; set; }

        [JsonPropertyName("commune_id")]
        public int CommuneId { get; set; } = -1;

        [JsonPropertyName("commune_name")]
        public string CommuneName { get; set; } = "";

        [JsonPropertyName("wilaya_id")]
        public int WilayaId { get; set; } = -1;

        [JsonPropertyName("wilaya_name")]
        public string WilayaName { get; set; } = "";
        public override string ToString()
        {
            //- Address:{Address} - Gps:{Gps} - CommuneId:{CommuneId} - CommuneName:{CommuneName}
            return $"CenterId:{CenterId} - Name:{Name} - WilayaId:{WilayaId}-WilayaName:{WilayaName}  ";
        }
    }

}

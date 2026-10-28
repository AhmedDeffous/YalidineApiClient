using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Diagnostics.Eventing.Reader;

namespace YalidineApiClient.Classes
{

    public class YParcelHistorie
    {
        int _CommuneId = -1;
        int _CenterId = 0;
        int _WilayaId = 16;
        [JsonPropertyName("date_status")]
        public string DateStatus { get; set; } = "01/11/1954";

        [JsonPropertyName("tracking")]
        public string Tracking { get; set; } = "";

        [JsonPropertyName("status")]
        public string Status { get; set; } = "";

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("center_id")]
        public int? CenterId { get {return _CenterId; } set { if (value == null) _CenterId=-1; else _CenterId=Convert.ToInt32( value); } } 

        [JsonPropertyName("center_name")]
        public string CenterName { get; set; } = "";

        [JsonPropertyName("wilaya_id")]
        public int? WilayaId { get { return _WilayaId; } set { if (value == null) _WilayaId=-1; else _WilayaId=Convert.ToInt32(value); } }  

        [JsonPropertyName("wilaya_name")]
        public string WilayaName { get; set; } = "";

        [JsonPropertyName("commune_id")]
        public int? CommuneId { get { return _CommuneId; } set { if (value == null) _CommuneId=-1; else _CommuneId=Convert.ToInt32(value); } }  

        [JsonPropertyName("commune_name")]
        public string CommuneName { get; set; } = "";

        public override string ToString()
        {
            return $"Tracking:{Tracking} - DateStatus:{DateStatus} - Status:{Status}  ";
        }
    }

}

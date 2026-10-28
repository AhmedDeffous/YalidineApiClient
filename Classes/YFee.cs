using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
    public class YFee
    {


        [JsonPropertyName("commune_id")]
        public int CommuneId { get; set; }

        [JsonPropertyName("commune_name")]
        public string CommuneName { get; set; } = "";

        [JsonPropertyName("express_home")]
        public int? ExpressHome { get; set; }

        [JsonPropertyName("express_desk")]
        public int? ExpressDesk { get; set; }

        [JsonPropertyName("economic_home")]
        public int? EconomicHome { get; set; }

        [JsonPropertyName("economic_desk")]
        public int? EconomicDesk { get; set; }

        public override string ToString()
        {
            return $"CommuneId:{CommuneId} - CommuneName:{CommuneName} - ExpressHome:{ExpressHome} - EconomicHome:{EconomicHome} - EconomicDesk:{EconomicDesk}";
        }
    }

}


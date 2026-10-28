using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

  
    public class YFees
    {
        [JsonPropertyName("from_wilaya_name")]
        public string FromWilayaName { get; set; } = "";

        [JsonPropertyName("to_wilaya_name")]
        public string ToWilayaName { get; set; } = "";

        [JsonPropertyName("zone")]
        public int Zone { get; set; }

        [JsonPropertyName("retour_fee")]
        public int RetourFee { get; set; }

        [JsonPropertyName("cod_percentage")]
        public double CodPercentage { get; set; }

        [JsonPropertyName("insurance_percentage")]
        public double InsurancePercentage { get; set; }

        [JsonPropertyName("oversize_fee")]
        public int OversizeFee { get; set; }

        [JsonPropertyName("per_commune")]
        public Dictionary<string, YFee> PerCommune { get; set; } = new Dictionary<string, YFee>();
        public override string ToString()
        {
            return $"FromWilayaName:{FromWilayaName} - ToWilayaName:{ToWilayaName} - Zone:{Zone} - RetourFee:{RetourFee} - CodPercentage:{CodPercentage} - InsurancePercentage:{InsurancePercentage} - OversizeFee:{OversizeFee}";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
    public class YCommune
    {
        [JsonPropertyName("id")]
        public int CommuneId { get; set; } = -1;
        [JsonPropertyName("name")]
        public string CommuneName { get; set; } = "";
        [JsonPropertyName("wilaya_id")]
        public int WilayaId { get; set; } = 1;
        [JsonPropertyName("wilaya_name")]
        public string WilayaName { get; set; } = "";
        [JsonPropertyName("has_stop_desk")]
        public int CommuneHasStopDesk { get; set; } = 0;
        [JsonPropertyName("is_deliverable")]
        public int CommuneIsDeliverable { get; set; } = 1;
        [JsonPropertyName("delivery_time_parcel")]
        public int CommuneDeliveryTimeParcel { get; set; } = 20;
        [JsonPropertyName("delivery_time_payment")]
        public int CommuneDeliveryTimePayment { get; set; } = 10;

        public override string ToString()
        {
            return $"CommuneId:{this.CommuneId} - WilayaId:{this.WilayaId} - CommuneName:{this.CommuneName} - WilayaName:{this.WilayaName} - CommuneHasStopDesk:{CommuneHasStopDesk} - CommuneIsDeliverable:{CommuneIsDeliverable} - CommuneDeliveryTimeParcel:{CommuneDeliveryTimeParcel} - CommuneDeliveryTimePayment:{CommuneDeliveryTimePayment}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
   public class YParcelToCreate
    {

        [JsonPropertyName("order_id")] public string OrderId { get; set; } = "";
        [JsonPropertyName("from_wilaya_name")] public string FromWilayaName { get; set; } = "";
        [JsonPropertyName("firstname")] public string Firstname { get; set; } = "";
        [JsonPropertyName("familyname")] public string Familyname { get; set; } = "";
        [JsonPropertyName("contact_phone")] public string ContactPhone { get; set; } = "";
        [JsonPropertyName("address")] public string Address { get; set; } = "";
        [JsonPropertyName("to_commune_name")] public string ToCommuneName { get; set; }
        [JsonPropertyName("to_wilaya_name")] public string ToWilayaName { get; set; } = "";
        [JsonPropertyName("product_list")] public string ProductList { get; set; } = "";
        [JsonPropertyName("price")] public int Price { get; set; } = 0;
        [JsonPropertyName("do_insurance")] public bool DoInsurance { get; set; } = false;
        [JsonPropertyName("declared_value")] public int DeclaredValue { get; set; } = 0;    
        [JsonPropertyName("height")] public int Height { get; set; } = 0;
        [JsonPropertyName("width")] public int Width { get; set; } = 0;
        [JsonPropertyName("length")] public int Length { get; set; } = 0;
        [JsonPropertyName("weight")] public int Weight { get; set; } = 0;
        [JsonPropertyName("freeshipping")] public bool FreeShipping { get; set; }
        [JsonPropertyName("is_stopdesk")] public bool IsStopdesk { get; set; } = false; 
        [JsonPropertyName("stopdesk_id")] public int StopdeskId { get; set; } = 0;
        [JsonPropertyName("has_exchange")] public int HasExchange { get; set; } = 0;
        [JsonPropertyName("product_to_collect")] public string ProductToCollect { get; set; } = "";
    }

    
}
 
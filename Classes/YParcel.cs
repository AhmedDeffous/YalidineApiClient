using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace YalidineApiClient.Classes
{

    public class YParcel
    {
        [JsonPropertyName("tracking")]
        public string Tracking { get; set; } = "";

        [JsonPropertyName("order_id")]
        public string OrderId { get; set; } = "";

        [JsonPropertyName("firstname")]
        public string Firstname { get; set; } = "";

        [JsonPropertyName("familyname")]
        public string Familyname { get; set; } = "";

        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; } = "";

        [JsonPropertyName("address")]
        public string Address { get; set; } = "";

        [JsonPropertyName("is_stopdesk")]
        public int? IsStopdesk
        {
            get { return _IsStopdesk; }
            set { if (value == null) _IsStopdesk = 0; else _IsStopdesk = System.Convert.ToInt32(value); }
        }

        [JsonPropertyName("stopdesk_id")]
        public int? StopdeskId
        {
            get
            {
                return _StopdeskId;
            }
            set
            {
                if (value == null)
                    _StopdeskId = -1;
                else
                    _StopdeskId = System.Convert.ToInt32(value);
            }
        }

        [JsonPropertyName("stopdesk_name")]
        public string StopdeskName { get; set; } = "";

        [JsonPropertyName("from_wilaya_id")]
        public int? FromWilayaId
        {
            get { return _FromWilayaId; }
            set { if (value == null) _FromWilayaId = 0; else _FromWilayaId = System.Convert.ToInt32(value); }
        }

        [JsonPropertyName("from_wilaya_name")]
        public string FromWilayaName { get; set; } = "";

        [JsonPropertyName("to_commune_id")]
        public int? ToCommuneId
        {
            get
            {
                return _ToCommuneId;
            }
            set
            {
                if (value == null)
                    _ToCommuneId = -1;
                else
                    _ToCommuneId = System.Convert.ToInt32(value);
            }
        }

        [JsonPropertyName("to_commune_name")]
        public string ToCommuneName { get; set; } = "";

        [JsonPropertyName("to_wilaya_id")]
        public int? ToWilayaId
        {
            get
            {
                return _ToWilayaId;
            }
            set
            {
                if (value == null)
                    _ToWilayaId = 16;
                else
                    _ToWilayaId = System.Convert.ToInt32(value);
            }
        }

        [JsonPropertyName("to_wilaya_name")]
        public string ToWilayaName { get; set; } = "Alger";

        [JsonPropertyName("product_list")]
        public string ProductList { get; set; } = "";

        [JsonPropertyName("price")]
        public int? Price
        {
            get { return _Price; }
            set { if (value == null) _Price = 0; else _Price = System.Convert.ToInt32(value); }
        }

        [JsonPropertyName("do_insurance")]
        public int? DoInsurance { get { return _DoInsurance; } set { if (value == null) _DoInsurance = 0; else System.Convert.ToInt32(value); } }

        [JsonPropertyName("declared_value")]
        public int? DeclaredValue
        {
            get { return _DeclaredValue; }
            set { if (value == null) _DeclaredValue = 0; else _DeclaredValue = System.Convert.ToInt32(value); }
        }


        [JsonPropertyName("delivery_fee")]
        public int? DeliveryFee
        {
            get { return _DeliveryFee; }
            set { if (value == null) _DeliveryFee = 0; else _DeliveryFee = System.Convert.ToInt32(value); }
        }

        [JsonPropertyName("freeshipping")]
        public int? FreeShipping
        {
            get { return _FreeShipping; }
            set { if (value == null) _FreeShipping = 0; else _FreeShipping = System.Convert.ToInt32(value); }
        }
        [JsonPropertyName("import_id")]
        public int? ImportId
        {
            get { return _ImportId; }
            set { if (value == null) _ImportId = 0; else _ImportId = System.Convert.ToInt32(value); }
        }

        [JsonPropertyName("date_creation")]
        public string DateCreation { get; set; } = "01/11/1954";

        [JsonPropertyName("date_expedition")]
        public string DateExpedition { get; set; } = "01/11/1954";

        [JsonPropertyName("date_last_status")]
        public string DateLastStatus { get; set; } = "01/11/1954";

        [JsonPropertyName("last_status")]
        public string LastStatus { get; set; } = "";

        [JsonPropertyName("taxe_percentage")]
        public double? TaxePercentage
        {
            get { return _TaxePercentage; }
            set { if (value == null) _TaxePercentage = 0; else _TaxePercentage = System.Convert.ToDouble(value); }
        }

        [JsonPropertyName("taxe_from")]
        public int? TaxeFrom
        {
            get { return _TaxeFrom; }
            set { if (value == null) _TaxeFrom = 0; else _TaxeFrom = System.Convert.ToInt32(value); }
        }

        [JsonPropertyName("taxe_retour")]
        public int? TaxeRetour
        {
            get { return _TaxeRetour; }
            set { if (value == null) _TaxeRetour = 0; else _TaxeRetour = System.Convert.ToInt32(value); }
        }

        [JsonPropertyName("parcel_type")]
        public string ParcelType { get; set; } = "";

        [JsonPropertyName("parcel_sub_type")]
        public string ParcelSubType { get; set; } = "";

        [JsonPropertyName("has_receipt")]
        public bool? HasReceipt
        {
            get { return _HasReceipt; }
            set { if (value == null) _HasReceipt = false; else _HasReceipt = System.Convert.ToBoolean(value); }
        }


        [JsonPropertyName("length")]
        public double? Length { get { return _Length; } set { if (value == null) _Length = 0; else _Length = System.Convert.ToDouble(value); } }

        [JsonPropertyName("width")]
        public double? Width { get { return _Width; } set { if (value == null) _Width = 0; else _Width = System.Convert.ToDouble(value); } }

        [JsonPropertyName("height")]
        public double? Height { get { return _Height; } set { if (value == null) _Height = 0; else _Height = System.Convert.ToDouble(value); } }

        [JsonPropertyName("weight")]
        public double? Weight { get { return _Weight; } set { if (value == null) _Weight = 0; else _Weight = System.Convert.ToDouble(value); } }

        [JsonPropertyName("has_recouvrement")]
        public int? HasRecouvrement { get { return _HasRecouvrement; } set { if (value == null) _HasRecouvrement = 0; else _HasRecouvrement = System.Convert.ToInt32(value); } }
        bool _HasReceipt = false;
        double _TaxePercentage = 0;
        int _FreeShipping = 0;
        int _DeclaredValue = 0;
        int _DoInsurance = 0;
        int _ToWilayaId = 16;
        int _ToCommuneId = -1;
        int _IsStopdesk = 0;
        int _StopdeskId = -1;
        int _FromWilayaId = 16;
        int _Price = 0;
        int _DeliveryFee = 0;
        int _ImportId = -1;
        int _TaxeFrom = 0;
        int _TaxeRetour = 0;
        double _Length = 1;
        double _Width = 1;
        double _Height = 1; 
        double _Weight = 1;
        int _HasRecouvrement = 0;
        int _CurrentCenterId = -1;
        int _CurrentWilayaId = -1;
        int _CurrentCommuneId = -1;
        int _HasExchange = 0;
        [JsonPropertyName("current_center_id")]
        public int? CurrentCenterId { get { return _CurrentCenterId; } set { if (value == null) _CurrentCenterId = 0; else _CurrentCenterId = System.Convert.ToInt32(value); } }

        [JsonPropertyName("current_center_name")]
        public string CurrentCenterName { get; set; } = "";

        [JsonPropertyName("current_wilaya_id")]
        public int? CurrentWilayaId
        {
            get { return _CurrentWilayaId; }
            set { if (value == null) _CurrentWilayaId = 0; else _CurrentWilayaId = System.Convert.ToInt32(value); }
        }

        [JsonPropertyName("current_wilaya_name")]
        public string CurrentWilayaName { get; set; } = "";

        [JsonPropertyName("current_commune_id")]
        public int? CurrentCommuneId
        {
            get { return _CurrentCommuneId; }
            set { if (value == null) _CurrentCommuneId = 0; else _CurrentCommuneId = System.Convert.ToInt32(value); }
        }

        [JsonPropertyName("current_commune_name")]
        public string CurrentCommuneName { get; set; } = "";

        [JsonPropertyName("payment_status")]
        public string PaymentStatus { get; set; } = "";

        [JsonPropertyName("payment_id")]
        public string PaymentId { get; set; } = "";

        [JsonPropertyName("has_exchange")]
        public int? HasExchange
        {
            get { return _HasExchange; }
            set { if (value == null) _HasExchange = 0; else _HasExchange = System.Convert.ToInt32(value); }
        }

        [JsonPropertyName("product_to_collect")]
        public string ProductToCollect { get; set; } = "";

        [JsonPropertyName("label")]
        public string Label { get; set; } = "";

        [JsonPropertyName("pin")]
        public string Pin { get; set; } = "";

        [JsonPropertyName("qr_text")]
        public string QrText { get; set; } = "";

        public override string ToString()
        {
            return $"Tracking:{Tracking} - ProductList:{this.ProductList} - Price:{this.Price} - ToWilayaName:{this.ToWilayaName}";
        }
    }

}

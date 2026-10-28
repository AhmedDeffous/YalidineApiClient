using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
    public class YDeleteParcelResponse
    {
        [JsonPropertyName("tracking")]
        public string Tracking { get; set; } = "";
        [JsonPropertyName("deleted")]
        public bool  Deleted { get; set; } = false;

        public override string ToString()
        {
            return $"Tracking:{Tracking} - Deleted:{Deleted.ToString()}";
        }
    }

 
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalidineApiClient.Classes
{
    public class YParcelWeight
    {
        public decimal WeightFree { get; } = 5;
        public decimal Coficient { get; } = 0.0002M;
        public decimal Weight { get; set; } = 0;
        public decimal Height { get; set; } = 0;
        public decimal Width { get; set; } = 0;
        public decimal length { get; set; } = 0;
        public decimal VolumetricWeight { get { return Height * Width * length * Coficient; } }
        public decimal BillableWeight { get { if (VolumetricWeight > Weight) return VolumetricWeight; else return Weight; } }
        public decimal OverWeight { get { return BillableWeight - WeightFree; } }
    }
}

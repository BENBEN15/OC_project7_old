using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class CurvePoints
    {
        public int CurvePointId { get; set; }
        public byte? CurveId { get; set; }
        public DateTime? AsOfDate { get; set; }
        public double? Term { get; set; }
        public double? Value { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Ratings
    {
        public int RatingId { get; set; }
        public string MoodysRating { get; set; }
        public string SandPrating { get; set; }
        public string FitchRating { get; set; }
        public byte? OrderNumber { get; set; }
    }
}

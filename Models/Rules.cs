using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Rules
    {
        public int RuleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Json { get; set; }
        public string Template { get; set; }
        public string SqlStr { get; set; }
        public string SqlPart { get; set; }
    }
}

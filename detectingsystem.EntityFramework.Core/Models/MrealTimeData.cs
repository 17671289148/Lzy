using System;
using System.Collections.Generic;

#nullable disable

namespace detectingsystem.EntityFramework.Core.Models
{
    public partial class MrealTimeData
    {
        public string Id { get; set; }
        public string Pid { get; set; }
        public int Sort { get; set; }
        public string Ted { get; set; }
        public string Load { get; set; }
        public string Elongation { get; set; }
        public DateTime AbsoluteTime { get; set; }
    }
}

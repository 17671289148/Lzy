using System;
using System.Collections.Generic;

#nullable disable

namespace detectingsystem.EntityFramework.Core.Models
{
    public partial class MtestStage
    {
        public string Id { get; set; }
        public string Pid { get; set; }
        public int Sort { get; set; }
        public string Ted { get; set; }
        public string Pot { get; set; }
        public string Tdf { get; set; }
        public string Tf { get; set; }
        public string Oce { get; set; }
        public string Tce { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public bool IsDel { get; set; }
        public string Remark { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace detectingsystem.EntityFramework.Core.Models
{
    public partial class MuploadFile
    {
        public string Id { get; set; }
        public string Bid { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public bool IsDel { get; set; }
        public string Remark { get; set; }
    }
}

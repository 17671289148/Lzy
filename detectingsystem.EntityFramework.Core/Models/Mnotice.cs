using System;
using System.Collections.Generic;

#nullable disable

namespace detectingsystem.EntityFramework.Core.Models
{
    public partial class Mnotice
    {
        public string Id { get; set; }
        public string Rid { get; set; }
        public string Title { get; set; }
        public string Files { get; set; }
        public string Content { get; set; }
        public bool IsTop { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public bool IsDel { get; set; }
        public string Remark { get; set; }
    }
}

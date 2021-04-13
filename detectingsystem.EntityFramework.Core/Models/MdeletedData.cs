using System;
using System.Collections.Generic;

#nullable disable

namespace detectingsystem.EntityFramework.Core.Models
{
    public partial class MdeletedData
    {
        public string Id { get; set; }
        public string Uid { get; set; }
        public string Did { get; set; }
        public string Content { get; set; }
        public DateTime DeleteTime { get; set; }
        public string Type { get; set; }
    }
}

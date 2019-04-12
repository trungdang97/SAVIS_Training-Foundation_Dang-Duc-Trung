using System;
using System.Collections.Generic;

namespace NetCoreAPI_DataFirst.Models
{
    public partial class Students
    {
        public int IntId { get; set; }
        public string StrCode { get; set; }
        public string StrName { get; set; }
        public DateTime DateBirth { get; set; }
        public int ClassId { get; set; }

        public Classes Class { get; set; }
    }
}

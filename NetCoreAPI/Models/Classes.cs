using System;
using System.Collections.Generic;

namespace NetCoreAPI_DataFirst.Models
{
    public partial class Classes
    {
        public Classes()
        {
            Students = new HashSet<Students>();
        }

        public int IntId { get; set; }
        public string StrCode { get; set; }
        public int IntAcademicYear { get; set; }
        public string StrName { get; set; }
        public int IntQuantity { get; set; }

        public ICollection<Students> Students { get; set; }
    }
}

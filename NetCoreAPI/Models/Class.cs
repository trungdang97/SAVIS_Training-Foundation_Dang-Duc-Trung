using System;
using System.Collections.Generic;

namespace NetCoreAPI.Models
{
    public partial class Class
    {
        public Class()
        {
            Student = new HashSet<Student>();
        }

        public int ClassId { get; set; }
        public string Code { get; set; }
        public int? AcademicYear { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}

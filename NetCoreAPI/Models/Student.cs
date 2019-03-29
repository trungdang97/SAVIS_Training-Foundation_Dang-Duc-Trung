using System;
using System.Collections.Generic;

namespace NetCoreAPI.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public int? ClassId { get; set; }

        public Class Class { get; set; }
    }
}

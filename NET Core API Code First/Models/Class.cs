using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreAPI_CodeFirst.Models
{
    public class Class
    {
        [Key]
        public int intId { get; set; }
        public string strCode { get; set; }
        public int intAcademicYear { get; set; }
        public string strName { get; set; }
        public int intQuantity { get; set; }
        //
        public List<Student> lstStudents { get; set; }

        [NotMapped]
        public double doubleAverageAge { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreAPI_CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int intId { get; set; }
        public string strCode { get; set; }
        public string strName { get; set; }
        public DateTime dateBirth { get; set; }

        [ForeignKey("Class")]
        public int Class_Id { get; set; }
        public Class Class { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Using_Web_API_2_with_Entity_Framework_6.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string strName { get; set; }
    }
}
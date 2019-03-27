using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Using_Web_API_2_with_Entity_Framework_6.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string strTitle { get; set; }
        public int intYear { get; set; }
        public decimal decPrice { get; set; }
        public string strGenre { get; set; }

        [ForeignKey("Author")]
        public int intAuthorId { get; set; }
        public Author Author { get; set; }
        //public virtual Author Author { get; set; }
    }
}
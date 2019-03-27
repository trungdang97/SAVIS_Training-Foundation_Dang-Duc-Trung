using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Using_Web_API_2_with_Entity_Framework_6.Models
{
    public class BookDetailDTO
    {
        public int intId { get; set; }
        public string strTitle { get; set; }
        public int intYear { get; set; }
        public decimal decPrice { get; set; }
        public string strAuthorName { get; set; }
        public string strGenre { get; set; }
    }
}
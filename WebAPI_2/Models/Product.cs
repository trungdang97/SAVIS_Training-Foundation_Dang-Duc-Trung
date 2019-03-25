using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_2.Models
{
    public class Product
    {
        public int intId { get; set; }
        public string strName { get; set; }
        public string strCategory { get; set; }
        public decimal decPrice { get; set; }
    }
}
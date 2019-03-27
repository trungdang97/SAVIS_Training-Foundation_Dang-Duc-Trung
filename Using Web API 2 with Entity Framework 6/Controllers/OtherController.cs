using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Using_Web_API_2_with_Entity_Framework_6.Controllers
{
    public class OtherController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetImage()
        {
            Image img;
            img = Image.FromFile(@"C:\Users\Trung\Desktop\Ultilities\pepega.jpg");

            return Ok(img);
        }
    }
}

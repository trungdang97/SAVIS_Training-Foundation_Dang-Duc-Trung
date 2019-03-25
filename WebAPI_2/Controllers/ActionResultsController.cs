using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace WebAPI_2.Controllers
{
    /*
     Routing là đánh dấu các method được gọi khi nào và map chung tên action cho các phương thức xoay quanh một object
     [Http<Get,Post,Put,Delete,...>]
     [ActionName("<string>")]
     [NonAction] để quy định những method mà không public ra ngoài, tức không thể gọi được qua đường dẫn
         */
    public class ActionResultsController : ApiController
    {
        public void Post()
        {
            // void => return code 204: No content
        }

        public HttpResponseMessage GetHttpResponseMessage()
        {
            // return ket qua va kem theo la HttpStatusCode => request co thanh cong hay khong
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");
            // value tra ve trong body co the thay bang Collection
            response.Content = new StringContent("Hello world!", Encoding.Unicode);
            response.Headers.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(20)
            };
            return response;
            // outdated => su dung interface IHttpActionResult
        }

        public IHttpActionResult GetIHttpActionResult()
        {
            //
            string test = null;
            if(test == null)
            {
                return NotFound();
            }
            return Ok(test); // tien hoa cua HttpResponseMessage: better control flow
        }

        //return mot so kieu khac nhu IEnumerable<T> thi kho co the throw HttpResponseException
    }
}

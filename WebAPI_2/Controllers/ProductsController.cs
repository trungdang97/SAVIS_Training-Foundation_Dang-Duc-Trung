using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_2.Models;

namespace WebAPI_2.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>()
           {
            new Product { intId = 1, strName = "Tomato Soup", strCategory = "Groceries", decPrice = 1 },
            new Product { intId = 2, strName = "Yo-yo", strCategory = "Toys", decPrice = 3.75M },
            new Product { intId = 3, strName = "Hammer", strCategory = "Hardware", decPrice = 16.99M }
           };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        [Route("prod/{id:int}")] // custom override WebApiConfig + constraint
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.intId == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [Route("api/v1/products")]  // custom + constraints
        [HttpPost]                  //define method trong controller
        public IHttpActionResult AddProduct([FromBody]Product product)
        {
            //Product product = new Product() { intId = products.Count + 1, strName = strName, strCategory = strCategory, decPrice = decPrice };
            products.Add(product);

            if(product.strName == "" || product.strName == null)
            {
                return Content(HttpStatusCode.BadRequest, "Product name is empty!");
            }
            else
            {
                return Ok(products);
            }
        }
    }
}

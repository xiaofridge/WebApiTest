using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TestApi.Models;
using System.Net;

namespace TestApi.Controllers
{
    public class ProductController : ApiController
    {

        Product[] products = {
                                 new Product{Id=1,Name="N1",Category="c1",Price=1m},
                             new Product{Id=2,Name="N2",Category="c2",Price=1m},
                             new Product{Id=3,Name="N3",Category="c3",Price=1m}};
        public IEnumerable<Product> GetallProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var query = products.FirstOrDefault(p => p.Id == id);
            if (query == null)
            {
                return NotFound();
            }
            return Ok(query);
        }
    }

}

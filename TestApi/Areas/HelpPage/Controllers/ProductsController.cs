using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApi.Models;

namespace TestApi.Areas.HelpPage.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /HelpPage/Products/

        public ActionResult Index()
        {
            return View();
        }


        Product[] product = { 
        new Product{Id=1,Name="N1",Category="C1",Price=1.2m},
         new Product{Id=1,Name="N2",Category="C2",Price=1.3m},
          new Product{Id=1,Name="N3",Category="C3",Price=1.4m}
        };

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.WebMvc.Controllers
{
    public class ProductsController: Controller
    {
        [ActionName("allproducts")]
        public ViewResult GetAll()
        {
            ViewBag.Products = new List<string>()
            {
                "ketchup",
                "orange"
            };
            return View("AllProducts");
        }
    }
}
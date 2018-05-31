using Sedc.MusicManager.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sedc.MusicManager.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = new Song();
            data.Title = "hello again";
            data.Description = "nothibg";
            ViewBag.status = "active";
            ViewData["somedata"] = "nodata";
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
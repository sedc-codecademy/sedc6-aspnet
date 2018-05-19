using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsDemo.Models;

namespace ViewsDemo.Controllers
{
    public class PictureController : Controller
    {
        public ActionResult Index()
        {
            SedcDatabase database = new SedcDatabase();
            List<Picture> pictures = database.Pictures
                .ToList();
            return View(pictures);
        }

        public ActionResult Create()
        {

            //string path =  Directory.GetCurrentDirectory();
            return View("~/Views/Picture/CreateWithHelpers.cshtml");
        }

        [HttpPost]
        public ActionResult Create(Picture picture)
        {
            if (ModelState.IsValid)
            {
                var db = new SedcDatabase();
                db.Pictures.Add(picture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("~/Views/Picture/CreateWithHelpers.cshtml", picture);
        }
    }
}
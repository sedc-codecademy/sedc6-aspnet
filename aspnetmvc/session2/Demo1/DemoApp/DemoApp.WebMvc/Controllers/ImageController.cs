using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoApp.WebMvc.Models;

namespace DemoApp.WebMvc.Controllers
{
    public class ImageController : Controller
    {
        private static List<Image> _images = new List<Image>
        {
            new Image{ DisplayName= "Image1", Description = "desc1", Height= 100, Width = 100 },
            new Image{ DisplayName= "Image2", Description = "desc2", Height= 100, Width = 100 },
            new Image{ DisplayName= "Image3", Description = "desc3", Height= 100, Width = 100 }
        };
        // GET: Image
        public ActionResult Index()
        {

            return View(_images);
        }

        // GET: Image/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Image/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Image/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Image/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Image/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Image/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Image/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

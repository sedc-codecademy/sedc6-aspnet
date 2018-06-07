using Sedc.MusicManagement.Models;
using Sedc.MusicManagement.Repositories.EntityFramework;
using Sedc.MusicManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sedc.MusicManagement.Web.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly IArtistRepository _artsitsRepository;

        public ArtistsController()
        {
            _artsitsRepository = new ArtistsRepository();
        }
        
        protected override void Dispose(bool disposing)
        {             
            _artsitsRepository.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult Index()
        {
            var artists = _artsitsRepository.GetAll();
            return View(artists);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Artist a)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var artist = _artsitsRepository.Create(a);
                    return RedirectToAction("Details", new { id = artist.Id });
                }
                catch (Exception ex)
                {
                    return View(a);   
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
                return RedirectToAction("Index");

            var artist = _artsitsRepository.GetById(id.Value);

            if (artist == null)
                return RedirectToAction("Index");

           return View(artist);
        }
    }
}
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

        public ActionResult Index()
        {
            var artists = _artsitsRepository.GetAll();
            return View(artists);
        }
    }
}
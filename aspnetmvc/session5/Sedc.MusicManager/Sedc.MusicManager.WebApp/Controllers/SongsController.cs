using Sedc.MusicManager.WebApp.Data;
using Sedc.MusicManager.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sedc.MusicManager.WebApp.Controllers
{
    public class SongsController : Controller
    {

        public ActionResult Index()
        {
            MusicDb db = new MusicDb();
            
            IQueryable<Song> results = db.Songs
                .Where(s => s.Duration > 100)
                .Where(s => s.Duration > 100)
                .Where(s => s.Duration > 100)   ;

            List<Song> songs = results.ToList();

            return View(songs);
        }

        public ActionResult Create()
        {   
            return View();
        }
    }
}
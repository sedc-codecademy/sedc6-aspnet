using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sedc.MusicManager.WebApp.Data;
using Sedc.MusicManager.WebApp.Models;

namespace Sedc.MusicManager.WebApp.Controllers
{
    public class AlbumsController : Controller
    {
        private MusicDb db = new MusicDb();

        // GET: Albums
        public ActionResult Index()
        {
            var albums = db.Albums.ToList();
            return View(albums);
        }

        // GET: Albums/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Album album = db.Albums.FirstOrDefault(x => x.Id == id);
            if (album == null)
            {
                return RedirectToAction("Index");
            }
            return View(album);
        }

        // GET: Albums/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                db.Albums.Add(album);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(album);
        }

        // GET: Albums/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtistId = new SelectList(db.Artists, "Id", "FullName", album.ArtistId);
            return View(album);
        }

        // POST: Albums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit(Album album)
        {
            if (ModelState.IsValid)
            {
                var dbAlbum = db.Albums.FirstOrDefault(x => x.Id == album.Id);
                dbAlbum.Title = album.Title;
                dbAlbum.Genre = album.Genre;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(album);
        }

        // GET: Albums/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Album album = db.Albums.Find(id);
            if (album == null)
            {
                return RedirectToAction("Index");
            }
            return View(album);
        }

        // POST: Albums/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (!id.HasValue)
                return RedirectToAction("Index");

            Album album = db.Albums.FirstOrDefault(x => x.Id == id);
            if (album == null)
                return RedirectToAction("Index");
            db.Albums.Remove(album);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

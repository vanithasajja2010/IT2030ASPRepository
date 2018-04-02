using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        MVCMusicStoreDB db = new MVCMusicStoreDB();

        // GET: Store
        public ActionResult Index(int id)
        {
            var albums = db.Albums.Where(n=>n.GenreId==id).ToList();
            return View(albums);
        }

        public ActionResult Browse()
        {
            var genres = db.Genres.ToList();
            return View(genres) ;
        }

        public ActionResult Details(int id)
        {
            var album = db.Albums.Where(n => n.AlbumId == id).FirstOrDefault<Album >() ;
            return View(album);
        }
    }
}
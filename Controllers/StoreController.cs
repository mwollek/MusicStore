using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {

        //Repo
        MusicStoreEntities storeDB = new MusicStoreEntities();

        // GET: Store
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);

        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre() { Name = genre };
            return View(genreModel);
        }

        // GET: Store/Details
        public ActionResult Details(int? id)
        {
            var album = new Album() { Title = "Album " + id };
            return View(album);
        }
    }
}
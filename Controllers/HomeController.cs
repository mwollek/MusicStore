using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {

        ApplicationDbContext db = new ApplicationDbContext();

        
        // GET: Home
        public ActionResult Index()
        {
            var albums = GetTopSellingAlbums(5);
            return View(albums);

        }

        private List<Album> GetTopSellingAlbums(int count)
        {
            return db.Albums.OrderByDescending(a => a.OrderDetails.Count()).Take(count).ToList();
        }
    }
}
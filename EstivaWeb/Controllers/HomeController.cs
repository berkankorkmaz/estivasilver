using EstivaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstivaWeb.Controllers
{
    public class HomeController : Controller
    {
        EstivaContext db = new EstivaContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _SonUrunler()
        {
            List<Urun> sonurunler = db.Uruns
                .OrderByDescending(x => x.Id)
                .Take(40)
                .ToList();

            return View(sonurunler);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
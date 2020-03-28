using EstivaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstivaWeb.Controllers
{
    public class SearchController : Controller
    {
        EstivaContext db = new EstivaContext();

        public ActionResult Index(string q)
        {
            List<Urun> urunler = db.Uruns
                .Where(x => x.Urunadi.Contains(q) || x.UrunKodu.Contains(q))
                .ToList();

            return View(urunler);
        }
    }
}
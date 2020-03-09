using EstivaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstivaWeb.Controllers
{
    public class SliderController : Controller
    {
        EstivaContext db = new EstivaContext();
        // GET: Slider
        public ActionResult _UrunCarousel()
        {
            List<Urun> urunler = db.Uruns.Include("Kategoriler").ToList();
            return View(urunler);
        }

        public ActionResult _HomeSlider2()
        {
            List<Urun> urunler = db.Uruns.Include("Kategoriler").ToList();
            return View(urunler);
        }

        public ActionResult _HomeSlider3()
        {
            List<Urun> urunler = db.Uruns.Include("Kategoriler").ToList();
            return View(urunler);
        }

        public ActionResult _HomeSlider4()
        {
            List<Urun> urunler = db.Uruns.Include("Kategoriler").ToList();
            return View(urunler);
        }

        public ActionResult _HomeSlider5()
        {
            List<Urun> urunler = db.Uruns.Include("Kategoriler").ToList();
            return View(urunler);
        }

        public ActionResult _HomeSlider6()
        {
            List<Urun> urunler = db.Uruns.Include("Kategoriler").ToList();
            return View(urunler);
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
using EstivaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstivaWeb.Controllers
{
    public class KategorilerController : Controller
    {
        EstivaContext db = new EstivaContext();
        public ActionResult Kolyeler()
        {
            Kategori kat = db.Kategoris.Where(x => x.KategoriAdi == "Kolyeler").FirstOrDefault();

            if (kat == null) return HttpNotFound();

            List<Urun> urunler = kat.Urunler.ToList();
            return View(urunler);
        }
        public ActionResult Küpeler()
        {
            Kategori kat = db.Kategoris.Where(x => x.KategoriAdi == "Küpeler").FirstOrDefault();

            if (kat == null) return HttpNotFound();

            List<Urun> urunler = kat.Urunler.ToList();
            return View(urunler);
        }
        public ActionResult Yüzükler()
        {
            Kategori kat = db.Kategoris.Where(x => x.KategoriAdi == "Yüzükler").FirstOrDefault();

            if (kat == null) return HttpNotFound();

            List<Urun> urunler = kat.Urunler.ToList();
            return View(urunler);
        }
        public ActionResult Bileklikler()
        {
            Kategori kat = db.Kategoris.Where(x => x.KategoriAdi == "Bileklikler").FirstOrDefault();

            if (kat == null) return HttpNotFound();

            List<Urun> urunler = kat.Urunler.ToList();
            return View(urunler);
        }
        public ActionResult Saatler()
        {
            Kategori kat = db.Kategoris.Where(x => x.KategoriAdi == "Saatler").FirstOrDefault();

            if (kat == null) return HttpNotFound();

            List<Urun> urunler = kat.Urunler.ToList();
            return View(urunler);
        }
        public ActionResult Erkek()
        {
            Kategori kat = db.Kategoris.Where(x => x.KategoriAdi == "Erkek").FirstOrDefault();

            if (kat == null) return HttpNotFound();

            List<Urun> urunler = kat.Urunler.ToList();
            return View(urunler);
        }
    }
}
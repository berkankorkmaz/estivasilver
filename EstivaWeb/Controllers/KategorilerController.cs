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

        public ActionResult KategoriDetay(int? id)
        {
            if (!id.HasValue)
                return RedirectToAction("Index", "Home");

            Kategori secilenKat = db.Kategoris
                .Include("Urunler")
                .FirstOrDefault(x=> x.Id == id.Value);

            return View(secilenKat);
        }
    }
}
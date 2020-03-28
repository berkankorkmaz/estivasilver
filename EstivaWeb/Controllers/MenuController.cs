using EstivaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstivaWeb.Controllers
{
    public class MenuController : Controller
    {
        EstivaContext db = new EstivaContext();
        public ActionResult _UstMenu()
        {
            List<Kategori> kategoriler = db.Kategoris
                .OrderBy(x => x.KategoriAdi)
                .ToList();

            return View(kategoriler);
        }
    }
}
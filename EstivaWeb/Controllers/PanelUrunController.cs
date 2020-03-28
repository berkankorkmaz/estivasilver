using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EstivaWeb.Models;

namespace EstivaWeb.Controllers
{

    [Authorize]
    public class PanelUrunController : Controller
    {

        private EstivaContext db = new EstivaContext();
        private string resimpath = "/Content/images/urunler/";

  

        public ActionResult Index()
        {
            return View(db.Uruns.ToList());
        }

        // GET: PanelUrun/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = db.Uruns.Find(id);
            if (urun == null)
            {
                return HttpNotFound();
            }
            return View(urun);
        }

        // GET: PanelUrun/Create
        public ActionResult Create()
        {
            ViewBag.Kategoriler = db.Kategoris.ToList();
            return View();
        }

        // POST: PanelUrun/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Urun urun, int[] kategori, HttpPostedFileBase resiminput)
        {
            if (ModelState.IsValid)
            {
                string path = Server.MapPath(resimpath);
                string resimAdi = resiminput.FileName;

                //TODO: burada ayni dosya adi varsa degistirilmeli

                resiminput.SaveAs(path + resimAdi);

                urun.UrunResmi = resimAdi;

                if(kategori.Length != 0)
                {
                    List<Kategori> secilenler = db.Kategoris.Where(x=> kategori.Contains(x.Id)).ToList();
                    urun.Kategoriler.AddRange(secilenler);
                }

                db.Uruns.Add(urun);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Kategoriler = db.Kategoris.ToList();
            return View(urun);
        }

        // GET: PanelUrun/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = db.Uruns.Find(id);
            if (urun == null)
            {
                return HttpNotFound();
            }

            ViewBag.Kategoriler = db.Kategoris.ToList();
            return View(urun);
        }

        // POST: PanelUrun/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Urun urun, HttpPostedFileBase resiminput)
        {
            if (ModelState.IsValid)
            {
                Urun eskihali = db.Uruns.Where(x=>x.Id == urun.Id).FirstOrDefault();

                if(resiminput != null)
                {
                    string path = Server.MapPath(resimpath);

                    try
                    {
                        System.IO.File.Delete(path + eskihali.UrunResmi);
                    }
                    catch { }

                    try
                    {
                        resiminput.SaveAs(path + eskihali.UrunResmi);
                        eskihali.UrunResmi = resiminput.FileName;
                    }
                    catch { }
                }

                //TODO: kategori duzenle





                db.Entry(eskihali).CurrentValues.SetValues(urun);
                db.Entry(eskihali).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Kategoriler = db.Kategoris.ToList();
            return View(urun);
        }

        // GET: PanelUrun/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = db.Uruns.Find(id);
            if (urun == null)
            {
                return HttpNotFound();
            }
            return View(urun);
        }

        // POST: PanelUrun/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Urun urun = db.Uruns.Find(id);
            string path = Server.MapPath(resimpath);
            try
            {
                System.IO.File.Delete(path + urun.UrunResmi);
            }
            catch { }

            db.Uruns.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
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

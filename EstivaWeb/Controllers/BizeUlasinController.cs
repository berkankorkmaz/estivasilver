using EstivaWeb.Models;
using EstivaWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstivaWeb.Controllers
{
    public class BizeUlasinController : Controller
    {
        EstivaContext db = new EstivaContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact mesaj)
        {
            if (mesaj == null)
            {
                ViewBag.Sonuc = "Lütfen formu doldurunuz.";
                return View();
            }

            db.Contacts.Add(mesaj);
            db.SaveChanges();

            

            ViewBag.Sonuc = "Mesajınız gönderildi.";
            return View();
        }

        public void MailHazirla()
        {
            
        }
    }
}
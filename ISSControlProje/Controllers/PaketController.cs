using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISSControlProje.Models.Entity;

namespace ISSControlProje.Controllers
{
    public class PaketController : Controller
    {

        iss_webEntities db = new iss_webEntities();

        // GET: Paket
        public ActionResult Index()
        {
            ViewBag.paketler = db.tblPaketler.ToList();
            return View();
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(tblPaketler pkt)
        {
            db.tblPaketler.Add(pkt);
            db.SaveChanges();
            return View();
        }

        public ActionResult Sil(int id)
        {
            db.tblPaketler.Remove(db.tblPaketler.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var paket = db.tblPaketler.Find(id);
            return View("Guncelle", paket);
        }

        [HttpPost]
        public ActionResult Guncelle(tblPaketler pkt)
        {
            var paket = db.tblPaketler.Find(pkt.paketId);
            paket.paketAd = pkt.paketAd;
            paket.paketFiyat = pkt.paketFiyat;
            paket.paketAciklamasi = pkt.paketAciklamasi;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
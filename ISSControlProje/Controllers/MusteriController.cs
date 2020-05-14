using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Tokenizer;
using ISSControlProje.Models.Entity;

namespace ISSControlProje.Controllers
{
    public class MusteriController : Controller
    {
        iss_webEntities vt = new iss_webEntities();

        // GET: Musteri
        public ActionResult Index()
        {
            return View(vt.tblMusteriler.ToList());
        }

        public ActionResult Sil(int id)
        {
            vt.tblMusteriler.Remove(vt.tblMusteriler.Find(id));
            vt.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(tblMusteriler mstr)
        {
            vt.tblMusteriler.Add(mstr);
            vt.SaveChanges();
            return View();
        }
    }
}
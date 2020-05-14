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
    }
}
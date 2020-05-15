using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISSControlProje.Models.Entity;

namespace ISSControlProje.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        iss_webEntities vt = new iss_webEntities();

        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home", new { area = "" });
        }
        [HttpPost]
        public ActionResult Login(string email, string parola)
        {
            var yonetici = vt.tblYoneticiler.Any(y => y.email == email && y.parola == parola);
            if(yonetici)
            {
                Session.Add("yonetici", true);
                return RedirectToAction("Index", "Musteri", new { area = "" });
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult egitimlerim()
        {
            var egitimlerim = db.TblEgitimlerim.ToList();
            return PartialView(egitimlerim);
        }

        public PartialViewResult Yeteneklerim()
        {
            var Yetenekler = db.TblYeteneklerim.ToList();
            return PartialView(Yetenekler);
        }

        public PartialViewResult Hobilerim()
        {
            var hobiler = db.TblHobilerim.ToList();
            return PartialView(hobiler);
        }

        public PartialViewResult Sertifikalarım()
        {
            var Sertifika = db.TblSertifikalarim.ToList();
            return PartialView(Sertifika);
        }

        [HttpGet]
        public PartialViewResult İletisim()
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult İletisim(Tblİletişim t)
        {
            db.Tblİletişim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}
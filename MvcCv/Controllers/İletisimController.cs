using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim
        GenericRepository<Tblİletişim> repo = new GenericRepository<Tblİletişim>(); 
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}
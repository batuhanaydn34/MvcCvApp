﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim
        GenericRepository<TblEgitimlerim> repo = new GenericRepository<TblEgitimlerim>();
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }

        [HttpGet]
        public ActionResult EgitimEkle() 
        {
            return View();
        
        }

        [HttpPost]
        public ActionResult EgitimEkle(TblEgitimlerim p)
        {
            if (!ModelState.IsValid) 
            {
                return View("EgitimEkle");
            }

            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult EgitimSil(int id) 
        {
            TblEgitimlerim t = repo.Find(x => x.ID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EgitimDuzenle(int id)
        {
            var egitim = repo.Find(x => x.ID == id);
            return View(egitim);

        }

        [HttpGet]
        public ActionResult EgitimDuzenle(TblEgitimlerim t) 
        {

            if (!ModelState.IsValid)
            {
                return View("EgitimDuzenle");
            }
            var egitim = repo.Find(x => x.ID == t.ID);
            egitim.Baslik = t.Baslik;
            egitim.AltBaslik1 = t.AltBaslik1;
            egitim.AltBaslik2 = t.AltBaslik2;
            egitim.GNO = t.GNO;
            egitim.Tarih = t.GNO;
            repo.TUpdate(egitim);
            return RedirectToAction("Index");
            
            
        }
    }
}
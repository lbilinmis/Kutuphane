using Kutuphane.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class OduncController : BaseController
    {
        // GET: Odunc
        public ActionResult Index()
        {
            var liste = dBEntities.TblHareket.ToList();

            return View(liste);
        }

        public ActionResult OduncVer()
        {
            ViewBag.personeller = this.SelectList_Personeller();
            ViewBag.uyeler = this.SelectList_Uyeler();
            ViewBag.kitaplar = this.SelectList_Kitaplar();

            return View();
        }


        [HttpPost]
        public ActionResult OduncVer(TblHareket entity)
        {
            //ViewBag.categories= SelectList_Category();
            //ViewBag.yazarlar= SelectList_Yazarlar();

            var kitap = dBEntities.TblKitap.Where(c => c.Id == entity.KitapId).FirstOrDefault();
            var personel = dBEntities.TblPersonel.Where(c => c.Id == entity.PersonelId).FirstOrDefault();

            entity.TblKitap = kitap;
            entity.TblPersonel = personel;

            dBEntities.TblHareket.Add(entity);
            dBEntities.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult IadeAl(int Id)
        {
            ViewBag.personeller = this.SelectList_Personeller();
            ViewBag.uyeler = this.SelectList_Uyeler();
            ViewBag.kitaplar = this.SelectList_Kitaplar();

            var iadeKayit = this.Find(Id);
            return View(iadeKayit);
        }

        [HttpPost]
        public ActionResult IadeAl()
        {
            return View();
        }


        public TblHareket Find(int id)
        {
            var hareket = dBEntities.TblHareket.Find(id);

            return hareket;
        }
    }
}
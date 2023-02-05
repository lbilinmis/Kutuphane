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
            var liste = dBEntities.TblHareket.Where(x => x.Durumu != true).ToList();

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
            TimeSpan fark = Convert.ToDateTime(DateTime.Now.ToShortDateString()) - DateTime.Parse(iadeKayit.IadeTarihi.ToString());

            ViewBag.GecikmeSuresi = fark.TotalDays;
            return View(iadeKayit);
        }

        [HttpPost]
        public ActionResult IadeAl(TblHareket iadeIslemi)
        {
            var iadeKayit = this.Find(iadeIslemi.Id);

            var Personel = dBEntities.TblPersonel.Where(c => c.Id == iadeIslemi.PersonelId).FirstOrDefault();
            var Kitap = dBEntities.TblKitap.Where(c => c.Id == iadeIslemi.KitapId).FirstOrDefault();
            var Uye = dBEntities.TblUye.Where(c => c.Id == iadeIslemi.UyeId).FirstOrDefault();


            iadeKayit.TeslimTarihi = DateTime.Now;
            iadeKayit.Durumu = true;
            iadeKayit.TblPersonel = Personel;
            iadeKayit.TblKitap = Kitap;
            iadeKayit.TblUye = Uye;

            dBEntities.SaveChanges();
            return View();
        }


        public TblHareket Find(int id)
        {
            var hareket = dBEntities.TblHareket.Find(id);

            return hareket;
        }
    }
}
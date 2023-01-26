using Kutuphane.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class KitapController : BaseController
    {
        // GET: Kitap
        public ActionResult Index(string keyword)
        {
            //var liste = dBEntities.TblKitap.ToList();

            var query = from x in dBEntities.TblKitap
                        select x;

            if (!String.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.Ad.ToLower().Contains(keyword) || x.TblCategory.Ad.Contains(keyword) || x.TblYazar.Ad.Contains(keyword) || x.TblYazar.Soyad.Contains(keyword) ||x.YayinEvi.Contains(keyword));
            }

            var liste = query.ToList();
            return View(liste);
        }
        public ActionResult Add()
        {
            ViewBag.categories = SelectList_Category();
            ViewBag.yazarlar = SelectList_Yazarlar();
            return View();
        }

        [HttpPost]
        public ActionResult Add(TblKitap entity)
        {
            //ViewBag.categories= SelectList_Category();
            //ViewBag.yazarlar= SelectList_Yazarlar();

            var category = dBEntities.TblCategory.Where(c => c.Id == entity.KategoriId).FirstOrDefault();
            var yazar = dBEntities.TblYazar.Where(c => c.Id == entity.YazarId).FirstOrDefault();

            entity.TblYazar = yazar;
            entity.TblCategory = category;

            dBEntities.TblKitap.Add(entity);
            dBEntities.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var kitap = Find(id);
            dBEntities.TblKitap.Remove(kitap);
            dBEntities.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Edit(int id)
        {
            ViewBag.categories = SelectList_Category();
            ViewBag.yazarlar = SelectList_Yazarlar();
            var kitap = dBEntities.TblKitap.Find(id);
            if (kitap == null)
            {
                return RedirectToAction("Index");
            }
            return View(kitap);
        }

        [HttpPost]
        public ActionResult Edit(TblKitap entity)
        {
            var kitap = Find(entity.Id);
            var category = dBEntities.TblCategory.Where(c => c.Id == entity.KategoriId).FirstOrDefault();
            var yazar = dBEntities.TblYazar.Where(c => c.Id == entity.YazarId).FirstOrDefault();

            kitap.Ad = entity.Ad;
            kitap.YayinEvi = entity.YayinEvi;
            kitap.Sayfa = entity.Sayfa;
            kitap.BasimYili = entity.BasimYili;
            kitap.TblYazar = yazar;
            kitap.TblCategory = category; ;

            dBEntities.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public TblKitap Find(int id)
        {
            var kitap = dBEntities.TblKitap.Find(id);

            return kitap;
        }

    }
}
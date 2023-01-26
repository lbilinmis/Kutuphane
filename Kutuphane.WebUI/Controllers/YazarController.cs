using Kutuphane.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class YazarController : BaseController
    {
        // GET: Yazar
        public ActionResult Index()
        {
            var liste = dBEntities.TblYazar.ToList();

            return View(liste);
        }


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(TblYazar entity)
        {
            dBEntities.TblYazar.Add(entity);
            dBEntities.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var yazar = dBEntities.TblYazar.Find(id);
            if (yazar == null)
            {
                return RedirectToAction("Index");
            }
            return View(yazar);
        }

        [HttpPost]
        public ActionResult Edit(TblYazar entity)
        {
            var yazar = Find(entity.Id);
            yazar.Ad = entity.Ad;
            yazar.Soyad = entity.Soyad;
            yazar.Detay = entity.Detay;
            dBEntities.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var yazar = Find(id);
            dBEntities.TblYazar.Remove(yazar);
            dBEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public TblYazar Find(int id)
        {
            var yazar = dBEntities.TblYazar.Find(id);

            return yazar;
        }
    }
}
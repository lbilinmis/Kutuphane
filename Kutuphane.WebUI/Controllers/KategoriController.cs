using Kutuphane.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class KategoriController : BaseController
    {
        // GET: Kategori
        public ActionResult Index()
        {
            var liste = dBEntities.TblCategory.Where(x=>x.Durum==true).ToList();

            return View(liste);
        }


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(TblCategory entity)
        {
            dBEntities.TblCategory.Add(entity);
            dBEntities.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var category = dBEntities.TblCategory.Find(id);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(TblCategory entity)
        {
            var category = Find(entity.Id);
            category.Ad = entity.Ad;
            dBEntities.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var category = Find(id);
            //dBEntities.TblCategory.Remove(category);
            category.Durum = false;
            dBEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public TblCategory Find(int id)
        {
            var category = dBEntities.TblCategory.Find(id);

            return category;
        }
    }
}
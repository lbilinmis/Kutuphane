using Kutuphane.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class DuyuruController : BaseController
    {
        // GET: Duyuru
        public ActionResult Index()
        {
            var list = dBEntities.TblDuyuru.ToList();
            return View(list);
        }



        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(TblDuyuru entity)
        {
            entity.Tarih = DateTime.UtcNow;
            dBEntities.TblDuyuru.Add(entity);
            dBEntities.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var duyuru = dBEntities.TblDuyuru.Find(id);
            if (duyuru == null)
            {
                return RedirectToAction("Index");
            }
            return View(duyuru);
        }

        [HttpPost]
        public ActionResult Edit(TblDuyuru entity)
        {
            var duyuru = Find(entity.Id);
            duyuru.Kategori = entity.Kategori;
            duyuru.Icerik = entity.Icerik;
            dBEntities.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var duyuru = Find(id);
            dBEntities.TblDuyuru.Remove(duyuru);
        
            dBEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public TblDuyuru Find(int id)
        {
            var duyuru = dBEntities.TblDuyuru.Find(id);

            return duyuru;
        }
    }
}
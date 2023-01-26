using Kutuphane.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class PersonelController : BaseController
    {
        // GET: Personel
        public ActionResult Index()
        {
            var liste = dBEntities.TblPersonel.ToList();

            return View(liste);
        }


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(TblPersonel entity)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            dBEntities.TblPersonel.Add(entity);
            dBEntities.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var personel = dBEntities.TblPersonel.Find(id);
            if (personel == null)
            {
                return RedirectToAction("Index");
            }
            return View(personel);
        }

        [HttpPost]
        public ActionResult Edit(TblPersonel entity)
        {
            var personel = Find(entity.Id);
            if (!ModelState.IsValid)
            {
                return View(personel);
            }

            personel.AdSoyad = entity.AdSoyad;
            dBEntities.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var personel = Find(id);
            dBEntities.TblPersonel.Remove(personel);
            dBEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public TblPersonel Find(int id)
        {
            var personel = dBEntities.TblPersonel.Find(id);

            return personel;
        }
    }
}
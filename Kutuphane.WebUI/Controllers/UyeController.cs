using Kutuphane.WebUI.Models.Entity;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class UyeController : BaseController
    {
        // GET: Uye
        public ActionResult Index(int page=1)
        {
            //nuget ten pagedlist eklendi
            var liste = dBEntities.TblUye.ToList().ToPagedList(page,10);

            return View(liste);
        }


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(TblUye entity)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            dBEntities.TblUye.Add(entity);
            dBEntities.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var personel = dBEntities.TblUye.Find(id);
            if (personel == null)
            {
                return RedirectToAction("Index");
            }
            return View(personel);
        }

        [HttpPost]
        public ActionResult Edit(TblUye entity)
        {
            var personel = Find(entity.Id);
            if (!ModelState.IsValid)
            {
                return View(personel);
            }

            personel.Ad= entity.Ad;
            personel.Soyad = entity.Soyad;
            personel.EMail = entity.EMail;
            personel.KullaniciAdi = entity.KullaniciAdi;
            personel.Sifre = entity.Sifre;
            personel.Fotograf= entity.Fotograf;
            personel.Telefon= entity.Telefon;
            personel.Okul= entity.Okul;
            dBEntities.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var personel = Find(id);
            dBEntities.TblUye.Remove(personel);
            dBEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AlinanKitaplar(int id)
        {
            List<TblHareket> kitaplar = new List<TblHareket>();
            var personel = dBEntities.TblUye.Find(id);
            if (personel!=null)
            {
                kitaplar=dBEntities.TblHareket.Where(x=>x.UyeId==id).ToList();
            }
            return View(kitaplar);
        }
        public TblUye Find(int id)
        {
            var personel = dBEntities.TblUye.Find(id);

            return personel;
        }
    }
}
using Kutuphane.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class BaseController : Controller
    {
        public KutuphaneDBEntities dBEntities = null;

        public BaseController()
        {
            dBEntities = new KutuphaneDBEntities();
        }
        // GET: Base

        public List<SelectListItem> SelectList_Category()
        {
            List<SelectListItem> categories = (from category in dBEntities.TblCategory.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = category.Ad,
                                                   Value = category.Id.ToString()
                                               }).ToList();

            return categories;
        }

        public List<SelectListItem> SelectList_Yazarlar()
        {
            List<SelectListItem> yazarlar = (from yazar in dBEntities.TblYazar.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = yazar.Ad + " " + yazar.Soyad,
                                                 Value = yazar.Id.ToString()
                                             }).ToList();

            return yazarlar;
        }


        public List<SelectListItem> SelectList_Uyeler()
        {
            List<SelectListItem> uyeler = (from uye in dBEntities.TblUye.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = uye.Ad + " " + uye.Soyad,
                                                 Value = uye.Id.ToString()
                                             }).ToList();

            return uyeler;
        }

        public List<SelectListItem> SelectList_Personeller()
        {
            List<SelectListItem> personeller = (from personel in dBEntities.TblPersonel.ToList()
                                           select new SelectListItem
                                           {
                                               Text = personel.AdSoyad ,
                                               Value = personel.Id.ToString()
                                           }).ToList();

            return personeller;
        }

        public List<SelectListItem> SelectList_Kitaplar(bool? durum)
        {
            List<TblKitap> kitapListesi = new List<TblKitap>();
            if (durum.HasValue)
            {
                kitapListesi = dBEntities.TblKitap.Where(x => x.Durum == durum.Value).ToList();
            }
            else
            {
                kitapListesi= dBEntities.TblKitap.ToList();
            }
        

            List<SelectListItem> kitaplar = (from kitap in kitapListesi
                                             select new SelectListItem
                                                {
                                                    Text = kitap.Ad,
                                                    Value = kitap.Id.ToString()
                                                }).ToList();

            

            return kitaplar;
        }


    }
}
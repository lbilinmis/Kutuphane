using Kutuphane.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.UyeSayisi = dBEntities.TblUye.ToList().Count();
            ViewBag.KitapSayisi = dBEntities.TblKitap.ToList().Count();
            ViewBag.OduncKitapSayisi = dBEntities.TblKitap.Where(x => x.Durum == false).ToList().Count();
            ViewBag.ToplamCeza = (dBEntities.TblCeza.Sum(x => x.ParaCezasi));

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cards()
        {
            ViewBag.Enfazla = dBEntities.Database.SqlQuery<string>("EnFazlaKitapOlanYazar").FirstOrDefault().ToString();
            ViewBag.YayinEvi=  dBEntities.TblKitap.GroupBy(x => x.YayinEvi).OrderByDescending(y => y.Count()).Select(z => new
            {
                z.Key
            }).FirstOrDefault();
            //ViewBag.Enfazla = dBEntities.EnFazlaKitapOlanYazar<string>("").FirstOrDefault().ToString();

            List<CardViewModel> list = new List<CardViewModel>()
            {
                new CardViewModel()
                {
                    Baslik = "Kitap Sayısı",
                    Sayi = dBEntities.TblKitap.ToList().Count().ToString(),
                },

                 new CardViewModel()
                {
                    Baslik = "Üye Sayısı",
                    Sayi = dBEntities.TblUye.ToList().Count().ToString()
                },


                  new CardViewModel()
                {
                    Baslik = "Ödünç Kitap Sayısı",
                    Sayi = dBEntities.TblKitap.Where(x=>x.Durum==false).ToList().Count().ToString(),
                },

                new CardViewModel()
                {
                    Baslik = "Toplam Kasa Tutarı",
                    Sayi = dBEntities.TblCeza.Sum(x=>x.ParaCezasi).ToString(),
                },
                 new CardViewModel()
                {
                    Baslik = "Kategori Sayısı",
                    Sayi = dBEntities.TblCategory.ToList().Count().ToString()
                },

                  new CardViewModel()
                {
                    Baslik = "Mesaj Sayısı",
                    Sayi = dBEntities.TblIletisim.ToList().Count().ToString()
                },

                   new CardViewModel()
                {
                    Baslik = "Yazar Kitap Sayısı",
                   Sayi = ViewBag.Enfazla
        },

                    new CardViewModel()
        {
            Baslik = "Yayın Evi Sayısı",
                  Sayi=ViewBag.YayinEvi
                },


            };


            return View(list);
        }
    }
}
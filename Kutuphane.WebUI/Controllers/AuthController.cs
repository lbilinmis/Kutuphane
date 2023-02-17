using Kutuphane.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Kutuphane.WebUI.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        // GET: Auth
        public ActionResult Register()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(TblUye entity)
        {
            TblUye loginUye = dBEntities.TblUye.Where(x => x.EMail == entity.EMail && x.Sifre == entity.Sifre).FirstOrDefault();

            if (loginUye != null)
            {
                FormsAuthentication.SetAuthCookie(loginUye.EMail, false);
                Session["user"] = loginUye;
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Profilim()
        {
            TblUye loginUye =(TblUye)Session["user"];

            if (loginUye == null)
            {
            }

            return View(loginUye);
        }

        [HttpPost]
        public ActionResult Profilim(TblUye entity)
        {
            TblUye guncellemeUye = dBEntities.TblUye.FirstOrDefault(x=>x.EMail== entity.EMail);

            guncellemeUye.Sifre= entity.Sifre;
            guncellemeUye.Okul= entity.Okul;

            dBEntities.SaveChanges();
            Session["user"] = guncellemeUye;
            return RedirectToAction("Index","Home");
        }


        public ActionResult KitapGecmisi()
        {
            TblUye loginUye = (TblUye)Session["user"];

            List<TblHareket> list = dBEntities.TblHareket.Where(x => x.UyeId == loginUye.Id).ToList();

            return View(list);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["user"]=null; 

            return RedirectToAction("Index","Home");
        }

    }
}
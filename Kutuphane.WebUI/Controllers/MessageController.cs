using Kutuphane.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class MessageController : BaseController
    {
        // GET: Message
        public ActionResult Index()
        {

            var list = dBEntities.TblMesajlar.ToList();

            return View(list);
        }

        public ActionResult GelenMesajlar()
        {
            TblUye loginUye = (TblUye)Session["user"];

            var list = dBEntities.TblMesajlar.Where(x => x.Alici == loginUye.EMail).ToList();

            return View("Index",list);
        }

        public ActionResult GidenMesajlar()
        {
            TblUye loginUye = (TblUye)Session["user"];

            var list = dBEntities.TblMesajlar.Where(x => x.Gonderen == loginUye.EMail).ToList();

            return View("Index", list);
        }


        public ActionResult NewMessage()
        {

            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(TblMesajlar entity)
        {
            TblUye loginUye = (TblUye)Session["user"];

            entity.Tarih = DateTime.Now;
            entity.Gonderen = loginUye.EMail;
            dBEntities.TblMesajlar.Add(entity);
            dBEntities.SaveChangesAsync();
            return View();
        }
    }
}
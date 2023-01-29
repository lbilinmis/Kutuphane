using Kutuphane.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class VitrinController : BaseController
    {
        // GET: Vitrin
        public ActionResult Index()
        {
            var list = dBEntities.TblKitap.ToList();
            return View(list);
        }

        public ActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Contact(TblIletisim entity)
        {
            dBEntities.TblIletisim.Add(entity);
            dBEntities.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
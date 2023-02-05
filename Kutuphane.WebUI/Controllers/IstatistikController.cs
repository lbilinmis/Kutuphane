using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class IstatistikController : BaseController
    {
        // GET: Istatistik
        public ActionResult Galeri()
        {
            return View();
        }

        public ActionResult ImageUpload(HttpPostedFileBase dosya)
        {
            if (dosya.ContentLength > 0)
            {
                string dosyaYolu=Path.Combine(Server.MapPath("~/Uploads/"),Path.GetFileName(dosya.FileName));
                dosya.SaveAs(dosyaYolu);
            }

            return RedirectToAction("Galeri");
        }
    }
}
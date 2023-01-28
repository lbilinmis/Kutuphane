using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.WebUI.Controllers
{
    public class IslemController : BaseController
    {
        // GET: Islem
        public ActionResult Index()
        {
            var liste = dBEntities.TblHareket.Where(x => x.Durumu == true).ToList();

            return View(liste);
        }
    }
}
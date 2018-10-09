using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace ttt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Name()
        {
            return Json(new { tt = "mahmoud" }, JsonRequestBehavior.AllowGet);
        }
    }
}

using System.Net;
using System.Text;
using System.Web.Mvc;
using ttt.Models;

namespace ttt.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        => View("Index");

        public ActionResult NamedView()
        => View("OtherView");

        public ActionResult ViewWithModel()
        => View(new Genre(1, "first"));

        public ContentResult ViewWithParameter(int id)
        => Content(GetStringOfNumber(id));

        public ActionResult ViewWithStatus()
        => new HttpStatusCodeResult(HttpStatusCode.PaymentRequired);

        public ActionResult FileView()
        => File(Encoding.UTF8.GetBytes("Hello World"), "application/octet-stream");

        public ActionResult NewOne()
        => View("NewOne");

        [HttpPost]
        public ActionResult Add(Genre model)
        {
            if (!ModelState.IsValid)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return View(model);
        }

        private string GetStringOfNumber(int id)
        {
            if (id == 1)
                return "first";
            if (id == 2)
                return "second";
            if (id == 3)
                return "third";
            return "not found";
        }
    }
}

using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Divisions()
        {
            ViewBag.Title = "Divisions";
            return View();
        }
    }
}
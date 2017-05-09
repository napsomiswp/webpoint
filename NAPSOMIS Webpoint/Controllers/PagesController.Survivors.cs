using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Survivors()
        {
            ViewBag.Title = "Survivors";
            return View();
        }
    }
}
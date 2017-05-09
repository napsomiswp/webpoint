using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Investments()
        {
            ViewBag.Title = "Investments";
            return View();
        }
    }
}
using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult HistoricalOverview()
        {
            ViewBag.Title = "Historical Overview";
            return View();
        }
    }
}
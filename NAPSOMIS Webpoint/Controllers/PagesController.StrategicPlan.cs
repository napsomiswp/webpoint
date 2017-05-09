using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult StrategicPlan()
        {
            ViewBag.Title = "Strategic Plan";
            return View();
        }
    }
}
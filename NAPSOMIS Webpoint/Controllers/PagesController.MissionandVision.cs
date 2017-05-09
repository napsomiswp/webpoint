using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult MissionandVision()
        {
            ViewBag.Title = "Mission and Vision";
            return View();
        }
    }
}
using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult BusinessPlan()
        {
            ViewBag.Title = "Business Plan";
            return View();
        }
    }
}
using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult GeneralInfo()
        {
            ViewBag.Title = "General Information";
            return View();
        }
    }
}
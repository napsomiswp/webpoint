using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult BoardofTrustees()
        {
            ViewBag.Title = "Board of Trustees";
            return View();
        }
    }
}
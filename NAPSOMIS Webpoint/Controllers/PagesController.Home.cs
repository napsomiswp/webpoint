using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Home()
        {
            ViewBag.Title = "Home";
            return View();
        }
    }
}
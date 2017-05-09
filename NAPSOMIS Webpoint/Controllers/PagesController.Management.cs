using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Management()
        {
            ViewBag.Title = "Management";
            return View();
        }
    }
}
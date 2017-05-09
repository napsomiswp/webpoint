using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Directorate()
        {
            ViewBag.Title = "Directorate";
            return View();
        }
    }
}
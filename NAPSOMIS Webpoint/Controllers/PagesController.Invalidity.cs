using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Invalidity()
        {
            ViewBag.Title = "Invalidity";
            return View();
        }
    }
}
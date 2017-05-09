using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult TheAct()
        {
            ViewBag.Title = "The Act";
            return View();
        }
    }
}
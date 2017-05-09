using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult OldAge()
        {
            ViewBag.Title = "Old Age";
            return View();
        }
    }
}
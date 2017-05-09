using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult NASSITRegulations()
        {
            ViewBag.Title = "NASSIT Regulations";
            return View();
        }
    }
}
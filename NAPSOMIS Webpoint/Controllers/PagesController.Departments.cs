using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Departents()
        {
            ViewBag.Title = "Departments";
            return View();
        }
    }
}
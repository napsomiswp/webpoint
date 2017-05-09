using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult OrganisationStructure()
        {
            ViewBag.Title = "Organisation Structure";
            return View();
        }
    }
}
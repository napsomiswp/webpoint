using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.Models;

namespace NAPSOMIS_Webpoint.Controllers
{
    public class ReceiveFormsController : Controller
    {
        NAPSOMISModel db = new NAPSOMISModel();

        // GET: ReceiveForms
        [HttpGet]
        public ActionResult ReceiveForms()
        {
            return View("ReceiveForms");
        }
  
        // POST: ReceiveForms/Create
        [HttpPost]
        public ActionResult ReceiveForms(MemberTransaction ReceiveForm)
        {
            try
            {
                db.MemberTransactions.Add(ReceiveForm);
                db.SaveChanges();
                return RedirectToAction("ReceiveForms");
            }
            catch
            {
                return View();
            }
        }
 
    }
}

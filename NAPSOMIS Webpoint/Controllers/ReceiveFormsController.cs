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

        private bool ValidateReferenceNo(string refno)
            {
            //W01 015 009488

            string thebranch = refno.Substring(0, 3);
            string branch = Session["Branch"].ToString();

            List<ReferenceNo> r = new List<ReferenceNo>();
            r = db.ReferenceNos.Where(b => b.Centre == branch).OrderByDescending(b => b.ReferenceID).ToList();

            bool isFound = false;

            if (r.Count > 0)
                {
                foreach (ReferenceNo item in r)
                    {
                    string range = item.GeneratedRange;

                    string[] splitrange = range.Split('-');

                    string firstthree = splitrange[0].ToString().Substring(0, 3);
                    string start = splitrange[0];
                    string end = splitrange[1];
 
                    int endserial = int.Parse(end.Substring(3, 9));

                    int startserial = int.Parse(start.Substring(3, 9));

                    for (int i = startserial; i <= endserial; i++)
                        {
                        if (refno.Contains(i.ToString()))
                            {
                            isFound = true;
                            break;
                            }
                        }

                    if (isFound)
                        {
                        break;
                        }

                    }
                }

            return isFound;

            }

        // POST: ReceiveForms/Create
        [HttpPost]
        public ActionResult ReceiveForms(mem_tr m)
            {
            try
                {

                if (!ValidateReferenceNo(m.fref_no))
                    {
                    ViewBag.Message = "This Reference No has not been generated";
                    return View("ReceiveForms", m);
                    }

                m.CreatedOn = DateTime.Now;
                m.CreatedBy = "DEFAULT";
                m.fref_no = m.fref_no.ToString().Trim();

                db.mem_tr.Add(m);
                db.SaveChanges();

                 ViewBag.Message = "FORM SUCCESSFULLY RECEIVED";
                return View("ReceiveForms", new mem_tr());
                }
            catch
                {
                return View();
                }
            }

        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.ViewModels;
using NAPSOMIS_Webpoint.Models;

namespace NAPSOMIS_Webpoint.Controllers
    {
    public class ListNosforEstablishmentController : Controller
        {
        NAPSOMISModel db = new NAPSOMISModel();

        // GET: ListNosforEstablishment
        public ActionResult Index()
            {
            return View();
            }
 
        public ActionResult Search(ListGeneratedEmployerViewModel l)
            {
            List<EmployMastersheet> emp = new List<EmployMastersheet>();
            emp = db.EmployMastersheets.Where(b => b.ferno == l.ferno).ToList();

            if (emp.Count > 0)
                {
                ListGeneratedEmployerViewModel li = new ListGeneratedEmployerViewModel();
                li.ferno = l.ferno;
                li.femp_name = emp[0].femp_name;
                li.StartDate = l.StartDate;
                li.EndDate = l.EndDate;

                return View("Index", li);
                }
            else
                {
                return View("Index");
                }
             
            }

 
        public ActionResult PrintPreview(ListGeneratedEmployerViewModel l)
            {
            List<MemberTransaction> m = new List<MemberTransaction>();
            m = db.MemberTransactions.Where(b => b.ferno == l.ferno).ToList();

            if (m.Count > 0)
                {

                XtraReportListofEstGeneratedNos myreport = new XtraReportListofEstGeneratedNos();

                myreport.RequestParameters = false;
                myreport.MembersDataSource.DataSource = m;
                myreport.SearchDataSource.DataSource = l;

                myreport.CreateDocument();

                return View("PrintPreview", myreport);
 
                }
            else
                {
                return View("Index");
                }


            }



        }
    }
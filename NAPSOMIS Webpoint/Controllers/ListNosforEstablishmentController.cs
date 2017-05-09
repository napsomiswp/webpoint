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
            return View("Index", new ListGeneratedEmployerViewModel());
            }

        public ActionResult Search(ListGeneratedEmployerViewModel l)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == l.ferno).ToList();

            if (emp.Count > 0)
                {
                ListGeneratedEmployerViewModel li = new ListGeneratedEmployerViewModel();
                li.ferno = l.ferno;
                li.femp_name = emp[0].femp_name;
                li.StartDate = l.StartDate;
                li.EndDate = l.EndDate;


                var dmember = from s in db.mem_tr where s.ferno == l.ferno where s.CreatedOn >= l.StartDate where s.CreatedOn <= l.EndDate select new { s.fref_no, s.fssno, s.fsurname, s.firstname, s.fothname, s.fper_addr, s.fcur_addr, s.fm_stat, s.fnation, s.fb_country, s.fsex, s.ftown, s.fb_date };

                List<mem_tr> fmd = new List<mem_tr>();

                var fullmember = dmember.ToList();

                foreach (var record in fullmember)
                    {
                    mem_tr cm = new mem_tr();

                    cm.fref_no = record.fref_no;
                    cm.fssno = record.fssno;
                    cm.fsurname = record.fsurname;
                    cm.firstname = record.firstname;
                    cm.fothname = record.fothname;
                    cm.fper_addr = record.fper_addr;
                    cm.fcur_addr = record.fcur_addr;
                    cm.fm_stat = record.fm_stat;
                    cm.fnation = record.fnation;
                    cm.fb_country = record.fb_country;
                    cm.fsex = record.fsex;

                    cm.ftown = record.ftown;
                    cm.fb_date = record.fb_date;

                    //cm.ID_SBTS = record.ID_SBTS;

                    fmd.Add(cm);
                    }

                if (fmd.Count == 0)
                    {
                    ViewBag.Message = "NO RECORD WAS FOUND MATCHING THE SEARCH CRITERIA";
                    }

                TempData["ListGeneratedNos"] = fmd;

                return View("Index", li);
                }
            else
                {
                 
                ViewBag.Message = "THE ERNO: " + l.ferno + " WAS NOT FOUND IN THE DATABASE";
                return View("Index", new ListGeneratedEmployerViewModel());
                }

            }


        public ActionResult PrintPreview(ListGeneratedEmployerViewModel l)
            {
            List<mem_tr> m = new List<mem_tr>();
            m = db.mem_tr.Where(b => b.ferno == l.ferno).ToList();

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
                return View("Index", l);
                }


            }



        }
    }
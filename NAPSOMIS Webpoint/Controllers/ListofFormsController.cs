using NAPSOMIS_Webpoint.Models;
using NAPSOMIS_Webpoint.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAPSOMIS_Webpoint.Controllers
    {
    public class ListofFormsController : Controller
        {
        NAPSOMISModel db = new NAPSOMISModel();

        // GET: CheckList
        [HttpGet]
        public ActionResult SearchList()
            {
            return View("SearchList", new PrintCheckListTemplate());
            }

        [HttpGet]
        public ActionResult ListMembersCheckList()
            {
            return View("ListMembersCheckList", new PrintCheckListTemplate());
            }

        [HttpPost]
        public ActionResult ListFormsbyDate(PrintCheckListTemplate c)
            {
            try
                {

                PrintCheckListTemplate pt = new PrintCheckListTemplate();
                pt.ReferenceNo = "";
                pt.StartDate = c.StartDate;
                pt.EndDate = c.EndDate;

                List<mem_tr> fmd = new List<mem_tr>();

                NAPSOMISModel db = new NAPSOMISModel();
                var dmember = from s in db.mem_tr where s.CreatedOn >= c.StartDate && s.CreatedOn <= c.EndDate select new { s.fref_no, s.fssno, s.fsurname, s.firstname, s.fothname, s.fper_addr, s.fcur_addr, s.fm_stat, s.fnation, s.fb_country, s.fsex, s.ftown, s.fb_date, s.ModifiedBy, s.ModifiedOn, s.CreatedBy, s.CreatedOn };

                var fullmember = dmember.ToList();
 
                List<nom_tr> alldependants = new List<nom_tr>();

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

                    cm.ModifiedBy = record.ModifiedBy;
                    cm.ModifiedOn = record.ModifiedOn;
                    cm.CreatedBy = record.CreatedBy;
                    cm.CreatedOn = record.CreatedOn;

                    //cm.ID_SBTS = record.ID_SBTS;

                    fmd.Add(cm);
                    }

                TempData["ListofForms"] = fmd;

                if (fmd.Count == 0)
                    {
                    ViewBag.Message = "NO RECORD WAS FOUND BETWEEN: " + c.StartDate.Value.ToString("dd/MM/yyyy") + " and " + c.EndDate.Value.ToString("dd/MM/yyyy") ;
                    }


                return View("SearchList", pt);

                }
            catch (Exception)
                {

                throw;
                }

            }


        [HttpPost]
        public ActionResult PrintPreview(PrintCheckListTemplate c)
            {
 
           
            var dlist = from s in db.mem_tr where s.CreatedOn >= c.StartDate && s.CreatedOn <= c.EndDate select new { s.fref_no, s.fssno, s.fsurname, s.firstname, s.fothname, s.fper_addr, s.fcur_addr, s.fm_stat, s.fnation, s.fb_country, s.fsex, s.ftown, s.fb_date, s.CreatedBy, s.CreatedOn, s.ModifiedOn, s.ModifiedBy };

            var fulllist = dlist.ToList();

            List<mem_tr> flist = new List<mem_tr>();

            List<nom_tr> alldependants = new List<nom_tr>();

            foreach (var record in fulllist)
                {
                mem_tr cm = new mem_tr();

                cm.fref_no = record.fref_no;
                cm.fssno = record.fssno;
                cm.fsurname = record.fsurname;
                cm.firstname = record.firstname;
                cm.fothname = record.fothname;

                cm.CreatedBy = record.CreatedBy;
                cm.CreatedOn = record.CreatedOn;
                cm.ModifiedBy = record.ModifiedBy;
                cm.ModifiedOn = record.ModifiedOn;

                cm.floc = GetZoneName(Session["Branch"].ToString());

                //cm.ID_SBTS = record.ID_SBTS;
                 
                flist.Add(cm);
 
                }


            if (flist.Count > 0)
                {

                XtraReportListofForms mydocument = new XtraReportListofForms();
                mydocument.MemberListDataSource.DataSource = flist;
                mydocument.SearchDataSource.DataSource = c;

                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);
                }
            else
                {
                return RedirectToAction("SearchList");
                }

            }


         private string GetZoneName(string code)
            {
            DataTable mytable = new DataTable();

            string zonename = code.Substring(0, 1);
            string zonecode = code.Substring(1, code.ToArray().Count() -1);

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fzone_name From zone_cod WHERE fzone_name like '" + zonename + "%' and fzone = '" + zonecode + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string thename = mytable.Rows[0].Field<String>("fzone_name");
                return thename;
                }
            return "";

            }

        private DataTable GetDependants(string ReferenceNo)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT * From nom_tr WHERE fref_no = '" + ReferenceNo + "%'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            return mytable;

            }



        }
    }
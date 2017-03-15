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
            return View();
            }

        [HttpGet]
        public ActionResult ListMembersCheckList()
            {
            return View();
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
 
           
            var dlist = from s in db.MemberTransactions where s.CreatedOn >= c.StartDate && s.CreatedOn <= c.EndDate select new { s.ID_SBTS, s.fref_no, s.fssno, s.fsurname, s.firstname, s.fothname, s.fper_addr, s.fcur_addr, s.fm_stat, s.fnation, s.fb_country, s.fsex, s.ftown, s.fb_date, s.CreatedBy, s.CreatedOn, s.ModifiedOn, s.ModifiedBy };

            var fulllist = dlist.ToList();

            List<MemberTransaction> flist = new List<MemberTransaction>();

            List<NomTemp> alldependants = new List<NomTemp>();

            foreach (var record in fulllist)
                {
                MemberTransaction cm = new MemberTransaction();

                cm.fref_no = record.fref_no;
                cm.fssno = record.fssno;
                cm.fsurname = record.fsurname;
                cm.firstname = record.firstname;
                cm.fothname = record.fothname;

                cm.CreatedBy = record.CreatedBy;
                cm.CreatedOn = record.CreatedOn;
                cm.ModifiedBy = record.ModifiedBy;
                cm.ModifiedOn = record.ModifiedOn;

                cm.ID_SBTS = record.ID_SBTS;
                 
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


        private DataTable GetDependants(string ReferenceNo)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT * From NomTemp WHERE fref_no = '" + ReferenceNo + "%'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            return mytable;

            }



        }
    }
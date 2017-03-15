﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.ViewModels;
using NAPSOMIS_Webpoint.Models;
using System.Data.Entity;
using System.Data;
using System.Configuration;
using DevExpress.XtraReports.UI;

namespace NAPSOMIS_Webpoint.Controllers
    {
    public class CheckListController : Controller
        {
        NAPSOMISModel db = new NAPSOMISModel();

        // GET: CheckList
        [HttpGet]
        public ActionResult PrintCheckList()
            {
            return View();
            }

        [HttpGet]
        public ActionResult ListMembersCheckList()
            {
            return View();
            }

        [HttpPost]
        public ActionResult ListMembersCheckListbyDate(PrintCheckListTemplate c)
            {
            try
                {
               
                PrintCheckListTemplate pt = new PrintCheckListTemplate();
                pt.ReferenceNo = "";
                pt.StartDate = c.StartDate;
                pt.EndDate = c.EndDate;

                return View("ListMembersCheckList", pt);

                }
            catch (Exception)
                {

                throw;
                }
           
            }


        [HttpGet]
        public ActionResult Delete(int id)
            {
            return View("ListMembersCheckList");
            }


         [HttpGet]
        public ActionResult Edit(int id)
            {
            return View("ListMembersCheckList");
            }


         [HttpGet]
        public ActionResult Preview(int id)
            {

             
            List<ViewModels.MemberCheckListViewModel> fmd = new List<ViewModels.MemberCheckListViewModel>();

            var dmember = from s in db.MemberTransactions join sa in db.ParentalTemps on s.fref_no equals sa.fref_no join p in db.Provinces on s.fprovince equals p.fcode join d in db.Districts on s.fdist equals d.d_code join ch in db.Chiefdoms on s.fchief equals ch.fc_code join occ in db.Occupations on s.foccupation equals occ.fcode join dep in db.NomTemps on s.fref_no equals dep.fref_no join rel in db.RelativesTypesMasters on dep.frelation equals rel.frel_code where s.ID_SBTS == id select new { s.ID_SBTS, s.fref_no, s.fssno, s.fsurname, s.firstname, s.fothname, s.fper_addr, s.fcur_addr, s.fm_stat, s.fnation, s.fb_country, s.fsex, fprovince = p.fdesc, fdist = d.d_desc, fchief = ch.fdescr, s.ftown, s.fb_date, s.fjoindate, s.fincome, s.fnat_income, foccupation = occ.fdescr, s.femp_name, s.ferno, s.femp_addr, s.ftel_no, sa.ffirstname, sa.ffsurname, sa.ffothname, sa.fmfirstname, sa.fmsurname, sa.fmothname, dep.fbirth_date, dep.fnfirstname, dep.fnomsex, dep.fnom_ssno, dep.fnothname, dep.fnsurname, fper_addr_dependant = dep.fper_addr, fres_addr_dependant = dep.fres_addr, frelation = rel.frel_desc, ID_SBTS_DEPENDANT = dep.ID_SBTS };

            var fullmember = dmember.ToList();
 
            List<NomTemp> alldependants = new List<NomTemp>();

            foreach (var record in fullmember)
                {
                MemberCheckListViewModel cm = new MemberCheckListViewModel();

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
                cm.fprovince = record.fprovince;
                cm.fdist = record.fdist;
                cm.fchief = record.fchief;
                cm.ftown = record.ftown;
                cm.fb_date = record.fb_date;
                cm.fjoindate = record.fjoindate;
                cm.fincome = record.fincome;

                if (record.fnat_income == "1") cm.fnat_income = "Daily";
                if (record.fnat_income == "2") cm.fnat_income = "Monthly";
                if (record.fnat_income == "3") cm.fnat_income = "Yearly";

                cm.foccupation = record.foccupation;
                cm.femp_name = record.femp_name;
                cm.ferno = record.ferno;
                cm.femp_addr = record.femp_addr;
                cm.ftel_no = record.ftel_no;
                cm.ID_SBTS = record.ID_SBTS;

                cm.fnom_ssno = record.fnom_ssno;
                cm.fnsurname = record.fnsurname;
                cm.fnfirstname = record.fnfirstname;
                cm.fnothname = record.fnothname;
                cm.fnomsex = record.fnomsex;
                cm.fbirth_date = record.fbirth_date;
                cm.frelation = record.frelation;
                cm.fper_addr_dependant = record.fper_addr_dependant;
                cm.fres_addr_dependant = record.fres_addr_dependant;
                cm.ID_SBTS_DEPENDANT = record.ID_SBTS_DEPENDANT;


                fmd.Add(cm);

                DataTable dependants = GetDependants(record.fref_no);

                if (dependants.Rows.Count > 0)
                    {
                    foreach (DataRow drow in dependants.Rows)
                        {
                        NomTemp sd = new NomTemp();
                        sd.fbirth_date = drow.Field<DateTime>("fbirth_date");
                        sd.fnfirstname = drow.Field<String>("fnfirstname");
                        sd.fnothname = drow.Field<String>("fnothname");
                        sd.fnsurname = drow.Field<String>("fnsurname");
                        sd.fnom_ssno = drow.Field<String>("fnom_ssno");
                        sd.fnomsex = drow.Field<String>("fnomsex");
                        sd.frelation = drow.Field<String>("frelation");
                        sd.fres_addr = drow.Field<String>("fres_addr");
                        sd.fper_addr = drow.Field<String>("fper_addr");

                        alldependants.Add(sd);
                        }
                    }
                else
                    {

                    }
                 
                }


            if (fmd.Count > 0)
                {

                XtraReportPreviewMember  mydocument = new XtraReportPreviewMember ();
                mydocument.MemberDataSource.DataSource = fmd;
 
                mydocument.CreateDocument();

                return View("/Shared/PrintPreview", mydocument);
                }
            else
                {
                return RedirectToAction("PrintPreview");
                }
             
            }

         [HttpPost]
        public ActionResult ListMembersCheckListbyReferenceNo(PrintCheckListTemplate c)
            {
            try
                {
                var ReferenceNo = Request["txtreferenceno"];

                c.ReferenceNo = ReferenceNo;

                return View("ListMembersCheckList", c);
                }
            catch (Exception)
                {

                throw;
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



        [HttpPost]
        public ActionResult PrintCheckList(PrintCheckListTemplate c)
            {

            List<PrintCheckListTemplate> ctemp = new List<PrintCheckListTemplate>();
            ctemp.Add(c);

            List<ViewModels.MemberCheckListViewModel> fmd = new List<ViewModels.MemberCheckListViewModel>();

            var dmember = from s in db.MemberTransactions join sa in db.ParentalTemps on s.fref_no equals sa.fref_no join p in db.Provinces on s.fprovince equals p.fcode join d in db.Districts on s.fdist equals d.d_code join ch in db.Chiefdoms on s.fchief equals ch.fc_code join occ in db.Occupations on s.foccupation equals occ.fcode join dep in db.NomTemps on s.fref_no equals dep.fref_no join rel in db.RelativesTypesMasters on dep.frelation equals rel.frel_code where s.CreatedOn >= c.StartDate && s.CreatedOn <= c.EndDate select new { s.ID_SBTS, s.fref_no, s.fssno, s.fsurname, s.firstname, s.fothname, s.fper_addr, s.fcur_addr, s.fm_stat, s.fnation, s.fb_country, s.fsex, fprovince = p.fdesc, fdist = d.d_desc, fchief = ch.fdescr, s.ftown, s.fb_date, s.fjoindate, s.fincome, s.fnat_income, foccupation = occ.fdescr, s.femp_name, s.ferno, s.femp_addr, s.ftel_no, sa.ffirstname, sa.ffsurname, sa.ffothname, sa.fmfirstname, sa.fmsurname, sa.fmothname, dep.fbirth_date, dep.fnfirstname, dep.fnomsex, dep.fnom_ssno, dep.fnothname, dep.fnsurname, fper_addr_dependant = dep.fper_addr, fres_addr_dependant = dep.fres_addr, frelation = rel.frel_desc, ID_SBTS_DEPENDANT = dep.ID_SBTS };

            var fullmember = dmember.ToList();
 
            List<NomTemp> alldependants = new List<NomTemp>();

            foreach (var record in fullmember)
                {
                MemberCheckListViewModel cm = new MemberCheckListViewModel();

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
                cm.fprovince = record.fprovince;
                cm.fdist = record.fdist;
                cm.fchief = record.fchief;
                cm.ftown = record.ftown;
                cm.fb_date = record.fb_date;
                cm.fjoindate = record.fjoindate;
                cm.fincome = record.fincome;

                if (record.fnat_income == "1") cm.fnat_income = "Daily";
                if (record.fnat_income == "2") cm.fnat_income = "Monthly";
                if (record.fnat_income == "3") cm.fnat_income = "Yearly";

                cm.foccupation = record.foccupation;
                cm.femp_name = record.femp_name;
                cm.ferno = record.ferno;
                cm.femp_addr = record.femp_addr;
                cm.ftel_no = record.ftel_no;
                cm.ID_SBTS = record.ID_SBTS;

                cm.fnom_ssno = record.fnom_ssno;
                cm.fnsurname = record.fnsurname;
                cm.fnfirstname = record.fnfirstname;
                cm.fnothname = record.fnothname;
                cm.fnomsex = record.fnomsex;
                cm.fbirth_date = record.fbirth_date;
                cm.frelation = record.frelation;
                cm.fper_addr_dependant = record.fper_addr_dependant;
                cm.fres_addr_dependant = record.fres_addr_dependant;
                cm.ID_SBTS_DEPENDANT = record.ID_SBTS_DEPENDANT;


                fmd.Add(cm);

                DataTable dependants = GetDependants(record.fref_no);

                if (dependants.Rows.Count > 0)
                    {
                    foreach (DataRow drow in dependants.Rows)
                        {
                        NomTemp sd = new NomTemp();
                        sd.fbirth_date = drow.Field<DateTime>("fbirth_date");
                        sd.fnfirstname = drow.Field<String>("fnfirstname");
                        sd.fnothname = drow.Field<String>("fnothname");
                        sd.fnsurname = drow.Field<String>("fnsurname");
                        sd.fnom_ssno = drow.Field<String>("fnom_ssno");
                        sd.fnomsex = drow.Field<String>("fnomsex");
                        sd.frelation = drow.Field<String>("frelation");
                        sd.fres_addr = drow.Field<String>("fres_addr");
                        sd.fper_addr = drow.Field<String>("fper_addr");

                        alldependants.Add(sd);
                        }
                    }
                else
                    {

                    }
                 
                }


            if (fmd.Count > 0)
                {

                XtraReportCheckList mydocument = new XtraReportCheckList();
                mydocument.MemberDataSource.DataSource = fmd;

                //XRSubreport detailReport = mydocument.Bands[BandKind.GroupHeader].FindControl("DependantsSubreport", true) as XRSubreport;
                //detailReport.ReportSource.DataSource = alldependants;

                mydocument.CheckListDataSource.DataSource = ctemp;

                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);
                }
            else
                {
                return RedirectToAction("ListMembersCheckList");
                }

            }

        }
    }
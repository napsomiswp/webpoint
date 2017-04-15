using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.Models;
using NAPSOMIS_Webpoint.ViewModels;
using System.Data;
using System.Configuration;

namespace NAPSOMIS_Webpoint.Controllers
    {

    [AuthorizeFilter]
    public class ContributionController : Controller
        {

        NAPSOMISModel db = new NAPSOMISModel();

        #region "Receive at Data Control"
        // DATA CAPTURING
        public ActionResult ReceiveCRDataControl()
            {
            TempData["Periods"] = null;

            CRSRegViewModel c = new CRSRegViewModel();
            return View("ReceiveCRDataControl", c);
            }


        public ActionResult ReceiveCRDataControl_Load(CRSRegViewModel creg)
            {
            TempData["MyEmployerCategories"] = GetMyEmployerCategories(creg.ferno);

            return View("ReceiveCRDataControl", creg);

            }


        public List<PDCTemplate> GetMyEmployerCategories(string ERNO)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT cat_code, description From StaffCat WHERE ferno = '" + ERNO + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<Province> provinces = db.Provinces.SqlQuery("SELECT ID_SBTS, fcode, fdesc From Province").ToList(); 

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("cat_code");
                    ct.Name = myp.Field<String>("description");

                    mylist.Add(ct);

                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }


        public List<ContrPeriodTemplate> GetMyMasterPeriods(string ERNO, string Category)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT mperd, mtype, mcat From c_crsdata WHERE ferno = '" + ERNO + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<Province> provinces = db.Provinces.SqlQuery("SELECT ID_SBTS, fcode, fdesc From Province").ToList(); 

            List<ContrPeriodTemplate> mylist = new List<ContrPeriodTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    ContrPeriodTemplate ct = new ContrPeriodTemplate();
                    ct.Period = myp.Field<String>("mperd");
                    ct.Type = myp.Field<String>("mtype");
                    ct.Media = myp.Field<String>("mcat");

                    mylist.Add(ct);

                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }

        public ActionResult ReceiveCRDataControl_Receive(CRSRegViewModel creg)
            {

            return View("ReceiveCRDataControl");
            }


        public ActionResult ReceiveCRDataControl_ReceiveForPeriod(CRSRegViewModel creg)
            {

            char[] echarac = creg.feperiod.ToString().ToCharArray();

            string theyear = echarac[0].ToString() + echarac[1].ToString() + echarac[2].ToString() + echarac[3].ToString();
            string fullchars = echarac[4].ToString() + echarac[5].ToString();
            int laststop = int.Parse(fullchars);

            if (TempData["Periods"] == null)
                {
                PeriodBreakDownViewModel p = new PeriodBreakDownViewModel();
                p.ID = 1;
                p.Period = creg.dperiod;
                p.NoOfWorkers = creg.fnowkr;
                p.TotalContribution = creg.ftot_cr;

                List<PeriodBreakDownViewModel> plist = new List<PeriodBreakDownViewModel>();
                plist.Add(p);

                TempData["Periods"] = plist;

                }
            else
                {
                List<PeriodBreakDownViewModel> plist = (List<PeriodBreakDownViewModel>)TempData["Periods"];

                PeriodBreakDownViewModel p = new PeriodBreakDownViewModel();
                p.ID = 1;
                p.Period = creg.dperiod;
                p.NoOfWorkers = creg.fnowkr;
                p.TotalContribution = creg.ftot_cr;

                plist.Add(p);

                TempData["Periods"] = plist;

                }

            CRSRegViewModel c = new CRSRegViewModel();

            creg.dperiod = c.dperiod;
            //creg.fnowkr = c.fnowkr;
            //creg.ftot_cr = c.ftot_cr;

            var period = Request["dperiod"];

            char[] currentp = period.ToString().ToCharArray();
            int currentfull = int.Parse(currentp[4].ToString() + currentp[5].ToString());

            if (currentfull < laststop)
                {
                currentfull += 1;
                creg.dperiod = theyear + CompleteStartNo(int.Parse(currentfull.ToString()));
                }
            else
                {
                creg.dperiod = theyear + CompleteStartNo(int.Parse(laststop.ToString()));
                }

            return View("ReceiveCRDataControl", creg);
            }

        private string CompleteStartNo(int TheNo)
            {
            string newValue = TheNo.ToString();

            if (TheNo < 10)
                {
                newValue = "0" + TheNo;
                }
            else
                {
                newValue = TheNo.ToString();
                }

            return newValue;
            }

        public ActionResult DeletePeriod(int id)
            {

            CRSRegViewModel c = new CRSRegViewModel();
            return View("ReceiveCRDataControl", c);
            }


        private bool ValidateContributionCapture(string ERNO, string Cat, string TypeOfContribution, string Period)
            {
            int? thecount = db.crsregs.Where(p => p.ferno == ERNO).Where(b => b.fcat == Cat).Where(b => b.ftype == TypeOfContribution).Where(b => b.fperiod == Period).Count();

            if (thecount.HasValue)
                {
                if (thecount.Value > 0)
                    {
                    return true;
                    }
                else
                    {
                    return false;
                    }
                
                }
            return false;
            }



        public ActionResult ReceiveCRDataControl_Complete(CRSRegViewModel creg)
            {

            if (TempData.Peek("Periods") == null)
                {
                return View("ReceiveCRDataControl", creg);
                }
            else
                {
                List<PeriodBreakDownViewModel> plist = (List<PeriodBreakDownViewModel>)TempData["Periods"];

                int noofperiods = plist.Count;
                decimal? totalbreakdown = creg.ftot_cr; //  /noofperiods;

                foreach (var pr in plist)
                    {

                    if (!ValidateContributionCapture(creg.ferno, creg.fcat, creg.ftype, pr.Period))
                        {
                        crsreg c = new crsreg();
                        c.fbaktype = creg.fbaktype;
                        c.fcat = creg.fcat;
                        c.fdateupd = creg.fdateupd;
                        c.fdate_rec = creg.fdate_rec.Value;
                        c.feperiod = pr.Period;
                        c.ferno = creg.ferno;
                        c.fmedia = creg.fmedia;
                        c.fmode = creg.fmode;
                        c.fnowkr = pr.NoOfWorkers;
                        c.fperiod = pr.Period;
                        c.fschme = creg.fscheme;
                        c.fstatus = "N";
                        c.ftot_cr = totalbreakdown;
                        c.ftype = creg.ftype;
                        //c.fperiodrange = creg.fperiod + "-" + creg.feperiod;

                        db.crsregs.Add(c);
                        db.SaveChanges();
                        }

                    }

                }

            TempData["Periods"] = null;

            CRSRegViewModel cd = new CRSRegViewModel();
            return View("ReceiveCRDataControl", cd);
            }

        #endregion
         
        #region "Receive at Data Capturing"
        //DATA CONTROL
        public ActionResult ReceiveCRDataCapturing()
            {
            emp_mst emp = new emp_mst();

            return View("ReceiveCRDataCapturing", emp);
            }


        public ActionResult ReceiveCRDataCapturing_Search(emp_mst emp)
            {

            List<emp_mst> employ = new List<emp_mst>();
            employ = db.emp_mst.Where(p => p.ferno == emp.ferno).ToList();

            if (employ.Count > 0)
                {
                return View("ReceiveCRDataCapturing", employ[0]);
                }
            else
                {

                emp_mst newe = new emp_mst();
                newe.ferno = emp.ferno;

                return View("ReceiveCRDataCapturing", newe);
                }

            }


        public ActionResult ReceiveCRDC_Accept(int id)
            {

            List<crsreg> crs = new List<crsreg>();
            crs = db.crsregs.Where(p => p.ID_SBTS == id).ToList();

            if (crs.Count > 0)
                {
                crsreg creg = new crsreg();
                creg = crs[0];
                creg.fdate_data = DateTime.Today;
                creg.fstatus = "C";

                db.crsregs.Attach(creg);
                var entry = db.Entry(creg);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                c_crsdata cd = new c_crsdata();
                cd.ferno = crs[0].ferno;
                cd.fcat = crs[0].fcat;
                cd.fdate_data = DateTime.Today;
                cd.fperiod = crs[0].fperiod;
                cd.ftype = crs[0].ftype;

                db.c_crsdata.Add(cd);
                db.SaveChanges();

                emp_mst emp = new emp_mst();
                emp.ferno = crs[0].ferno;

                return RedirectToAction("ReceiveCRDataCapturing_Search", emp);
                }
            else
                {

                return RedirectToAction("ReceiveCRDataCapturing");
                }

            }

        #endregion
         
        #region Edit Received Report
        //EDIT RECEIVED DATA
        public ActionResult EditReceive()
            {

            CRSRegViewModel c = new CRSRegViewModel();
            return View("EditReceive", c);
            }

        public ActionResult EditReceive_Complete(CRSRegViewModel creg)
            {

            string StartPeriod = creg.fperiod;
            string EndPeriod = creg.feperiod;

            char[] echarac = EndPeriod.ToCharArray();

            string theyear = echarac[0].ToString() + echarac[1].ToString() + echarac[2].ToString() + echarac[3].ToString();
            string fullchars = echarac[4].ToString() + echarac[5].ToString();
            int laststop = int.Parse(fullchars);


            char[] currentp = StartPeriod.ToCharArray();
            int currentfull = int.Parse(currentp[4].ToString() + currentp[5].ToString());

            int noofperiods = laststop - currentfull + 1;
            decimal totalbreakdown = creg.ftot_cr.Value / noofperiods;


            while (currentfull <= laststop + 1)
                {
                string dcomplete = theyear + CompleteStartNo(int.Parse(currentfull.ToString()));
                currentfull += 1;

                //if (ValidateContributionCapture(creg.ferno, creg.fcat, creg.ftype, dcomplete))
                //    {
                List<crsreg> cr = new List<crsreg>();
                cr = db.crsregs.Where(b => b.ferno == creg.ferno).Where(b => b.fcat == creg.fcat).Where(b => b.ftype == creg.ftype).Where(b => b.fperiod == dcomplete).ToList();

                if (cr.Count > 0)
                    {

                    crsreg c = new crsreg();
                    c = cr[0];

                    c.fbaktype = creg.fbaktype;
                    c.fcat = creg.fcat;
                    c.fdateupd = creg.fdateupd;
                    c.fdate_rec = creg.fdate_rec.Value;
                    c.feperiod = dcomplete;
                    c.ferno = creg.ferno;
                    c.fmedia = creg.fmedia;
                    c.fmode = creg.fmode;
                    c.fnowkr = creg.fnowkr;
                    c.fperiod = dcomplete;
                    c.fschme = creg.fscheme;
                    c.fstatus = "N";
                    c.ftot_cr = totalbreakdown;
                    c.ftype = creg.ftype;
                    //c.fperiodrange = creg.fperiod + "-" + creg.feperiod;


                    db.crsregs.Attach(c);
                    var entry = db.Entry(c);
                    entry.State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();

                    }
                else
                    {
                    crsreg c = new crsreg();

                    c.fbaktype = creg.fbaktype;
                    c.fcat = creg.fcat;
                    c.fdateupd = creg.fdateupd;
                    c.fdate_rec = creg.fdate_rec.Value;
                    c.feperiod = dcomplete;
                    c.ferno = creg.ferno;
                    c.fmedia = creg.fmedia;
                    c.fmode = creg.fmode;
                    c.fnowkr = creg.fnowkr;
                    c.fperiod = dcomplete;
                    c.fschme = creg.fscheme;
                    c.fstatus = "N";
                    c.ftot_cr = creg.ftot_cr;
                    c.ftype = creg.ftype;
                    //c.fperiodrange = creg.fperiod + "-" + creg.feperiod;


                    db.crsregs.Add(c);
                    db.SaveChanges();
                    }


                }

            //}

            List<PeriodBreakDownViewModel> plist = (List<PeriodBreakDownViewModel>)TempData["Periods"];



            CRSRegViewModel cd = new CRSRegViewModel();
            return View("EditReceive", cd);
            }

        public ActionResult EditReceive_Load(CRSRegViewModel creg)
            {
            TempData["MyEmployerCategories"] = GetMyEmployerCategories(creg.ferno);

            List<crsreg> cr = new List<crsreg>();

            string periodrange = creg.fperiod + "-" + creg.feperiod;

            cr = db.crsregs.Where(b => b.ferno == creg.ferno).Where(b => b.fperiod == creg.fperiod).Where(b => b.feperiod == creg.feperiod).ToList();

            if (cr.Count > 0)
                {
                crsreg dc = new crsreg();
                dc = cr[0];

                CRSRegViewModel c = new CRSRegViewModel();

                c.fbaktype = dc.fbaktype;
                c.fcat = dc.fcat;
                c.fdateupd = dc.fdateupd;
                c.fdate_rec = dc.fdate_rec;

                //string[] splitrange = dc.fperiodrange.Split('-');

                c.feperiod = dc.feperiod;
                c.ferno = dc.ferno;
                c.fmedia = dc.fmedia;
                c.fmode = dc.fmode;
                c.fnowkr = dc.fnowkr;
                c.fperiod = dc.fperiod;
                c.fscheme = dc.fschme;

                c.ftot_cr = dc.ftot_cr;
                c.ftype = dc.ftype;

                return View("EditReceive", c);
                }
            else
                {
                return View("EditReceive", creg);
                }


            }



        #endregion
         
        #region RECEIVE REPORT FOR ESTABLISHMENT

        public ActionResult ReceiveReport()
            {
            return View("ReceiveReport", new ReceiveReportViewModel());
            }

        public ActionResult ReceiveReport_Search(ReceiveReportViewModel re)
            {

            return View("ReceiveReport", re);
            }

        #endregion
         
        #region PROCESS HARDCOPY CONTRIBUTION REPORT

        public ActionResult HardCopy()
            {
            TempData["MyMasterPeriods"] = null;
            TempData["Periods"] = null;
            TempData["MyEmployerCategories"] = null;

            return View("HardCopy", new HardCopyViewModel());
            }

        public ActionResult HardCopy_SummaryLoadErno(HardCopyViewModel re)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == re.ferno).ToList();

            if (emp.Count > 0)
                {
                TempData["MyEmployerCategories"] = GetMyEmployerCategories(re.ferno);

                TempData["MyMasterPeriods"] = GetMyMasterPeriods(re.ferno, re.fcat);

                re.femp_name = emp[0].femp_name;

                return View("HardCopy", re);
                }
            else
                {
                return View("HardCopy", re);
                }

            }

        private string GetEmployerName(string ferno)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == ferno).ToList();

            if (emp.Count > 0)
                {

                return emp[0].femp_name;
                }
            else
                {
                return "";
                }
            }
        public ActionResult HardCopy_SummaryAccept(HardCopyViewModel re)
            {
            List<cr_ctrl> cr = new List<cr_ctrl>();
            cr = db.cr_ctrl.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (cr.Count > 0)
                {

                hist_tmp ht = new hist_tmp();

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fcont = cr[0].ftotcr.Value;
                ht.fwkrs = cr[0].ftotwkr.Value;
                ht.ftotcr = re.ftotalsalaryorcontribution.Value;
                ht.ftotwkr = re.fnoofworkers.Value;
                ht.fmode = re.fmodesubmission;
                //ht.me = cr[0].fmedia;

                ht.CreatedBy = Session["AccountID"].ToString();
                ht.CreatedOn = DateTime.Today;

                db.hist_tmp.Add(ht);
                db.SaveChanges();

                }
            else
                {

                hist_tmp ht = new hist_tmp();

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fcont = 0;
                ht.fwkrs = 0;
                ht.ftotcr = re.ftotalsalaryorcontribution.Value;
                ht.ftotwkr = re.fnoofworkers.Value;

                ht.fmode = re.fmodesubmission;
                //ht.fmedia = "P";

                ht.CreatedBy = Session["AccountID"].ToString();
                ht.CreatedOn = DateTime.Today;

                db.hist_tmp.Add(ht);
                db.SaveChanges();

                }

            re.fAddworkersexpected = re.fnoofworkers;
            re.fAddcontributionexpected = re.ftotalsalaryorcontribution.Value;

            re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
            re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

            if (re.fAddworkercaptured > re.fAddworkersexpected)
                {
                ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                }

            if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                {
                ViewBag.Message = "Contribution captured has exceeded the expected amount";
                }

            re.fdisplayerno = re.ferno;
            re.fdisplayemp_name = re.femp_name;

            return View("HardCopy", re);
            }


        public ActionResult HardCopy_SummaryResetEditAll(HardCopyViewModel re)
            {

            re.fcat = "C";

            return View("HardCopy", re);


            }

        public ActionResult HardCopy_SummaryStartAfresh(HardCopyViewModel re)
            {

            List<hist_tmp> htemps = new List<hist_tmp>();
            htemps = db.hist_tmp.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (htemps.Count > 0)
                {
                foreach (hist_tmp ht in htemps)
                    {
                    db.hist_tmp.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }
                }


            List<hist_tr> htrans = new List<hist_tr>();
            htrans = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (htrans.Count > 0)
                {
                foreach (hist_tr ht in htrans)
                    {
                    db.hist_tr.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }
                }

            HardCopyViewModel newre = new HardCopyViewModel();

            return View("HardCopy", newre);


            }



        public ActionResult HardCopy_SummaryLoadLastEntry(HardCopyViewModel re)
            {
            List<hist_tmp> ht = new List<hist_tmp>();
            ht = db.hist_tmp.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (ht.Count > 0)
                {

                TempData["MyMasterPeriods"] = GetMyMasterPeriods(re.ferno, re.fcat);

                re.fmodesubmission = ht[0].fmode;
                re.ftotalsalaryorcontribution = ht[0].ftotcr;
                re.fnoofworkers = ht[0].ftotwkr;

                re.fAddworkersexpected = re.fnoofworkers;
                re.fAddcontributionexpected = re.ftotalsalaryorcontribution.Value;

                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("HardCopy", re);
                }
            else
                {

                return View("HardCopy", re);
                }


            }

        private bool CheckifSSNoisValid(string SSNo)
            {

            if (SSNo == null)
                {
                return false;
                }

            List<mem_tr> mv = new List<mem_tr>();
            mv = db.mem_tr.Where(b => b.fssno == SSNo).ToList();

            if (mv.Count > 0)
                {
                return true;
                }
            else
                {
                return false;
                }
            }

        public ActionResult HardCopy_AddNewAccept(HardCopyViewModel re)
            {
            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            if (ValidateStaffNo(re.ferno, re.fAddStaffNumber, re.fAddFirstContributionPeriod))
                {
                ViewBag.Message = "Staff Number is in use by another staff under the same Establishment.";
                return View("HardCopy", re);
                }

            List<hist_tr> htss = new List<hist_tr>();
            htss = db.hist_tr.Where(b => b.firstname == re.fAddFirstName).Where(b => b.fothername == re.fAddOtherName).Where(b => b.fsurname == re.fAddSurname).Where(b => b.fcurcr_perd == re.fAddFirstContributionPeriod).ToList();

            if (htss.Count == 0)
                {
                hist_tr ht = new hist_tr();

                re.fAddResponsibilityCentre = Session["Branch"].ToString();

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fssno = re.fAddSSNo;

                if (CheckifSSNoisValid(re.fAddSSNo) == true)
                    {
                    ht.fcorr_ssno = re.fAddSSNo;
                    }
                else
                    {
                    ViewBag.Message = "SSNo - " + re.fAddSSNo + " is not valid. Please verify and update this member record.";
                    }

                ht.fsurname = re.fAddSurname;
                ht.firstname = re.fAddFirstName;
                ht.fothername = re.fAddOtherName;
                ht.fpcentre = re.fAddResponsibilityCentre;
                ht.fstaffno = re.fAddStaffNumber;
                ht.fcur_cr = re.fAddContributionorSalary;
                ht.fcurcr_perd = re.fAddFirstContributionPeriod;
                ht.fremark = "A";
                ht.fupd_type = "A";

                if (re.fAddSSNo != null && re.fAddSSNo != "")
                    {
                    ht.fflag = false;
                    }
                else
                    {
                    ht.fflag = true;
                    }

                //ht.ftype = "";
                //ht.fmedia = "P";

                ht.CreatedBy = "DEFAULT";
                ht.CreatedOn = DateTime.Today;

                db.hist_tr.Add(ht);
                db.SaveChanges();


                re.fAddSSNo = "";
                re.fAddSurname = "";
                re.fAddFirstName = "";
                re.fAddOtherName = "";
                re.fAddStaffNumber = "";
                re.fAddContributionorSalary = 0;


                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                List<hist_tmp> htemps = new List<hist_tmp>();
                htemps = db.hist_tmp.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (htemps.Count > 0)
                    {
                    hist_tmp theht = new hist_tmp();
                    theht = htemps[0];

                    theht.fcont += re.fAddContributionorSalary;
                    theht.fwkrs += 1;

                    }
                else
                    {
                    hist_tmp theht = new hist_tmp();

                    theht.CreatedBy = Session["AccountID"].ToString();
                    theht.CreatedOn = DateTime.Today;
                    theht.fcat = re.fcat;
                    theht.fcont = re.fAddContributionorSalary;
                    theht.ferno = re.ferno;
                    theht.fmode = re.fmodesubmission;
                    theht.fwkrs = 1;
                    theht.ftotwkr = re.fnoofworkers.Value;
                    theht.ftotcr = re.ftotalsalaryorcontribution.Value;

                    }
                }
            else
                {
                ViewBag.Message = "Given name has already been captured for current employer and the selected period. Please verify.";
                }


            return View("HardCopy", re);
            }


        private int GetTotalWorkersCaptured(string ERNo, string Cat)
            {
            int? dcount = db.hist_tr.Where(b => b.ferno == ERNo).Where(b => b.fcat == Cat).Count();

            if (dcount == null)
                {
                return 0;
                }
            else
                {
                return dcount.Value;
                }

            }

        private decimal GetTotalContributionCaptured(string ERNo, string Cat)
            {
            decimal? total = db.hist_tr.Where(b => b.ferno == ERNo).Where(b => b.fcat == Cat).Sum(b => b.fcur_cr);

            if (total == null)
                {
                return 0;
                }
            else
                {
                return total.Value;
                }


            }


        public ActionResult HardCopy_EditLoad(HardCopyViewModel re)
            {
            List<hist_tr> ht = new List<hist_tr>();
            ht = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditSSNo).ToList();

            if (ht.Count > 0)
                {

                re.fEditID = ht[0].ID_SBTS;
                re.fEditFirstName = ht[0].firstname;
                re.fEditSurname = ht[0].fsurname;
                re.fEditOtherName = ht[0].fothername;
                re.fEditResponsibilityCentre = ht[0].fpcentre;
                re.fEditContributionorSalary = ht[0].fcur_cr;
                re.fEditStaffNumber = ht[0].fstaffno;
                re.fEditPeriod = ht[0].fcurcr_perd;

                return View("HardCopy", re);
                }
            else
                {
                re.fEditID = 0;
                re.fEditFirstName = "";
                re.fEditSurname = "";
                re.fEditOtherName = "";
                re.fEditResponsibilityCentre = "";
                re.fEditContributionorSalary = 0;
                re.fEditStaffNumber = "";
                re.fEditPeriod = "";

                return View("HardCopy", re);
                }


            }



        public ActionResult HardCopy_EditUndo(HardCopyViewModel re)
            {
            List<hist_tr> ht = new List<hist_tr>();
            ht = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditSSNo).ToList();

            if (ht.Count > 0)
                {

                re.fEditFirstName = ht[0].firstname;
                re.fEditSurname = ht[0].fsurname;
                re.fEditOtherName = ht[0].fothername;
                re.fEditResponsibilityCentre = ht[0].fpcentre;
                re.fEditContributionorSalary = ht[0].fcur_cr;
                re.fEditStaffNumber = ht[0].fstaffno;

                return View("HardCopy", re);
                }
            else
                {
                return View("HardCopy", re);
                }


            }


        public ActionResult HardCopy_EditAccept(HardCopyViewModel re)
            {

            if (ValidateStaffNo(re.ferno, re.fAddStaffNumber, re.fAddFirstContributionPeriod))
                {
                ViewBag.Message = "Staff Number is in use by another staff under the same Establishment.";
                return View("HardCopy", re);
                }

            List<hist_tr> htrans = new List<hist_tr>();
            htrans = db.hist_tr.Where(b => b.ID_SBTS == re.fEditID).ToList();

            if (htrans.Count > 0)
                {
                hist_tr ht = new hist_tr();
                ht = htrans[0];

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fssno = re.fEditSSNo;

                if (CheckifSSNoisValid(re.fEditSSNo) == true)
                    {
                    ht.fcorr_ssno = re.fEditSSNo;
                    }
                else
                    {
                    ViewBag.Message = "SSNo - " + re.fEditSSNo + " is not valid. Please verify and update this member record.";
                    }

                if (re.fEditName != null)
                    {
                    if (re.fEditName == true)
                        {
                        ht.fsurname = re.fEditSurname;
                        ht.firstname = re.fEditFirstName;
                        ht.fothername = re.fEditOtherName;
                        }
                    }

                ht.fpcentre = re.fEditResponsibilityCentre;
                ht.fstaffno = re.fEditStaffNumber;
                ht.fcur_cr = re.fEditContributionorSalary;
                ht.fcurcr_perd = re.fEditPeriod;

                db.hist_tr.Attach(ht);
                var entry = db.Entry(ht);
                entry.State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
                }


            re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
            re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

            if (re.fAddworkercaptured > re.fAddworkersexpected)
                {
                ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                }

            if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                {
                ViewBag.Message = "Contribution captured has exceeded the expected amount";
                }

            re.fdisplayerno = re.ferno;
            re.fdisplayemp_name = re.femp_name;

            return View("HardCopy", re);


            }


        public ActionResult HardCopy_EditRemove(HardCopyViewModel re)
            {


            List<hist_tr> ht = new List<hist_tr>();
            ht = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditSSNo).ToList();

            if (ht.Count > 0)
                {

                db.hist_tr.Attach(ht[0]);
                var entry = db.Entry(ht[0]);
                entry.State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();

                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("HardCopy", re);
                }
            else
                {

                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("HardCopy", re);
                }


            }


        public ActionResult HardCopy_ShowCapturedMembers(HardCopyViewModel re)
            {
            ViewBag.ShowMembers = "Y";

            return View("HardCopy", re);
            }

        public ActionResult HardCopy_DeleteMember(int id)
            {


            hist_tr ht = new hist_tr();
            ht = db.hist_tr.Find(id);

            if (ht.fssno != null)
                {

                string ferno = ht.ferno;
                string fcat = ht.fcat;

                db.hist_tr.Attach(ht);
                var entry = db.Entry(ht);
                entry.State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();

                List<hist_tmp> htemp = new List<hist_tmp>();
                htemp = db.hist_tmp.Where(b => b.ferno == ferno).Where(b => b.fcat == fcat).ToList();

                if (htemp.Count > 0)
                    {
                    hist_tmp htt = new hist_tmp();
                    htt = htemp[0];

                    HardCopyViewModel re = new HardCopyViewModel();
                    re.ferno = htt.ferno;
                    re.fcat = htt.fcat;
                    re.femp_name = GetEmployerName(ferno);
                    re.ftotalsalaryorcontribution = htt.ftotcr;
                    re.fnoofworkers = htt.ftotwkr;

                    re.fAddcontributioncaptured = GetTotalContributionCaptured(ferno, fcat);
                    re.fAddworkercaptured = GetTotalWorkersCaptured(ferno, fcat);

                    re.fdisplayerno = re.ferno;
                    re.fdisplayemp_name = re.femp_name;

                    return View("HardCopy", re);

                    }

                return View("HardCopy", new HardCopyViewModel());


                }
            else
                {
                return View("HardCopy", new HardCopyViewModel());
                }


            }


        public ActionResult HardCopy_EditAllLoad(HardCopyViewModel re)
            {
            List<hist_tr> ht = new List<hist_tr>();
            ht = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditAllSSNo).ToList();

            if (ht.Count > 0)
                {

                re.fEditAllID = ht[0].ID_SBTS;
                re.fEditAllSSNo = ht[0].fcorr_ssno;
                re.fEditAllFirstName = ht[0].firstname;
                re.fEditAllSurname = ht[0].fsurname;
                re.fEditAllOtherName = ht[0].fothername;
                re.fEditAllResponsibilityCentre = ht[0].fpcentre;
                re.fEditAllContributionorSalary = ht[0].fcur_cr;
                re.fEditAllStaffNumber = ht[0].fstaffno;
                re.fEditAllPeriod = ht[0].fcurcr_perd;

                return View("HardCopy", re);
                }
            else
                {

                re.fEditAllID = 0;
                re.fEditAllSSNo = "";
                re.fEditAllFirstName = "";
                re.fEditAllSurname = "";
                re.fEditAllOtherName = "";
                re.fEditAllResponsibilityCentre = "";
                re.fEditAllContributionorSalary = 0;
                re.fEditAllStaffNumber = "";
                re.fEditAllPeriod = "";

                return View("HardCopy", re);
                }


            }



        public ActionResult HardCopy_LoadMemberDetails(HardCopyViewModel re)
            {
            List<mem_tr> mv = new List<mem_tr>();
            mv = db.mem_tr.Where(b => b.fssno == re.fAddSSNo).ToList();

            if (mv.Count > 0)
                {

                re.fAddFirstName = mv[0].firstname;
                re.fAddOtherName = mv[0].fothname;
                re.fAddSurname = mv[0].fsurname;

                return View("HardCopy", re);
                }
            else
                {

                re.fAddFirstName = "";
                re.fAddOtherName = "";
                re.fAddSurname = "";

                ViewBag.Message = "This SSNo is not valid. Please verify and try again.";

                return View("HardCopy", re);
                }


            }

        public ActionResult HardCopy_PreviousEdit(HardCopyViewModel re)
            {
            List<hist_tr> ht = new List<hist_tr>();
            ht = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (ht.Count > 0)
                {

                int nowindex;

                if (TempData["CurrentIndex"] == null)
                    {
                    TempData["CurrentIndex"] = 0;
                    nowindex = 0;
                    }
                else
                    {
                    int newIndex = int.Parse(TempData.Peek("CurrentIndex").ToString()) - 1;

                    if (newIndex < 0)
                        {
                        newIndex = 0;
                        }

                    TempData["CurrentIndex"] = newIndex;
                    nowindex = newIndex;

                    }

                TempData["TotalIndex"] = ht.Count;

                re.fEditAllID = ht[nowindex].ID_SBTS;
                re.fEditAllSSNo = ht[nowindex].fssno;
                re.fEditAllFirstName = ht[nowindex].firstname;
                re.fEditAllSurname = ht[nowindex].fsurname;
                re.fEditAllOtherName = ht[nowindex].fothername;
                re.fEditAllResponsibilityCentre = ht[nowindex].fpcentre;
                re.fEditAllContributionorSalary = ht[nowindex].fcur_cr;
                re.fEditAllStaffNumber = ht[nowindex].fstaffno;
                re.fEditAllPeriod = ht[nowindex].fcurcr_perd;

                return View("HardCopy", re);
                }
            else
                {

                re.fEditAllID = 0;
                re.fEditAllSSNo = "";
                re.fEditAllFirstName = "";
                re.fEditAllSurname = "";
                re.fEditAllOtherName = "";
                re.fEditAllResponsibilityCentre = "";
                re.fEditAllContributionorSalary = 0;
                re.fEditAllStaffNumber = "";
                re.fEditAllPeriod = "";

                return View("HardCopy", re);
                }


            }


        public ActionResult HardCopy_NextEdit(HardCopyViewModel re)
            {
            List<hist_tr> ht = new List<hist_tr>();
            ht = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (ht.Count > 0)
                {

                int nowindex;

                if (TempData["CurrentIndex"] == null)
                    {
                    TempData["CurrentIndex"] = 0;
                    nowindex = 0;
                    }
                else
                    {
                    int newIndex = int.Parse(TempData.Peek("CurrentIndex").ToString()) + 1;

                    if (newIndex > ht.Count - 1)
                        {
                        newIndex = ht.Count - 1;
                        }

                    TempData["CurrentIndex"] = newIndex;
                    nowindex = newIndex;

                    }

                TempData["TotalIndex"] = ht.Count;

                re.fEditAllID = ht[nowindex].ID_SBTS;
                re.fEditAllSSNo = ht[nowindex].fssno;
                re.fEditAllFirstName = ht[nowindex].firstname;
                re.fEditAllSurname = ht[nowindex].fsurname;
                re.fEditAllOtherName = ht[nowindex].fothername;
                re.fEditAllResponsibilityCentre = ht[nowindex].fpcentre;
                re.fEditAllContributionorSalary = ht[nowindex].fcur_cr;
                re.fEditAllStaffNumber = ht[nowindex].fstaffno;
                re.fEditAllPeriod = ht[nowindex].fcurcr_perd;

                return View("HardCopy", re);
                }
            else
                {

                re.fEditAllID = 0;
                re.fEditAllSSNo = "";
                re.fEditAllFirstName = "";
                re.fEditAllSurname = "";
                re.fEditAllOtherName = "";
                re.fEditAllResponsibilityCentre = "";
                re.fEditAllContributionorSalary = 0;
                re.fEditAllStaffNumber = "";
                re.fEditAllPeriod = "";

                return View("HardCopy", re);
                }


            }

        public ActionResult HardCopy_EditAllAccept(HardCopyViewModel re)
            {

            if (ValidateStaffNo(re.ferno, re.fAddStaffNumber, re.fAddFirstContributionPeriod))
                {
                ViewBag.Message = "Staff Number is in use by another staff under the same Establishment.";
                return View("HardCopy", re);
                }

            List<hist_tr> htrans = new List<hist_tr>();
            htrans = db.hist_tr.Where(b => b.ID_SBTS == re.fEditAllID).ToList();

            if (htrans.Count > 0)
                {
                hist_tr ht = new hist_tr();
                ht = htrans[0];

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;

                ht.fssno = re.fEditAllSSNo;

                if (CheckifSSNoisValid(re.fEditAllSSNo) == true)
                    {
                    ht.fcorr_ssno = re.fEditAllSSNo;
                    }
                else
                    {
                    ViewBag.Message = "SSNo - " + re.fEditAllSSNo + " is not valid. Please verify and update this member record.";
                    }

                ht.fpcentre = re.fEditAllResponsibilityCentre;
                ht.fstaffno = re.fEditAllStaffNumber;
                ht.fcur_cr = re.fEditAllContributionorSalary;
                ht.fcurcr_perd = re.fEditAllPeriod;

                db.hist_tr.Attach(ht);
                var entry = db.Entry(ht);
                entry.State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
                }


            re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
            re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);


            if (re.fAddworkercaptured > re.fAddworkersexpected)
                {
                ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                }

            if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                {
                ViewBag.Message = "Contribution captured has exceeded the expected amount";
                }


            re.fdisplayerno = re.ferno;
            re.fdisplayemp_name = re.femp_name;

            return View("HardCopy", re);


            }


        public ActionResult HardCopy_EditAllRemove(HardCopyViewModel re)
            {


            List<hist_tr> ht = new List<hist_tr>();
            ht = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditAllSSNo).ToList();

            if (ht.Count > 0)
                {

                db.hist_tr.Attach(ht[0]);
                var entry = db.Entry(ht[0]);
                entry.State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();

                re.fEditAllSSNo = "";
                re.fEditAllResponsibilityCentre = "";
                re.fEditAllStaffNumber = "";
                re.fEditAllContributionorSalary = 0;
                re.fEditAllFirstName = "";
                re.fEditAllOtherName = "";
                re.fEditAllSurname = "";


                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("HardCopy", re);
                }
            else
                {

                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("HardCopy", re);
                }


            }


        public ActionResult HardCopy_PrintCheckList(HardCopyViewModel re)
            {

            List<hist_tr> ht = new List<hist_tr>();
            ht = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (ht.Count > 0)
                {
                XtraReportContributionCheckList mydocument = new XtraReportContributionCheckList();

                List<ContributionCheckListViewModel> cvm = new List<ContributionCheckListViewModel>();
                ContributionCheckListViewModel c = new ContributionCheckListViewModel();
                c.femp_name = GetEmployerName(re.ferno);

                cvm.Add(c);

                mydocument.HistoryTransactionDataSource.DataSource = ht;
                mydocument.ContributionVMDataSource.DataSource = cvm;

                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);

                }
            else
                {
                return View("HardCopy", re);
                }

            }


        private bool ValidateStaffNo(string ERNO, string StaffNo, string Period)
            {
            int? thecount = db.hist_tr.Where(p => p.ferno == ERNO).Where(b => b.fstaffno == StaffNo).Where(b => b.fcurcr_perd == Period).Count();

            if (thecount.HasValue)
                {
                if (thecount.Value > 0)
                    {
                    return true;
                    }
                else
                    {
                    return false;
                    }

                }
            return false;
            }


        public ActionResult HardCopy_MasterUpdateOK(HardCopyViewModel re)
            {

            if (Session["AccountID"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            List<hist_tr> histemp = new List<hist_tr>();
            histemp = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (histemp.Count > 0)
                {

                foreach (hist_tr ht in histemp)
                    {

                    hist_mst hm = new hist_mst();
                    hm.CreatedBy = Session["AccountID"].ToString();
                    hm.CreatedOn = DateTime.Today;
                    hm.fcat = ht.fcat;
                    hm.fcatbperd = "";
                    hm.fcurcr_perd = ht.fcurcr_perd;
                    hm.fcur_cr = ht.fcur_cr;
                    hm.ferno = ht.ferno;
                    hm.firstname = ht.firstname;
                    hm.flast_cr = ht.flast_cr;
                    hm.fothername = ht.fothername;
                    hm.fpcentre = ht.fpcentre;
                    hm.fprocess = "A";
                    hm.fremark = ht.fremark;
                    hm.frstcr_perd = "";

                    hm.fstaffno = ht.fstaffno;
                    hm.fsurname = ht.fsurname;
                    hm.fflag = ht.fflag;
                    hm.fid = "";
                    hm.fdateupd = DateTime.Today;

                    if (ht.fcorr_ssno != "" && ht.fcorr_ssno != null)
                        {
                        hm.fssno = ht.fcorr_ssno;
                        }

                    db.hist_mst.Add(hm);
                    db.SaveChanges();

                    ht.fid = "P";
                    ht.fcorr_ssno = "";

                    }

                List<cr_ctrl> ctss = new List<cr_ctrl>();
                ctss = db.cr_ctrl.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (ctss.Count > 0)
                    {
                    cr_ctrl ct = new cr_ctrl();
                    ct = ctss[0];

                    ct.CreatedBy = Session["AccountID"].ToString();
                    ct.CreatedOn = DateTime.Today;

                    ct.fmedia = "P";
                    ct.fmode = re.fmodesubmission;
                    ct.ftotcr += re.fmastercontributiontext;
                    ct.ftotwkr += re.fmasterperiodnoofworkers;

                    db.cr_ctrl.Attach(ct);
                    var entry = db.Entry(ct);
                    entry.State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    }
                else
                    {
                    cr_ctrl ct = new cr_ctrl();
                    ct.CreatedBy = Session["AccountID"].ToString();
                    ct.CreatedOn = DateTime.Today;
                    ct.fcat = re.fcat;
                    ct.ferno = re.ferno;
                    ct.fmedia = "P";
                    ct.fmode = re.fmodesubmission;
                    ct.ftotcr = re.fmastercontributiontext;
                    ct.ftotwkr = re.fmasterperiodnoofworkers;

                    db.cr_ctrl.Add(ct);
                    db.SaveChanges();

                    }


                //DELETE THE HISTORY TEMP

                List<hist_tmp> htemps = new List<hist_tmp>();
                htemps = db.hist_tmp.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                foreach (hist_tmp ht in htemps)
                    {
                    db.hist_tmp.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }


                //DELETE THE HISTORY TRANSACTION

                List<hist_tr> htrans = new List<hist_tr>();
                htrans = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                foreach (hist_tr ht in htrans)
                    {
                    db.hist_tr.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }


                //CHECK IF THE USER DESIRED TO UPDATE THE GENERATED CR
                //GO THROUGH ALL THE HISTORY MASTER RECORDS AND UPDATE THEM




                re.fmastercontributiontext = GetTotalContribution(re.ferno, re.fcat, re.fmasterperiod);
                re.fmasterperiodnoofworkers = GetTotalNoOfWorkers(re.ferno, re.fcat, re.fmasterperiod);
                re.fmasterperiodtext = re.fmasterperiod;

                return View("HardCopy", new HardCopyViewModel());

                }
            else
                {

                List<hist_mst> hismast = new List<hist_mst>();
                hismast = db.hist_mst.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (hismast.Count > 0)
                    {

                    if (re.fMasterUpdateGenerateCR == true)
                        {

                        decimal NASSITPercent = decimal.Parse("0.15");
                        List<NASSITPercentage> nps = new List<NASSITPercentage>();
                        nps = db.NASSITPercentages.ToList();

                        if (nps.Count > 0)
                            {
                            NASSITPercent = nps[0].NPercentage;
                            }

                        List<hist_mst> hmast = new List<hist_mst>();
                        hmast = db.hist_mst.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiodtext).ToList();

                        if (hmast.Count > 0)
                            {

                            List<empcr_tr> decs = new List<empcr_tr>();
                            string dftype = "R";

                            decs = db.empcr_tr.Where(b => b.ferno == re.ferno).Where(b => b.ftype_cr == dftype).Where(b => b.fcat == re.fcat).Where(b => b.fperiod == re.fmasterperiodtext).ToList();

                            if (decs.Count > 0)
                                {
                                foreach (empcr_tr item in decs)
                                    {
                                    db.empcr_tr.Attach(item);
                                    var entry = db.Entry(item);
                                    entry.State = System.Data.Entity.EntityState.Deleted;
                                    db.SaveChanges();
                                    }
                                }

                            foreach (hist_mst hm in hmast)
                                {
                                if (hm.fremark == "A")
                                    {
                                    List<memcr_tr> testmember = new List<memcr_tr>();
                                    testmember = db.memcr_tr.Where(b => b.ferno == hm.ferno).Where(b => b.fcat == hm.fcat).Where(b => b.ftype_cr == "R").Where(b => b.fssno == hm.fssno).Where(b => b.fsurname == hm.fsurname)
                                        .Where(b => b.fothername == hm.fothername).Where(b => b.firstname == hm.firstname).Where(b => b.fperiod == hm.fcurcr_perd).ToList();

                                    if (testmember.Count > 0)
                                        {
                                        memcr_tr mcon = new memcr_tr();
                                        mcon = testmember[0];

                                        mcon.fcat = hm.fcat;

                                        if (hm.fcat == "C")
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value;
                                            }
                                        else
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value * NASSITPercent;
                                            }

                                        mcon.fstaffno = hm.fstaffno;
                                        mcon.ferno = hm.ferno;
                                        mcon.fssno = hm.fssno;
                                        mcon.ftype_cr = "R";
                                        mcon.fsurname = hm.fsurname;
                                        mcon.fothername = hm.fothername;
                                        mcon.firstname = hm.firstname;
                                        mcon.fperiod = hm.fcurcr_perd;
                                        mcon.fmedia = "P";

                                        mcon.CreatedBy = Session["AccountID"].ToString();
                                        mcon.CreatedOn = DateTime.Today;

                                        db.memcr_tr.Attach(mcon);
                                        var entry = db.Entry(mcon);
                                        entry.State = System.Data.Entity.EntityState.Modified;
                                        db.SaveChanges();

                                        }
                                    else
                                        {

                                        memcr_tr mcon = new memcr_tr();

                                        mcon.fcat = hm.fcat;

                                        if (hm.fcat == "C")
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value;
                                            }
                                        else
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value * NASSITPercent;
                                            }

                                        mcon.fstaffno = hm.fstaffno;
                                        mcon.ferno = hm.ferno;
                                        mcon.fssno = hm.fssno;
                                        mcon.ftype_cr = "R";
                                        mcon.fsurname = hm.fsurname;
                                        mcon.fothername = hm.fothername;
                                        mcon.firstname = hm.firstname;
                                        mcon.fperiod = hm.fcurcr_perd;
                                        mcon.fmedia = "P";
                                        mcon.fpcentre = Session["Branch"].ToString();

                                        mcon.CreatedBy = Session["AccountID"].ToString();
                                        mcon.CreatedOn = DateTime.Today;

                                        db.memcr_tr.Add(mcon);
                                        db.SaveChanges();

                                        }
                                    }

                                List<empcr_tr> ecs = new List<empcr_tr>();
                                string ddftype = "R";

                                ecs = db.empcr_tr.Where(b => b.ferno == hm.ferno).Where(b => b.ftype_cr == ddftype).Where(b => b.fcat == hm.fcat).Where(b => b.fperiod == hm.fcurcr_perd).ToList();

                                if (ecs.Count > 0)
                                    {
                                    empcr_tr ec = new empcr_tr();
                                    ec = ecs[0];

                                    if (hm.fcat == "C")
                                        {
                                        ec.ftot_cont += hm.fcur_cr;
                                        }
                                    else
                                        {
                                        ec.ftot_cont += (hm.fcur_cr * NASSITPercent);
                                        }

                                    ec.fdateupd = DateTime.Today;
                                    ec.fuser_code = Session["AccountID"].ToString();
                                    ec.ftype_cr = "R";
                                    ec.fno_wkr += 1;

                                    db.empcr_tr.Attach(ec);
                                    var entry = db.Entry(ec);
                                    entry.State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();

                                    }
                                else
                                    {

                                    empcr_tr ec = new empcr_tr();

                                    if (hm.fcat == "C")
                                        {
                                        ec.ftot_cont = hm.fcur_cr;
                                        }
                                    else
                                        {
                                        ec.ftot_cont = (hm.fcur_cr * NASSITPercent);
                                        }

                                    ec.fdateupd = DateTime.Today;
                                    ec.fuser_code = Session["AccountID"].ToString();
                                    ec.ferno = hm.ferno;
                                    ec.fcat = hm.fcat;
                                    ec.fperiod = hm.fcurcr_perd;
                                    ec.ftype_cr = "R";
                                    ec.fno_wkr = 1;

                                    db.empcr_tr.Add(ec);
                                    db.SaveChanges();

                                    }
                                }

                            }


                        List<crsreg> cregss = new List<crsreg>();
                        string thetype = "R";
                        cregss = db.crsregs.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fperiod == re.fmasterperiodtext).Where(b => b.ftype == thetype).ToList();

                        if (cregss.Count > 0)
                            {

                            crsreg cr = new crsreg();
                            cr = cregss[0];

                            cr.fnowkr = re.fmasterperiodnoofworkers.Value;
                            cr.ftot_cr = re.fmastercontributiontext.Value;
                            cr.fstatus = "G";
                            cr.fdate_cap = DateTime.Today;
                            cr.fuser_cap = Session["AccountID"].ToString();

                            }

                        }

                    }

                return View("HardCopy", re);
                }

            }

        private decimal GetTotalContribution(string ERNo, string Category, string Period)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT Sum(fcur_cr) AS fcur_cr From hist_mst WHERE ferno = '" + ERNo + "' AND fcat = '" + Category + "' AND fcurcr_perd = '" + Period + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string Total = mytable.Rows[0].Field<Decimal?>("fcur_cr").ToString();

                if (Total == "" || Total == null)
                    {
                    return 0;
                    }
                else
                    {
                    return decimal.Parse(Total);
                    }

                }
            return 0;
            }


        private int GetTotalNoOfWorkers(string ERNo, string Category, string Period)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT Count(ID_SBTS) AS Total From hist_mst WHERE ferno = '" + ERNo + "' AND fcat = '" + Category + "' AND fcurcr_perd = '" + Period + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string Total = mytable.Rows[0].Field<int>("Total").ToString();

                if (Total == "" || Total == null)
                    {
                    return 0;
                    }
                else
                    {
                    return int.Parse(Total);
                    }

                }
            return 0;
            }



        public ActionResult HardCopy_MasterPeriodLoad(HardCopyViewModel re)
            {

            re.fmastercontributiontext = GetTotalContribution(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodnoofworkers = GetTotalNoOfWorkers(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodtext = re.fmasterperiod;

            if (re.fcat == null || re.fcat == "")
                {
                ViewBag.Message = "You have not selected the Staff Category from the Summary Tab. Please do and try again.";
                }
            return View("HardCopy", re);

            }



        #endregion

        #region VIEW MEMBERS

        public ActionResult ViewMembers()
            {
            return View("ViewMembers", new ViewMembersViewModel());
            }

        public ActionResult ViewMembers_Load(ViewMembersViewModel vm)
            {
            vm.Emp_Name = GetEmployerName(vm.ERNo);
            TempData["MyEmployerCategories"] = GetMyEmployerCategories(vm.ERNo);

            vm.TotalContribution = 0;
            vm.TotalNoofWorkers = 0;

            return View("ViewMembers", vm);
            }

        public ActionResult ViewMembers_OK(ViewMembersViewModel vm)
            {
            List<hist_mst> hm = new List<hist_mst>();
            hm = db.hist_mst.Where(b => b.ferno == vm.ERNo).Where(b => b.fcat == vm.Category).ToList();

            if (hm.Count > 0)
                {

                vm.TotalContribution = GetTotalContributionForMaster(vm.ERNo, vm.Category);
                vm.TotalNoofWorkers = GetTotalNoofWorkersForMaster(vm.ERNo, vm.Category);

                TempData["MemberList"] = hm;
                }
            else
                {
                TempData["MemberList"] = null;
                }

            return View("ViewMembers", vm);
            }

        private decimal GetTotalContributionForMaster(string ERNo, string Cat)
            {
            decimal? total = db.hist_mst.Where(b => b.ferno == ERNo).Where(b => b.fcat == Cat).Sum(b => b.fcur_cr);

            if (total == null)
                {
                return 0;
                }
            else
                {
                return total.Value;
                }


            }


        private int GetTotalNoofWorkersForMaster(string ERNo, string Cat)
            {
            int? total = db.hist_mst.Where(b => b.ferno == ERNo).Where(b => b.fcat == Cat).Count();

            if (total == null)
                {
                return 0;
                }
            else
                {
                return total.Value;
                }


            }

        #endregion

        #region MEMBER STATEMENT


        public ActionResult mem_stmt()
            {
            return View("mem_stmt", new MemberStatementViewModel());
            }

        public ActionResult MemberStatement_LoadSSNo(MemberStatementViewModel mv)
            {
            List<mem_tr> mvs = new List<mem_tr>();
            mvs = db.mem_tr.Where(b => b.fssno == mv.SSNo).ToList();

            if (mvs.Count > 0)
                {
                mv.NameOfMember = mvs[0].fsurname + ", " + mvs[0].firstname + ", " + mvs[0].fothname;
                }
            else
                {
                mv.NameOfMember = "";
                }

            return View("mem_stmt", mv);
            }

        public ActionResult MemberStatement_LoadERNo(MemberStatementViewModel mv)
            {

            List<emp_mst> mvs = new List<emp_mst>();
            mvs = db.emp_mst.Where(b => b.ferno == mv.ERNo).ToList();

            if (mvs.Count > 0)
                {
                mv.Emp_Name = mvs[0].femp_name;
                }
            else
                {
                mv.Emp_Name = "";
                }

            return View("mem_stmt", mv);
            }

        public ActionResult MemberStatement_OK(MemberStatementViewModel mv)
            {

            List<MemberStatementPrintViewModel> mpvms = new List<MemberStatementPrintViewModel>();

            if (mv.TypeofReport == "S")
                {
                List<mem_stmt> mvs = new List<mem_stmt>();
                mvs = db.mem_stmt.Where(b => b.ferno == mv.ERNo).Where(b => b.fssno == mv.SSNo).Where(b => b.fyear == mv.Year).ToList();

                if (mvs.Count > 0)
                    {
                    mem_stmt membst = new mem_stmt();
                    membst = mvs[0];

                    List<mem_tr> mems = new List<mem_tr>(); ;
                    mems = db.mem_tr.Where(b => b.fssno == mv.SSNo).ToList();

                    if (mems.Count > 0)
                        {
                        string NameofStaff = mems[0].fsurname + ", " + mems[0].firstname + " " + mems[0].fothname;
                        string NameofEmployer = GetEmployerName(membst.ferno);
                        string SSNo = mems[0].fssno;
                        string ERNo = membst.ferno;
                        string Sex = mems[0].fsex.ToString();
                        DateTime? DateJoined = mems[0].fjoindate;
                        string StaffPINNo = membst.fstaffno;

                        if (!membst.fjancr.HasValue) { membst.fjancr = 0; }
                        if (!membst.ffebcr.HasValue) { membst.ffebcr = 0; }
                        if (!membst.fmarcr.HasValue) { membst.fmarcr = 0; }
                        if (!membst.faprcr.HasValue) { membst.faprcr = 0; }
                        if (!membst.fmaycr.HasValue) { membst.fmaycr = 0; }
                        if (!membst.fjuncr.HasValue) { membst.fjuncr = 0; }
                        if (!membst.fjulcr.HasValue) { membst.fjulcr = 0; }
                        if (!membst.faugcr.HasValue) { membst.faugcr = 0; }
                        if (!membst.fsepcr.HasValue) { membst.fsepcr = 0; }
                        if (!membst.foctcr.HasValue) { membst.foctcr = 0; }
                        if (!membst.fnovcr.HasValue) { membst.fnovcr = 0; }
                        if (!membst.fdeccr.HasValue) { membst.fdeccr = 0; }

                        for (int i = 1; i <= 12; i++)
                            {

                            MemberStatementPrintViewModel mpvm = new MemberStatementPrintViewModel();
                            mpvm.ERNo = ERNo;
                            mpvm.NameOfEmployer = NameofEmployer;
                            mpvm.SSNo = SSNo;
                            mpvm.NameofStaff = NameofStaff;
                            mpvm.Type = membst.ftype;

                            if (DateJoined.HasValue)
                                {
                                mpvm.DateJoined = DateJoined.Value;
                                }

                            mpvm.StaffPINNo = StaffPINNo;
                            mpvm.DYear = mv.Year;
                            mpvm.sex = Sex;

                            switch (i)
                                {
                                case 1:
                                    mpvm.Month = "January";

                                    if (membst.ftype == "R") { mpvm.Contribution = membst.fjancr.Value; }
                                    else { mpvm.BackPay = membst.fjancr.Value; }

                                    break;
                                case 2:
                                    mpvm.Month = "February";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.ffebcr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.ffebcr.Value;
                                        }

                                    break;
                                case 3:
                                    mpvm.Month = "March";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.fmarcr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.fmarcr.Value;
                                        }

                                    break;
                                case 4:
                                    mpvm.Month = "April";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.faprcr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.faprcr.Value;
                                        }

                                    break;
                                case 5:
                                    mpvm.Month = "May";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.fmaycr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.fmaycr.Value;
                                        }

                                    break;
                                case 6:
                                    mpvm.Month = "June";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.fjuncr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.fjuncr.Value;
                                        }

                                    break;
                                case 7:
                                    mpvm.Month = "July";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.fjulcr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.fjulcr.Value;
                                        }

                                    break;
                                case 8:
                                    mpvm.Month = "August";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.faugcr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.faugcr.Value;
                                        }

                                    break;
                                case 9:
                                    mpvm.Month = "September";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.fsepcr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.fsepcr.Value;
                                        }

                                    break;
                                case 10:
                                    mpvm.Month = "October";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.foctcr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.foctcr.Value;
                                        }

                                    break;
                                case 11:
                                    mpvm.Month = "November";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.fnovcr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.fnovcr.Value;
                                        }

                                    break;
                                case 12:
                                    mpvm.Month = "December";

                                    if (membst.ftype == "R")
                                        {
                                        mpvm.Contribution = membst.fdeccr.Value;
                                        }
                                    else
                                        {
                                        mpvm.BackPay = membst.fdeccr.Value;
                                        }

                                    break;

                                default:
                                    break;
                                }

                            if (mpvm.Contribution != 0)
                                {
                                mpvm.Salary = decimal.Parse(((mpvm.Contribution * 100) / 15).ToString());
                                }
                            else
                                {
                                mpvm.Salary = decimal.Parse(((mpvm.BackPay * 100) / 15).ToString());
                                }

                            if (mpvm.Salary > 0)
                                {
                                mpvm.Salary = decimal.Parse(mpvm.Salary.ToString("F2"));
                                }

                            mpvms.Add(mpvm);

                            }
                        }

                    XtraReportMemberStatement mydocument = new XtraReportMemberStatement();
                    mydocument.MemberStatementPrintDataSource.DataSource = mpvms;
                    mydocument.CreateDocument();

                    return View("PrintPreview", mydocument);
                    }
                else
                    {

                    List<mem_stmt> mvs2 = new List<mem_stmt>();
                    mvs2 = db.mem_stmt.Where(b => b.ferno == mv.ERNo).Where(b => b.fssno == mv.SSNo).Where(b => b.fyear == mv.Year).ToList();

                    if (mvs2.Count > 0)
                        {

                        mem_stmt membst = new mem_stmt();
                        membst = mvs2[0];

                        List<mem_tr> mems = new List<mem_tr>(); ;
                        mems = db.mem_tr.Where(b => b.fssno == mv.SSNo).ToList();

                        if (mems.Count > 0)
                            {
                            string NameofStaff = mems[0].fsurname + ", " + mems[0].firstname + " " + mems[0].fothname;
                            string NameofEmployer = GetEmployerName(mems[0].ferno);
                            string SSNo = mems[0].fssno;
                            string ERNo = mems[0].ferno;
                            string Sex = mems[0].fsex.ToString();
                            DateTime? DateJoined = mems[0].fjoindate;
                            string StaffPINNo = membst.fstaffno;

                            if (!membst.fjancr.HasValue) { membst.fjancr = 0; }
                            if (!membst.ffebcr.HasValue) { membst.ffebcr = 0; }
                            if (!membst.fmarcr.HasValue) { membst.fmarcr = 0; }
                            if (!membst.faprcr.HasValue) { membst.faprcr = 0; }
                            if (!membst.fmaycr.HasValue) { membst.fmaycr = 0; }
                            if (!membst.fjuncr.HasValue) { membst.fjuncr = 0; }
                            if (!membst.fjulcr.HasValue) { membst.fjulcr = 0; }
                            if (!membst.faugcr.HasValue) { membst.faugcr = 0; }
                            if (!membst.fsepcr.HasValue) { membst.fsepcr = 0; }
                            if (!membst.foctcr.HasValue) { membst.foctcr = 0; }
                            if (!membst.fnovcr.HasValue) { membst.fnovcr = 0; }
                            if (!membst.fdeccr.HasValue) { membst.fdeccr = 0; }

                            for (int i = 1; i <= 12; i++)
                                {

                                MemberStatementPrintViewModel mpvm = new MemberStatementPrintViewModel();
                                mpvm.ERNo = ERNo;
                                mpvm.NameOfEmployer = NameofEmployer;
                                mpvm.SSNo = SSNo;
                                mpvm.NameofStaff = NameofStaff;
                                mpvm.Type = membst.ftype;

                                if (DateJoined.HasValue)
                                    {
                                    mpvm.DateJoined = DateJoined.Value;
                                    }

                                mpvm.StaffPINNo = StaffPINNo;
                                mpvm.DYear = mv.Year;
                                mpvm.sex = Sex;

                                switch (i)
                                    {
                                    case 1:
                                        mpvm.Month = "January";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fjancr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fjancr.Value;
                                            }

                                        break;
                                    case 2:
                                        mpvm.Month = "February";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.ffebcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.ffebcr.Value;
                                            }

                                        break;
                                    case 3:
                                        mpvm.Month = "March";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fmarcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fmarcr.Value;
                                            }

                                        break;
                                    case 4:
                                        mpvm.Month = "April";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.faprcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.faprcr.Value;
                                            }

                                        break;
                                    case 5:
                                        mpvm.Month = "May";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fmaycr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fmaycr.Value;
                                            }

                                        break;
                                    case 6:
                                        mpvm.Month = "June";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fjuncr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fjuncr.Value;
                                            }

                                        break;
                                    case 7:
                                        mpvm.Month = "July";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fjulcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fjulcr.Value;
                                            }

                                        break;
                                    case 8:
                                        mpvm.Month = "August";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.faugcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.faugcr.Value;
                                            }

                                        break;
                                    case 9:
                                        mpvm.Month = "September";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fsepcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fsepcr.Value;
                                            }

                                        break;
                                    case 10:
                                        mpvm.Month = "October";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.foctcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.foctcr.Value;
                                            }

                                        break;
                                    case 11:
                                        mpvm.Month = "November";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fnovcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fnovcr.Value;
                                            }

                                        break;
                                    case 12:
                                        mpvm.Month = "December";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fdeccr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fdeccr.Value;
                                            }

                                        break;

                                    default:
                                        break;
                                    }

                                if (mpvm.Contribution != 0)
                                    {
                                    mpvm.Salary = decimal.Parse(((mpvm.Contribution * 100) / 15).ToString());
                                    }
                                else
                                    {
                                    mpvm.Salary = decimal.Parse(((mpvm.BackPay * 100) / 15).ToString());
                                    }

                                if (mpvm.Salary > 0)
                                    {
                                    mpvm.Salary = decimal.Parse(mpvm.Salary.ToString("F2"));
                                    }

                                mpvms.Add(mpvm);

                                }
                            }

                        }

                    XtraReportMemberStatement mydocument = new XtraReportMemberStatement();
                    mydocument.MemberStatementPrintDataSource.DataSource = mpvms;
                    mydocument.CreateDocument();

                    return View("PrintPreview", mydocument);

                    }
                }
            else if (mv.TypeofReport == "E")
                {
                List<mem_stmt> mvs = new List<mem_stmt>();
                mvs = db.mem_stmt.Where(b => b.ferno == mv.ERNo).Where(b => b.fyear == mv.Year).ToList();


                if (mvs.Count > 0)
                    {

                    foreach (mem_stmt membst in mvs)
                        {
                        List<mem_tr> mems = new List<mem_tr>();
                        mems = db.mem_tr.Where(b => b.fssno == membst.fssno).ToList();

                        if (mems.Count > 0)
                            {
                            string NameofStaff = mems[0].fsurname + ", " + mems[0].firstname + " " + mems[0].fothname;
                            string NameofEmployer = GetEmployerName(mems[0].ferno);
                            string SSNo = mems[0].fssno;
                            string ERNo = mems[0].ferno;
                            string Sex = mems[0].fsex.ToString();
                            DateTime? DateJoined = mems[0].fjoindate;
                            string StaffPINNo = membst.fstaffno;

                            if (!membst.fjancr.HasValue) { membst.fjancr = 0; }
                            if (!membst.ffebcr.HasValue) { membst.ffebcr = 0; }
                            if (!membst.fmarcr.HasValue) { membst.fmarcr = 0; }
                            if (!membst.faprcr.HasValue) { membst.faprcr = 0; }
                            if (!membst.fmaycr.HasValue) { membst.fmaycr = 0; }
                            if (!membst.fjuncr.HasValue) { membst.fjuncr = 0; }
                            if (!membst.fjulcr.HasValue) { membst.fjulcr = 0; }
                            if (!membst.faugcr.HasValue) { membst.faugcr = 0; }
                            if (!membst.fsepcr.HasValue) { membst.fsepcr = 0; }
                            if (!membst.foctcr.HasValue) { membst.foctcr = 0; }
                            if (!membst.fnovcr.HasValue) { membst.fnovcr = 0; }
                            if (!membst.fdeccr.HasValue) { membst.fdeccr = 0; }

                            for (int i = 1; i <= 12; i++)
                                {

                                MemberStatementPrintViewModel mpvm = new MemberStatementPrintViewModel();
                                mpvm.ERNo = ERNo;
                                mpvm.NameOfEmployer = NameofEmployer;
                                mpvm.SSNo = SSNo;
                                mpvm.NameofStaff = NameofStaff;
                                mpvm.Type = membst.ftype;

                                if (DateJoined.HasValue)
                                    {
                                    mpvm.DateJoined = DateJoined.Value;
                                    }

                                mpvm.StaffPINNo = StaffPINNo;
                                mpvm.DYear = mv.Year;
                                mpvm.sex = Sex;

                                switch (i)
                                    {
                                    case 1:
                                        mpvm.Month = "January";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fjancr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fjancr.Value;
                                            }


                                        break;
                                    case 2:
                                        mpvm.Month = "February";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.ffebcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.ffebcr.Value;
                                            }

                                        break;
                                    case 3:
                                        mpvm.Month = "March";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fmarcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fmarcr.Value;
                                            }

                                        break;
                                    case 4:
                                        mpvm.Month = "April";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.faprcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.faprcr.Value;
                                            }

                                        break;
                                    case 5:
                                        mpvm.Month = "May";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fmaycr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fmaycr.Value;
                                            }

                                        break;
                                    case 6:
                                        mpvm.Month = "June";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fjuncr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fjuncr.Value;
                                            }

                                        break;
                                    case 7:
                                        mpvm.Month = "July";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fjulcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fjulcr.Value;
                                            }

                                        break;
                                    case 8:
                                        mpvm.Month = "August";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.faugcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.faugcr.Value;
                                            }

                                        break;
                                    case 9:
                                        mpvm.Month = "September";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fsepcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fsepcr.Value;
                                            }

                                        break;
                                    case 10:
                                        mpvm.Month = "October";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.foctcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.foctcr.Value;
                                            }

                                        break;
                                    case 11:
                                        mpvm.Month = "November";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fnovcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fnovcr.Value;
                                            }

                                        break;
                                    case 12:
                                        mpvm.Month = "December";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fdeccr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fdeccr.Value;
                                            }

                                        break;

                                    default:
                                        break;
                                    }

                                if (mpvm.Contribution != 0)
                                    {
                                    mpvm.Salary = decimal.Parse(((mpvm.Contribution * 100) / 15).ToString());
                                    }
                                else
                                    {
                                    mpvm.Salary = decimal.Parse(((mpvm.BackPay * 100) / 15).ToString());
                                    }

                                if (mpvm.Salary > 0)
                                    {
                                    mpvm.Salary = decimal.Parse(mpvm.Salary.ToString("F2"));
                                    }


                                mpvms.Add(mpvm);

                                }
                            }
                        }

                    XtraReportMemberStatement mydocument = new XtraReportMemberStatement();
                    mydocument.MemberStatementPrintDataSource.DataSource = mpvms;
                    mydocument.CreateDocument();

                    return View("PrintPreview", mydocument);
                    }
                else
                    {

                    List<mem_stmt> mvs2 = new List<mem_stmt>();
                    mvs2 = db.mem_stmt.Where(b => b.ferno == mv.ERNo).Where(b => b.fssno == mv.SSNo).Where(b => b.fyear == mv.Year).ToList();

                    if (mvs2.Count > 0)
                        {

                        mem_stmt membst = new mem_stmt();
                        membst = mvs2[0];

                        List<mem_tr> mems = new List<mem_tr>(); ;
                        mems = db.mem_tr.Where(b => b.fssno == membst.fssno).ToList();

                        if (mems.Count > 0)
                            {
                            string NameofStaff = mems[0].fsurname + ", " + mems[0].firstname + " " + mems[0].fothname;
                            string NameofEmployer = GetEmployerName(mems[0].ferno);
                            string SSNo = mems[0].fssno;
                            string ERNo = mems[0].ferno;
                            string Sex = mems[0].fsex.ToString();
                            DateTime? DateJoined = mems[0].fjoindate;
                            string StaffPINNo = membst.fstaffno;

                            if (!membst.fjancr.HasValue) { membst.fjancr = 0; }
                            if (!membst.ffebcr.HasValue) { membst.ffebcr = 0; }
                            if (!membst.fmarcr.HasValue) { membst.fmarcr = 0; }
                            if (!membst.faprcr.HasValue) { membst.faprcr = 0; }
                            if (!membst.fmaycr.HasValue) { membst.fmaycr = 0; }
                            if (!membst.fjuncr.HasValue) { membst.fjuncr = 0; }
                            if (!membst.fjulcr.HasValue) { membst.fjulcr = 0; }
                            if (!membst.faugcr.HasValue) { membst.faugcr = 0; }
                            if (!membst.fsepcr.HasValue) { membst.fsepcr = 0; }
                            if (!membst.foctcr.HasValue) { membst.foctcr = 0; }
                            if (!membst.fnovcr.HasValue) { membst.fnovcr = 0; }
                            if (!membst.fdeccr.HasValue) { membst.fdeccr = 0; }

                            for (int i = 1; i <= 12; i++)
                                {

                                MemberStatementPrintViewModel mpvm = new MemberStatementPrintViewModel();
                                mpvm.ERNo = ERNo;
                                mpvm.NameOfEmployer = NameofEmployer;
                                mpvm.SSNo = SSNo;
                                mpvm.NameofStaff = NameofStaff;
                                mpvm.Type = membst.ftype;

                                if (DateJoined.HasValue)
                                    {
                                    mpvm.DateJoined = DateJoined.Value;
                                    }

                                mpvm.StaffPINNo = StaffPINNo;
                                mpvm.DYear = mv.Year;
                                mpvm.sex = Sex;

                                switch (i)
                                    {
                                    case 1:
                                        mpvm.Month = "January";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fjancr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fjancr.Value;
                                            }

                                        break;
                                    case 2:
                                        mpvm.Month = "February";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.ffebcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.ffebcr.Value;
                                            }

                                        break;
                                    case 3:
                                        mpvm.Month = "March";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fmarcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fmarcr.Value;
                                            }

                                        break;
                                    case 4:
                                        mpvm.Month = "April";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.faprcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.faprcr.Value;
                                            }

                                        break;
                                    case 5:
                                        mpvm.Month = "May";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fmaycr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fmaycr.Value;
                                            }

                                        break;
                                    case 6:
                                        mpvm.Month = "June";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fjuncr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fjuncr.Value;
                                            }

                                        break;
                                    case 7:
                                        mpvm.Month = "July";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fjulcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fjulcr.Value;
                                            }

                                        break;
                                    case 8:
                                        mpvm.Month = "August";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.faugcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.faugcr.Value;
                                            }

                                        break;
                                    case 9:
                                        mpvm.Month = "September";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fsepcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fsepcr.Value;
                                            }

                                        break;
                                    case 10:
                                        mpvm.Month = "October";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.foctcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.foctcr.Value;
                                            }

                                        break;
                                    case 11:
                                        mpvm.Month = "November";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fnovcr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fnovcr.Value;
                                            }

                                        break;
                                    case 12:
                                        mpvm.Month = "December";

                                        if (membst.ftype == "R")
                                            {
                                            mpvm.Contribution = membst.fdeccr.Value;
                                            }
                                        else
                                            {
                                            mpvm.BackPay = membst.fdeccr.Value;
                                            }

                                        break;

                                    default:
                                        break;
                                    }

                                if (mpvm.Contribution != 0)
                                    {
                                    mpvm.Salary = decimal.Parse(((mpvm.Contribution * 100) / 15).ToString());
                                    }
                                else
                                    {
                                    mpvm.Salary = decimal.Parse(((mpvm.BackPay * 100) / 15).ToString());
                                    }

                                if (mpvm.Salary > 0)
                                    {
                                    mpvm.Salary = decimal.Parse(mpvm.Salary.ToString("F2"));
                                    }

                                mpvms.Add(mpvm);

                                }
                            }

                        }

                    XtraReportMemberStatement mydocument = new XtraReportMemberStatement();
                    mydocument.MemberStatementPrintDataSource.DataSource = mpvms;
                    mydocument.CreateDocument();

                    return View("PrintPreview", mydocument);

                    }


                }
            else
                {
                ViewBag.Message = "Please select the Type of Report you wish to see.";
                return View("mem_stmt", mv);
                }

            }

        #endregion

        #region PROCESS Old CR CONTRIBUTION REPORT

        public ActionResult OldCR()
            {
            TempData["MyMasterPeriods"] = null;
            TempData["Periods"] = null;
            TempData["MyEmployerCategories"] = null;

            return View("OldCR", new HardCopyViewModel());
            }

        public ActionResult OldCR_SummaryLoadErno(HardCopyViewModel re)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == re.ferno).ToList();

            if (emp.Count > 0)
                {
                TempData["MyEmployerCategories"] = GetMyEmployerCategories(re.ferno);

                TempData["MyMasterPeriods"] = GetMyMasterPeriods(re.ferno, re.fcat);

                re.femp_name = emp[0].femp_name;

                return View("OldCR", re);
                }
            else
                {
                return View("OldCR", re);
                }

            }

        public ActionResult OldCR_SummaryAccept(HardCopyViewModel re)
            {
            List<cr_ctrl> cr = new List<cr_ctrl>();
            cr = db.cr_ctrl.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (cr.Count > 0)
                {

                chist_tr ht = new chist_tr();

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fcur_cr = cr[0].ftotcr.Value;
                //ht.fnoofworkers = cr[0].ftotwkr.Value;
                //ht.ftotalcr = re.ftotalsalaryorcontribution.Value;
                //ht.ftotalworkers = re.fnoofworkers.Value;
                //ht.fmodeofsubmission = re.fmodesubmission;
                //ht.fmedia = cr[0].fmedia;

                ht.CreatedBy = Session["AccountID"].ToString();
                ht.CreatedOn = DateTime.Today;

                db.chist_tr.Add(ht);
                db.SaveChanges();

                }
            else
                {

                chist_tr ht = new chist_tr();

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                //ht.fcont = 0;
                //ht.fnoofworkers = 0;
                //ht.ftotalcr = re.ftotalsalaryorcontribution.Value;
                //ht.ftotalworkers = re.fnoofworkers.Value;

                //ht.fmodeofsubmission = re.fmodesubmission;
                //ht.fmedia = "P";

                ht.CreatedBy = Session["AccountID"].ToString();
                ht.CreatedOn = DateTime.Today;

                db.chist_tr.Add(ht);
                db.SaveChanges();

                }

            re.fAddworkersexpected = re.fnoofworkers;
            re.fAddcontributionexpected = re.ftotalsalaryorcontribution.Value;

            re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
            re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

            if (re.fAddworkercaptured > re.fAddworkersexpected)
                {
                ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                }

            if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                {
                ViewBag.Message = "Contribution captured has exceeded the expected amount";
                }

            re.fdisplayerno = re.ferno;
            re.fdisplayemp_name = re.femp_name;

            return View("OldCR", re);
            }


        public ActionResult OldCR_SummaryResetEditAll(HardCopyViewModel re)
            {

            re.fcat = "C";

            return View("OldCR", re);


            }

        public ActionResult OldCR_SummaryStartAfresh(HardCopyViewModel re)
            {

            List<chist_tr> htemps = new List<chist_tr>();
            htemps = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (htemps.Count > 0)
                {
                foreach (chist_tr ht in htemps)
                    {
                    db.chist_tr.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }
                }


            List<chist_tr> htrans = new List<chist_tr>();
            htrans = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (htrans.Count > 0)
                {
                foreach (chist_tr ht in htrans)
                    {
                    db.chist_tr.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }
                }

            HardCopyViewModel newre = new HardCopyViewModel();

            return View("OldCR", newre);


            }



        public ActionResult OldCR_SummaryLoadLastEntry(HardCopyViewModel re)
            {
            List<chist_tr> ht = new List<chist_tr>();
            ht = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (ht.Count > 0)
                {

                TempData["MyMasterPeriods"] = GetMyMasterPeriods(re.ferno, re.fcat);

                //re.fmodesubmission = ht[0].fmodeofsubmission;
                //re.ftotalsalaryorcontribution = ht[0].ftotalcr;
                //re.fnoofworkers = ht[0].ftotalworkers;

                re.fAddworkersexpected = re.fnoofworkers;
                re.fAddcontributionexpected = re.ftotalsalaryorcontribution.Value;

                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("OldCR", re);
                }
            else
                {

                return View("OldCR", re);
                }


            }

        public ActionResult OldCR_AddNewAccept(HardCopyViewModel re)
            {
            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            if (ValidateStaffNo(re.ferno, re.fAddStaffNumber, re.fAddFirstContributionPeriod))
                {
                ViewBag.Message = "Staff Number is in use by another staff under the same Establishment.";
                return View("OldCR", re);
                }

            List<chist_tr> htss = new List<chist_tr>();
            htss = db.chist_tr.Where(b => b.firstname == re.fAddFirstName).Where(b => b.fothername == re.fAddOtherName).Where(b => b.fsurname == re.fAddSurname).Where(b => b.fcurcr_per == re.fAddFirstContributionPeriod).ToList();

            if (htss.Count == 0)
                {
                chist_tr ht = new chist_tr();

                re.fAddResponsibilityCentre = Session["Branch"].ToString();

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fssno = re.fAddSSNo;

                if (CheckifSSNoisValid(re.fAddSSNo) == true)
                    {
                    ht.fcorr_ssno = re.fAddSSNo;
                    }
                else
                    {
                    ViewBag.Message = "SSNo - " + re.fAddSSNo + " is not valid. Please verify and update this member record.";
                    }

                ht.fsurname = re.fAddSurname;
                ht.firstname = re.fAddFirstName;
                ht.fothername = re.fAddOtherName;
                ht.fpcentre = re.fAddResponsibilityCentre;
                ht.fstaffno = re.fAddStaffNumber;
                ht.fcur_cr = re.fAddContributionorSalary;
                ht.fcurcr_per = re.fAddFirstContributionPeriod;
                ht.fremark = "A";
                ht.fupd_type = "A";

                if (re.fAddSSNo != null && re.fAddSSNo != "")
                    {
                    ht.fflag = false;
                    }
                else
                    {
                    ht.fflag = true;
                    }

                //ht.ftype = "";
                //ht.fmedia = "P";

                ht.CreatedBy = "DEFAULT";
                ht.CreatedOn = DateTime.Today;

                db.chist_tr.Add(ht);
                db.SaveChanges();


                re.fAddSSNo = "";
                re.fAddSurname = "";
                re.fAddFirstName = "";
                re.fAddOtherName = "";
                re.fAddStaffNumber = "";
                re.fAddContributionorSalary = 0;


                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                List<chist_tr> htemps = new List<chist_tr>();
                htemps = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (htemps.Count > 0)
                    {
                    chist_tr theht = new chist_tr();
                    theht = htemps[0];

                    theht.fcur_cr += re.fAddContributionorSalary;
                    //theht.fnoofworkers += 1;

                    }
                else
                    {
                    chist_tr theht = new chist_tr();

                    theht.CreatedBy = Session["AccountID"].ToString();
                    theht.CreatedOn = DateTime.Today;
                    theht.fcat = re.fcat;
                    theht.fcur_cr = re.fAddContributionorSalary;
                    theht.ferno = re.ferno;
                    //theht.fmodeofsubmission = re.fmodesubmission;
                    //theht.fnoofworkers = 1;
                    //theht.ftotalworkers = re.fnoofworkers.Value;
                    //theht.ftotalcr = re.ftotalsalaryorcontribution.Value;

                    }
                }
            else
                {
                ViewBag.Message = "Given name has already been captured for current employer and the selected period. Please verify.";
                }


            return View("OldCR", re);
            }


        public ActionResult OldCR_EditLoad(HardCopyViewModel re)
            {
            List<chist_tr> ht = new List<chist_tr>();
            ht = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditSSNo).ToList();

            if (ht.Count > 0)
                {

                re.fEditID = ht[0].ID_SBTS;
                re.fEditFirstName = ht[0].firstname;
                re.fEditSurname = ht[0].fsurname;
                re.fEditOtherName = ht[0].fothername;
                re.fEditResponsibilityCentre = ht[0].fpcentre;
                re.fEditContributionorSalary = ht[0].fcur_cr;
                re.fEditStaffNumber = ht[0].fstaffno;
                re.fEditPeriod = ht[0].fcurcr_per;

                return View("OldCR", re);
                }
            else
                {
                re.fEditID = 0;
                re.fEditFirstName = "";
                re.fEditSurname = "";
                re.fEditOtherName = "";
                re.fEditResponsibilityCentre = "";
                re.fEditContributionorSalary = 0;
                re.fEditStaffNumber = "";
                re.fEditPeriod = "";

                return View("OldCR", re);
                }


            }



        public ActionResult OldCR_EditUndo(HardCopyViewModel re)
            {
            List<chist_tr> ht = new List<chist_tr>();
            ht = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditSSNo).ToList();

            if (ht.Count > 0)
                {

                re.fEditFirstName = ht[0].firstname;
                re.fEditSurname = ht[0].fsurname;
                re.fEditOtherName = ht[0].fothername;
                re.fEditResponsibilityCentre = ht[0].fpcentre;
                re.fEditContributionorSalary = ht[0].fcur_cr;
                re.fEditStaffNumber = ht[0].fstaffno;

                return View("OldCR", re);
                }
            else
                {
                return View("OldCR", re);
                }


            }


        public ActionResult OldCR_EditAccept(HardCopyViewModel re)
            {

            if (ValidateStaffNo(re.ferno, re.fAddStaffNumber, re.fAddFirstContributionPeriod))
                {
                ViewBag.Message = "Staff Number is in use by another staff under the same Establishment.";
                return View("OldCR", re);
                }

            List<chist_tr> htrans = new List<chist_tr>();
            htrans = db.chist_tr.Where(b => b.ID_SBTS == re.fEditID).ToList();

            if (htrans.Count > 0)
                {
                chist_tr ht = new chist_tr();
                ht = htrans[0];

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fssno = re.fEditSSNo;

                if (CheckifSSNoisValid(re.fEditSSNo) == true)
                    {
                    ht.fcorr_ssno = re.fEditSSNo;
                    }
                else
                    {
                    ViewBag.Message = "SSNo - " + re.fEditSSNo + " is not valid. Please verify and update this member record.";
                    }

                if (re.fEditName != null)
                    {
                    if (re.fEditName == true)
                        {
                        ht.fsurname = re.fEditSurname;
                        ht.firstname = re.fEditFirstName;
                        ht.fothername = re.fEditOtherName;
                        }
                    }

                ht.fpcentre = re.fEditResponsibilityCentre;
                ht.fstaffno = re.fEditStaffNumber;
                ht.fcur_cr = re.fEditContributionorSalary;
                ht.fcurcr_per = re.fEditPeriod;

                db.chist_tr.Attach(ht);
                var entry = db.Entry(ht);
                entry.State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
                }


            re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
            re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

            if (re.fAddworkercaptured > re.fAddworkersexpected)
                {
                ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                }

            if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                {
                ViewBag.Message = "Contribution captured has exceeded the expected amount";
                }

            re.fdisplayerno = re.ferno;
            re.fdisplayemp_name = re.femp_name;

            return View("OldCR", re);


            }


        public ActionResult OldCR_EditRemove(HardCopyViewModel re)
            {


            List<chist_tr> ht = new List<chist_tr>();
            ht = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditSSNo).ToList();

            if (ht.Count > 0)
                {

                db.chist_tr.Attach(ht[0]);
                var entry = db.Entry(ht[0]);
                entry.State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();

                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("OldCR", re);
                }
            else
                {

                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("OldCR", re);
                }


            }


        public ActionResult OldCR_ShowCapturedMembers(HardCopyViewModel re)
            {
            ViewBag.ShowMembers = "Y";

            return View("OldCR", re);
            }

        public ActionResult OldCR_DeleteMember(int id)
            {


            chist_tr ht = new chist_tr();
            ht = db.chist_tr.Find(id);

            if (ht.fssno != null)
                {

                string ferno = ht.ferno;
                string fcat = ht.fcat;

                db.chist_tr.Attach(ht);
                var entry = db.Entry(ht);
                entry.State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();

                List<chist_tr> htemp = new List<chist_tr>();
                htemp = db.chist_tr.Where(b => b.ferno == ferno).Where(b => b.fcat == fcat).ToList();

                if (htemp.Count > 0)
                    {
                    chist_tr htt = new chist_tr();
                    htt = htemp[0];

                    HardCopyViewModel re = new HardCopyViewModel();
                    re.ferno = htt.ferno;
                    re.fcat = htt.fcat;
                    re.femp_name = GetEmployerName(ferno);
                    re.ftotalsalaryorcontribution = htt.fcur_cr;
                    //re.fnoofworkers = htt.fnoofworkers;

                    re.fAddcontributioncaptured = GetTotalContributionCaptured(ferno, fcat);
                    re.fAddworkercaptured = GetTotalWorkersCaptured(ferno, fcat);

                    re.fdisplayerno = re.ferno;
                    re.fdisplayemp_name = re.femp_name;

                    return View("OldCR", re);

                    }

                return View("OldCR", new HardCopyViewModel());


                }
            else
                {
                return View("OldCR", new HardCopyViewModel());
                }


            }



        public ActionResult OldCR_LoadMemberDetails(HardCopyViewModel re)
            {
            List<mem_tr> mv = new List<mem_tr>();
            mv = db.mem_tr.Where(b => b.fssno == re.fAddSSNo).ToList();

            if (mv.Count > 0)
                {

                re.fAddFirstName = mv[0].firstname;
                re.fAddOtherName = mv[0].fothname;
                re.fAddSurname = mv[0].fsurname;

                return View("OldCR", re);
                }
            else
                {

                re.fAddFirstName = "";
                re.fAddOtherName = "";
                re.fAddSurname = "";

                ViewBag.Message = "This SSNo is not valid. Please verify and try again.";

                return View("OldCR", re);
                }


            }

        public ActionResult OldCR_PrintCheckList(HardCopyViewModel re)
            {

            List<chist_tr> ht = new List<chist_tr>();
            ht = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (ht.Count > 0)
                {
                XtraReportContributionCheckList mydocument = new XtraReportContributionCheckList();

                List<ContributionCheckListViewModel> cvm = new List<ContributionCheckListViewModel>();
                ContributionCheckListViewModel c = new ContributionCheckListViewModel();
                c.femp_name = GetEmployerName(re.ferno);

                cvm.Add(c);

                mydocument.HistoryTransactionDataSource.DataSource = ht;
                mydocument.ContributionVMDataSource.DataSource = cvm;

                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);

                }
            else
                {
                return View("OldCR", re);
                }

            }


        public ActionResult OldCR_MasterUpdateOK(HardCopyViewModel re)
            {

            if (Session["AccountID"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            List<chist_tr> histemp = new List<chist_tr>();
            histemp = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (histemp.Count > 0)
                {

                foreach (chist_tr ht in histemp)
                    {

                    hist_mst hm = new hist_mst();
                    hm.CreatedBy = Session["AccountID"].ToString();
                    hm.CreatedOn = DateTime.Today;
                    hm.fcat = ht.fcat;
                    hm.fcatbperd = "";
                    hm.fcurcr_perd = ht.fcurcr_per;
                    hm.fcur_cr = ht.fcur_cr;
                    hm.ferno = ht.ferno;
                    hm.firstname = ht.firstname;
                    hm.flast_cr = ht.flast_cr;
                    hm.fothername = ht.fothername;
                    hm.fpcentre = ht.fpcentre;
                    hm.fprocess = "A";
                    hm.fremark = ht.fremark;
                    hm.frstcr_perd = ht.fcurcr_per;

                    hm.fstaffno = ht.fstaffno;
                    hm.fsurname = ht.fsurname;
                    hm.fflag = ht.fflag;
                    hm.fid = "";
                    hm.fdateupd = DateTime.Today;

                    if (ht.fcorr_ssno != "" && ht.fcorr_ssno != null)
                        {
                        hm.fssno = ht.fcorr_ssno;
                        }

                    db.hist_mst.Add(hm);
                    db.SaveChanges();

                    ht.fid = "P";
                    ht.fcorr_ssno = "";

                    }

                List<cr_ctrl> ctss = new List<cr_ctrl>();
                ctss = db.cr_ctrl.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (ctss.Count > 0)
                    {
                    cr_ctrl ct = new cr_ctrl();
                    ct = ctss[0];

                    ct.CreatedBy = Session["AccountID"].ToString();
                    ct.CreatedOn = DateTime.Today;

                    ct.fmedia = "P";
                    ct.fmode = re.fmodesubmission;
                    ct.ftotcr += re.fmastercontributiontext;
                    ct.ftotwkr += re.fmasterperiodnoofworkers;

                    db.cr_ctrl.Attach(ct);
                    var entry = db.Entry(ct);
                    entry.State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    }
                else
                    {
                    cr_ctrl ct = new cr_ctrl();
                    ct.CreatedBy = Session["AccountID"].ToString();
                    ct.CreatedOn = DateTime.Today;
                    ct.fcat = re.fcat;
                    ct.ferno = re.ferno;
                    ct.fmedia = "P";
                    ct.fmode = re.fmodesubmission;
                    ct.ftotcr = re.fmastercontributiontext;
                    ct.ftotwkr = re.fmasterperiodnoofworkers;

                    db.cr_ctrl.Add(ct);
                    db.SaveChanges();

                    }


                //DELETE THE HISTORY TEMP

                List<chist_tr> htemps = new List<chist_tr>();
                htemps = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                foreach (chist_tr ht in htemps)
                    {
                    db.chist_tr.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }


                //DELETE THE HISTORY TRANSACTION

                List<chist_tr> htrans = new List<chist_tr>();
                htrans = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                foreach (chist_tr ht in htrans)
                    {
                    db.chist_tr.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }


                //CHECK IF THE USER DESIRED TO UPDATE THE GENERATED CR
                //GO THROUGH ALL THE HISTORY MASTER RECORDS AND UPDATE THEM




                re.fmastercontributiontext = GetTotalContribution(re.ferno, re.fcat, re.fmasterperiod);
                re.fmasterperiodnoofworkers = GetTotalNoOfWorkers(re.ferno, re.fcat, re.fmasterperiod);
                re.fmasterperiodtext = re.fmasterperiod;

                return View("OldCR", new HardCopyViewModel());

                }
            else
                {

                List<hist_mst> hismast = new List<hist_mst>();
                hismast = db.hist_mst.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (hismast.Count > 0)
                    {

                    if (re.fMasterUpdateGenerateCR == true)
                        {

                        decimal NASSITPercent = decimal.Parse("0.15");
                        List<NASSITPercentage> nps = new List<NASSITPercentage>();
                        nps = db.NASSITPercentages.ToList();

                        if (nps.Count > 0)
                            {
                            NASSITPercent = nps[0].NPercentage;
                            }

                        List<hist_mst> hmast = new List<hist_mst>();
                        hmast = db.hist_mst.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiodtext).ToList();

                        if (hmast.Count > 0)
                            {

                            List<empcr_tr> decs = new List<empcr_tr>();
                            string dftype = "R";

                            decs = db.empcr_tr.Where(b => b.ferno == re.ferno).Where(b => b.ftype_cr == dftype).Where(b => b.fcat == re.fcat).Where(b => b.fperiod == re.fmasterperiodtext).ToList();

                            if (decs.Count > 0)
                                {
                                foreach (empcr_tr item in decs)
                                    {
                                    db.empcr_tr.Attach(item);
                                    var entry = db.Entry(item);
                                    entry.State = System.Data.Entity.EntityState.Deleted;
                                    db.SaveChanges();
                                    }
                                }

                            foreach (hist_mst hm in hmast)
                                {
                                if (hm.fremark == "A")
                                    {
                                    List<memcr_tr> testmember = new List<memcr_tr>();
                                    testmember = db.memcr_tr.Where(b => b.ferno == hm.ferno).Where(b => b.fcat == hm.fcat).Where(b => b.ftype_cr == "R").Where(b => b.fssno == hm.fssno).Where(b => b.fsurname == hm.fsurname)
                                        .Where(b => b.fothername == hm.fothername).Where(b => b.firstname == hm.firstname).Where(b => b.fperiod == hm.fcurcr_perd).ToList();

                                    if (testmember.Count > 0)
                                        {
                                        memcr_tr mcon = new memcr_tr();
                                        mcon = testmember[0];

                                        mcon.fcat = hm.fcat;

                                        if (hm.fcat == "C")
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value;
                                            }
                                        else
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value * NASSITPercent;
                                            }

                                        mcon.fstaffno = hm.fstaffno;
                                        mcon.ferno = hm.ferno;
                                        mcon.fssno = hm.fssno;
                                        mcon.ftype_cr = "R";
                                        mcon.fsurname = hm.fsurname;
                                        mcon.fothername = hm.fothername;
                                        mcon.firstname = hm.firstname;
                                        mcon.fperiod = hm.fcurcr_perd;
                                        mcon.fmedia = "P";

                                        mcon.CreatedBy = Session["AccountID"].ToString();
                                        mcon.CreatedOn = DateTime.Today;

                                        db.memcr_tr.Attach(mcon);
                                        var entry = db.Entry(mcon);
                                        entry.State = System.Data.Entity.EntityState.Modified;
                                        db.SaveChanges();

                                        }
                                    else
                                        {

                                        memcr_tr mcon = new memcr_tr();

                                        mcon.fcat = hm.fcat;

                                        if (hm.fcat == "C")
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value;
                                            }
                                        else
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value * NASSITPercent;
                                            }

                                        mcon.fstaffno = hm.fstaffno;
                                        mcon.ferno = hm.ferno;
                                        mcon.fssno = hm.fssno;
                                        mcon.ftype_cr = "R";
                                        mcon.fsurname = hm.fsurname;
                                        mcon.fothername = hm.fothername;
                                        mcon.firstname = hm.firstname;
                                        mcon.fperiod = hm.fcurcr_perd;
                                        mcon.fmedia = "P";
                                        mcon.fpcentre = Session["Branch"].ToString();

                                        mcon.CreatedBy = Session["AccountID"].ToString();
                                        mcon.CreatedOn = DateTime.Today;

                                        db.memcr_tr.Add(mcon);
                                        db.SaveChanges();

                                        }
                                    }

                                List<empcr_tr> ecs = new List<empcr_tr>();
                                string ddftype = "R";

                                ecs = db.empcr_tr.Where(b => b.ferno == hm.ferno).Where(b => b.ftype_cr == ddftype).Where(b => b.fcat == hm.fcat).Where(b => b.fperiod == hm.fcurcr_perd).ToList();

                                if (ecs.Count > 0)
                                    {
                                    empcr_tr ec = new empcr_tr();
                                    ec = ecs[0];

                                    if (hm.fcat == "C")
                                        {
                                        ec.ftot_cont += hm.fcur_cr;
                                        }
                                    else
                                        {
                                        ec.ftot_cont += (hm.fcur_cr * NASSITPercent);
                                        }

                                    ec.fdateupd = DateTime.Today;
                                    ec.fuser_code = Session["AccountID"].ToString();
                                    ec.ftype_cr = "R";
                                    ec.fno_wkr += 1;

                                    db.empcr_tr.Attach(ec);
                                    var entry = db.Entry(ec);
                                    entry.State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();

                                    }
                                else
                                    {

                                    empcr_tr ec = new empcr_tr();

                                    if (hm.fcat == "C")
                                        {
                                        ec.ftot_cont = hm.fcur_cr;
                                        }
                                    else
                                        {
                                        ec.ftot_cont = (hm.fcur_cr * NASSITPercent);
                                        }

                                    ec.fdateupd = DateTime.Today;
                                    ec.fuser_code = Session["AccountID"].ToString();
                                    ec.ferno = hm.ferno;
                                    ec.fcat = hm.fcat;
                                    ec.fperiod = hm.fcurcr_perd;
                                    ec.ftype_cr = "R";
                                    ec.fno_wkr = 1;

                                    db.empcr_tr.Add(ec);
                                    db.SaveChanges();

                                    }
                                }

                            }


                        List<crsreg> cregss = new List<crsreg>();
                        string thetype = "R";
                        cregss = db.crsregs.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fperiod == re.fmasterperiodtext).Where(b => b.ftype == thetype).ToList();

                        if (cregss.Count > 0)
                            {

                            crsreg cr = new crsreg();
                            cr = cregss[0];

                            cr.fnowkr = re.fmasterperiodnoofworkers.Value;
                            cr.ftot_cr = re.fmastercontributiontext.Value;
                            cr.fstatus = "G";
                            cr.fdate_cap = DateTime.Today;
                            cr.fuser_cap = Session["AccountID"].ToString();

                            }

                        }

                    }

                return View("OldCR", re);
                }

            }


        public ActionResult OldCR_MasterPeriodLoad(HardCopyViewModel re)
            {

            re.fmastercontributiontext = GetTotalContribution(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodnoofworkers = GetTotalNoOfWorkers(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodtext = re.fmasterperiod;

            if (re.fcat == null || re.fcat == "")
                {
                ViewBag.Message = "You have not selected the Staff Category from the Summary Tab. Please do and try again.";
                }
            return View("OldCR", re);

            }



        #endregion

        #region PROCESS BACKPAY CONTRIBUTION REPORT

        public ActionResult Backpay()
            {
            TempData["MyMasterPeriods"] = null;
            TempData["Periods"] = null;
            TempData["MyEmployerCategories"] = null;

            return View("Backpay", new HardCopyViewModel());
            }

        public ActionResult Backpay_SummaryLoadErno(HardCopyViewModel re)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == re.ferno).ToList();

            if (emp.Count > 0)
                {
                TempData["MyEmployerCategories"] = GetMyEmployerCategories(re.ferno);

                TempData["MyMasterPeriods"] = GetMyMasterPeriods(re.ferno, re.fcat);

                re.femp_name = emp[0].femp_name;

                return View("Backpay", re);
                }
            else
                {
                return View("Backpay", re);
                }

            }

        public ActionResult Backpay_SummaryAccept(HardCopyViewModel re)
            {
            List<cr_ctrl> cr = new List<cr_ctrl>();
            cr = db.cr_ctrl.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (cr.Count > 0)
                {

                chist_tr ht = new chist_tr();

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fcur_cr = cr[0].ftotcr;
                //ht.fnoofworkers = cr[0].ftotalworkers.Value;
                //ht.ftotalcr = re.ftotalsalaryorcontribution.Value;
                //ht.ftotalworkers = re.fnoofworkers.Value;
                //ht.fmodeofsubmission = re.fmodesubmission;
                //ht.fmedia = cr[0].fmedia;

                ht.CreatedBy = Session["AccountID"].ToString();
                ht.CreatedOn = DateTime.Today;

                db.chist_tr.Add(ht);
                db.SaveChanges();

                }
            else
                {

                chist_tr ht = new chist_tr();

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fcur_cr = 0;
                //ht.fnoofworkers = 0;
                //ht.ftotalcr = re.ftotalsalaryorcontribution.Value;
                //ht.ftotalworkers = re.fnoofworkers.Value;

                //ht.fmodeofsubmission = re.fmodesubmission;
                //ht.fmedia = "P";

                ht.CreatedBy = Session["AccountID"].ToString();
                ht.CreatedOn = DateTime.Today;

                db.chist_tr.Add(ht);
                db.SaveChanges();

                }

            re.fAddworkersexpected = re.fnoofworkers;
            re.fAddcontributionexpected = re.ftotalsalaryorcontribution.Value;

            re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
            re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

            if (re.fAddworkercaptured > re.fAddworkersexpected)
                {
                ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                }

            if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                {
                ViewBag.Message = "Contribution captured has exceeded the expected amount";
                }

            re.fdisplayerno = re.ferno;
            re.fdisplayemp_name = re.femp_name;

            return View("Backpay", re);
            }


        public ActionResult Backpay_SummaryResetEditAll(HardCopyViewModel re)
            {

            re.fcat = "C";

            return View("Backpay", re);


            }

        public ActionResult Backpay_SummaryStartAfresh(HardCopyViewModel re)
            {

            List<chist_tr> htemps = new List<chist_tr>();
            htemps = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (htemps.Count > 0)
                {
                foreach (chist_tr ht in htemps)
                    {
                    db.chist_tr.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }
                }


            List<chist_tr> htrans = new List<chist_tr>();
            htrans = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (htrans.Count > 0)
                {
                foreach (chist_tr ht in htrans)
                    {
                    db.chist_tr.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }
                }

            HardCopyViewModel newre = new HardCopyViewModel();

            return View("Backpay", newre);


            }



        public ActionResult Backpay_SummaryLoadLastEntry(HardCopyViewModel re)
            {
            List<chist_tr> ht = new List<chist_tr>();
            ht = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (ht.Count > 0)
                {

                TempData["MyMasterPeriods"] = GetMyMasterPeriods(re.ferno, re.fcat);

                //re.fmodesubmission = ht[0].fmodeofsubmission;
                //re.ftotalsalaryorcontribution = ht[0].ftotalcr;
                //re.fnoofworkers = ht[0].ftotalworkers;

                re.fAddworkersexpected = re.fnoofworkers;
                re.fAddcontributionexpected = re.ftotalsalaryorcontribution.Value;

                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("Backpay", re);
                }
            else
                {

                return View("Backpay", re);
                }


            }

        public ActionResult Backpay_AddNewAccept(HardCopyViewModel re)
            {
            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            if (ValidateStaffNo(re.ferno, re.fAddStaffNumber, re.fAddFirstContributionPeriod))
                {
                ViewBag.Message = "Staff Number is in use by another staff under the same Establishment.";
                return View("Backpay", re);
                }

            List<chist_tr> htss = new List<chist_tr>();
            htss = db.chist_tr.Where(b => b.firstname == re.fAddFirstName).Where(b => b.fothername == re.fAddOtherName).Where(b => b.fsurname == re.fAddSurname).Where(b => b.fcurcr_per == re.fAddFirstContributionPeriod).ToList();

            if (htss.Count == 0)
                {
                chist_tr ht = new chist_tr();

                re.fAddResponsibilityCentre = Session["Branch"].ToString();

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fssno = re.fAddSSNo;

                if (CheckifSSNoisValid(re.fAddSSNo) == true)
                    {
                    ht.fcorr_ssno = re.fAddSSNo;
                    }
                else
                    {
                    ViewBag.Message = "SSNo - " + re.fAddSSNo + " is not valid. Please verify and update this member record.";
                    }

                ht.fsurname = re.fAddSurname;
                ht.firstname = re.fAddFirstName;
                ht.fothername = re.fAddOtherName;
                ht.fpcentre = re.fAddResponsibilityCentre;
                ht.fstaffno = re.fAddStaffNumber;
                ht.fcur_cr = re.fAddContributionorSalary;
                ht.fcurcr_per = re.fAddFirstContributionPeriod;
                ht.fremark = "A";
                ht.fupd_type = "A";

                if (re.fAddSSNo != null && re.fAddSSNo != "")
                    {
                    ht.fflag = false;
                    }
                else
                    {
                    ht.fflag = true;
                    }

                //ht.ftype = "";
                //ht.fmedia = "P";

                ht.CreatedBy = "DEFAULT";
                ht.CreatedOn = DateTime.Today;

                db.chist_tr.Add(ht);
                db.SaveChanges();


                re.fAddSSNo = "";
                re.fAddSurname = "";
                re.fAddFirstName = "";
                re.fAddOtherName = "";
                re.fAddStaffNumber = "";
                re.fAddContributionorSalary = 0;


                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                List<chist_tr> htemps = new List<chist_tr>();
                htemps = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (htemps.Count > 0)
                    {
                    chist_tr theht = new chist_tr();
                    theht = htemps[0];

                    theht.fcur_cr += re.fAddContributionorSalary;
                    //theht.fnoofworkers += 1;

                    }
                else
                    {
                    chist_tr theht = new chist_tr();

                    theht.CreatedBy = Session["AccountID"].ToString();
                    theht.CreatedOn = DateTime.Today;
                    theht.fcat = re.fcat;
                    theht.fcur_cr = re.fAddContributionorSalary;
                    theht.ferno = re.ferno;
                    //theht.fmodeofsubmission = re.fmodesubmission;
                    //theht.fnoofworkers = 1;
                    //theht.ftotalworkers = re.fnoofworkers.Value;
                    //theht.ftotalcr = re.ftotalsalaryorcontribution.Value;

                    }
                }
            else
                {
                ViewBag.Message = "Given name has already been captured for current employer and the selected period. Please verify.";
                }


            return View("Backpay", re);
            }


        public ActionResult Backpay_EditLoad(HardCopyViewModel re)
            {
            List<chist_tr> ht = new List<chist_tr>();
            ht = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditSSNo).ToList();

            if (ht.Count > 0)
                {

                re.fEditID = ht[0].ID_SBTS;
                re.fEditFirstName = ht[0].firstname;
                re.fEditSurname = ht[0].fsurname;
                re.fEditOtherName = ht[0].fothername;
                re.fEditResponsibilityCentre = ht[0].fpcentre;
                re.fEditContributionorSalary = ht[0].fcur_cr;
                re.fEditStaffNumber = ht[0].fstaffno;
                re.fEditPeriod = ht[0].fcurcr_per;

                return View("Backpay", re);
                }
            else
                {
                re.fEditID = 0;
                re.fEditFirstName = "";
                re.fEditSurname = "";
                re.fEditOtherName = "";
                re.fEditResponsibilityCentre = "";
                re.fEditContributionorSalary = 0;
                re.fEditStaffNumber = "";
                re.fEditPeriod = "";

                return View("Backpay", re);
                }


            }



        public ActionResult Backpay_EditUndo(HardCopyViewModel re)
            {
            List<chist_tr> ht = new List<chist_tr>();
            ht = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditSSNo).ToList();

            if (ht.Count > 0)
                {

                re.fEditFirstName = ht[0].firstname;
                re.fEditSurname = ht[0].fsurname;
                re.fEditOtherName = ht[0].fothername;
                re.fEditResponsibilityCentre = ht[0].fpcentre;
                re.fEditContributionorSalary = ht[0].fcur_cr;
                re.fEditStaffNumber = ht[0].fstaffno;

                return View("Backpay", re);
                }
            else
                {
                return View("Backpay", re);
                }


            }


        public ActionResult Backpay_EditAccept(HardCopyViewModel re)
            {

            if (ValidateStaffNo(re.ferno, re.fAddStaffNumber, re.fAddFirstContributionPeriod))
                {
                ViewBag.Message = "Staff Number is in use by another staff under the same Establishment.";
                return View("Backpay", re);
                }

            List<chist_tr> htrans = new List<chist_tr>();
            htrans = db.chist_tr.Where(b => b.ID_SBTS == re.fEditID).ToList();

            if (htrans.Count > 0)
                {
                chist_tr ht = new chist_tr();
                ht = htrans[0];

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;
                ht.fssno = re.fEditSSNo;

                if (CheckifSSNoisValid(re.fEditSSNo) == true)
                    {
                    ht.fcorr_ssno = re.fEditSSNo;
                    }
                else
                    {
                    ViewBag.Message = "SSNo - " + re.fEditSSNo + " is not valid. Please verify and update this member record.";
                    }

                if (re.fEditName != null)
                    {
                    if (re.fEditName == true)
                        {
                        ht.fsurname = re.fEditSurname;
                        ht.firstname = re.fEditFirstName;
                        ht.fothername = re.fEditOtherName;
                        }
                    }

                ht.fpcentre = re.fEditResponsibilityCentre;
                ht.fstaffno = re.fEditStaffNumber;
                ht.fcur_cr = re.fEditContributionorSalary;
                ht.fcurcr_per = re.fEditPeriod;

                db.chist_tr.Attach(ht);
                var entry = db.Entry(ht);
                entry.State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
                }


            re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
            re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

            if (re.fAddworkercaptured > re.fAddworkersexpected)
                {
                ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                }

            if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                {
                ViewBag.Message = "Contribution captured has exceeded the expected amount";
                }

            re.fdisplayerno = re.ferno;
            re.fdisplayemp_name = re.femp_name;

            return View("Backpay", re);


            }


        public ActionResult Backpay_EditRemove(HardCopyViewModel re)
            {


            List<chist_tr> ht = new List<chist_tr>();
            ht = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fssno == re.fEditSSNo).ToList();

            if (ht.Count > 0)
                {

                db.chist_tr.Attach(ht[0]);
                var entry = db.Entry(ht[0]);
                entry.State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();

                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("Backpay", re);
                }
            else
                {

                re.fAddcontributioncaptured = GetTotalContributionCaptured(re.ferno, re.fcat);
                re.fAddworkercaptured = GetTotalWorkersCaptured(re.ferno, re.fcat);

                if (re.fAddworkercaptured > re.fAddworkersexpected)
                    {
                    ViewBag.Message = "No. of Workers captured has exceeded the expected number";
                    }

                if (re.fAddcontributioncaptured > re.fAddcontributionexpected)
                    {
                    ViewBag.Message = "Contribution captured has exceeded the expected amount";
                    }

                re.fdisplayerno = re.ferno;
                re.fdisplayemp_name = re.femp_name;

                return View("Backpay", re);
                }


            }


        public ActionResult Backpay_ShowCapturedMembers(HardCopyViewModel re)
            {
            ViewBag.ShowMembers = "Y";

            return View("Backpay", re);
            }

        public ActionResult Backpay_DeleteMember(int id)
            {


            chist_tr ht = new chist_tr();
            ht = db.chist_tr.Find(id);

            if (ht.fssno != null)
                {

                string ferno = ht.ferno;
                string fcat = ht.fcat;

                db.chist_tr.Attach(ht);
                var entry = db.Entry(ht);
                entry.State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();

                List<chist_tr> htemp = new List<chist_tr>();
                htemp = db.chist_tr.Where(b => b.ferno == ferno).Where(b => b.fcat == fcat).ToList();

                if (htemp.Count > 0)
                    {
                    chist_tr htt = new chist_tr();
                    htt = htemp[0];

                    HardCopyViewModel re = new HardCopyViewModel();
                    re.ferno = htt.ferno;
                    re.fcat = htt.fcat;
                    re.femp_name = GetEmployerName(ferno);
                    re.ftotalsalaryorcontribution = htt.fcur_cr;
                    //re.fnoofworkers = htt.fnoofworkers;

                    re.fAddcontributioncaptured = GetTotalContributionCaptured(ferno, fcat);
                    re.fAddworkercaptured = GetTotalWorkersCaptured(ferno, fcat);

                    re.fdisplayerno = re.ferno;
                    re.fdisplayemp_name = re.femp_name;

                    return View("Backpay", re);

                    }

                return View("Backpay", new HardCopyViewModel());


                }
            else
                {
                return View("Backpay", new HardCopyViewModel());
                }


            }



        public ActionResult Backpay_LoadMemberDetails(HardCopyViewModel re)
            {
            List<mem_tr> mv = new List<mem_tr>();
            mv = db.mem_tr.Where(b => b.fssno == re.fAddSSNo).ToList();

            if (mv.Count > 0)
                {

                re.fAddFirstName = mv[0].firstname;
                re.fAddOtherName = mv[0].fothname;
                re.fAddSurname = mv[0].fsurname;

                return View("Backpay", re);
                }
            else
                {

                re.fAddFirstName = "";
                re.fAddOtherName = "";
                re.fAddSurname = "";

                ViewBag.Message = "This SSNo is not valid. Please verify and try again.";

                return View("Backpay", re);
                }


            }

        public ActionResult Backpay_PrintCheckList(HardCopyViewModel re)
            {

            List<chist_tr> ht = new List<chist_tr>();
            ht = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (ht.Count > 0)
                {
                XtraReportContributionCheckList mydocument = new XtraReportContributionCheckList();

                List<ContributionCheckListViewModel> cvm = new List<ContributionCheckListViewModel>();
                ContributionCheckListViewModel c = new ContributionCheckListViewModel();
                c.femp_name = GetEmployerName(re.ferno);

                cvm.Add(c);

                mydocument.HistoryTransactionDataSource.DataSource = ht;
                mydocument.ContributionVMDataSource.DataSource = cvm;

                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);

                }
            else
                {
                return View("Backpay", re);
                }

            }


        public ActionResult Backpay_MasterUpdateOK(HardCopyViewModel re)
            {

            if (Session["AccountID"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            List<chist_tr> histemp = new List<chist_tr>();
            histemp = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (histemp.Count > 0)
                {

                foreach (chist_tr ht in histemp)
                    {

                    hist_mst hm = new hist_mst();
                    hm.CreatedBy = Session["AccountID"].ToString();
                    hm.CreatedOn = DateTime.Today;
                    hm.fcat = ht.fcat;
                    hm.fcatbperd = "";
                    hm.fcurcr_perd = ht.fcurcr_per;
                    hm.fcur_cr = ht.fcur_cr;
                    hm.ferno = ht.ferno;
                    hm.firstname = ht.firstname;
                    hm.flast_cr = ht.flast_cr;
                    hm.fothername = ht.fothername;
                    hm.fpcentre = ht.fpcentre;
                    hm.fprocess = "A";
                    hm.fremark = ht.fremark;
                    hm.frstcr_perd = "";

                    hm.fstaffno = ht.fstaffno;
                    hm.fsurname = ht.fsurname;
                    hm.fflag = ht.fflag;
                    hm.fid = "";
                    hm.fdateupd = DateTime.Today;

                    if (ht.fcorr_ssno != "" && ht.fcorr_ssno != null)
                        {
                        hm.fssno = ht.fcorr_ssno;
                        }

                    db.hist_mst.Add(hm);
                    db.SaveChanges();

                    ht.fid = "P";
                    ht.fcorr_ssno = "";

                    }

                List<cr_ctrl> ctss = new List<cr_ctrl>();
                ctss = db.cr_ctrl.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (ctss.Count > 0)
                    {
                    cr_ctrl ct = new cr_ctrl();
                    ct = ctss[0];

                    ct.CreatedBy = Session["AccountID"].ToString();
                    ct.CreatedOn = DateTime.Today;

                    ct.fmedia = "P";
                    ct.fmode = re.fmodesubmission;
                    ct.ftotcr += re.fmastercontributiontext;
                    ct.ftotwkr += re.fmasterperiodnoofworkers;

                    db.cr_ctrl.Attach(ct);
                    var entry = db.Entry(ct);
                    entry.State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    }
                else
                    {
                    cr_ctrl ct = new cr_ctrl();
                    ct.CreatedBy = Session["AccountID"].ToString();
                    ct.CreatedOn = DateTime.Today;
                    ct.fcat = re.fcat;
                    ct.ferno = re.ferno;
                    ct.fmedia = "P";
                    ct.fmode = re.fmodesubmission;
                    ct.ftotcr = re.fmastercontributiontext;
                    ct.ftotwkr = re.fmasterperiodnoofworkers;

                    db.cr_ctrl.Add(ct);
                    db.SaveChanges();

                    }


                //DELETE THE HISTORY TEMP

                List<chist_tr> htemps = new List<chist_tr>();
                htemps = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                foreach (chist_tr ht in htemps)
                    {
                    db.chist_tr.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }


                //DELETE THE HISTORY TRANSACTION

                List<chist_tr> htrans = new List<chist_tr>();
                htrans = db.chist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                foreach (chist_tr ht in htrans)
                    {
                    db.chist_tr.Attach(ht);
                    var entry = db.Entry(ht);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }


                //CHECK IF THE USER DESIRED TO UPDATE THE GENERATED CR
                //GO THROUGH ALL THE HISTORY MASTER RECORDS AND UPDATE THEM




                re.fmastercontributiontext = GetTotalContribution(re.ferno, re.fcat, re.fmasterperiod);
                re.fmasterperiodnoofworkers = GetTotalNoOfWorkers(re.ferno, re.fcat, re.fmasterperiod);
                re.fmasterperiodtext = re.fmasterperiod;

                return View("Backpay", new HardCopyViewModel());

                }
            else
                {

                List<hist_mst> hismast = new List<hist_mst>();
                hismast = db.hist_mst.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (hismast.Count > 0)
                    {

                    if (re.fMasterUpdateGenerateCR == true)
                        {

                        decimal NASSITPercent = decimal.Parse("0.15");
                        List<NASSITPercentage> nps = new List<NASSITPercentage>();
                        nps = db.NASSITPercentages.ToList();

                        if (nps.Count > 0)
                            {
                            NASSITPercent = nps[0].NPercentage;
                            }

                        List<hist_mst> hmast = new List<hist_mst>();
                        hmast = db.hist_mst.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiodtext).ToList();

                        if (hmast.Count > 0)
                            {

                            List<empcr_tr> decs = new List<empcr_tr>();
                            string dftype = "R";

                            decs = db.empcr_tr.Where(b => b.ferno == re.ferno).Where(b => b.ftype_cr == dftype).Where(b => b.fcat == re.fcat).Where(b => b.fperiod == re.fmasterperiodtext).ToList();

                            if (decs.Count > 0)
                                {
                                foreach (empcr_tr item in decs)
                                    {
                                    db.empcr_tr.Attach(item);
                                    var entry = db.Entry(item);
                                    entry.State = System.Data.Entity.EntityState.Deleted;
                                    db.SaveChanges();
                                    }
                                }

                            foreach (hist_mst hm in hmast)
                                {
                                if (hm.fremark == "A")
                                    {
                                    List<memcr_tr> testmember = new List<memcr_tr>();
                                    testmember = db.memcr_tr.Where(b => b.ferno == hm.ferno).Where(b => b.fcat == hm.fcat).Where(b => b.ftype_cr == "R").Where(b => b.fssno == hm.fssno).Where(b => b.fsurname == hm.fsurname)
                                        .Where(b => b.fothername == hm.fothername).Where(b => b.firstname == hm.firstname).Where(b => b.fperiod == hm.fcurcr_perd).ToList();

                                    if (testmember.Count > 0)
                                        {
                                        memcr_tr mcon = new memcr_tr();
                                        mcon = testmember[0];

                                        mcon.fcat = hm.fcat;

                                        if (hm.fcat == "C")
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value;
                                            }
                                        else
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value * NASSITPercent;
                                            }

                                        mcon.fstaffno = hm.fstaffno;
                                        mcon.ferno = hm.ferno;
                                        mcon.fssno = hm.fssno;
                                        mcon.ftype_cr = "R";
                                        mcon.fsurname = hm.fsurname;
                                        mcon.fothername = hm.fothername;
                                        mcon.firstname = hm.firstname;
                                        mcon.fperiod = hm.fcurcr_perd;
                                        mcon.fmedia = "P";

                                        mcon.CreatedBy = Session["AccountID"].ToString();
                                        mcon.CreatedOn = DateTime.Today;

                                        db.memcr_tr.Attach(mcon);
                                        var entry = db.Entry(mcon);
                                        entry.State = System.Data.Entity.EntityState.Modified;
                                        db.SaveChanges();

                                        }
                                    else
                                        {

                                        memcr_tr mcon = new memcr_tr();

                                        mcon.fcat = hm.fcat;

                                        if (hm.fcat == "C")
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value;
                                            }
                                        else
                                            {
                                            mcon.fcontr = hm.fcur_cr.Value * NASSITPercent;
                                            }

                                        mcon.fstaffno = hm.fstaffno;
                                        mcon.ferno = hm.ferno;
                                        mcon.fssno = hm.fssno;
                                        mcon.ftype_cr = "R";
                                        mcon.fsurname = hm.fsurname;
                                        mcon.fothername = hm.fothername;
                                        mcon.firstname = hm.firstname;
                                        mcon.fperiod = hm.fcurcr_perd;
                                        mcon.fmedia = "P";
                                        mcon.fpcentre = Session["Branch"].ToString();

                                        mcon.CreatedBy = Session["AccountID"].ToString();
                                        mcon.CreatedOn = DateTime.Today;

                                        db.memcr_tr.Add(mcon);
                                        db.SaveChanges();

                                        }
                                    }

                                List<empcr_tr> ecs = new List<empcr_tr>();
                                string ddftype = "R";

                                ecs = db.empcr_tr.Where(b => b.ferno == hm.ferno).Where(b => b.ftype_cr == ddftype).Where(b => b.fcat == hm.fcat).Where(b => b.fperiod == hm.fcurcr_perd).ToList();

                                if (ecs.Count > 0)
                                    {
                                    empcr_tr ec = new empcr_tr();
                                    ec = ecs[0];

                                    if (hm.fcat == "C")
                                        {
                                        ec.ftot_cont += hm.fcur_cr;
                                        }
                                    else
                                        {
                                        ec.ftot_cont += (hm.fcur_cr * NASSITPercent);
                                        }

                                    ec.fdateupd = DateTime.Today;
                                    ec.fuser_code = Session["AccountID"].ToString();
                                    ec.ftype_cr = "R";
                                    ec.fno_wkr += 1;

                                    db.empcr_tr.Attach(ec);
                                    var entry = db.Entry(ec);
                                    entry.State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();

                                    }
                                else
                                    {

                                    empcr_tr ec = new empcr_tr();

                                    if (hm.fcat == "C")
                                        {
                                        ec.ftot_cont = hm.fcur_cr;
                                        }
                                    else
                                        {
                                        ec.ftot_cont = (hm.fcur_cr * NASSITPercent);
                                        }

                                    ec.fdateupd = DateTime.Today;
                                    ec.fuser_code = Session["AccountID"].ToString();
                                    ec.ferno = hm.ferno;
                                    ec.fcat = hm.fcat;
                                    ec.fperiod = hm.fcurcr_perd;
                                    //ec.ftype = "R";
                                    //ec.fno_wrk = 1;

                                    db.empcr_tr.Add(ec);
                                    db.SaveChanges();

                                    }
                                }

                            }


                        List<crsreg> cregss = new List<crsreg>();
                        string thetype = "R";
                        cregss = db.crsregs.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fperiod == re.fmasterperiodtext).Where(b => b.ftype == thetype).ToList();

                        if (cregss.Count > 0)
                            {

                            crsreg cr = new crsreg();
                            cr = cregss[0];

                            cr.fnowkr = re.fmasterperiodnoofworkers.Value;
                            cr.ftot_cr = re.fmastercontributiontext.Value;
                            cr.fstatus = "G";
                            cr.fdate_cap = DateTime.Today;
                            cr.fuser_cap = Session["AccountID"].ToString();

                            }

                        }

                    }

                return View("Backpay", re);
                }

            }


        public ActionResult Backpay_MasterPeriodLoad(HardCopyViewModel re)
            {

            re.fmastercontributiontext = GetTotalContribution(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodnoofworkers = GetTotalNoOfWorkers(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodtext = re.fmasterperiod;

            if (re.fcat == null || re.fcat == "")
                {
                ViewBag.Message = "You have not selected the Staff Category from the Summary Tab. Please do and try again.";
                }
            return View("Backpay", re);

            }



        #endregion

        #region VIEW SHORT PAYMENTS

        public ActionResult ViewShortPayments()
            {

            return View("ViewShortPayments", new ViewShortPaymentsViewModel());
            }

        public ActionResult ViewShortPayments_LoadERNo(ViewShortPaymentsViewModel cs)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == cs.ferno).ToList();

            if (emp.Count > 0)
                {
                TempData["MyEmployerCategories"] = GetMyEmployerCategories(cs.ferno);

                cs.femp_name = emp[0].femp_name;

                return View("ViewShortPayments", cs);
                }
            else
                {
                return View("ViewShortPayments", cs);
                }

            }


        public ActionResult ViewShortPayments_OK(ViewShortPaymentsViewModel cs)
            {
            List<empcr_tr> emp = new List<empcr_tr>();
            emp = db.empcr_tr.Where(b => b.ferno == cs.ferno).ToList();

            if (emp.Count > 0)
                {

                List<memcr_tr> mem = new List<memcr_tr>();
                mem = db.memcr_tr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.ftype_cr == cs.ftype).Where(b => b.fperiod == cs.fperiod).ToList();

                if (mem.Count > 0)
                    {

                    TempData["TOBEPOSTED"] = mem;

                    }
                else
                    {
                    TempData["TOBEPOSTED"] = null;

                    List<mem_stmt> memst = new List<Models.mem_stmt>();

                    char[] thechars = cs.fperiod.ToCharArray();
                    string theyear = thechars[0].ToString() + thechars[1].ToString() + thechars[2].ToString() + thechars[3].ToString();

                    memst = db.mem_stmt.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.ftype == cs.ftype).Where(b => b.fyear == theyear).ToList();

                    if (memst.Count > 0)
                        {
                        List<memcr_tr> temporary = new List<memcr_tr>();

                        foreach (mem_stmt item in memst)
                            {
                            memcr_tr m = new memcr_tr();

                            List<mem_tr> mg = new List<mem_tr>();
                            mg = db.mem_tr.Where(b => b.fssno == item.fssno).ToList();

                            if (mg.Count > 0)
                                {

                                m.firstname = mg[0].firstname;
                                m.fsurname = mg[0].fsurname;
                                m.fothername = mg[0].fothname;

                                }

                            m.ftype_cr = item.ftype;
                            m.fperiod = cs.fperiod;

                            char[] thechars2 = cs.fperiod.ToString().ToCharArray();
                            string themonth = thechars2[4].ToString() + thechars2[5].ToString();

                            switch (themonth)
                                {
                                case "01":
                                    m.fcontr = item.fjancr.Value;

                                    break;
                                case "02":
                                    m.fcontr = item.ffebcr.Value;

                                    break;
                                case "03":
                                    m.fcontr = item.fmarcr.Value;

                                    break;
                                case "04":
                                    m.fcontr = item.faprcr.Value;

                                    break;
                                case "05":
                                    m.fcontr = item.fmaycr.Value;

                                    break;
                                case "06":
                                    m.fcontr = item.fjuncr.Value;

                                    break;
                                case "07":
                                    m.fcontr = item.fjulcr.Value;

                                    break;
                                case "08":
                                    m.fcontr = item.faugcr.Value;

                                    break;
                                case "09":
                                    m.fcontr = item.fsepcr.Value;

                                    break;
                                case "10":
                                    m.fcontr = item.foctcr.Value;

                                    break;
                                case "11":
                                    m.fcontr = item.fnovcr.Value;

                                    break;
                                case "12":
                                    m.fcontr = item.fdeccr.Value;

                                    break;

                                }

                            temporary.Add(m);

                            }

                        TempData["POSTED"] = temporary;

                        }

                    }

                List<inval_cr> invs = new List<inval_cr>();
                invs = db.inval_cr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.ftype_cr == cs.ftype).Where(b => b.fperiod == cs.fperiod).ToList();

                if (invs.Count > 0)
                    {
                    TempData["INVALID"] = invs;
                    }
                else
                    {
                    TempData["INVALID"] = null;
                    }

                return View("ViewShortPayments", cs);
                }
            else
                {
                ViewBag.Message = cs.ftype + " for given period has not been Captured for the Employer Category";

                return View("ViewShortPayments", cs);
                }

            }

        #endregion

        #region CAPTURE SHORT PAYMENTS

        public ActionResult CaptureShortPayments()
            {
            return View("CaptureShortPayments", new CaptureShortPaymentsViewModel());
            }

        public ActionResult CaptureShortPayments_LoadERNo(CaptureShortPaymentsViewModel cs)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == cs.ferno).ToList();

            if (emp.Count > 0)
                {
                TempData["MyEmployerCategories"] = GetMyEmployerCategories(cs.ferno);

                //TempData["MyMasterPeriods"] = GetMyMasterPeriods(cs.ferno, cs.fcat);

                cs.femp_name = emp[0].femp_name;

                return View("CaptureShortPayments", cs);
                }
            else
                {
                return View("CaptureShortPayments", cs);
                }

            }


        public ActionResult CaptureShortPayments_LoadSSNo(CaptureShortPaymentsViewModel cs)
            {
            List<mem_tr> mem = new List<mem_tr>();
            mem = db.mem_tr.Where(b => b.ferno == cs.ferno).ToList();

            if (mem.Count > 0)
                {

                cs.ffirstname = mem[0].firstname;
                cs.fsurname = mem[0].fsurname;
                cs.fothername = mem[0].fothname;
                cs.ffoundstatus = true;

                return View("CaptureShortPayments", cs);
                }
            else
                {
                cs.ffirstname = "";
                cs.fsurname = "";
                cs.fothername = "";

                cs.ffoundstatus = true;

                return View("CaptureShortPayments", cs);
                }

            }


        public ActionResult CaptureShortPayments_OK(CaptureShortPaymentsViewModel cs)
            {
            int? dcount = db.empcr_tr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).Count();

            if (dcount.HasValue)
                {
                cs.ffoundstatus = true;
                }
            else
                {
                cs.ffoundstatus = false;
                }

            return View("CaptureShortPayments", cs);

            }


        public ActionResult CaptureShortPayments_Fetch(CaptureShortPaymentsViewModel cs)
            {

            cs.ffoundstatus = true;

            bool isfound = false;

            List<memcr_tr> mcs = new List<memcr_tr>();
            mcs = db.memcr_tr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).Where(b => b.fssno == cs.fssno)
                .Where(b => b.firstname == cs.ffirstname).Where(b => b.fothername == cs.fothername).Where(b => b.fsurname == cs.fsurname).ToList();

            if (mcs.Count > 0)
                {
                memcr_tr mc = new memcr_tr();
                mc = mcs[0];

                cs.fcronfile = mc.fcontr;
                cs.fstatus = "READY FOR POSTING";

                }
            else
                {
                List<memcr_h> mcth = new List<memcr_h>();
                mcth = db.memcr_h.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod)
                        .Where(b => b.ftype_cr == cs.ftype).Where(b => b.fssno == cs.fssno).ToList();

                if (mcth.Count > 0)
                    {
                    memcr_h mc = new memcr_h();
                    mc = mcth[0];

                    cs.fcronfile = mc.fcontr.Value;
                    cs.fstatus = "VALID POSTED BUT NOT TRANSFERED";
                    isfound = true;
                    }
                else
                    {

                    List<mem_stmt> dmemst = new List<mem_stmt>();
                    dmemst = db.mem_stmt.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat)
                        .Where(b => b.ftype == cs.ftype).Where(b => b.fssno == cs.fssno).ToList();

                    if (dmemst.Count > 0)
                        {
                        mem_stmt sm = new mem_stmt();
                        sm = dmemst[0];

                        char[] thechars = cs.fperiod.ToString().ToCharArray();
                        string themonth = thechars[4].ToString() + thechars[5].ToString();

                        switch (themonth)
                            {
                            case "01":
                                cs.fcronfile = sm.fjancr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "02":
                                cs.fcronfile = sm.ffebcr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "03":
                                cs.fcronfile = sm.fmarcr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "04":
                                cs.fcronfile = sm.faprcr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "05":
                                cs.fcronfile = sm.fmaycr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "06":
                                cs.fcronfile = sm.fjuncr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "07":
                                cs.fcronfile = sm.fjulcr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "08":
                                cs.fcronfile = sm.faugcr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "09":
                                cs.fcronfile = sm.fsepcr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "10":
                                cs.fcronfile = sm.foctcr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "11":
                                cs.fcronfile = sm.fnovcr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;
                            case "12":
                                cs.fcronfile = sm.fdeccr;
                                cs.fstatus = "TRANSFERRED TO H/O";
                                break;

                            }

                        isfound = true;

                        }

                    if (cs.fcronfile == 0)
                        {
                        cs.fstatus = "NOT CAPTURED";
                        }
                    }

                List<inval_cr> memst = new List<inval_cr>();
                memst = db.inval_cr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).Where(b => b.fssno == cs.fssno)
            .Where(b => b.firstname == cs.ffirstname).Where(b => b.fothername == cs.fothername).Where(b => b.fsurname == cs.fsurname).ToList();

                if (memst.Count > 0)
                    {
                    cs.fcronfile = memst[0].famount;
                    cs.fstatus = "POSTED INVALID";
                    isfound = true;
                    }

                if (isfound == false)
                    {
                    cs.fcronfile = 0;
                    cs.fstatus = "NOT CAPTURED";
                    }
                }

            return View("CaptureShortPayments", cs);

            }

        public ActionResult CaptureShortPayments_Process(CaptureShortPaymentsViewModel cs)
            {
            switch (cs.fstatus)
                {
                case "READY FOR POSTING":

                    List<memcr_tr> mcs = new List<memcr_tr>();
                    mcs = db.memcr_tr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).Where(b => b.fssno == cs.fssno)
                        .Where(b => b.firstname == cs.ffirstname).Where(b => b.fothername == cs.fothername).Where(b => b.fsurname == cs.fsurname).ToList();

                    if (mcs.Count > 0)
                        {
                        memcr_tr mc = new memcr_tr();
                        mc = mcs[0];

                        mc.fcontr += cs.fdifference.Value;

                        db.memcr_tr.Attach(mc);
                        var entry = db.Entry(mc);

                        if (mc.fcontr == 0)
                            {
                            entry.State = System.Data.Entity.EntityState.Deleted;
                            }
                        else
                            {
                            entry.State = System.Data.Entity.EntityState.Modified;
                            }

                        db.SaveChanges();

                        }



                    List<empcr_tr> emc = new List<empcr_tr>();
                    emc = db.empcr_tr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).ToList();

                    if (emc.Count > 0)
                        {
                        empcr_tr mc = new empcr_tr();
                        mc = emc[0];

                        mc.ftot_cont += cs.fdifference;
                        mc.fno_wkr -= 1;

                        if (mc.fno_wkr < 0)
                            {
                            mc.fno_wkr = 0;
                            }

                        db.empcr_tr.Attach(mc);
                        var entry = db.Entry(mc);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }

                    break;

                case "VALID POSTED BUT NOT TRANSFERRED":

                    List<memcr_h> mcsh = new List<memcr_h>();
                    mcsh = db.memcr_h.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).Where(b => b.fssno == cs.fssno)
                        .Where(b => b.firstname == cs.ffirstname).Where(b => b.fothername == cs.fothername).Where(b => b.fsurname == cs.fsurname).ToList();

                    if (mcsh.Count > 0)
                        {
                        memcr_h mc = new memcr_h();
                        mc = mcsh[0];

                        mc.fcontr += cs.fdifference;

                        db.memcr_h.Attach(mc);
                        var entry = db.Entry(mc);

                        if (mc.fcontr == 0)
                            {
                            entry.State = System.Data.Entity.EntityState.Deleted;
                            }
                        else
                            {
                            entry.State = System.Data.Entity.EntityState.Modified;
                            }

                        db.SaveChanges();

                        }


                    List<empcr_tr> ects = new List<empcr_tr>();
                    ects = db.empcr_tr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).ToList();

                    if (ects.Count > 0)
                        {
                        empcr_tr ec = new empcr_tr();
                        ec = ects[0];

                        ec.ftot_cont += cs.fdifference;
                        ec.fno_wkr -= 1;

                        if (ec.fno_wkr < 0)
                            {
                            ec.fno_wkr = 0;
                            }

                        db.empcr_tr.Attach(ec);
                        var entry = db.Entry(ec);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }


                    List<mem_stmt> dmemst = new List<mem_stmt>();
                    dmemst = db.mem_stmt.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat)
                        .Where(b => b.ftype == cs.ftype).Where(b => b.fssno == cs.fssno).ToList();

                    if (dmemst.Count > 0)
                        {
                        mem_stmt sm = new mem_stmt();
                        sm = dmemst[0];

                        char[] thechars = cs.fperiod.ToString().ToCharArray();
                        string themonth = thechars[4].ToString() + thechars[5].ToString();

                        switch (themonth)
                            {
                            case "01":
                                sm.fjancr += cs.fdifference;
                                break;
                            case "02":
                                sm.ffebcr += cs.fdifference; ;
                                break;
                            case "03":
                                sm.fmarcr += cs.fdifference;
                                break;
                            case "04":
                                sm.faprcr += cs.fdifference;
                                break;
                            case "05":
                                sm.fmaycr += cs.fdifference;
                                break;
                            case "06":
                                sm.fjuncr += cs.fdifference;
                                break;
                            case "07":
                                sm.fjulcr += cs.fdifference;
                                break;
                            case "08":
                                sm.faugcr += cs.fdifference;
                                break;
                            case "09":
                                sm.fsepcr += cs.fdifference;
                                break;
                            case "10":
                                sm.foctcr += cs.fdifference;
                                break;
                            case "11":
                                sm.fnovcr += cs.fdifference;
                                break;
                            case "12":
                                sm.fdeccr += cs.fdifference;
                                break;

                            }

                        sm.fuser_code = Session["AccountID"].ToString();

                        }


                    break;
                case "POSTED INVALID":

                    List<inval_cr> invcr = new List<inval_cr>();
                    invcr = db.inval_cr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).Where(b => b.fssno == cs.fssno)
                        .Where(b => b.firstname == cs.ffirstname).Where(b => b.fothername == cs.fothername).Where(b => b.fsurname == cs.fsurname).ToList();

                    if (invcr.Count > 0)
                        {
                        inval_cr ec = new inval_cr();
                        ec = invcr[0];

                        ec.famount += cs.fdifference;

                        db.inval_cr.Attach(ec);
                        var entry = db.Entry(ec);

                        if (ec.famount == 0)
                            {
                            entry.State = System.Data.Entity.EntityState.Deleted;
                            }
                        else
                            {
                            entry.State = System.Data.Entity.EntityState.Modified;
                            }

                        db.SaveChanges();

                        }


                    List<empcr_tr> ects2 = new List<empcr_tr>();
                    ects2 = db.empcr_tr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).ToList();

                    if (ects2.Count > 0)
                        {
                        empcr_tr ec = new empcr_tr();
                        ec = ects2[0];

                        ec.ftot_cont += cs.fdifference;
                        ec.fno_wkr -= 1;

                        if (ec.fno_wkr < 0)
                            {
                            ec.fno_wkr = 0;
                            }

                        db.empcr_tr.Attach(ec);
                        var entry = db.Entry(ec);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }

                    break;
                case "TRANSFERRED TO H/O":

                    List<mem_stmt> dmemst2 = new List<mem_stmt>();
                    dmemst2 = db.mem_stmt.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat)
                        .Where(b => b.ftype == cs.ftype).Where(b => b.fssno == cs.fssno).ToList();

                    if (dmemst2.Count > 0)
                        {
                        mem_stmt sm = new mem_stmt();
                        sm = dmemst2[0];

                        char[] thechars = cs.fperiod.ToString().ToCharArray();
                        string themonth = thechars[4].ToString() + thechars[5].ToString();

                        switch (themonth)
                            {
                            case "01":
                                sm.fjancr += cs.fdifference;
                                break;
                            case "02":
                                sm.ffebcr += cs.fdifference; ;
                                break;
                            case "03":
                                sm.fmarcr += cs.fdifference;
                                break;
                            case "04":
                                sm.faprcr += cs.fdifference;
                                break;
                            case "05":
                                sm.fmaycr += cs.fdifference;
                                break;
                            case "06":
                                sm.fjuncr += cs.fdifference;
                                break;
                            case "07":
                                sm.fjulcr += cs.fdifference;
                                break;
                            case "08":
                                sm.faugcr += cs.fdifference;
                                break;
                            case "09":
                                sm.fsepcr += cs.fdifference;
                                break;
                            case "10":
                                sm.foctcr += cs.fdifference;
                                break;
                            case "11":
                                sm.fnovcr += cs.fdifference;
                                break;
                            case "12":
                                sm.fdeccr += cs.fdifference;
                                break;

                            }

                        sm.fuser_code = Session["AccountID"].ToString();

                        }


                    List<empcr_tr> ects3 = new List<empcr_tr>();
                    ects3 = db.empcr_tr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).ToList();

                    if (ects3.Count > 0)
                        {
                        empcr_tr ec = new empcr_tr();
                        ec = ects3[0];

                        ec.ftot_cont += cs.fdifference;
                        ec.fno_wkr -= 1;

                        if (ec.fno_wkr < 0)
                            {
                            ec.fno_wkr = 0;
                            }

                        db.empcr_tr.Attach(ec);
                        var entry = db.Entry(ec);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }

                    break;
                case "NOT CAPTURED":

                    memcr_tr mc2 = new memcr_tr();

                    mc2.fcat = cs.fcat;
                    mc2.ferno = cs.ferno;
                    mc2.fcontr = cs.fdifference.Value;
                    mc2.firstname = cs.ffirstname;
                    mc2.fothername = cs.fothername;
                    mc2.fsurname = cs.fsurname;
                    mc2.fperiod = cs.fperiod;
                    mc2.fssno = cs.fssno;
                    mc2.fmedia = "P";
                    mc2.ftype_cr = cs.ftype;
                    mc2.fpcentre = Session["Branch"].ToString();

                    db.memcr_tr.Add(mc2);
                    db.SaveChanges();


                    List<empcr_tr> ects4 = new List<empcr_tr>();
                    ects4 = db.empcr_tr.Where(b => b.ferno == cs.ferno).Where(b => b.fcat == cs.fcat).Where(b => b.fperiod == cs.fperiod).Where(b => b.ftype_cr == cs.ftype).ToList();

                    if (ects4.Count > 0)
                        {
                        empcr_tr ec = new empcr_tr();
                        ec = ects4[0];

                        ec.ftot_cont += cs.fdifference;
                        ec.fno_wkr += 1;

                        if (ec.fno_wkr < 0)
                            {
                            ec.fno_wkr = 0;
                            }

                        db.empcr_tr.Attach(ec);
                        var entry = db.Entry(ec);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }

                    break;

                default:
                    break;
                }

            return View("CaptureShortPayments", new CaptureShortPaymentsViewModel());

            }
        #endregion
         
        #region PROCESS CONTIRBUTION

        private decimal GetCROnFile(string ferno, string fperiod, string ftype)
            {
            List<empcr_tr> dmemst = new List<empcr_tr>();
            dmemst = db.empcr_tr.Where(b => b.ferno == ferno)
                .Where(b => b.ftype_cr == ftype).Where(b => b.fperiod == fperiod).ToList();

            if (dmemst.Count > 0)
                {

                return dmemst[0].ftot_cont.Value;

                }
            else
                {
                return 0;
                }

            }


        private decimal GetAmountPaid(string ferno, string fperiod, string ftype)
            {

            decimal? total = db.memcr_tr.Where(b => b.ferno == ferno)
               .Where(b => b.ftype_cr == ftype).Where(b => b.fperiod == fperiod).Sum(b => b.fcontr);

            if (total != null)
                {

                return total.Value;

                }
            else
                {
                return 0;
                }
            }

        private DataTable GetRecordsToProcess()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT ferno, fperiod, sum(fcontr) as fcontr, ftype From memcr_tr Group by ferno, fperiod, ftype, fcontr";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            return mytable;
            }

        public ActionResult MemberCreditProcessing()
            {

            DataTable mcr = GetRecordsToProcess();

            List<MCreditProListViewModel> mlist = new List<MCreditProListViewModel>();

            if (mcr.Rows.Count > 0)
                {
                foreach (DataRow item in mcr.Rows)
                    {
                    //ferno, fperiod, sum(fcontr) as fcontr, ftype

                    MCreditProListViewModel ml = new MCreditProListViewModel();

                    ml.ID = mlist.Count + 1;
                    ml.Contribution = item.Field<Decimal>("fcontr");
                    ml.Establishment = GetEmployerName(item.Field<String>("ferno"));
                    ml.ERNO = item.Field<String>("ferno");
                    ml.Period = item.Field<String>("fperiod");
                    ml.Type = item.Field<String>("ftype");

                    ml.AmountPaid = GetAmountPaid(ml.Establishment, ml.Period, ml.Type);
                    ml.ContributionOnFile = GetCROnFile(ml.Establishment, ml.Period, ml.Type);

                    mlist.Add(ml);

                    }


                TempData["MemberCreditList"] = mlist;
                }


            MemberCreditProcessingViewMode mc = new MemberCreditProcessingViewMode();
            mc.TotalRecords = mlist.Count;

            return View("MemberCreditProcessing", mc);
            }


        public ActionResult MemberCreditProcessing_Start(MemberCreditProcessingViewMode pc)
            {

            List<memcr_tr> mct = new List<memcr_tr>();

            mct = db.memcr_tr.ToList();

            foreach (memcr_tr item in mct)
                {
                string themonth = item.fperiod.Substring(4, 2);
                string theyear = item.fperiod.Substring(0, 4);

                if (!CheckifSSNoisValid(item.fssno))
                    {
                    inval_cr inv = new inval_cr();

                    inv.famount = item.fcontr;
                    inv.fcat = item.fcat;
                    inv.ferno = item.ferno;
                    inv.firstname = item.firstname;
                    inv.fothername = item.fothername;
                    inv.fsurname = item.fsurname;
                    inv.fpcentre = item.fpcentre;
                    inv.fperiod = item.fperiod;
                    inv.fssno = item.fssno;
                    inv.fstaffno = item.fstaffno;
                    inv.ftype_cr = item.ftype_cr;

                    //THERE IS A VALIDATION ERROR IN THE MODEL

                    db.inval_cr.Add(inv);
                    db.SaveChanges();

                    }
                else
                    {

                    List<mem_stmt> mst = new List<mem_stmt>();

                    mst = db.mem_stmt.Where(b => b.fssno == item.fssno).Where(b => b.fcat == item.fcat).Where(b => b.ftype == item.ftype_cr).Where(b => b.fyear == theyear).ToList();

                    if (mst.Count > 0)
                        {
                        mem_stmt m = new Models.mem_stmt();
                        m = mst[0];


                        switch (themonth)
                            {
                            case "01":
                                m.fjancr = item.fcontr;

                                break;
                            case "02":
                                m.ffebcr = item.fcontr;

                                break;
                            case "03":
                                m.fmarcr = item.fcontr;

                                break;
                            case "04":
                                m.faprcr = item.fcontr;

                                break;
                            case "05":
                                m.fmaycr = item.fcontr;

                                break;
                            case "06":
                                m.fjuncr = item.fcontr;

                                break;
                            case "07":
                                m.fjulcr = item.fcontr;

                                break;
                            case "08":
                                m.faugcr = item.fcontr;

                                break;
                            case "09":
                                m.fsepcr = item.fcontr;

                                break;
                            case "10":
                                m.foctcr = item.fcontr;

                                break;
                            case "11":
                                m.fnovcr = item.fcontr;

                                break;
                            case "12":
                                m.fdeccr = item.fcontr;

                                break;

                            }

                        m.ModifiedBy = Session["AccountID"].ToString();
                        m.ModifiedOn = DateTime.Today;

                        db.mem_stmt.Attach(m);

                        var entry = db.Entry(m);
                        entry.State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();

                        }
                    else
                        {

                        mem_stmt m = new Models.mem_stmt();

                        switch (themonth)
                            {
                            case "01":
                                m.fjancr = item.fcontr;

                                break;
                            case "02":
                                m.ffebcr = item.fcontr;

                                break;
                            case "03":
                                m.fmarcr = item.fcontr;

                                break;
                            case "04":
                                m.faprcr = item.fcontr;

                                break;
                            case "05":
                                m.fmaycr = item.fcontr;

                                break;
                            case "06":
                                m.fjuncr = item.fcontr;

                                break;
                            case "07":
                                m.fjulcr = item.fcontr;

                                break;
                            case "08":
                                m.faugcr = item.fcontr;

                                break;
                            case "09":
                                m.fsepcr = item.fcontr;

                                break;
                            case "10":
                                m.foctcr = item.fcontr;

                                break;
                            case "11":
                                m.fnovcr = item.fcontr;

                                break;
                            case "12":
                                m.fdeccr = item.fcontr;

                                break;

                            }

                        m.CreatedBy = Session["AccountID"].ToString();
                        m.CreatedOn = DateTime.Today;

                        db.mem_stmt.Add(m);
                        db.SaveChanges();



                        }



                    }

                //UPDATE THE MINMAX
                int NoofWorkers = GetTotalNoofWorkersforMinMax(item.ferno, themonth, theyear);
                decimal TotalContribution = GetTotalContributionforMinMax(item.ferno, themonth, theyear);

                decimal? Average = null;

                if (NoofWorkers > 0)
                    {
                    Average = TotalContribution / NoofWorkers;
                    }

                decimal? theminimum = GetMinmumValueforEstablishment(item.ferno, theyear, themonth);
                decimal? themaximum = GetMaximumValueforEstablishment(item.ferno, theyear, themonth);

                if (theminimum == null)
                    {

                    minmax_est mm = new minmax_est();
                    mm.Createdby = Session["AccountID"].ToString();
                    mm.CreatedOn = DateTime.Today;
                    mm.favgcont = Average;
                    mm.ferno = item.ferno;
                    mm.fmonth = themonth;
                    mm.fno_wkr = NoofWorkers;

                    mm.ftype = "MIN";
                    mm.fyear = theyear;

                    db.minmax_est.Add(mm);
                    db.SaveChanges();

                    }
                else
                    {
                    string thetype = "MIN";

                    List<minmax_est> minm = new List<minmax_est>();
                    minm = db.minmax_est.Where(b => b.ferno == item.ferno).Where(b => b.fyear == theyear).Where(b => b.fmonth == themonth).Where(b => b.ftype == thetype).ToList();

                    if (minm.Count > 0)
                        {
                        minmax_est mm = new minmax_est();
                        mm = minm[0];

                        mm.Modifiedby = Session["AccountID"].ToString();
                        mm.ModifiedOn = DateTime.Today;
                        mm.favgcont = Average;
                        mm.ferno = item.ferno;
                        mm.fmonth = themonth;
                        mm.fno_wkr = NoofWorkers;

                        mm.ftype = thetype;
                        mm.fyear = theyear;

                        db.minmax_est.Attach(mm);
                        var entry = db.Entry(mm);
                        entry.State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();

                        }

                    }


                if (themaximum == null)
                    {

                    minmax_est mm = new minmax_est();
                    mm.Createdby = Session["AccountID"].ToString();
                    mm.CreatedOn = DateTime.Today;
                    mm.favgcont = Average;
                    mm.ferno = item.ferno;
                    mm.fmonth = themonth;
                    mm.fno_wkr = NoofWorkers;

                    mm.ftype = "MAX";
                    mm.fyear = theyear;

                    db.minmax_est.Add(mm);
                    db.SaveChanges();

                    }
                else
                    {

                    string thetype = "MAX";

                    List<minmax_est> maxm = new List<minmax_est>();
                    maxm = db.minmax_est.Where(b => b.ferno == item.ferno).Where(b => b.fyear == theyear).Where(b => b.fmonth == themonth).Where(b => b.ftype == thetype).ToList();

                    if (maxm.Count > 0)
                        {
                        minmax_est mm = new minmax_est();
                        mm = maxm[0];

                        mm.Modifiedby = Session["AccountID"].ToString();
                        mm.ModifiedOn = DateTime.Today;
                        mm.favgcont = Average;
                        mm.ferno = item.ferno;
                        mm.fmonth = themonth;
                        mm.fno_wkr = NoofWorkers;

                        mm.ftype = thetype;
                        mm.fyear = theyear;

                        db.minmax_est.Attach(mm);
                        var entry = db.Entry(mm);
                        entry.State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();

                        }

                    }


                }

            return RedirectToAction("MemberCreditProcessing");
            }


        private decimal? GetMinmumValueforEstablishment(string ferno, string theyear, string themonth)
            {

            string ftype = "MIN";

            decimal? total = db.minmax_est.Where(b => b.ferno == ferno)
               .Where(b => b.ftype == ftype).Where(b => b.fyear == theyear).Where(b => b.fmonth == themonth).Where(b => b.ftype == ftype).Sum(b => b.favgcont);

            if (total != null)
                {

                return total;

                }
            else
                {
                return null;
                }
            }


        private decimal? GetMaximumValueforEstablishment(string ferno, string theyear, string themonth)
            {

            string ftype = "MAX";

            decimal? total = db.minmax_est.Where(b => b.ferno == ferno)
               .Where(b => b.ftype == ftype).Where(b => b.fyear == theyear).Where(b => b.fmonth == themonth).Where(b => b.ftype == ftype).Sum(b => b.favgcont);

            if (total != null)
                {

                return total;

                }
            else
                {
                return null;
                }
            }

        private decimal GetTotalContributionforMinMax(string ferno, string fmonth, string fyear)
            {

            decimal? total;

            switch (fmonth)
                {
                case "01":

                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.fjancr);
                    if (total != null) { return total.Value; } else { return 0; }

                case "02":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.ffebcr);
                    if (total != null) { return total.Value; } else { return 0; }
                case "03":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.fmarcr);
                    if (total != null) { return total.Value; } else { return 0; }
                case "04":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.faprcr);
                    if (total != null) { return total.Value; } else { return 0; }
                case "05":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.fmaycr);
                    if (total != null) { return total.Value; } else { return 0; }
                case "06":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.fjuncr);
                    if (total != null) { return total.Value; } else { return 0; }
                case "07":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.fjulcr);
                    if (total != null) { return total.Value; } else { return 0; }
                case "08":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.faugcr);
                    if (total != null) { return total.Value; } else { return 0; }
                case "09":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.fsepcr);
                    if (total != null) { return total.Value; } else { return 0; }
                case "10":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.foctcr);
                    if (total != null) { return total.Value; } else { return 0; }
                case "11":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.fnovcr);
                    if (total != null) { return total.Value; } else { return 0; }
                case "12":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Sum(b => b.fdeccr);
                    if (total != null) { return total.Value; } else { return 0; }

                default:
                    return 0;

                }

            }


        private int GetTotalNoofWorkersforMinMax(string ferno, string fmonth, string fyear)
            {

            int? total;

            switch (fmonth)
                {
                case "01":

                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.fjancr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }

                case "02":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.ffebcr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }
                case "03":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.fmarcr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }
                case "04":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.faprcr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }
                case "05":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.fmaycr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }
                case "06":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.fjuncr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }
                case "07":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.fjulcr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }
                case "08":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.faugcr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }
                case "09":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.fsepcr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }
                case "10":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.foctcr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }
                case "11":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.fnovcr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }
                case "12":
                    total = db.mem_stmt.Where(b => b.ferno == ferno).Where(b => b.fyear == fyear).Where(b => b.fdeccr > 0).Count();
                    if (total != null) { return total.Value; } else { return 0; }

                default:
                    return 0;

                }

            }

        public ActionResult AcceptMemberCredit(int id)
            {

            List<MCreditProListViewModel> mlist = (List<MCreditProListViewModel>)TempData.Peek("MemberCreditList");

            MCreditProListViewModel m = new MCreditProListViewModel();
            m = mlist[id - 1];

            List<MCreditProListViewModel> newmlist = new List<MCreditProListViewModel>();

            foreach (MCreditProListViewModel item in mlist)
                {

                item.ID = newmlist.Count + 1;
                newmlist.Add(item);

                }

            TempData["MemberCreditList"] = newmlist;

            return View("MemberCreditProcessing", new MemberCreditProcessingViewMode());
            }


        #endregion

        }
    }
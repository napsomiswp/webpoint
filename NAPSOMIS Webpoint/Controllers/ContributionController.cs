using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.Models;
using NAPSOMIS_Webpoint.ViewModels;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using System.Xml;
using System.Data.SqlClient;

namespace NAPSOMIS_Webpoint.Controllers
    {

    [AuthorizeFilter]
    public class ContributionController : Controller
        {

        NAPSOMISModel db = new NAPSOMISModel();

        #region Receive at Data Control
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
            string Query = "SELECT fcat, fdesc From staf_cat WHERE ferno = '" + ERNO + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<Province> provinces = db.Provinces.SqlQuery("SELECT ID_SBTS, fcode, fdesc From Province").ToList(); 

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("fcat");
                    ct.Name = myp.Field<String>("fdesc");

                    mylist.Add(ct);

                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }



        public List<SoftCopyCRListViewModel> GetMySoftCopyCRSRegPeriod(string ERNO)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fperiod, ftype, fcat From crsreg WHERE ferno = '" + ERNO + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<Province> provinces = db.Provinces.SqlQuery("SELECT ID_SBTS, fcode, fdesc From Province").ToList(); 

            List<SoftCopyCRListViewModel> mylist = new List<SoftCopyCRListViewModel>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    SoftCopyCRListViewModel ct = new SoftCopyCRListViewModel();
                    ct.Period = myp.Field<String>("fperiod");
                    ct.Type = myp.Field<String>("ftype").ToString();
                    ct.Category = myp.Field<String>("fcat");

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
            string Query = "SELECT fperiod, ftype, fcat From crsreg WHERE ferno = '" + ERNO + "' and fmode = 'C'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<Province> provinces = db.Provinces.SqlQuery("SELECT ID_SBTS, fcode, fdesc From Province").ToList(); 

            List<ContrPeriodTemplate> mylist = new List<ContrPeriodTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    ContrPeriodTemplate ct = new ContrPeriodTemplate();
                    ct.Period = myp.Field<String>("fperiod");
                    ct.Type = myp.Field<String>("ftype");
                    ct.Media = myp.Field<String>("fcat");

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
            try
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
            catch (Exception)
                {
                ViewBag.Message = "ERROR PROCESSING THE REQUEST, PLEASE VERIFY THE PERIOD";
                return View("ReceiveCRDataControl", creg);
                }

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
                //decimal? totalbreakdown = creg.ftot_cr; //  /noofperiods;

                foreach (var pr in plist)
                    {

                    if (!ValidateContributionCapture(creg.ferno, creg.fcat, creg.ftype, pr.Period))
                        {
                        crsreg c = new crsreg();
                        //c.fbaktype = dc.fbaktype;
                        c.fbaktype = 0;
                        c.fcat = creg.fcat;
                        c.fdateupd = creg.fdateupd;
                        c.fdate_rec = creg.fdate_rec.Value;
                        c.feperiod = pr.Period;
                        c.ferno = creg.ferno;
                        c.fmedia = creg.fmedia;
                        c.fmode = creg.fmode;
                        c.fnowkr = pr.NoOfWorkers;
                        c.fperiod = pr.Period;
                        c.fschme = "";
                        c.fstatus = "N";
                        c.ftot_cr = pr.TotalContribution;
                        c.ftype = creg.ftype;
                        c.fwkr_rec = 0;
                        c.fremark = "";
                        c.fdata_user = "";

                        //c.fperiodrange = creg.fperiod + "-" + creg.feperiod;

                        c.ModifiedBy = Session["AccountID"].ToString();
                        c.ModifiedOn = DateTime.Today;

                        c.CreatedBy = Session["AccountID"].ToString();
                        c.CreatedOn = DateTime.Today;

                        db.crsregs.Add(c);
                        db.SaveChanges();

                        ViewBag.Message = "CONTRIBUTION REPORT SUCCESSFULLY RECEIVED AT DATA CONTROL";
                        }

                    }

                }

            TempData["Periods"] = null;

            CRSRegViewModel cd = new CRSRegViewModel();
            return View("ReceiveCRDataControl", cd);
            }

        #endregion

        #region Receive at Data Capturing
        //DATA CONTROL
        public ActionResult ReceiveCRDataCapturing()
            {
            emp_mst emp = new emp_mst();

            return View("ReceiveCRDataCapturing", emp);
            }


        public ActionResult ReceiveCRDataCapturing_Search(emp_mst emp)
            {

            TempData["DCErno"] = emp.ferno;

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

                creg.ModifiedBy = Session["AccountID"].ToString();
                creg.ModifiedOn = DateTime.Today;

                db.crsregs.Attach(creg);
                var entry = db.Entry(creg);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


                /******************************************/

                c_crsdata cd = new c_crsdata();
                cd.ferno = crs[0].ferno;
                cd.fcat = crs[0].fcat;
                cd.fdate_data = DateTime.Today;
                cd.fperiod = crs[0].fperiod;
                cd.ftype = crs[0].ftype;
                cd.fmode = crs[0].fmode;
                cd.fmedia = crs[0].fmedia;
                cd.fdate_rec = DateTime.Today;
                cd.fnowkr = crs[0].fnowkr;
                cd.ftot_cr = crs[0].ftot_cr;
                cd.fwkr_rec = 0;
                cd.fremark = "";
                cd.fstatus = "";
                cd.fdate_cap = DateTime.Today;
                cd.fdata_user = crs[0].fdata_user;
                cd.fuser_cap = crs[0].fuser_cap;

                cd.femp_name = GetEmployerName(crs[0].ferno);

                cd.CreatedBy = Session["AccountID"].ToString();
                cd.CreatedOn = DateTime.Today;

                cd.ModifiedBy = Session["AccountID"].ToString();
                cd.ModifiedOn = DateTime.Today;

                db.c_crsdata.Add(cd);
                db.SaveChanges();

                emp_mst emp = new emp_mst();
                emp.ferno = crs[0].ferno;


                ViewBag.Message = "CONTRIBUTION REPORT SUCCESSFULLY RECEIVED AT DATA CONTROL";


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
            else
                {

                ViewBag.Message = "Error Processing the request. Please try again.";

                string ERNo = "";

                if (TempData.Peek("DCErno") != null)
                    {
                    ERNo = TempData.Peek("DCErno").ToString();
                    }

                List<emp_mst> employ = new List<emp_mst>();
                employ = db.emp_mst.Where(p => p.ferno == ERNo).ToList();

                if (employ.Count > 0)
                    {
                    return View("ReceiveCRDataCapturing", employ[0]);
                    }
                else
                    {

                    emp_mst newe = new emp_mst();
                    newe.ferno = ERNo;

                    return View("ReceiveCRDataCapturing", newe);
                    }

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

            string theyear = EndPeriod.Substring(0, 4);
            string fullchars = EndPeriod.Substring(4, 2);
            int laststop = int.Parse(fullchars);


            char[] currentp = StartPeriod.ToCharArray();
            int currentfull = int.Parse(StartPeriod.Substring(4, 2));

            int noofperiods = laststop - currentfull + 1;
            decimal totalbreakdown = creg.ftot_cr.Value / noofperiods;


            while (currentfull <= laststop)
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

                    //c.fbaktype = dc.fbaktype;
                    c.fbaktype = 0;

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

                    c.ModifiedBy = Session["AccountID"].ToString();
                    c.ModifiedOn = DateTime.Today;

                    //c.fperiodrange = creg.fperiod + "-" + creg.feperiod;

                    db.crsregs.Attach(c);
                    var entry = db.Entry(c);
                    entry.State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();

                    }
                else
                    {
                    crsreg c = new crsreg();

                    //c.fbaktype = dc.fbaktype;
                    c.fbaktype = 0;

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

                    c.ModifiedBy = Session["AccountID"].ToString();
                    c.ModifiedOn = DateTime.Today;

                    c.CreatedBy = Session["AccountID"].ToString();
                    c.CreatedOn = DateTime.Today;

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

                //c.fbaktype = dc.fbaktype;
                c.fbaktype = "";
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

        private List<String> GetAllEmployerNames(string fssno)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT Distinct(ferno) AS ferno From mem_stmt WHERE fssno = @fssno";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);

            dp.SelectCommand.Parameters.AddWithValue("@fssno", fssno);

            dp.Fill(mytable);

            List<String> mylist = new List<string>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow item in mytable.Rows)
                    {
                    mylist.Add(GetEmployerName(item.Field<String>("ferno")));
                    }

                }

            return mylist;

            }


        public ActionResult HardCopy_SummaryAccept(HardCopyViewModel re)
            {

            //CHECK HISTORY TRANSACTION AND SEE IT THE RECORD IS THERE WITH RESPECT
            //TO THE ferno and fcat
            //
            //IF NOT FOUND 
            //CHECK THE HISTORY MASTER
            //IF FOUND THEN
            //DO NOTHING SINCE THE CODE THAT WAS THERE WAS DESIGNED TO RETURN THE LAST ID

            //END IF

            //SELECT HISTORY TEMP
            //CHECK IF THE RECORD IS THERE ALSO
            //IF FOUND UPDATE THE TOTALWRK AND THE TOTALCR WITH THE NEW VALUES

            //ELSE IF NOT FOUND IN HISTORY TEMP
            //SELECT cr_ctrl
            //CHECK IF THE RECORD IS THERE
            //IF FOUND THEN
            //INSERT A NEW HISTORY TEMP RECORD WITH THE ferno, fcat, fwkrs = cr_ctrl.ftotwkr, fcont = cr_ctrl.ftotcr, 
            //ftotwkr, ftotcr

            //ELSE IF NOT FOUND
            //INSERT NEW RECORD IN HISTORY TEMP WITH ferno, fcat, fwkrs = 0, fcont = 0, 
            //ftotwkr, ftotcr

            //END IF


            List<hist_tr> htr = new List<hist_tr>();
            htr = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (htr.Count == 0)
                {

                }


            List<hist_tmp> htm = new List<hist_tmp>();
            htm = db.hist_tmp.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (htm.Count > 0)
                {
                hist_tmp ht = new hist_tmp();
                ht = htm[0];

                ht.ftotcr = re.ftotalsalaryorcontribution;
                ht.ftotwkr = re.fnoofworkers;

                db.hist_tmp.Attach(ht);
                var entry = db.Entry(ht);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                }
            else
                {
                List<cr_ctrl> crs = new List<cr_ctrl>();
                crs = db.cr_ctrl.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (crs.Count > 0)
                    {

                    hist_tmp htemp = new hist_tmp();
                    htemp.CreatedBy = Session["AccountID"].ToString();
                    htemp.CreatedOn = DateTime.Today;
                    htemp.fcat = re.fcat;
                    htemp.ferno = re.ferno;
                    htemp.fmode = re.fmodesubmission;
                    htemp.ftotcr = re.ftotalsalaryorcontribution;
                    htemp.ftotwkr = re.fnoofworkers;

                    htemp.fwkrs = crs[0].ftotwkr;
                    htemp.fcont = crs[0].ftotcr;

                    htemp.ModifiedBy = Session["AccountID"].ToString();
                    htemp.ModifiedOn = DateTime.Today;

                    db.hist_tmp.Add(htemp);
                    db.SaveChanges();

                    }
                else
                    {

                    hist_tmp htemp = new hist_tmp();
                    htemp.CreatedBy = Session["AccountID"].ToString();
                    htemp.CreatedOn = DateTime.Today;
                    htemp.fcat = re.fcat;
                    htemp.ferno = re.ferno;
                    htemp.fmode = re.fmodesubmission;
                    htemp.ftotcr = re.ftotalsalaryorcontribution;
                    htemp.ftotwkr = re.fnoofworkers;

                    htemp.fwkrs = 0;
                    htemp.fcont = 0;

                    htemp.ModifiedBy = Session["AccountID"].ToString();
                    htemp.ModifiedOn = DateTime.Today;

                    db.hist_tmp.Add(htemp);
                    db.SaveChanges();

                    }

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

            TempData["MyMasterPeriods"] = GetMyMasterPeriods(re.ferno, re.fcat);

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

            if (SSNo == null || SSNo == "")
                {
                return false;
                }

            List<mper_mst> mv = new List<mper_mst>();
            mv = db.mper_mst.Where(b => b.fssno == SSNo).ToList();

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
                re.TabIndex = 1;
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

            re.TabIndex = 1;
            return View("HardCopy", re);
            }


        private int GetTotalWorkersCaptured(string ERNo, string Cat)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT Count(ID_SBTS) AS Total From hist_tr WHERE ferno = '" + ERNo + "' AND fcat = '" + Cat + "'";
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

        private decimal GetTotalContributionCaptured(string ERNo, string Cat)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT Sum(fcur_cr) AS fcur_cr From hist_tr WHERE ferno = '" + ERNo + "' AND fcat = '" + Cat + "'";
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

                re.TabIndex = 2;
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

                re.TabIndex = 2;
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

                re.TabIndex = 2;
                return View("HardCopy", re);
                }
            else
                {

                re.TabIndex = 2;
                return View("HardCopy", re);
                }


            }


        public ActionResult HardCopy_EditAccept(HardCopyViewModel re)
            {

            if (ValidateStaffNo(re.ferno, re.fAddStaffNumber, re.fAddFirstContributionPeriod))
                {
                re.TabIndex = 2;
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

            re.TabIndex = 2;
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

                re.TabIndex = 2;
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

                re.TabIndex = 2;
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

                re.TabIndex = 3;
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

                re.TabIndex = 3;
                return View("HardCopy", re);
                }


            }



        public ActionResult HardCopy_LoadMemberDetails(HardCopyViewModel re)
            {
            List<mper_mst> mv = new List<mper_mst>();
            mv = db.mper_mst.Where(b => b.fssno == re.fAddSSNo).ToList();

            if (mv.Count > 0)
                {

                re.fAddFirstName = mv[0].firstname;
                re.fAddOtherName = mv[0].fothname;
                re.fAddSurname = mv[0].fsurname;

                re.TabIndex = 1;
                return View("HardCopy", re);
                }
            else
                {

                re.fAddFirstName = "";
                re.fAddOtherName = "";
                re.fAddSurname = "";

                ViewBag.Message = "This SSNo is not valid. Please verify and try again.";

                re.TabIndex = 1;
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

                re.TabIndex = 3;
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

                re.TabIndex = 3;
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

                re.TabIndex = 3;
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

                re.TabIndex = 3;
                return View("HardCopy", re);
                }


            }

        public ActionResult HardCopy_EditAllAccept(HardCopyViewModel re)
            {

            //if (ValidateStaffNo(re.ferno, re.fAddStaffNumber, re.fAddFirstContributionPeriod))
            //    {
            //    ViewBag.Message = "Staff Number is in use by another staff under the same Establishment.";
            //    return View("HardCopy", re);
            //    }

            List<hist_tr> htrans = new List<hist_tr>();
            htrans = db.hist_tr.Where(b => b.ID_SBTS == re.fEditAllID).ToList();

            if (htrans.Count > 0)
                {
                hist_tr ht = new hist_tr();
                ht = htrans[0];

                ht.ferno = re.ferno;
                ht.fcat = re.fcat;

                ht.fssno = re.fEditAllSSNo;

                if (re.fEditAllSSNo != null && re.fEditAllSSNo != "")
                    {
                    if (CheckifSSNoisValid(re.fEditAllSSNo) == true)
                        {
                        ht.fcorr_ssno = re.fEditAllSSNo;
                        }
                    else
                        {
                        ViewBag.Message = "SSNo - " + re.fEditAllSSNo + " is not valid. Please verify and update this member record.";
                        }
                    }


                ht.fpcentre = re.fEditAllResponsibilityCentre;
                ht.fstaffno = re.fEditAllStaffNumber;
                ht.fcur_cr = re.fEditAllContributionorSalary;
                ht.fcurcr_perd = re.fEditAllPeriod;

                ht.ModifiedBy = Session["AccountID"].ToString();
                ht.ModifiedOn = DateTime.Today;

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


            re.TabIndex = 3;
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

                re.TabIndex = 3;
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

                re.TabIndex = 3;
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
                ViewBag.Message = "NO RECORD FOUND IN HISTORY TRANSACTION";

                re.TabIndex = 4;
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


        private bool ValidateSSNo(string SSNo)
            {
            int? thecount = db.mper_mst.Where(p => p.fssno == SSNo).Count();

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

            decimal NASSITPercent = decimal.Parse("0.15");
            List<NASSITPercentage> nps = new List<NASSITPercentage>();
            nps = db.NASSITPercentages.ToList();

            if (nps.Count > 0)
                {
                NASSITPercent = nps[0].NPercentage;
                }

            //FIRST CHECK FOR RECORDS IN HISTORY TRANSACTION AND MOVE ALL RECORDS TO THE HISTORY MASTER
            //IF RECORDS HAVE BEEN MOVED TO HISTORY MASTER, THEN UPDATE TH EMPLOYER CONTRIBUTION REPORT 
            //AND THE MEMBER CONTRIBUTION REPORT


            List<hist_tr> histtr = new List<hist_tr>();
            histtr = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiodtext).ToList();

            if (histtr.Count > 0)
                {

                foreach (hist_tr ht in histtr)
                    {

                    hist_mst hm = new hist_mst();

                    hm.CreatedBy = Session["AccountID"].ToString();
                    hm.CreatedOn = DateTime.Today;

                    hm.fcat = ht.fcat;
                    hm.fcatbperd = "";
                    hm.fcurcr_perd = ht.fcurcr_perd;

                    if (re.fmodesubmission == "C")
                        {
                        hm.fcur_cr = ht.fcur_cr.Value;
                        }
                    else
                        {
                        hm.fcur_cr = ht.fcur_cr.Value * NASSITPercent;
                        }

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

                    hm.ModifiedBy = Session["AccountID"].ToString();
                    hm.ModifiedOn = DateTime.Today;

                    if (ht.fcorr_ssno != "" && ht.fcorr_ssno != null)
                        {
                        hm.fssno = ht.fcorr_ssno;
                        }


                    db.hist_mst.Add(hm);
                    db.SaveChanges();

                    ht.fid = "P";
                    ht.fcorr_ssno = "";

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

                        if (re.fmodesubmission == "C")
                            {
                            ct.ftotcr += ht.fcur_cr.Value;
                            }
                        else
                            {
                            ct.ftotcr += ht.fcur_cr.Value * NASSITPercent;
                            }

                        ct.ftotwkr += 1;

                        ct.ModifiedBy = Session["AccountID"].ToString();
                        ct.ModifiedOn = DateTime.Today;

                        db.cr_ctrl.Attach(ct);
                        var entry = db.Entry(ct);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }
                    else
                        {
                        cr_ctrl ct = new cr_ctrl();


                        ct.fcat = re.fcat;
                        ct.ferno = re.ferno;
                        ct.fmedia = "P";
                        ct.fmode = re.fmodesubmission;

                        if (re.fmodesubmission == "C")
                            {
                            ct.ftotcr = ht.fcur_cr.Value;
                            }
                        else
                            {
                            ct.ftotcr = ht.fcur_cr.Value * NASSITPercent;
                            }

                        ct.ftotwkr = 1;

                        ct.CreatedBy = Session["AccountID"].ToString();
                        ct.CreatedOn = DateTime.Today;


                        ct.ModifiedBy = Session["AccountID"].ToString();
                        ct.ModifiedOn = DateTime.Today;

                        ct.fdateupd = DateTime.Today;
                        //ct.fuser_code = Session["AccountID"].ToString();

                        db.cr_ctrl.Attach(ct);
                        var entry = db.Entry(ct);
                        entry.State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();

                        }

                    }


                //DELETE THE CRSREG RECORD

                //List<crsreg> htemps = new List<crsreg>();
                //htemps = db.crsregs.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fperiod == re.fmasterperiodtext).ToList();

                //foreach (crsreg ht in htemps)
                //    {

                //    db.crsregs.Attach(ht);
                //    var entry = db.Entry(ht);
                //    entry.State = System.Data.Entity.EntityState.Deleted;
                //    db.SaveChanges();

                //    }


                //DELETE THE HISTORY TRANSACTION

                List<hist_tr> htrans = new List<hist_tr>();
                htrans = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiodtext).ToList();

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

                re.TabIndex = 4;
                return View("HardCopy", re);

                }
            else
                {

                List<hist_mst> hismast = new List<hist_mst>();
                hismast = db.hist_mst.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiodtext).ToList();

                if (hismast.Count > 0)
                    {

                    if (re.fMasterUpdateGenerateCR == true)
                        {

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

                                        if (re.fmodesubmission == "C")
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

                                        mcon.ModifiedBy = Session["AccountID"].ToString();
                                        mcon.ModifiedOn = DateTime.Today;

                                        db.memcr_tr.Attach(mcon);
                                        var entry = db.Entry(mcon);
                                        entry.State = System.Data.Entity.EntityState.Modified;
                                        db.SaveChanges();

                                        }
                                    else
                                        {

                                        memcr_tr mcon = new memcr_tr();

                                        mcon.fcat = hm.fcat;

                                        if (re.fmodesubmission == "C")
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
                                        mcon.fprocess = false;

                                        mcon.CreatedBy = Session["AccountID"].ToString();
                                        mcon.CreatedOn = DateTime.Today;

                                        db.memcr_tr.Add(mcon);
                                        db.SaveChanges();


                                        List<hist_tmp> htmps = new List<hist_tmp>();
                                        htmps = db.hist_tmp.Where(b => b.ferno == hm.ferno).Where(b => b.fcat == hm.fcat).ToList();

                                        if (htmps.Count > 0)
                                            {
                                            hist_tmp htp = new hist_tmp();
                                            htp = htmps[0];

                                            htp.fwkrs += 1;
                                            htp.fcont += hm.fcur_cr;

                                            htp.ModifiedBy = Session["AccountID"].ToString();
                                            htp.ModifiedOn = DateTime.Today;

                                            db.hist_tmp.Attach(htp);
                                            var entry = db.Entry(htp);
                                            entry.State = System.Data.Entity.EntityState.Modified;
                                            db.SaveChanges();


                                            }

                                        List<empcr_tr> ecs = new List<empcr_tr>();
                                        string ddftype = "R";

                                        ecs = db.empcr_tr.Where(b => b.ferno == hm.ferno).Where(b => b.ftype_cr == ddftype).Where(b => b.fcat == hm.fcat).Where(b => b.fperiod == hm.fcurcr_perd).ToList();

                                        if (ecs.Count > 0)
                                            {
                                            empcr_tr ec = new empcr_tr();
                                            ec = ecs[0];

                                            if (re.fmodesubmission == "C")
                                                {
                                                ec.ftot_cont += hm.fcur_cr;
                                                }
                                            else
                                                {
                                                ec.ftot_cont += (hm.fcur_cr * NASSITPercent);
                                                }


                                            //ERROR THE empcr_tr DELETES THE RECORD INSTEAD OF UPDATING THE RECORD

                                            ec.fdateupd = DateTime.Today;
                                            ec.fuser_code = Session["AccountID"].ToString();
                                            ec.ftype_cr = "R";
                                            ec.fno_wkr += 1;

                                            ec.ModifiedBy = Session["AccountID"].ToString();
                                            ec.ModifiedOn = DateTime.Today;

                                            db.empcr_tr.Attach(ec);
                                            var ventry = db.Entry(ec);
                                            ventry.State = System.Data.Entity.EntityState.Modified;
                                            db.SaveChanges();

                                            }
                                        else
                                            {

                                            empcr_tr ec = new empcr_tr();

                                            if (re.fmodesubmission == "C")
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

                                            ec.CreatedBy = Session["AccountID"].ToString();
                                            ec.CreatedOn = DateTime.Today;

                                            db.empcr_tr.Add(ec);
                                            db.SaveChanges();

                                            }
                                        }

                                    }
                                }



                            }


                        //List<crsreg> cregss = new List<crsreg>();
                        //string thetype = "R";
                        //cregss = db.crsregs.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fperiod == re.fmasterperiodtext).Where(b => b.ftype == thetype).ToList();

                        //if (cregss.Count > 0)
                        //    {

                        //    crsreg cr = new crsreg();
                        //    cr = cregss[0];

                        //    cr.fnowkr = re.fmasterperiodnoofworkers.Value;
                        //    cr.ftot_cr = re.fmastercontributiontext.Value;
                        //    cr.fstatus = "G";
                        //    cr.fdate_cap = DateTime.Today;
                        //    cr.fuser_cap = Session["AccountID"].ToString();

                        //    db.crsregs.Attach(cr);
                        //    var entry = db.Entry(cr);
                        //    entry.State = System.Data.Entity.EntityState.Modified;
                        //    db.SaveChanges();

                        //    }

                        }
                    else
                        {
                        ViewBag.Message = "Please check the Generte CR before proceeding on processing the Contribution Report";
                        }

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

                re.TabIndex = 4;
                return View("HardCopy", re);
                }

            }

        private decimal GetTotalContribution(string ERNo, string Category, string Period)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT Sum(fcur_cr) AS fcur_cr From hist_tr WHERE ferno = '" + ERNo + "' AND fcat = '" + Category + "' AND fcurcr_perd = '" + Period + "'";
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
            string Query = "SELECT Count(ID_SBTS) AS Total From hist_tr WHERE ferno = '" + ERNo + "' AND fcat = '" + Category + "' AND fcurcr_perd = '" + Period + "'";
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




        private decimal GetTotalContributionCRControl(string ERNo, string Category, string Period)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT Sum(ftot_cr) AS fcur_cr From crsreg WHERE ferno = '" + ERNo + "' AND fcat = '" + Category + "' AND fperiod = '" + Period + "'";
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


        private int GetTotalNoOfWorkersCRControl(string ERNo, string Category, string Period)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fnowkr AS Total From crsreg WHERE ferno = '" + ERNo + "' AND fcat = '" + Category + "' AND fperiod = '" + Period + "'";
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


            re.fmastercontributionCRControltext = GetTotalContributionCRControl(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodnoofworkersCRControl = GetTotalNoOfWorkersCRControl(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodCRControltext = re.fmasterperiod;


            if (re.fmasterperiodnoofworkers == 0)
                {
                List<hist_mst> hm = new List<hist_mst>();
                hm = db.hist_mst.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiod).ToList();

                if (hm.Count > 0)
                    {
                    ViewBag.Message = "Ready to Generate the Contribution Report. Please check the Generate CR checkbox and click complete.";
                    }
                }


            if (re.fcat == null || re.fcat == "")
                {
                ViewBag.Message = "You have not selected the Staff Category from the Summary Tab. Please do and try again.";
                }

            re.TabIndex = 4;
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


        public ActionResult MemberStatement()
            {
            return View("MemberStatement", new MemberStatementViewModel());
            }

        public ActionResult MemberStatement_LoadSSNo(MemberStatementViewModel mv)
            {
            List<mper_mst> mvs = new List<mper_mst>();
            mvs = db.mper_mst.Where(b => b.fssno == mv.SSNo).ToList();

            if (mvs.Count > 0)
                {
                mv.NameOfMember = mvs[0].fsurname + ", " + mvs[0].firstname + ", " + mvs[0].fothname;
                }
            else
                {
                mv.NameOfMember = "";
                }

            return View("MemberStatement", mv);
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

            return View("MemberStatement", mv);
            }

        private List<String> GetAllDistinctStatementYears(string fssno)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT Distinct(fyear) AS Year From mem_stmt WHERE fssno = @fssno";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);

            dp.SelectCommand.Parameters.AddWithValue("@fssno", fssno);

            dp.Fill(mytable);

            List<String> mylist = new List<string>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow item in mytable.Rows)
                    {
                    mylist.Add(item.Field<String>("Year"));
                    }

                }

            return mylist;

            }



        public ActionResult MemberStatement_OK(MemberStatementViewModel mv)
            {

            List<MemberStatementPrintViewModel> mpvms = new List<MemberStatementPrintViewModel>();

            if (mv.TypeofReport == "S")
                {

                if (!mv.PrintConsolidated)
                    {

                    List<mem_stmt> mvs = new List<mem_stmt>();
                    mvs = db.mem_stmt.Where(b => b.ferno == mv.ERNo).Where(b => b.fssno == mv.SSNo).Where(b => b.fyear == mv.Year).ToList();

                    if (mvs.Count > 0)
                        {
                        mem_stmt membst = new mem_stmt();
                        membst = mvs[0];

                        List<mper_mst> mems = new List<mper_mst>(); ;
                        mems = db.mper_mst.Where(b => b.fssno == mv.SSNo).ToList();

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

                            List<mper_mst> mems = new List<mper_mst>(); ;
                            mems = db.mper_mst.Where(b => b.fssno == mv.SSNo).ToList();

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

                    List<MemberStatementConsolidatedViewModel> mst = new List<MemberStatementConsolidatedViewModel>();

                    List<String> myyears = new List<string>();
                    myyears = GetAllDistinctStatementYears(mv.SSNo);

                    if (myyears.Count > 0)
                        {

                        List<mper_mst> mems = new List<mper_mst>(); 
                        mems = db.mper_mst.Where(b => b.fssno == mv.SSNo).ToList();

                        if (mems.Count > 0)
                            {
                            string NameofStaff = mems[0].fsurname + ", " + mems[0].firstname + " " + mems[0].fothname;
                            string NameofEmployers = "";

                            List<String> mylist = new List<string>();
                            mylist = GetAllEmployerNames(mv.SSNo);

                            if (mylist.Count > 0)
                                {
                                foreach (String item in mylist)
                                    {
                                    if (NameofEmployers == "")
                                        {
                                        NameofEmployers = item;
                                        }
                                    else
                                        {
                                        NameofEmployers += ", " + item;
                                        }
                                    }

                                }

                            string SSNo = mems[0].fssno;
                            string ERNo = mems[0].ferno;

                            string Sex = mems[0].fsex.ToString();

                            if (Sex == "M")
                                {
                                Sex = "Male";
                                }
                            else
                                {
                                 Sex = "Female";
                                }
                            DateTime? DateJoined = mems[0].fjoindate;

                            decimal NASSITPercent = decimal.Parse("0.15");
                            List<NASSITPercentage> nps = new List<NASSITPercentage>();
                            nps = db.NASSITPercentages.ToList();

                            if (nps.Count > 0)
                                {
                                NASSITPercent = nps[0].NPercentage;
                                }

                            foreach (String dyear in myyears)
                                {
                                int NoofMonths = 0;
                                decimal TotalContribution = 0;
                                decimal TotalSalary = 0;

                                List<mem_stmt> membst = new List<mem_stmt>();
                                membst = db.mem_stmt.Where(b => b.fssno == mv.SSNo).Where(b => b.fyear == dyear).ToList();

                                if (membst.Count > 0)
                                    {
                                    mem_stmt m = new mem_stmt();
                                    m = membst[0];

                                    if (m.fjancr.HasValue) { if (m.fjancr > 0) { NoofMonths += 1; TotalContribution += m.fjancr.Value; } }
                                    if (m.ffebcr.HasValue) { if (m.ffebcr > 0) { NoofMonths += 1; TotalContribution += m.ffebcr.Value; } }
                                    if (m.fmarcr.HasValue) { if (m.fmarcr > 0) { NoofMonths += 1; TotalContribution += m.fmarcr.Value; } }
                                    if (m.faprcr.HasValue) { if (m.faprcr > 0) { NoofMonths += 1; TotalContribution += m.faprcr.Value; } }
                                    if (m.fmaycr.HasValue) { if (m.fmaycr > 0) { NoofMonths += 1; TotalContribution += m.fmaycr.Value; } }
                                    if (m.fjuncr.HasValue) { if (m.fjuncr > 0) { NoofMonths += 1; TotalContribution += m.fjuncr.Value; } }
                                    if (m.fjulcr.HasValue) { if (m.fjulcr > 0) { NoofMonths += 1; TotalContribution += m.fjulcr.Value; } }
                                    if (m.faugcr.HasValue) { if (m.faugcr > 0) { NoofMonths += 1; TotalContribution += m.faugcr.Value; } }
                                    if (m.fsepcr.HasValue) { if (m.fsepcr > 0) { NoofMonths += 1; TotalContribution += m.fsepcr.Value; } }
                                    if (m.foctcr.HasValue) { if (m.foctcr > 0) { NoofMonths += 1; TotalContribution += m.foctcr.Value; } }
                                    if (m.fnovcr.HasValue) { if (m.fnovcr > 0) { NoofMonths += 1; TotalContribution += m.fnovcr.Value; } }
                                    if (m.fdeccr.HasValue) { if (m.fdeccr > 0) { NoofMonths += 1; TotalContribution += m.fdeccr.Value; } }

                                    TotalSalary = ((TotalContribution * 100) / 15);

                                    MemberStatementConsolidatedViewModel mp = new MemberStatementConsolidatedViewModel();
                                    mp.DateJoined = DateJoined;
                                    mp.NameOfEmployers = NameofEmployers;
                                    mp.NameofStaff = NameofStaff;
                                    mp.NoOfMonths = NoofMonths;
                                    mp.Sex = Sex;
                                    mp.SSNo = mv.SSNo;
                                    mp.TotalContribution = Decimal.Parse(TotalContribution.ToString("F2"));
                                    mp.TotalSalary = Decimal.Parse(TotalSalary.ToString("F2"));
                                    mp.Year = dyear;

                                    mst.Add(mp);

                                    }
                                }
                            }

                        XtraReportMemberStatementConsol mydocument = new XtraReportMemberStatementConsol();
                        mydocument.MemberStatementDataSource.DataSource = mst;
                        mydocument.CreateDocument();

                        return View("PrintPreview", mydocument);


                        }

                    else
                        {
                        ViewBag.Message = "NO RECORD WAS FOUND FOR THIS MEMBER. PLEASE VERIFY THE SSNO AND TRY AGAIN";
                        return View("MemberStatement", mv);
                        }


                    }
                }
            else if (mv.TypeofReport == "E")
                {
                List<mem_stmt> mvs = new List<mem_stmt>();
                mvs = db.mem_stmt.Where(b => b.ferno == mv.ERNo).Where(b => b.fyear == mv.Year).ToList();


                if (mvs.Count > 0)
                    {

                    string NameofEmployer = GetEmployerName(mv.ERNo);

                    foreach (mem_stmt membst in mvs)
                        {
                        List<mper_mst> mems = new List<mper_mst>();
                        mems = db.mper_mst.Where(b => b.fssno == membst.fssno).ToList();

                        if (mems.Count > 0)
                            {
                            string NameofStaff = mems[0].fsurname + ", " + mems[0].firstname + " " + mems[0].fothname;

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

                        List<mper_mst> mems = new List<mper_mst>(); ;
                        mems = db.mper_mst.Where(b => b.fssno == membst.fssno).ToList();

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
                return View("MemberStatement", mv);
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
            List<mper_mst> mv = new List<mper_mst>();
            mv = db.mper_mst.Where(b => b.fssno == re.fAddSSNo).ToList();

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
                                        mcon.fprocess = false;

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

                            List<mper_mst> mg = new List<mper_mst>();
                            mg = db.mper_mst.Where(b => b.fssno == item.fssno).ToList();

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
            List<mper_mst> mem = new List<mper_mst>();
            mem = db.mper_mst.Where(b => b.ferno == cs.ferno).ToList();

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
                    mc2.fprocess = false;

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

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT SUM(fcontr) AS Total From memcr_tr WHERE ferno = @ferno and ftype_cr = @ftype_cr and fperiod = @fperiod";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);

            dp.SelectCommand.Parameters.AddWithValue("@ferno", ferno);
            dp.SelectCommand.Parameters.AddWithValue("@ftype_cr", ftype);
            dp.SelectCommand.Parameters.AddWithValue("@fperiod", fperiod);


            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                if (mytable.Rows[0].Field<Decimal?>("Total").HasValue)
                    {
                    return mytable.Rows[0].Field<Decimal>("Total");
                    }
                else
                    {
                    return 0;
                    }

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
            string Query = "SELECT ferno, fperiod, sum(fcontr) as fcontr, ftype_cr From memcr_tr where fprocess = 0 Group by ferno, fperiod, ftype_cr";
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
                    ml.Type = item.Field<String>("ftype_cr");

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
            mct = db.memcr_tr.Where(b => b.fprocess == false).ToList();

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
                    inv.fpcentre = Session["Branch"].ToString();

                    inv.ModifiedBy = Session["AccountID"].ToString();
                    inv.ModifiedOn = DateTime.Today;

                    inv.CreatedBy = Session["AccountID"].ToString();
                    inv.CreatedOn = DateTime.Today;

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

                        m.fssno = item.fssno;
                        m.ferno = item.ferno;
                        m.fcat = item.fcat;
                        m.ftype = item.ftype_cr;
                        m.fyear = item.fperiod.Substring(0, 4);

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


                //SET THE PROCESS CONDITION TO TRUE SINCE IT HAS ALREADY BEEN PROCESSED
                item.fprocess = true;
                db.memcr_tr.Attach(item);
                var mementry = db.Entry(item);
                mementry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

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

            ViewBag.Message = "MEMBER CREDIT PROCESSING SUCESSFULLY COMPLETED";
            TempData["MemberCreditList"] = null;

            return View("MemberCreditProcessing");
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

            //DO NECESSARY CREDIT PROCESSING


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

        #region PROCESS SOFTCOPY CONTRIBUTION REPORT

        public ActionResult ProcessSoftCopy()
            {
            return View("ProcessSoftCopy", new ContributionSoftCopyViewModel());
            }

        public ActionResult SoftCopy_Load(ContributionSoftCopyViewModel sc)
            {
            TempData["MySoftContributionPeriod"] = GetMySoftCopyCRSRegPeriod(sc.ERNO);

            sc.EstablishmentName = GetEmployerName(sc.ERNO);

            return View("ProcessSoftCopy", sc);

            }


        public ActionResult SoftCopy_LoadPeriod(ContributionSoftCopyViewModel sc)
            {


            List<crsreg> cr = new List<crsreg>();
            cr = db.crsregs.Where(b => b.ferno == sc.ERNO).Where(b => b.fperiod == sc.CR).ToList();

            if (cr.Count > 0)
                {

                crsreg c = new crsreg();
                c = cr[0];

                sc.CRBeginPeriod = c.fperiod;
                sc.CREndPeriod = c.feperiod;
                sc.fcat = c.fcat;
                sc.ftype = c.ftype;

                string fullcr = Request["CR"].ToString();

                if (fullcr != null)
                    {
                    string[] splitcr = fullcr.Split(';');

                    string Type = splitcr[1].Trim();

                    if (Type == "R")
                        {
                        sc.ContributionType = "Regular";
                        }
                    else
                        {
                        sc.ContributionType = "Backpay";
                        }

                    }
                }
            else
                {
                ViewBag.Message = "Unable to load period data. Please verify the selection and try again.";
                }

            return View("ProcessSoftCopy", sc);

            }



        [HttpPost]
        public ActionResult SoftCopy_Browse(HttpPostedFileBase file, ContributionSoftCopyViewModel scopy)
            {
            DataSet ds = new DataSet();
            if (Request.Files["file"].ContentLength > 0)
                {
                string fileExtension = System.IO.Path.GetExtension(Request.Files["file"].FileName);
                string fullname = System.IO.Path.GetFileName(Request.Files["file"].FileName);

                if (fileExtension == ".xls" || fileExtension == ".xlsx")
                    {
                    string fileLocation = Server.MapPath("~/Uploads/") + fullname;
                    if (System.IO.File.Exists(fileLocation))
                        {
                        System.IO.File.Delete(fileLocation);
                        }

                    Request.Files["file"].SaveAs(fileLocation);
                    string excelConnectionString = string.Empty;
                    excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileLocation + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                    //connection String for xls file format.
                    if (fileExtension == ".xls")
                        {
                        excelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileLocation + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
                        }
                    //connection String for xlsx file format.
                    else if (fileExtension == ".xlsx")
                        {

                        excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileLocation + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                        }
                    //Create Connection to Excel work book and add oledb namespace
                    OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                    excelConnection.Open();
                    DataTable dt = new DataTable();

                    dt = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    if (dt == null)
                        {
                        return null;
                        }

                    String[] excelSheets = new String[dt.Rows.Count];
                    int t = 0;
                    //excel data saves in temp file here.
                    foreach (DataRow row in dt.Rows)
                        {
                        excelSheets[t] = row["TABLE_NAME"].ToString();
                        t++;
                        }
                    OleDbConnection excelConnection1 = new OleDbConnection(excelConnectionString);


                    string query = string.Format("Select * from [{0}]", excelSheets[0]);
                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, excelConnection1))
                        {
                        dataAdapter.Fill(ds);
                        }
                    }

                if (fileExtension.ToString().ToLower().Equals(".xml"))
                    {
                    string fileLocation = Server.MapPath("~/Content/") + fullname;
                    if (System.IO.File.Exists(fileLocation))
                        {
                        System.IO.File.Delete(fileLocation);
                        }

                    Request.Files["FileUpload"].SaveAs(fileLocation);
                    XmlTextReader xmlreader = new XmlTextReader(fileLocation);
                    // DataSet ds = new DataSet();
                    ds.ReadXml(xmlreader);
                    xmlreader.Close();
                    }

                double TotalContribution = 0;
                int Noofinvalids = 0;

                List<SoftcopyMemberListViewModel> scm = new List<SoftcopyMemberListViewModel>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                    SoftcopyMemberListViewModel sc = new SoftcopyMemberListViewModel();
                    sc.FBAKTYPE = ds.Tables[0].Rows[i].Field<String>("FBAKTYPE");
                    sc.FBAK_BEGIN = ds.Tables[0].Rows[i].Field<String>("FBAK_BEGIN");
                    sc.FBAK_END = ds.Tables[0].Rows[i].Field<String>("FBAK_END");
                    sc.FCODE = ds.Tables[0].Rows[i].Field<String>("FCODE");
                    sc.FCONTR = ds.Tables[0].Rows[i].Field<Double?>("FCONTR").ToString();
                    sc.FDATE = ds.Tables[0].Rows[i].Field<DateTime?>("FDATE");
                    sc.FERNO = ds.Tables[0].Rows[i].Field<String>("FERNO");
                    sc.FFLAG = ds.Tables[0].Rows[i].Field<String>("FFLAG");
                    sc.FMISC = ds.Tables[0].Rows[i].Field<String>("FMISC");
                    sc.FNAME = ds.Tables[0].Rows[i].Field<String>("FNAME");
                    sc.FNAME1 = ds.Tables[0].Rows[i].Field<String>("FNAME1");
                    sc.FNAME2 = ds.Tables[0].Rows[i].Field<String>("FNAME2");
                    sc.FSSNO = ds.Tables[0].Rows[i].Field<String>("FSSNO");
                    sc.FSTAFFNO = ds.Tables[0].Rows[i].Field<String>("FSTAFFNO");

                    TotalContribution += double.Parse(sc.FCONTR);

                    if (sc.FSSNO == null)
                        {
                        Noofinvalids += 1;
                        }
                    else
                        {
                        if (!ValidateSSNo(sc.FSSNO))
                            {
                            Noofinvalids += 1;
                            }
                        }

                    scm.Add(sc);

                    //string conn = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
                    //SqlConnection con = new SqlConnection(conn);
                    //string query = "Insert into Person(Name,Email,Mobile) Values('" + ds.Tables[0].Rows[i][0].ToString() + "','" + ds.Tables[0].Rows[i][1].ToString() + "','" + ds.Tables[0].Rows[i][2].ToString() + "')";
                    //con.Open();
                    //SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.ExecuteNonQuery();
                    //con.Close();
                    }

                //scopy.NoofRecords = scm.Count;
                //scopy.NoofInvalidRecords = Noofinvalids;
                scopy.Period = scopy.CR;
                //scopy.TotalContribution = decimal.Parse(TotalContribution.ToString());

                TempData["SoftcopyMemberList"] = scm;


                }
            return View("ProcessSoftCopy", scopy);
            }


        public ActionResult SoftCopy_Complete(ContributionSoftCopyViewModel scopy)
            {

            string fullcr = Request["CR"].ToString();
            string[] splitcr = fullcr.Split(';');

            string Period = splitcr[0].Trim();
            string Type = splitcr[1].Trim();
            string Category = splitcr[2].Trim();


            int noofworkers = 0;
            decimal totalcontribution = 0;
            int noofinvalidrecords = 0;


            if (Type != "B")  //PROCESS REGULAR PAYMENTS
                {

                List<hist_mst> hms = new List<hist_mst>();
                hms = db.hist_mst.Where(b => b.ferno == scopy.ERNO).Where(b => b.fcat == Category).Where(b => b.fcurcr_perd == Period).ToList();

                if (hms.Count > 0)
                    {

                    foreach (hist_mst item in hms)
                        {
                        hist_mst hm = new hist_mst();
                        hm = item;

                        hm.ModifiedBy = Session["AccountID"].ToString();
                        hm.ModifiedOn = DateTime.Today;

                        hm.fprocess = "N";
                        db.hist_mst.Attach(hm);
                        var entry = db.Entry(hm);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        }


                    }
                else
                    {

                    }

                if (TempData.Peek("SoftcopyMemberList") != null)
                    {

                    List<SoftcopyMemberListViewModel> plist = (List<SoftcopyMemberListViewModel>)TempData.Peek("SoftcopyMemberList");

                    if (plist.Count > 0)
                        {

                        foreach (SoftcopyMemberListViewModel sc in plist)
                            {
                            bool mflag = ValidateSSNo(sc.FSSNO);
                            string mcode = "";
                            bool mupd;

                            if (scopy.ERNO == "G01J2011004")  //POLICE FORCE
                                {
                                if (!mflag)
                                    {
                                    if (sc.FSTAFFNO != null && sc.FSTAFFNO != "")
                                        {
                                        List<mper_mst> mper = new List<mper_mst>();
                                        mper = db.mper_mst.Where(b => b.fstaffno == sc.FSTAFFNO).Where(b => b.ferno == scopy.ERNO).ToList();

                                        if (mper.Count > 0)
                                            {
                                            sc.FSSNO = mper[0].fssno;
                                            mflag = true;
                                            }
                                        }
                                    }
                                }



                            if (scopy.ERNO == "G01J2011005")  //SOLDIERS
                                {
                                if (!mflag)
                                    {
                                    if (sc.FSTAFFNO != null && sc.FSTAFFNO != "")
                                        {
                                        List<mper_mst> mper = new List<mper_mst>();
                                        mper = db.mper_mst.Where(b => b.fstaffno == sc.FSTAFFNO).Where(b => b.ferno == scopy.ERNO).ToList();

                                        if (mper.Count > 0)
                                            {
                                            sc.FSSNO = mper[0].fssno;
                                            mflag = true;
                                            }
                                        }
                                    }
                                }


                            if (scopy.ERNO == "G01J2011006")  //TEACHERS
                                {
                                if (!mflag)
                                    {
                                    if (sc.FSTAFFNO != null && sc.FSTAFFNO != "")
                                        {
                                        List<mper_mst> mper = new List<mper_mst>();
                                        mper = db.mper_mst.Where(b => b.fstaffno == sc.FSTAFFNO).Where(b => b.ferno == scopy.ERNO).ToList();

                                        if (mper.Count > 0)
                                            {
                                            sc.FSSNO = mper[0].fssno;
                                            mflag = true;
                                            }
                                        }
                                    }
                                }


                            if (scopy.ERNO == "G01J2011007")  //CIVIL SERVANTS
                                {
                                if (!mflag)
                                    {
                                    if (sc.FSTAFFNO != null && sc.FSTAFFNO != "")
                                        {
                                        List<mper_mst> mper = new List<mper_mst>();
                                        mper = db.mper_mst.Where(b => b.fstaffno == sc.FSTAFFNO).Where(b => b.ferno == scopy.ERNO).ToList();

                                        if (mper.Count > 0)
                                            {
                                            sc.FSSNO = mper[0].fssno;
                                            mflag = true;
                                            }
                                        }
                                    }
                                }


                            if (sc.FCODE == "1")
                                {
                                mcode = "1";
                                }
                            else
                                {
                                mcode = "2";
                                }



                            if (mcode == "1")
                                {
                                if (mflag == true)  //VALID NO
                                    {
                                    List<hist_mst> hmst = new List<hist_mst>();
                                    hmst = db.hist_mst.Where(b => b.ferno == scopy.ERNO).Where(b => b.fcurcr_perd == Period).Where(b => b.fssno == sc.FSSNO).ToList();

                                    if (hmst.Count == 0)
                                        {

                                        List<hist_mst> hmst2 = new List<hist_mst>();
                                        hmst2 = db.hist_mst.Where(b => b.ferno == scopy.ERNO).Where(b => b.fcurcr_perd == Period).Where(b => b.firstname == sc.FNAME1).Where(b => b.fothername == sc.FNAME2).Where(b => b.fsurname == sc.FNAME).ToList();

                                        if (hmst2.Count > 0)
                                            {
                                            inv_corr inv = new inv_corr();
                                            inv.ferno = scopy.ERNO;
                                            inv.fwssno = sc.FSSNO;
                                            inv.fssno = sc.FSSNO;
                                            inv.fcat = hmst2[0].fcat;
                                            inv.fsurname = hmst2[0].fsurname;
                                            inv.firstname = hmst2[0].firstname;
                                            inv.fothername = hmst2[0].fothername;

                                            inv.ModifiedBy = Session["AccountID"].ToString();
                                            inv.ModifiedOn = DateTime.Today;

                                            db.inv_corr.Add(inv);
                                            db.SaveChanges();


                                            hist_mst hm1 = new hist_mst();
                                            hm1 = hmst2[0];

                                            hm1.fssno = sc.FSSNO;
                                            hm1.fflag = true;
                                            hm1.fprocess = "A";

                                            db.hist_mst.Attach(hm1);
                                            var entry = db.Entry(hm1);
                                            entry.State = System.Data.Entity.EntityState.Modified;
                                            db.SaveChanges();

                                            mupd = true;
                                            }
                                        else
                                            {

                                            hist_mst hm1 = new hist_mst();

                                            hm1.ferno = scopy.ERNO;
                                            hm1.fcat = Category;
                                            hm1.fsurname = sc.FNAME;
                                            hm1.firstname = sc.FNAME1;
                                            hm1.fothername = sc.FNAME2;
                                            hm1.frstcr_perd = Period;
                                            hm1.fcurcr_perd = Period;
                                            hm1.fcur_cr = decimal.Parse(sc.FCONTR.ToString());
                                            hm1.fremark = "A";
                                            hm1.fflag = mflag;
                                            hm1.fstaffno = sc.FSTAFFNO;
                                            hm1.fprocess = "A";

                                            hm1.fpcentre = Session["Branch"].ToString();

                                            hm1.ModifiedBy = Session["AccountID"].ToString();
                                            hm1.ModifiedOn = DateTime.Today;

                                            hm1.CreatedBy = Session["AccountID"].ToString();
                                            hm1.CreatedOn = DateTime.Today;

                                            hm1.fssno = sc.FSSNO;

                                            db.hist_mst.Add(hm1);
                                            db.SaveChanges();

                                            mupd = false;


                                            }


                                        }
                                    else
                                        {
                                        mupd = true;
                                        }
                                    }
                                else  //INVALID NO
                                    {

                                    noofinvalidrecords += 1;

                                    List<hist_mst> hmst2 = new List<hist_mst>();
                                    hmst2 = db.hist_mst.Where(b => b.ferno == scopy.ERNO).Where(b => b.fcurcr_perd == Period).Where(b => b.firstname == sc.FNAME1).Where(b => b.fothername == sc.FNAME2).Where(b => b.fsurname == sc.FNAME).ToList();

                                    if (hmst2.Count > 0)
                                        {
                                        if (hmst2[0].fflag == true)
                                            {
                                            sc.FSSNO = hmst2[0].fssno;

                                            hmst2[0].fprocess = "A";

                                            db.hist_mst.Attach(hmst2[0]);
                                            var entry = db.Entry(hmst2[0]);
                                            entry.State = System.Data.Entity.EntityState.Modified;
                                            db.SaveChanges();

                                            }

                                        mupd = true;

                                        }
                                    else
                                        {

                                        hist_mst hm1 = new hist_mst();

                                        hm1.ferno = scopy.ERNO;
                                        hm1.fcat = Category;
                                        hm1.fsurname = sc.FNAME;
                                        hm1.firstname = sc.FNAME1;
                                        hm1.fothername = sc.FNAME2;
                                        hm1.frstcr_perd = Period;
                                        hm1.fcurcr_perd = Period;
                                        hm1.fcur_cr = decimal.Parse(sc.FCONTR.ToString());
                                        hm1.fremark = "A";
                                        hm1.fflag = mflag;
                                        hm1.fstaffno = sc.FSTAFFNO;
                                        hm1.fprocess = "A";

                                        hm1.fpcentre = Session["Branch"].ToString();

                                        hm1.ModifiedBy = Session["AccountID"].ToString();
                                        hm1.ModifiedOn = DateTime.Today;

                                        hm1.CreatedBy = Session["AccountID"].ToString();
                                        hm1.CreatedOn = DateTime.Today;

                                        hm1.fssno = sc.FSSNO;

                                        db.hist_mst.Add(hm1);
                                        db.SaveChanges();

                                        mupd = false;

                                        }

                                    }


                                if (mupd == true)
                                    {

                                    List<hist_mst> hmst2 = new List<hist_mst>();
                                    hmst2 = db.hist_mst.Where(b => b.ferno == scopy.ERNO).Where(b => b.fcurcr_perd == Period).Where(b => b.firstname == sc.FNAME1).Where(b => b.fothername == sc.FNAME2).Where(b => b.fsurname == sc.FNAME).ToList();

                                    if (hmst2.Count > 0)
                                        {

                                        hist_mst dh = new hist_mst();
                                        dh = hmst2[0];

                                        dh.fcat = Category;
                                        dh.fcur_cr = decimal.Parse(sc.FCONTR.ToString());
                                        dh.fremark = "A";
                                        dh.fprocess = "A";

                                        dh.ModifiedBy = Session["AccountID"].ToString();
                                        dh.ModifiedOn = DateTime.Today;

                                        db.hist_mst.Attach(dh);
                                        var entry = db.Entry(dh);
                                        entry.State = System.Data.Entity.EntityState.Modified;
                                        db.SaveChanges();

                                        }

                                    }


                                noofworkers += 1;
                                totalcontribution += decimal.Parse(sc.FCONTR);

                                List<memcr_tr> mems = new List<memcr_tr>();
                                mems = db.memcr_tr.Where(b => b.ferno == scopy.ERNO).Where(b => b.fperiod == Period).Where(b => b.firstname == sc.FNAME1).Where(b => b.fothername == sc.FNAME2).Where(b => b.fsurname == sc.FNAME).ToList();

                                if (mems.Count > 0)
                                    {

                                    memcr_tr mc = new memcr_tr();
                                    mc = mems[0];

                                    mc.fssno = sc.FSSNO;
                                    mc.ferno = scopy.ERNO;
                                    mc.ftype_cr = Type;
                                    mc.fcat = Category;
                                    mc.fsurname = sc.FNAME;
                                    mc.firstname = sc.FNAME1;
                                    mc.fothername = sc.FNAME2;
                                    mc.fstaffno = sc.FSTAFFNO;
                                    mc.fperiod = Period;
                                    mc.fcontr = decimal.Parse(sc.FCONTR);
                                    mc.fmedia = "D";
                                    mc.fprocess = false;

                                    mc.fpcentre = Session["Branch"].ToString();

                                    mc.ModifiedBy = Session["AccountID"].ToString();
                                    mc.ModifiedOn = DateTime.Today;

                                    db.memcr_tr.Add(mc);
                                    var entry = db.Entry(mc);
                                    entry.State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();

                                    }
                                else
                                    {
                                    memcr_tr mc = new memcr_tr();
                                    mc.fssno = sc.FSSNO;
                                    mc.ferno = scopy.ERNO;
                                    mc.ftype_cr = Type;
                                    mc.fcat = Category;
                                    mc.fsurname = sc.FNAME;
                                    mc.firstname = sc.FNAME1;
                                    mc.fothername = sc.FNAME2;
                                    mc.fstaffno = sc.FSTAFFNO;
                                    mc.fperiod = Period;
                                    mc.fcontr = decimal.Parse(sc.FCONTR);
                                    mc.fmedia = "D";
                                    mc.fprocess = false;

                                    mc.fpcentre = Session["Branch"].ToString();

                                    mc.ModifiedBy = Session["AccountID"].ToString();
                                    mc.ModifiedOn = DateTime.Today;

                                    mc.CreatedBy = Session["AccountID"].ToString();
                                    mc.CreatedOn = DateTime.Today;

                                    db.memcr_tr.Add(mc);
                                    db.SaveChanges();
                                    }




                                }


                            }

                        List<empcr_tr> emp = new List<empcr_tr>();
                        emp = db.empcr_tr.Where(b => b.ferno == scopy.ERNO).Where(b => b.fcat == Category).Where(b => b.ftype_cr == Type).Where(b => b.fperiod == Period).ToList();

                        if (emp.Count > 0)
                            {
                            emp[0].fno_wkr = noofworkers;
                            emp[0].ftot_cont = totalcontribution;

                            emp[0].ModifiedBy = Session["AccountID"].ToString();
                            emp[0].ModifiedOn = DateTime.Today;

                            db.empcr_tr.Attach(emp[0]);
                            var entry = db.Entry(emp[0]);
                            entry.State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            }
                        else
                            {
                            empcr_tr empp = new empcr_tr();

                            empp.ferno = scopy.ERNO;
                            empp.ftype_cr = Type;
                            empp.fcat = Category;
                            empp.fno_wkr = noofworkers;
                            empp.ftot_cont = totalcontribution;
                            empp.fperiod = Period;
                            empp.fdateupd = DateTime.Today;
                            empp.fuser_code = Session["AccountID"].ToString();

                            empp.CreatedBy = Session["AccountID"].ToString();
                            empp.CreatedOn = DateTime.Today;

                            empp.ModifiedBy = Session["AccountID"].ToString();
                            empp.ModifiedOn = DateTime.Today;

                            db.empcr_tr.Add(empp);
                            db.SaveChanges();

                            }


                        }

                    }

                scopy.TotalContribution = totalcontribution;
                scopy.NoOfRecords = noofworkers;
                scopy.NoOfInvalidRecords = noofinvalidrecords;

                }
            else //PROCESS BACK PAY
                {


                if (TempData.Peek("SoftcopyMemberList") != null)
                    {

                    List<SoftcopyMemberListViewModel> plist = (List<SoftcopyMemberListViewModel>)TempData.Peek("SoftcopyMemberList");

                    if (plist.Count > 0)
                        {

                        foreach (SoftcopyMemberListViewModel sc in plist)
                            {

                            bool mflag = ValidateSSNo(sc.FSSNO);
                            string mcode = "";
                            

                            if (scopy.ERNO == "G01J2011004")  //POLICE FORCE
                                {
                                if (!mflag)
                                    {
                                    if (sc.FSTAFFNO != null && sc.FSTAFFNO != "")
                                        {
                                        List<mper_mst> mper = new List<mper_mst>();
                                        mper = db.mper_mst.Where(b => b.fstaffno == sc.FSTAFFNO).Where(b => b.ferno == scopy.ERNO).ToList();

                                        if (mper.Count > 0)
                                            {
                                            sc.FSSNO = mper[0].fssno;
                                            mflag = true;
                                            }
                                        }
                                    }
                                }



                            if (scopy.ERNO == "G01J2011005")  //SOLDIERS
                                {
                                if (!mflag)
                                    {
                                    if (sc.FSTAFFNO != null && sc.FSTAFFNO != "")
                                        {
                                        List<mper_mst> mper = new List<mper_mst>();
                                        mper = db.mper_mst.Where(b => b.fstaffno == sc.FSTAFFNO).Where(b => b.ferno == scopy.ERNO).ToList();

                                        if (mper.Count > 0)
                                            {
                                            sc.FSSNO = mper[0].fssno;
                                            mflag = true;
                                            }
                                        }
                                    }
                                }


                            if (scopy.ERNO == "G01J2011006")  //TEACHERS
                                {
                                if (!mflag)
                                    {
                                    if (sc.FSTAFFNO != null && sc.FSTAFFNO != "")
                                        {
                                        List<mper_mst> mper = new List<mper_mst>();
                                        mper = db.mper_mst.Where(b => b.fstaffno == sc.FSTAFFNO).Where(b => b.ferno == scopy.ERNO).ToList();

                                        if (mper.Count > 0)
                                            {
                                            sc.FSSNO = mper[0].fssno;
                                            mflag = true;
                                            }
                                        }
                                    }
                                }


                            if (scopy.ERNO == "G01J2011007")  //CIVIL SERVANTS
                                {
                                if (!mflag)
                                    {
                                    if (sc.FSTAFFNO != null && sc.FSTAFFNO != "")
                                        {
                                        List<mper_mst> mper = new List<mper_mst>();
                                        mper = db.mper_mst.Where(b => b.fstaffno == sc.FSTAFFNO).Where(b => b.ferno == scopy.ERNO).ToList();

                                        if (mper.Count > 0)
                                            {
                                            sc.FSSNO = mper[0].fssno;
                                            mflag = true;
                                            }
                                        }
                                    }
                                }


                            if (sc.FCODE == "5")
                                {
                                mcode = "5";
                                }
                            else
                                {
                                mcode = "6";
                                }



                            if (mcode == "5")
                                {

                                int baktimes = GetTotalNumberofMonths(sc.FBAK_BEGIN, sc.FBAK_END);

                                string mmperiod = sc.FBAK_BEGIN;

                                List<String> thelist = GetPeriodListforBackpay(sc.FBAK_BEGIN, sc.FBAK_END);

                                if (thelist.Count > 0)
                                    {
                                    foreach (String item in thelist)
                                        {

                                        memcr_tr mc = new memcr_tr();
                                        mc.fssno = sc.FSSNO;
                                        mc.ferno = scopy.ERNO;
                                        mc.ftype_cr = Type;
                                        mc.fcat = Category;
                                        mc.fsurname = sc.FNAME;
                                        mc.firstname = sc.FNAME1;
                                        mc.fothername = sc.FNAME2;
                                        mc.fstaffno = sc.FSTAFFNO;
                                        mc.fperiod = item;
                                        mc.fprocess = false;

                                        mc.fpcentre = Session["Branch"].ToString();

                                        if (sc.FBAKTYPE == "1")
                                            {
                                            mc.fcontr = decimal.Parse(sc.FCONTR);
                                            }
                                        else
                                            {
                                            mc.fcontr = decimal.Parse(sc.FCONTR) / baktimes;
                                            }

                                        mc.fmedia = "D";

                                        db.memcr_tr.Add(mc);
                                        db.SaveChanges();

                                        }

                                    if (sc.FCODE == "5")
                                        {

                                        noofworkers += 1;
                                        totalcontribution += decimal.Parse(sc.FCONTR);

                                        scopy.TotalContribution += decimal.Parse(sc.FCONTR);
                                        scopy.NoOfRecords += 1;
                                        scopy.Period = Period;

                                        if (mflag == false)
                                            {
                                            scopy.NoOfInvalidRecords += 1;
                                            }
                                        }
                                    }

                                }

                            }  //END DO


                        List<empcr_tr> emp = new List<empcr_tr>();
                        string thetype = "B";

                        emp = db.empcr_tr.Where(b => b.ferno == scopy.ERNO).Where(b => b.fcat == Category).Where(b => b.ftype_cr == thetype).Where(b => b.fperiod == Period).ToList();

                        if (emp.Count > 0)
                            {
                            emp[0].fno_wkr = noofworkers;
                            emp[0].ftot_cont = totalcontribution;

                            emp[0].ModifiedBy = Session["AccountID"].ToString();
                            emp[0].ModifiedOn = DateTime.Today;

                            db.empcr_tr.Attach(emp[0]);
                            var entry = db.Entry(emp[0]);
                            entry.State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            }
                        else
                            {
                            empcr_tr empp = new empcr_tr();

                            empp.ferno = scopy.ERNO;
                            empp.ftype_cr = Type;
                            empp.fcat = Category;
                            empp.fno_wkr = noofworkers;
                            empp.ftot_cont = totalcontribution;
                            empp.fperiod = Period;
                            empp.fdateupd = DateTime.Today;
                            empp.fuser_code = Session["AccountID"].ToString();

                            empp.CreatedBy = Session["AccountID"].ToString();
                            empp.CreatedOn = DateTime.Today;

                            empp.ModifiedBy = Session["AccountID"].ToString();
                            empp.ModifiedOn = DateTime.Today;

                            db.empcr_tr.Add(emp[0]);
                            db.SaveChanges();

                            }


                        }

                    }

                }


            List<crsreg> creg = new List<crsreg>();
            creg = db.crsregs.Where(b => b.ferno == scopy.ERNO).Where(b => b.fcat == Category).Where(b => b.ftype == Type).Where(b => b.fperiod == Period).ToList();

            if (creg.Count > 0)
                {
                crsreg c = new crsreg();
                c = creg[0];

                c.fdate_cap = DateTime.Today;
                c.fnowkr = noofworkers;
                c.fstatus = "G";
                c.fuser_cap = Session["AccountID"].ToString();

                db.crsregs.Attach(c);
                var entry = db.Entry(c);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                }

            scopy.TotalContribution = totalcontribution;
            scopy.NoOfRecords = noofworkers;
            scopy.NoOfInvalidRecords = noofinvalidrecords;

            ViewBag.Message = "SOFTCOPY CONTRIBUTION SUCCESSFULLY CAPTURED";
            return View("ProcessSoftCopy", scopy);

            }


        private List<String> GetPeriodListforBackpay(string startperiod, string endperiod)
            {
            List<String> thelist = new List<string>();

            string startmonth = startperiod.Substring(4, 2);
            string endmonth = endperiod.Substring(4, 2);

            DateTime startdate = new DateTime(int.Parse(startperiod.Substring(0, 4)), int.Parse(startmonth), 1);
            DateTime enddate = new DateTime(int.Parse(endperiod.Substring(0, 4)), int.Parse(endmonth), 1);

            DateTime ddate = startdate;

            string dstartmonth = "";
            dstartmonth = "0" + ddate.Month.ToString();
            thelist.Add(ddate.Year + "" + dstartmonth);


            while (true)
                {

                if (startdate != enddate)
                    {
                    ddate = ddate.AddMonths(1);

                    string fullmonth;

                    if (ddate.Month < 10)
                        {
                        fullmonth = "0" + ddate.Month.ToString();
                        }
                    else
                        {
                        fullmonth = ddate.Month.ToString();
                        }


                    thelist.Add(ddate.Year + "" + fullmonth);

                    if (ddate == enddate)
                        {
                        break;
                        }
                    }
                else
                    {

                    string fullmonth;

                    if (ddate.Month < 10)
                        {
                        fullmonth = "0" + ddate.Month.ToString();
                        }
                    else
                        {
                        fullmonth = ddate.Month.ToString();
                        }

                    thelist.Add(ddate.Year + "" + fullmonth);
                    break;
                    }
                }

            return thelist;
            }

        private int GetTotalNumberofMonths(string startperiod, string endperiod)
            {
            string startmonth = startperiod.Substring(4, 2);
            string endmonth = endperiod.Substring(4, 2);

            DateTime startdate = new DateTime(int.Parse(startperiod.Substring(0, 4)), int.Parse(startmonth), 1);
            DateTime enddate = new DateTime(int.Parse(endperiod.Substring(0, 4)), int.Parse(endmonth), 1);

            DateTime ddate = startdate;

            int numberofmonths = 1;

            while (true)
                {

                if (startdate != enddate)
                    {
                    ddate = ddate.AddMonths(1);

                    numberofmonths += 1;

                    if (ddate == enddate)
                        {
                        break;
                        }
                    }
                else
                    {
                    numberofmonths += 1;
                    break;
                    }
                }

            return numberofmonths;

            }
        #endregion

        #region LIST INVALID NUMBERS

        public ActionResult ListInvalidNumbers()
            {
            return View("ListInvalidNumbers", new ListInvalidNumbersViewModel());
            }

        public ActionResult ListInvalidNumbers_LoadERNo(ListInvalidNumbersViewModel lv)
            {
            lv.EstablishmentName = GetEmployerName(lv.ferno);

            return View("ListInvalidNumbers", lv);
            }

        public ActionResult ListInvalidNumbers_OK(ListInvalidNumbersViewModel lv)
            {


            List<inval_cr> fullinvlist = new List<inval_cr>();


            if (lv.ListBy == "Period")
                {

                List<String> thelist = GetPeriodListforBackpay(lv.BeginPeriod, lv.EndPeriod);

                if (thelist.Count > 0)
                    {
                    foreach (String item in thelist)
                        {
                        List<inval_cr> inv = new List<inval_cr>();
                        inv = db.inval_cr.Where(b => b.ferno == lv.ferno).Where(b => b.fperiod == item).ToList();

                        if (inv.Count > 0)
                            {
                            foreach (inval_cr div in inv)
                                {
                                if (fullinvlist.Count == 0)
                                    {
                                    div.ferno = div.ferno + " - " + GetEmployerName(div.ferno);
                                    }

                                div.fssno = "10000";
                                fullinvlist.Add(div);
                                }
                            }
                        }
                    }


                }
            else
                {

                List<inval_cr> inv = new List<inval_cr>();
                inv = db.inval_cr.Where(b => b.ferno == lv.ferno).ToList();

                if (inv.Count > 0)
                    {
                    foreach (inval_cr div in inv)
                        {
                        if (fullinvlist.Count == 0)
                            {
                            div.ferno = div.ferno + " - " + GetEmployerName(div.ferno);
                            }

                        div.fssno = "10000";
                        fullinvlist.Add(div);
                        }
                    }

                }

            if (fullinvlist.Count > 0)
                {

                XtraReportListofInvalidNumbers mydocument = new XtraReportListofInvalidNumbers();

                mydocument.ListInvalidNumbersDataSource.DataSource = fullinvlist;

                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);

                }
            else
                {
                ViewBag.Message = "NO RECORD FOUND MATCHING THE SEARCH CRITERIA";
                return View("ListInvalidNumbers", lv);
                }

            }

        #endregion

        #region LIST INVALID NUMBERS BY CATEGORY

        public ActionResult ListInvalidNumbersByCategory()
            {
            return View("ListInvalidNumbersByCategory", new ListInvalidNumbersbyCategoryViewModel());
            }

        public ActionResult ListInvalidNumbersByCategory_LoadERNo(ListInvalidNumbersbyCategoryViewModel lv)
            {

            lv.EstablishmentName = GetEmployerName(lv.ferno);
            TempData["MyEmployerCategories"] = GetMyEmployerCategories(lv.ferno);

            return View("ListInvalidNumbersByCategory", lv);
            }

        public ActionResult ListInvalidNumbersByCategory_OK(ListInvalidNumbersbyCategoryViewModel lv)
            {


            List<inval_cr> fullinvlist = new List<inval_cr>();

            if (lv.ListBy == "Category")
                {

                List<inval_cr> inv = new List<inval_cr>();

                inv = db.inval_cr.Where(b => b.ferno == lv.ferno).Where(b => b.fcat == lv.fcat).Where(b => b.fperiod == lv.BeginPeriod).ToList();

                if (inv.Count > 0)
                    {
                    foreach (inval_cr div in inv)
                        {
                        if (fullinvlist.Count == 0)
                            {
                            div.ferno = div.ferno + " - " + GetEmployerName(div.ferno);
                            }

                        div.fssno = "10000";
                        fullinvlist.Add(div);
                        }
                    }
                }
            else if (lv.ListBy == "Name")
                {


                List<inval_cr> inv2 = new List<inval_cr>();
                inv2 = db.inval_cr.Where(b => b.ferno == lv.ferno).Where(b => b.firstname == lv.firstname).Where(b => b.fsurname == lv.fsurname).Where(b => b.fothername == lv.fothername).ToList();

                if (inv2.Count > 0)
                    {
                    foreach (inval_cr div in inv2)
                        {
                        if (fullinvlist.Count == 0)
                            {
                            div.ferno = div.ferno + " - " + GetEmployerName(div.ferno);
                            }

                        div.fssno = "10000";
                        fullinvlist.Add(div);
                        }
                    }
                else
                    {
                    string othername = "";
                    inv2 = db.inval_cr.Where(b => b.ferno == lv.ferno).Where(b => b.firstname == lv.firstname).Where(b => b.fsurname == lv.fsurname).Where(b => b.fothername == othername).ToList();

                    if (inv2.Count > 0)
                        {
                        foreach (inval_cr div in inv2)
                            {
                            if (fullinvlist.Count == 0)
                                {
                                div.ferno = div.ferno + " - " + GetEmployerName(div.ferno);
                                }

                            div.fssno = "10000";
                            fullinvlist.Add(div);
                            }
                        }

                    }

                }
            else
                {

                List<inval_cr> inv3 = new List<inval_cr>();
                inv3 = db.inval_cr.Where(b => b.ferno == lv.ferno).Where(b => b.fstaffno == lv.StaffNumber).ToList();

                if (inv3.Count > 0)
                    {
                    foreach (inval_cr div in inv3)
                        {
                        if (fullinvlist.Count == 0)
                            {
                            div.ferno = div.ferno + " - " + GetEmployerName(div.ferno);
                            }

                        div.fssno = "10000";
                        fullinvlist.Add(div);
                        }
                    }

                }

            if (fullinvlist.Count > 0)
                {

                XtraReportListofInvalidNumbers mydocument = new XtraReportListofInvalidNumbers();

                mydocument.ListInvalidNumbersDataSource.DataSource = fullinvlist;

                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);

                }
            else
                {
                ViewBag.Message = "NO RECORD FOUND MATCHING THE SEARCH CRITERIA";
                return View("ListInvalidNumbersByCategory", lv);
                }
            }

        #endregion

        #region MEMBER MASTER FILE SEARCH

        public ActionResult MemberMasterFileSearch()
            {

            return View("MemberMasterFileSearch", new MemberMasterFileSearchViewModel());

            }

        public ActionResult MemberMasterFileSearch_Search(MemberMasterFileSearchViewModel ms)
            {

            List<mper_mst> mlist = new List<mper_mst>();

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "";


            Query = "SELECT fssno, fref_no, fsurname, firstname, fothname, fsex From mper_mst WHERE ";

            if (ms.fref_no != null)
                {
                Query = Query + " fref_no = '" + ms.fref_no + "'";
                }
            else if (ms.fssno != null)
                {
                Query = Query + " fssno = '" + ms.fssno + "'";
                }
            else
                {
                bool andtoadded = false;

                if (ms.firstname != null)
                    {
                    Query = Query + " firstname = '" + ms.firstname + "'";
                    andtoadded = true;
                    }

                if (ms.fsurname != null)
                    {
                    if (andtoadded)
                        {
                        Query = Query + " and fsurname = '" + ms.fsurname + "'";
                        }
                    else
                        {
                        Query = Query + " fsurname = '" + ms.fsurname + "'";
                        andtoadded = true;
                        }

                    }

                if (ms.fothername != null)
                    {
                    if (andtoadded)
                        {
                        Query = Query + " and fothname = '" + ms.fothername + "'";
                        }
                    else
                        {
                        Query = Query + " fothname = '" + ms.fothername + "'";
                        }

                    }
                }



            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow item in mytable.Rows)
                    {
                    mper_mst m = new mper_mst();

                    m.fssno = item.Field<String>("fssno");
                    m.fref_no = item.Field<String>("fref_no");
                    m.firstname = item.Field<String>("firstname");

                    if (item.Field<String>("fsex") == "M")
                        {
                        m.fsex = "MALE";
                        }
                    else
                        {
                        m.fsex = "FEMALE";
                        }

                    m.fothname = item.Field<String>("fothname");
                    m.fsurname = item.Field<String>("fsurname");

                    mlist.Add(m);

                    }
                }

            TempData["SearchMemberMasterList"] = mlist;

            return View("MemberMasterFileSearch", ms);

            }


        public ActionResult MemberMasterFileSearch_Display(string id)
            {
            List<mper_mst> mp = new List<mper_mst>();
            mp = db.mper_mst.Where(b => b.fref_no == id).ToList();

            if (mp.Count > 0)
                {
                mper_mst m = new mper_mst();
                m = mp[0];

                MemberMasterFileSearchViewModel ms = new MemberMasterFileSearchViewModel();

                ms.fsurname = m.fsurname;
                ms.fothername = m.fothname;
                ms.firstname = m.firstname;

                if (m.fsex == "M")
                    {
                    ms.sex = "MALE";
                    }
                else
                    {
                    ms.sex = "FEMALE";
                    }

                ms.fssno = m.fssno;
                ms.fref_no = m.fref_no;

                ms.province = GetProvinceName(m.fprovince);
                ms.district = GetDistrictName(m.fprovince, m.fdist);
                ms.chiefdom = GetChiefdomName(m.fprovince, m.fdist, m.fchief);
                ms.town = m.ftown;

                ms.dateofbirth = m.fb_date;

                return View("MemberMasterFileSearch", ms);

                }
            else
                {
                ViewBag.Message = "NO RECORD FOUND. PLEASE VERIFY TRY AGAIN.";
                return View("MemberMasterFileSearch", new MemberMasterFileSearchViewModel());
                }

            }

        private string GetProvinceName(string code)
            {
            List<province> list = new List<province>();
            list = db.provinces.Where(b => b.fcode == code).ToList();

            if (list.Count > 0)
                {

                return list[0].fdesc;
                }
            else
                {
                return "";
                }
            }


        private string GetDistrictName(string provincecode, string districtcode)
            {
            List<district> list = new List<district>();
            list = db.districts.Where(b => b.d_code == districtcode).Where(b => b.p_code == provincecode).ToList();

            if (list.Count > 0)
                {

                return list[0].d_desc;
                }
            else
                {
                return "";
                }
            }

        private string GetChiefdomName(string provincecode, string districtcode, string chiefdomcode)
            {
            List<chiefdom> list = new List<chiefdom>();
            list = db.chiefdoms.Where(b => b.fd_code == districtcode).Where(b => b.fp_code == provincecode).Where(b => b.fc_code == chiefdomcode).ToList();

            if (list.Count > 0)
                {

                return list[0].fdescr;
                }
            else
                {
                return "";
                }
            }


        #endregion

        #region MEMBER IDENTIFICATION

        public ActionResult MemberIdentification()
            {

            return View("MemberIdentification", new CaptureMemRegViewModel());

            }

        public ActionResult MemberIdentification_Search(CaptureMemRegViewModel memb)
            {
            try
                {

                var ssno = Request["fssno2"];

                if (TempData.Peek("MyProvinces") == null)
                    {
                    TempData["MyProvinces"] = GetMyProvinces();
                    }

                if (TempData.Peek("MyDistricts") == null)
                    {
                    TempData["MyDistricts"] = GetMyDistrict();
                    }

                if (TempData.Peek("MyChiefdoms") == null)
                    {
                    TempData["MyChiefdoms"] = GetMyChiefdom();
                    }

                if (TempData.Peek("MyEmployers") == null)
                    {
                    TempData["MyEmployers"] = GetMyEmployers();
                    }

                if (TempData.Peek("MyOccupations") == null)
                    {
                    TempData["MyOccupations"] = GetMyOccupations();
                    }

                if (ssno != null)
                    {

                    List<mper_mst> mt = new List<mper_mst>();
                    mt = db.mper_mst.Where(r => r.fssno == ssno).ToList();

                    CaptureMemRegViewModel mvm = new CaptureMemRegViewModel();

                    if (mt.Count == 0) return View("MemberIdentification");

                    string refno = mt[0].fref_no;

                    mvm.fref_no = mt[0].fref_no;
                    mvm.firstname = mt[0].firstname;
                    mvm.fothname = mt[0].fothname;
                    mvm.fsurname = mt[0].fsurname;
                    mvm.fb_date = mt[0].fb_date;
                    mvm.fjoindate = mt[0].fjoindate;
                    //mvm.fbatch = mt[0].fbatch;

                    //mvm.fbatch = mt[0].fbatch;
                    mvm.fb_country = mt[0].fb_country;

                    mvm.fchief = mt[0].fchief;
                    mvm.fcur_addr = mt[0].fcur_addr;
                    mvm.fdist = mt[0].fdist;
                    mvm.femp_addr = mt[0].femp_addr;
                    mvm.femp_name = mt[0].femp_name;
                    mvm.ferno = mt[0].ferno;

                    //mvm.fgen_date = mt[0].fgen_date;
                    //mvm.fgov_code = mt[0].fgov_code;

                    mvm.fincome = mt[0].fincome;
                    mvm.fm_stat = mt[0].fm_stat;
                    mvm.fnation = mt[0].fnation;
                    mvm.fnat_income = mt[0].fnat_incom;
                    mvm.foccupation = mt[0].foccupatio;
                    mvm.fper_addr = mt[0].fper_addr;
                    mvm.fprovince = mt[0].fprovince;
                    //mvm.freg_date = mt[0].freg_date;
                    mvm.fsex = mt[0].fsex;

                    mvm.fssno = mt[0].fssno;

                    mvm.ftel_no = mt[0].ftel_no;
                    mvm.ftown = mt[0].ftown;
                    //mvm.ID_SBTS = mt[0].ID_SBTS;

                    mvm.ModifiedBy = "DEFAULT";
                    mvm.ModifiedOn = DateTime.Today;


                    //GET PARENTS INFORMATION 
                    List<paren_mst> p = new List<paren_mst>();
                    p = db.paren_mst.Where(b => b.fref_no == refno).ToList();

                    if (p.Count > 0)
                        {
                        mvm.ffirstname = p[0].ffirstname;
                        mvm.ffothname = p[0].ffothname;
                        mvm.ffsurname = p[0].ffsurname;

                        mvm.fmfirstname = p[0].fmfirstnam;
                        mvm.fmothname = p[0].fmothname;
                        mvm.fmsurname = p[0].fmsurname;
                        }


                    List<prevn_mst> prev = new List<prevn_mst>();
                    prev = db.prevn_mst.Where(r => r.fref_no == refno).ToList();
                    prevn_mst previous = new prevn_mst();

                    if (prev.Count > 0)
                        {

                        previous = prev[0];
                        mvm.fpfirstname = previous.fpfirstnam;
                        mvm.fpothname = previous.fpothname;
                        mvm.fpsurname = previous.fpsurname;

                        }


                    if (mt.Count > 0)
                        {
                        return View("MemberIdentification", mvm);
                        }
                    else
                        {
                        return View("MemberIdentification");
                        }

                    }
                return View("MemberIdentification");
                }
            catch (Exception)
                {

                throw;
                }
            }


        [HttpPost]
        public ActionResult MemberIdentificationtoDependants(CaptureMemRegViewModel c)
            {
            try
                {

                TempData["SSNo"] = c.fssno;

                TempData["MemberEditReferenceNo"] = c.fref_no;

                if (TempData["MyRelations"] == null)
                    {
                    TempData["MyRelations"] = GetMyRelations();
                    }

                return RedirectToAction("EditDependants");
                }
            catch
                {
                throw;
                //return View();
                }
            }


        [HttpGet]
        public ActionResult EditDependants()
            {
            try
                {

                string refno = TempData.Peek("MemberEditReferenceNo").ToString();
                List<nom_mst> d = new List<nom_mst>();
                d = db.nom_mst.Where(b => b.fref_no == refno).ToList();

                return View("MemberIdentificationDependantEdit", d[0]);

                }
            catch (Exception)
                {
                return View("MemberIdentificationDependantEdit");
                }

            }


        [HttpGet]
        public ActionResult StartEditDependants(int id)
            {
            try
                {

                nom_mst dep = new nom_mst();
                dep = db.nom_mst.Find(id);

                return View("MemberIdentificationDependantEdit", dep);

                }
            catch (Exception)
                {
                return View("MemberIdentificationDependantEdit");
                }

            }


        public List<PDCTemplate> GetMyOccupations()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fcode, fdescr From occupate";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<Province> provinces = db.Provinces.SqlQuery("SELECT ID_SBTS, fcode, fdesc From Province").ToList(); 

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("fcode");
                    ct.Name = myp.Field<String>("fdescr");

                    mylist.Add(ct);

                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }

        //public ActionResult FilterDistrict(string Province)
        //    {

        //    TempData["MyDistricts"] = GetMyDistrict(Province);
        //    }

        public List<PDCTemplate> GetMyProvinces()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fcode, fdesc From Province";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<Province> provinces = db.Provinces.SqlQuery("SELECT ID_SBTS, fcode, fdesc From Province").ToList(); 

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("fcode");
                    ct.Name = myp.Field<String>("fdesc");

                    mylist.Add(ct);

                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }


        public List<PDCTemplate> GetMyDistrict(string provincecode = "")
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query;

            if (provincecode == "")
                {
                Query = "SELECT d_code, d_desc From District";
                }
            else
                {
                Query = "SELECT d_code, d_desc From District where p_code = '" + provincecode + "'";
                }

            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<District> district = db.Districts.SqlQuery("SELECT ID_SBTS, d_code, d_desc From District").ToList();

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("d_code");
                    ct.Name = myp.Field<String>("d_desc");

                    mylist.Add(ct);
                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }



        public List<PDCTemplate> GetMyChiefdom(string districtcode = "", string provincecode = "")
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query;

            if (provincecode == "")
                {
                Query = "SELECT fc_code, fdescr From Chiefdom ORDER BY fc_code ASC";
                }
            else
                {
                Query = "SELECT fc_code, fdescr From Chiefdom where fp_code = '" + provincecode + "' and fd_code = '" + districtcode + "' ORDER BY fc_code ASC";
                }


            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<Chiefdom> chiefdom = db.Chiefdoms.SqlQuery("SELECT ID_SBTS, fc_code, fdescr From Chiefdom ORDER BY fc_code ASC").ToList();

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("fc_code");
                    ct.Name = myp.Field<String>("fdescr");

                    mylist.Add(ct);
                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }


        public List<EmployerTemplate> GetMyEmployers()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT TOP 20 ferno, femp_name, faddress1, faddress2, ftown, ftelno From emp_mst";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            List<EmployerTemplate> mylist = new List<EmployerTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    EmployerTemplate ct = new EmployerTemplate();
                    ct.Code = myp.Field<String>("ferno");
                    ct.Name = myp.Field<String>("femp_name");
                    ct.Address = String.Format("{0}, {1}, {2}", myp.Field<String>("faddress1"), myp.Field<String>("faddress2"), myp.Field<String>("ftown"));
                    ct.TelNo = myp.Field<String>("ftelno");

                    mylist.Add(ct);

                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }


        public List<PDCTemplate> GetMyRelations()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT frel_code, frel_desc From rel_mst";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<RelativesTypesMaster> relations = db.RelativesTypesMasters.SqlQuery("SELECT frel_code, frel_desc From RelativesTypesMaster").ToList();
            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("frel_code");
                    ct.Name = myp.Field<String>("frel_desc").ToString().Trim();

                    mylist.Add(ct);
                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }


        #endregion

        #region LIST OF ESTABLISHMENT WITH VALID NUMBERS

        public ActionResult ListofEstWithValidNos()
            {
            TempData["MyAreaOffices"] = GetMyZones();

            return View("ListofEstWithValidNos", new ListofEstWithValidNumViewModel());
            }


        public ActionResult ListofEstWithValidNos_Print(ListofEstWithValidNumViewModel li)
            {

            List<ListofEstWithValidNumViewModel> elist = new List<ListofEstWithValidNumViewModel>();

            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.floc == li.areaoffice).ToList();

            if (emp.Count > 0)
                {

                foreach (emp_mst item in emp)
                    {
                    ListofEstWithValidNumViewModel e = new ListofEstWithValidNumViewModel();
                    e.establishment = item.femp_name;
                    e.ferno = item.ferno;
                    e.LF = GetTotalLabourForce(item.ferno);

                    if (elist.Count == 0)
                        {
                        e.areaoffice = GetZoneName(item.floc);
                        }
                    else
                        {
                        e.areaoffice = elist[0].areaoffice;
                        }

                    elist.Add(e);

                    }

                XtraReportListofEstwithValidNos mydocument = new XtraReportListofEstwithValidNos();

                mydocument.ListofEstValidNosDataSource.DataSource = elist;

                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);

                }
            else
                {
                ViewBag.Message = "NO ESTABLISHMENT RECORD WAS FOUND FOR THE SELECTED AREA OFFICE";
                }

            return View("PrintPreview");
            }


        private int GetTotalLabourForce(string ERNo)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT Count(ID_SBTS) AS Total From mper_mst WHERE ferno = '" + ERNo + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                int? Total = mytable.Rows[0].Field<int?>("Total");

                if (Total == null)
                    {
                    return 0;
                    }
                else
                    {
                    return Total.Value;
                    }

                }
            return 0;

            }


        private string GetZoneName(string zonecode)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fzone_name From zone_cod WHERE fzone = '" + zonecode.Substring(1, 2) + "' and fzone_name like '" + zonecode.Substring(0, 1) + "%'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string zonename = mytable.Rows[0].Field<String>("fzone_name");

                return zonename;

                }

            return "";

            }

        public List<PDCTemplate> GetMyZones()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT floc, floc_name From dist_loc";

            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("floc");
                    ct.Name = myp.Field<String>("floc_name");

                    mylist.Add(ct);
                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }
        #endregion

        #region REVERSE CAPTURED CONTRIBUTION RECORDS

        public ActionResult ReverseCapturedContribution()
            {

            return View("ReverseCapturedContribution", new ReverseCapturedContributionViewModel());

            }

        public ActionResult ReverseCapturedContribution_LoadERNo(ReverseCapturedContributionViewModel rv)
            {

            TempData["MyEmployerCategories"] = GetMyEmployerCategories(rv.ferno);

            rv.establishment = GetEmployerName(rv.ferno);

            return View("ReverseCapturedContribution", rv);

            }


        public ActionResult ReverseCapturedContribution_OK(ReverseCapturedContributionViewModel rv)
            {


            if (rv.fcat == null)
                {
                ViewBag.Message = "Please select the Staff Category before proceeding.";
                return View("ReverseCapturedContribution", rv);
                }


            if (rv.ftype == "Regular")
                {
                string thetype = "R";

                List<empcr_tr> empcr = new List<empcr_tr>();
                empcr = db.empcr_tr.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype_cr == thetype).Where(b => b.fperiod == rv.beginperiod).ToList();

                if (empcr.Count > 0)
                    {
                    foreach (empcr_tr item in empcr)
                        {
                        db.empcr_tr.Attach(item);
                        var entry = db.Entry(item);
                        entry.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        }

                    }


                List<memcr_tr> memcr = new List<memcr_tr>();
                memcr = db.memcr_tr.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype_cr == thetype).Where(b => b.fperiod == rv.beginperiod).ToList();

                if (memcr.Count > 0)
                    {
                    foreach (memcr_tr item in memcr)
                        {
                        db.memcr_tr.Attach(item);
                        var entry = db.Entry(item);
                        entry.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        }

                    }

                List<memcr_h> memcrh = new List<memcr_h>();
                memcrh = db.memcr_h.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype_cr == thetype).Where(b => b.fperiod == rv.beginperiod).ToList();

                if (memcrh.Count > 0)
                    {
                    foreach (memcr_h item in memcrh)
                        {
                        db.memcr_h.Attach(item);
                        var entry = db.Entry(item);
                        entry.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        }

                    }

                List<inval_cr> incalcr = new List<inval_cr>();
                incalcr = db.inval_cr.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype_cr == thetype).Where(b => b.fperiod == rv.beginperiod).ToList();

                if (incalcr.Count > 0)
                    {
                    foreach (inval_cr item in incalcr)
                        {
                        db.inval_cr.Attach(item);
                        var entry = db.Entry(item);
                        entry.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        }

                    }


                List<crsreg> crsr = new List<crsreg>();
                crsr = db.crsregs.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype == thetype).Where(b => b.fperiod == rv.beginperiod).ToList();

                if (crsr.Count > 0)
                    {
                    foreach (crsreg item in crsr)
                        {
                        db.crsregs.Attach(item);
                        var entry = db.Entry(item);
                        entry.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        }

                    }


                List<mem_stmt> memst = new List<mem_stmt>();
                string theyear = rv.beginperiod.Substring(0, 4);
                memst = db.mem_stmt.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype == thetype).Where(b => b.fyear == theyear).ToList();

                if (memst.Count > 0)
                    {
                    foreach (mem_stmt item in memst)
                        {

                        string themonth = rv.beginperiod.Substring(4, 2);

                        switch (themonth)
                            {

                            case "01":
                                item.fjancr = 0;
                                break;
                            case "02":
                                item.ffebcr = 0;
                                break;
                            case "03":
                                item.fmarcr = 0;
                                break;
                            case "04":
                                item.faprcr = 0;
                                break;
                            case "05":
                                item.fmaycr = 0;
                                break;
                            case "06":
                                item.fjuncr = 0;
                                break;
                            case "07":
                                item.fjulcr = 0;
                                break;
                            case "08":
                                item.faugcr = 0;
                                break;
                            case "09":
                                item.fsepcr = 0;
                                break;
                            case "10":
                                item.foctcr = 0;
                                break;
                            case "11":
                                item.fnovcr = 0;
                                break;
                            case "12":
                                item.fdeccr = 0;
                                break;

                            default:
                                break;
                            }


                        db.mem_stmt.Attach(item);
                        var entry = db.Entry(item);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        }

                    }

                }
            else if (rv.ftype == "Backpay")
                {
                string thetype = "B";

                List<empcr_tr> empcr = new List<empcr_tr>();
                empcr = db.empcr_tr.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype_cr == thetype).Where(b => b.fperiod == rv.debit).ToList();

                if (empcr.Count > 0)
                    {
                    foreach (empcr_tr item in empcr)
                        {
                        db.empcr_tr.Attach(item);
                        var entry = db.Entry(item);
                        entry.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        }

                    //DO A RECOMPILE ON ferno and debit
                    }




                List<String> perlist = new List<string>();
                perlist = GetPeriodListforBackpay(rv.beginperiod, rv.endperiod);

                foreach (String period in perlist)
                    {

                    List<memcr_tr> memcr = new List<memcr_tr>();
                    memcr = db.memcr_tr.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype_cr == thetype).Where(b => b.fperiod == period).ToList();

                    if (memcr.Count > 0)
                        {
                        foreach (memcr_tr item in memcr)
                            {
                            db.memcr_tr.Attach(item);
                            var entry = db.Entry(item);
                            entry.State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();
                            }

                        }


                    }


                foreach (String period in perlist)
                    {

                    List<memcr_h> memcrh = new List<memcr_h>();
                    memcrh = db.memcr_h.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype_cr == thetype).Where(b => b.fperiod == period).ToList();

                    if (memcrh.Count > 0)
                        {
                        foreach (memcr_h item in memcrh)
                            {
                            db.memcr_h.Attach(item);
                            var entry = db.Entry(item);
                            entry.State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();
                            }

                        }


                    }


                foreach (String period in perlist)
                    {

                    List<inval_cr> invl = new List<inval_cr>();
                    invl = db.inval_cr.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype_cr == thetype).Where(b => b.fperiod == period).ToList();

                    if (invl.Count > 0)
                        {
                        foreach (inval_cr item in invl)
                            {
                            db.inval_cr.Attach(item);
                            var entry = db.Entry(item);
                            entry.State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();
                            }

                        }


                    }


                foreach (String period in perlist)
                    {

                    List<crsreg> crsr = new List<crsreg>();
                    crsr = db.crsregs.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype == thetype).Where(b => b.fperiod == period).ToList();

                    if (crsr.Count > 0)
                        {
                        foreach (crsreg item in crsr)
                            {
                            db.crsregs.Attach(item);
                            var entry = db.Entry(item);
                            entry.State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();
                            }

                        }


                    }



                foreach (String period in perlist)
                    {

                    List<mem_stmt> memst = new List<mem_stmt>();
                    string theyear = period.Substring(0, 4);
                    memst = db.mem_stmt.Where(b => b.ferno == rv.ferno).Where(b => b.fcat == rv.fcat).Where(b => b.ftype == thetype).Where(b => b.fyear == theyear).ToList();

                    if (memst.Count > 0)
                        {
                        foreach (mem_stmt item in memst)
                            {

                            string themonth = rv.beginperiod.Substring(4, 2);

                            switch (themonth)
                                {

                                case "01":
                                    item.fjancr = 0;
                                    break;
                                case "02":
                                    item.ffebcr = 0;
                                    break;
                                case "03":
                                    item.fmarcr = 0;
                                    break;
                                case "04":
                                    item.faprcr = 0;
                                    break;
                                case "05":
                                    item.fmaycr = 0;
                                    break;
                                case "06":
                                    item.fjuncr = 0;
                                    break;
                                case "07":
                                    item.fjulcr = 0;
                                    break;
                                case "08":
                                    item.faugcr = 0;
                                    break;
                                case "09":
                                    item.fsepcr = 0;
                                    break;
                                case "10":
                                    item.foctcr = 0;
                                    break;
                                case "11":
                                    item.fnovcr = 0;
                                    break;
                                case "12":
                                    item.fdeccr = 0;
                                    break;

                                default:
                                    break;
                                }


                            db.mem_stmt.Attach(item);
                            var entry = db.Entry(item);
                            entry.State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            }

                        }

                    }


                }

            ViewBag.Message = "CONTRIBUTION REPORT SUCCESSFULLY REVERSED FOR " + rv.beginperiod;
            return View("ReverseCapturedContribution", rv);

            }

        #endregion

        #region CORRECT INVALID NUMBERS

        public ActionResult CorrectInvalidNumbers()
            {



            return View("CorrectInvalidNumbers", new CorrectInvalidNosViewModel());
            }


        public ActionResult CorrectInvalidNumbers_LoadERno(CorrectInvalidNosViewModel ci)
            {

            string festname = GetEmployerName(ci.ferno);

            if (festname != null && festname != "")
                {
                TempData["MyEmployerCategories"] = GetMyEmployerCategories(ci.ferno);

                ci.establishment = festname;

                List<hist_mst> hm = new List<hist_mst>();
                hm = db.hist_mst.Where(b => b.ferno == ci.ferno).Where(b => b.fssno == ci.validssno).ToList();

                if (hm.Count > 0)
                    {
                    string fullname = hm[0].fsurname + ", " + hm[0].firstname + " " + hm[0].fothername;
                    ViewBag.Message = "GIVEN NUMBER IS ALREADY IN USE BY " + fullname + ". DO YOU STILL WISH TO PROCEED?";
                    }

                }
            else
                {

                ViewBag.Message = "GIVEN ESTABLISHMENT NUMBER IS NOT ON FILE";

                }

            return View("CorrectInvalidNumbers", ci);
            }


        public ActionResult CorrectInvalidNumbers_Validate(CorrectInvalidNosViewModel ci)
            {

            if (ci.usetype == "SSNO")
                {

                List<hist_mst> hm = new List<hist_mst>();
                hm = db.hist_mst.Where(b => b.ferno == ci.ferno).Where(b => b.fssno == ci.ssno).ToList();

                if (hm.Count > 0)
                    {
                    string fullname = hm[0].fsurname + ", " + hm[0].firstname + " " + hm[0].fothername;
                    ViewBag.Validation = "Validation - SUCCESSFUL";
                    ViewBag.ValidationMessage = "Name: " + fullname;
                    }
                else
                    {
                    ViewBag.Validation = "Validation - FAILED";
                    ViewBag.ValidationMessage = "NO RECORD WAS FOUND";
                    }

                }
            else if (ci.usetype == "STAFFNO")
                {

                List<hist_mst> hm = new List<hist_mst>();
                hm = db.hist_mst.Where(b => b.ferno == ci.ferno).Where(b => b.fstaffno == ci.staffno).ToList();

                if (hm.Count > 0)
                    {
                    string fullname = hm[0].fsurname + ", " + hm[0].firstname + " " + hm[0].fothername;
                    ViewBag.Validation = "Validation - SUCCESSFUL";
                    ViewBag.ValidationMessage = "Name: " + fullname;
                    }
                else
                    {
                    ViewBag.Validation = "Validation - FAILED";
                    ViewBag.ValidationMessage = "NO RECORD WAS FOUND";
                    }


                }
            else if (ci.usetype == "NAME")
                {
                List<hist_mst> hm = new List<hist_mst>();

                hm = db.hist_mst.Where(b => b.ferno == ci.ferno).Where(b => b.firstname == ci.firstname).Where(b => b.fsurname == ci.fsurname).Where(b => b.fothername == ci.fothername).ToList();

                if (hm.Count > 0)
                    {
                    string fullname = hm[0].fsurname + ", " + hm[0].firstname + " " + hm[0].fothername;
                    ViewBag.Validation = "Validation - SUCCESSFULL";
                    ViewBag.ValidationMessage = "Name: " + fullname;
                    }
                else
                    {

                    string othername = "";

                    hm = db.hist_mst.Where(b => b.ferno == ci.ferno).Where(b => b.firstname == ci.firstname).Where(b => b.fsurname == ci.fsurname).Where(b => b.fothername == othername).ToList();

                    if (hm.Count > 0)
                        {
                        string fullname = hm[0].fsurname + ", " + hm[0].firstname + " " + hm[0].fothername;
                        ViewBag.Validation = "Validation - SUCCESSFULL";
                        ViewBag.ValidationMessage = "Name: " + fullname;

                        }
                    else
                        {
                        ViewBag.Validation = "Validation - FAILED";
                        ViewBag.ValidationMessage = "NO RECORD WAS FOUND";
                        }


                    }
                }

            return View("CorrectInvalidNumbers", ci);
            }


        public ActionResult CorrectInvalidNumbers_LoadSSNo(CorrectInvalidNosViewModel ci)
            {

            if (CheckifSSNoisValid(ci.validssno))
                {

                List<mper_mst> mpe = new List<mper_mst>();
                mpe = db.mper_mst.Where(b => b.fssno == ci.validssno).ToList();

                if (mpe.Count > 0)
                    {
                    ci.fname = mpe[0].fsurname + ", " + mpe[0].firstname + " " + mpe[0].fothname;
                    }

                }
            else
                {
                ViewBag.Message = "WRONG S.S. NUMBER. PLEASE VERIFY.";
                }

            return View("CorrectInvalidNumbers", ci);
            }

        public ActionResult CorrectInvalidNumbers_OK(CorrectInvalidNosViewModel ci)
            {


            if (ci.usetype == "SSNO")
                {

                List<hist_mst> hm = new List<hist_mst>();
                hm = db.hist_mst.Where(b => b.ferno == ci.ferno).Where(b => b.fssno == ci.ssno).ToList();

                if (hm.Count > 0)
                    {
                    foreach (hist_mst item in hm)
                        {
                        item.fssno = ci.validssno;

                        db.hist_mst.Attach(item);
                        var entry = db.Entry(item);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }

                    }


                List<inval_cr> inv = new List<inval_cr>();
                inv = db.inval_cr.Where(b => b.ferno == ci.ferno).Where(b => b.fcat == ci.fcat).Where(b => b.fssno == ci.ssno).ToList();

                if (inv.Count > 0)
                    {
                    foreach (inval_cr item in inv)
                        {
                        string mtype = item.ftype_cr;
                        string mperiod = item.fperiod;

                        if (ValidateMemberStatementPresence(ci.validssno, ci.ferno, mperiod, mtype))
                            {
                            ViewBag.Message = "GIVEN MEMBER ALREADY HAS A CREDIT ON FILE. DO YOU STILL WITH TO CONTINUE?";
                            }
                        else
                            {

                            }


                        List<memcr_tr> mcr = new List<memcr_tr>();
                        mcr = db.memcr_tr.Where(b => b.ferno == ci.ferno).Where(b => b.fcat == ci.fcat).Where(b => b.fssno == ci.validssno).Where(b => b.ftype_cr == mtype).Where(b => b.fperiod == mperiod).ToList();

                        if (mcr.Count == 0)
                            {
                            memcr_tr m = new memcr_tr();
                            m.fssno = ci.validssno;
                            m.ferno = ci.ferno;
                            m.ftype_cr = mtype;
                            m.fcat = ci.fcat;
                            m.fsurname = item.fsurname;
                            m.fothername = item.fothername;
                            m.firstname = item.firstname;
                            m.fperiod = mperiod;
                            m.fcontr = item.famount.Value;
                            m.fflag = true;

                            m.CreatedBy = Session["AccountID"].ToString();
                            m.CreatedOn = DateTime.Today;

                            m.ModifiedBy = Session["AccountID"].ToString();
                            m.ModifiedOn = DateTime.Today;

                            db.memcr_tr.Add(m);
                            db.SaveChanges();

                            }


                        }

                    ViewBag.Message = "Member Invalid Contribution Records were successfully updated.";

                    }
                else
                    {
                    ViewBag.Message = "THERE IS NO TRANSACTION FOR THE GIVEN MEMBER AND PERIOD";
                    }

                }
            else if (ci.usetype == "STAFFNO")
                {

                List<hist_mst> hm = new List<hist_mst>();
                hm = db.hist_mst.Where(b => b.ferno == ci.ferno).Where(b => b.fstaffno == ci.staffno).ToList();

                if (hm.Count > 0)
                    {
                    foreach (hist_mst item in hm)
                        {
                        item.fssno = ci.validssno;

                        db.hist_mst.Attach(item);
                        var entry = db.Entry(item);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }

                    }


                List<inval_cr> inv = new List<inval_cr>();
                inv = db.inval_cr.Where(b => b.ferno == ci.ferno).Where(b => b.fcat == ci.fcat).Where(b => b.fstaffno == ci.staffno).ToList();

                if (inv.Count > 0)
                    {
                    foreach (inval_cr item in inv)
                        {
                        string mtype = item.ftype_cr;
                        string mperiod = item.fperiod;

                        if (ValidateMemberStatementPresence(ci.validssno, ci.ferno, mperiod, mtype))
                            {
                            ViewBag.Message = "GIVEN MEMBER ALREADY HAS A CREDIT ON FILE. DO YOU STILL WITH TO CONTINUE?";
                            }
                        else
                            {

                            }


                        List<memcr_tr> mcr = new List<memcr_tr>();
                        mcr = db.memcr_tr.Where(b => b.ferno == ci.ferno).Where(b => b.fcat == ci.fcat).Where(b => b.fssno == ci.validssno).Where(b => b.ftype_cr == mtype).Where(b => b.fperiod == mperiod).ToList();

                        if (mcr.Count == 0)
                            {
                            memcr_tr m = new memcr_tr();
                            m.fssno = ci.validssno;
                            m.ferno = ci.ferno;
                            m.ftype_cr = mtype;
                            m.fcat = ci.fcat;
                            m.fsurname = item.fsurname;
                            m.fothername = item.fothername;
                            m.firstname = item.firstname;
                            m.fperiod = mperiod;
                            m.fcontr = item.famount.Value;
                            m.fflag = true;

                            m.CreatedBy = Session["AccountID"].ToString();
                            m.CreatedOn = DateTime.Today;

                            m.ModifiedBy = Session["AccountID"].ToString();
                            m.ModifiedOn = DateTime.Today;

                            db.memcr_tr.Add(m);
                            db.SaveChanges();

                            }


                        }

                    ViewBag.Message = "Member Invalid Contribution Records were successfully updated.";


                    }
                else
                    {
                    ViewBag.Message = "THERE IS NO TRANSACTION FOR THE GIVEN MEMBER AND PERIOD";
                    }



                }
            else if (ci.usetype == "NAME")
                {



                List<hist_mst> hm = new List<hist_mst>();
                hm = db.hist_mst.Where(b => b.ferno == ci.ferno).Where(b => b.firstname == ci.firstname).Where(b => b.fothername == ci.fothername).Where(b => b.fsurname == ci.fsurname).ToList();

                if (hm.Count > 0)
                    {
                    foreach (hist_mst item in hm)
                        {
                        item.fssno = ci.validssno;

                        db.hist_mst.Attach(item);
                        var entry = db.Entry(item);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }

                    }
                else
                    {
                    string othername = "";

                    hm = db.hist_mst.Where(b => b.ferno == ci.ferno).Where(b => b.firstname == ci.firstname).Where(b => b.fsurname == ci.fsurname).Where(b => b.fothername == othername).ToList();

                    if (hm.Count > 0)
                        {
                        foreach (hist_mst item in hm)
                            {
                            item.fssno = ci.validssno;

                            db.hist_mst.Attach(item);
                            var entry = db.Entry(item);
                            entry.State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            }

                        }

                    }

                List<inval_cr> inv = new List<inval_cr>();
                inv = db.inval_cr.Where(b => b.ferno == ci.ferno).Where(b => b.fcat == ci.fcat).Where(b => b.firstname == ci.firstname).Where(b => b.fothername == ci.fothername).Where(b => b.fsurname == ci.fsurname).ToList();

                if (inv.Count > 0)
                    {
                    foreach (inval_cr item in inv)
                        {
                        string mtype = item.ftype_cr;
                        string mperiod = item.fperiod;

                        if (ValidateMemberStatementPresence(ci.validssno, ci.ferno, mperiod, mtype))
                            {
                            ViewBag.Message = "GIVEN MEMBER ALREADY HAS A CREDIT ON FILE. DO YOU STILL WITH TO CONTINUE?";
                            }
                        else
                            {

                            }


                        List<memcr_tr> mcr = new List<memcr_tr>();
                        mcr = db.memcr_tr.Where(b => b.ferno == ci.ferno).Where(b => b.fcat == ci.fcat).Where(b => b.fssno == ci.validssno).Where(b => b.ftype_cr == mtype).Where(b => b.fperiod == mperiod).ToList();

                        if (mcr.Count == 0)
                            {
                            memcr_tr m = new memcr_tr();
                            m.fssno = ci.validssno;
                            m.ferno = ci.ferno;
                            m.ftype_cr = mtype;
                            m.fcat = ci.fcat;
                            m.fsurname = item.fsurname;
                            m.fothername = item.fothername;
                            m.firstname = item.firstname;
                            m.fperiod = mperiod;
                            m.fcontr = item.famount.Value;
                            m.fflag = true;

                            m.CreatedBy = Session["AccountID"].ToString();
                            m.CreatedOn = DateTime.Today;

                            m.ModifiedBy = Session["AccountID"].ToString();
                            m.ModifiedOn = DateTime.Today;

                            db.memcr_tr.Add(m);
                            db.SaveChanges();

                            }


                        }

                    ViewBag.Message = "Member Invalid Contribution Records were successfully updated.";


                    }
                else
                    {
                    ViewBag.Message = "THERE IS NO TRANSACTION FOR THE GIVEN MEMBER AND PERIOD";
                    }


                }


            return View("CorrectInvalidNumbers", ci);
            }


        private bool ValidateMemberStatementPresence(string SSNo, string ferno, string period, string ftype)
            {
            string themonth = period.Substring(4, 2);

            List<mem_stmt> ms = new List<mem_stmt>();
            ms = db.mem_stmt.Where(p => p.fssno == SSNo).Where(p => p.ferno == ferno).Where(p => p.ftype == ftype).ToList();

            if (ms.Count > 0)
                {
                mem_stmt membst = new mem_stmt();
                membst = ms[0];

                if (membst.fjancr.HasValue) { if (membst.fjancr.Value > 0) return true; }
                if (membst.ffebcr.HasValue) { if (membst.ffebcr.Value > 0) return true; }
                if (membst.fmarcr.HasValue) { if (membst.fmarcr.Value > 0) return true; }
                if (membst.faprcr.HasValue) { if (membst.faprcr.Value > 0) return true; }
                if (membst.fmaycr.HasValue) { if (membst.fmaycr.Value > 0) return true; }
                if (membst.fjuncr.HasValue) { if (membst.fjuncr.Value > 0) return true; }
                if (membst.fjulcr.HasValue) { if (membst.fjulcr.Value > 0) return true; }
                if (membst.faugcr.HasValue) { if (membst.faugcr.Value > 0) return true; }
                if (membst.fsepcr.HasValue) { if (membst.fsepcr.Value > 0) return true; }
                if (membst.foctcr.HasValue) { if (membst.foctcr.Value > 0) return true; }
                if (membst.fnovcr.HasValue) { if (membst.fnovcr.Value > 0) return true; }
                if (membst.fdeccr.HasValue) { if (membst.fdeccr.Value > 0) return true; }

                }

            return false;
            }



        #endregion

        #region CHANGE STAFF CATEGORY

        public ActionResult ChangeStaffCategory()
            {

            TempData["MyEmployerCategories"] = null;
            TempData["ChangeCategoryList"] = null;
            TempData["ChangeCategoryLoad"] = null;

            return View("ChangeStaffCategory", new ChangeStaffCategoryViewModel());

            }

        public ActionResult ChangeStaffCategory_LoadERNo(ChangeStaffCategoryViewModel cs)
            {

            cs.establishment = GetEmployerName(cs.ferno);

            TempData["ChangeCategoryLoad"] = null;

            TempData["Change_Ferno"] = cs.ferno;
            TempData["Change_Establishment"] = cs.establishment;

            TempData["MyEmployerCategories"] = GetMyEmployerCategories(cs.ferno);

            List<ChangeStaffCategoryListViewModel> css = new List<ChangeStaffCategoryListViewModel>();


            List<hist_mst> hms = new List<hist_mst>();
            hms = db.hist_mst.Where(b => b.ferno == cs.ferno).OrderBy(b => b.fcat).ToList();

            if (hms.Count > 0)
                {
                foreach (hist_mst item in hms)
                    {

                    ChangeStaffCategoryListViewModel c = new ChangeStaffCategoryListViewModel();

                    c.establishment = cs.establishment;
                    c.firstname = item.firstname;
                    c.fothername = item.fothername;
                    c.fsurname = item.fsurname;
                    c.ferno = item.ferno;
                    c.fcurrentcat = item.fcat;
                    c.fcontribution = item.fcur_cr;
                    c.fperiod = item.frstcr_perd;

                    c.recordid = item.ID_SBTS;

                    css.Add(c);

                    }

                TempData["ChangeCategoryList"] = css;

                }
            else
                {

                ViewBag.Message = "GIVEN ESTABLISHMENT IS NOT ON HISTORY FILE";
                TempData["ChangeCategoryList"] = null;
                }


            return View("ChangeStaffCategory", cs);
            }


        public ActionResult ChangeStaffCategory_ChangeLoad(int id)
            {

            string ferno;
            string establishment;

            ChangeStaffCategoryViewModel cs = new ChangeStaffCategoryViewModel();

            hist_mst hm = new hist_mst();
            hm = db.hist_mst.Find(id);

            if (hm.ID_SBTS != 0)
                {
                cs.recordid = hm.ID_SBTS.ToString();
                cs.ferno = hm.ferno;
                cs.fname = hm.fsurname + "," + hm.firstname + " " + hm.fothername;
                cs.fcurrentcat = hm.fcat;

                TempData["ChangeCategoryLoad"] = cs;


                ferno = TempData.Peek("Change_Ferno").ToString();
                establishment = TempData.Peek("Change_Establishment").ToString();

                return View("ChangeStaffCategory", new ChangeStaffCategoryViewModel() { ferno = ferno, establishment = establishment });

                }

            TempData["ChangeCategoryLoad"] = null;

            ferno = TempData.Peek("Change_Ferno").ToString();
            establishment = TempData.Peek("Change_Establishment").ToString();

            return View("ChangeStaffCategory", new ChangeStaffCategoryViewModel() { ferno = ferno, establishment = establishment });


            }

        public ActionResult ChangeStaffCategory_Change(ChangeStaffCategoryViewModel cs)
            {

            if (!cs.fdothis)
                {

                int theid = int.Parse(cs.recordid);
                hist_mst hm = new hist_mst();
                hm = db.hist_mst.Find(theid);

                if (hm.ID_SBTS != 0)
                    {

                    if (CheckifSSNoisValid(hm.fssno))
                        {

                        List<hist_mst> hms = new List<hist_mst>();
                        hms = db.hist_mst.Where(b => b.ferno == hm.ferno).Where(b => b.fssno == hm.fssno).Where(b => b.fcat == hm.fcat).ToList();

                        if (hms.Count > 0)
                            {

                            foreach (hist_mst item in hms)
                                {
                                item.fcat = cs.fnewcat;

                                item.ModifiedBy = Session["AccountID"].ToString();
                                item.ModifiedOn = DateTime.Today;

                                db.hist_mst.Attach(item);
                                var entry = db.Entry(item);
                                entry.State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();

                                }

                            }
                        else
                            {
                            ViewBag.Message = "NO RECORD FOUND. PLEASE VERIFY YOUR ACTION AND TRY AGAIN";
                            }

                        }
                    else
                        {
                        List<hist_mst> hms = new List<hist_mst>();
                        hms = db.hist_mst.Where(b => b.ferno == hm.ferno).Where(b => b.fsurname == hm.fsurname).Where(b => b.fothername == hm.fothername).Where(b => b.firstname == hm.firstname).Where(b => b.fcat == hm.fcat).ToList();

                        if (hms.Count > 0)
                            {

                            foreach (hist_mst item in hms)
                                {
                                item.fcat = cs.fnewcat;
                                item.ModifiedBy = Session["AccountID"].ToString();
                                item.ModifiedOn = DateTime.Today;

                                db.hist_mst.Attach(item);
                                var entry = db.Entry(item);
                                entry.State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();

                                }

                            }
                        else
                            {
                            ViewBag.Message = "NO RECORD FOUND. PLEASE VERIFY YOUR ACTION AND TRY AGAIN";
                            }
                        }


                    }


                }
            else
                {

                int theid = int.Parse(cs.recordid);
                hist_mst hm = new hist_mst();
                hm = db.hist_mst.Find(theid);

                if (hm.ID_SBTS != 0)
                    {

                    List<hist_mst> hms = new List<hist_mst>();
                    hms = db.hist_mst.Where(b => b.ferno == hm.ferno).Where(b => b.fcat == cs.fcurrentcat).ToList();

                    if (hms.Count > 0)
                        {
                        foreach (hist_mst item in hms)
                            {
                            item.fcat = cs.fnewcat;
                            item.ModifiedBy = Session["AccountID"].ToString();
                            item.ModifiedOn = DateTime.Today;

                            db.hist_mst.Attach(item);
                            var entry = db.Entry(item);
                            entry.State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            }

                        }
                    else
                        {
                        ViewBag.Message = "NO RECORD FOUND. PLEASE VERIFY YOUR ACTION AND TRY AGAIN";
                        }


                    }
                else
                    {
                    ViewBag.Message = "NO RECORD FOUND. PLEASE VERIFY YOUR ACTION AND TRY AGAIN";
                    }

                }

            string ferno = TempData.Peek("Change_Ferno").ToString();
            string establishment = TempData.Peek("Change_Establishment").ToString();

            return RedirectToAction("ChangeStaffCategory_LoadERNo", new ChangeStaffCategoryViewModel() { ferno = ferno, establishment = establishment });
            }

        public ActionResult ChangeStaffCategory_Delete(int id)
            {

            hist_mst hm = new hist_mst();
            hm = db.hist_mst.Find(id);

            if (hm.ID_SBTS != 0)
                {


                db.hist_mst.Attach(hm);
                var entry = db.Entry(hm);
                entry.State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                }
            else
                {
                ViewBag.Message = "NO RECORD FOUND. PLEASE VERIFY YOUR ACTION AND TRY AGAIN";
                }


            string ferno = TempData.Peek("Change_Ferno").ToString();
            string establishment = TempData.Peek("Change_Establishment").ToString();

            return RedirectToAction("ChangeStaffCategory_LoadERNo", new ChangeStaffCategoryViewModel() { ferno = ferno, establishment = establishment });

            }

        #endregion

        #region ADD MEMBER TO CREDIT PURCHASE LIST

        public ActionResult AddMemberToCPList()
            {
            TempData["MyAreaOffices"] = GetMyZones();

            AddMemberToCPListViewModel am = new AddMemberToCPListViewModel();
            am.fcostofvalidation = 0;
            am.ffactor = 0;
            am.fnoofyears = 0;

            return View("AddMemberToCPList", am);
            }

        public ActionResult AddMemberToCPList_LoadSSNo(AddMemberToCPListViewModel a)
            {

            TempData["MyAreaOffices"] = GetMyZones();

            List<mper_mst> ms = new List<mper_mst>();
            ms = db.mper_mst.Where(b => b.fssno == a.fssno).ToList();

            if (ms.Count > 0)
                {
                mper_mst m = new mper_mst();
                m = ms[0];

                a.fsurname = m.fsurname;
                a.fothername = m.fothname;
                a.firstname = m.firstname;
                a.fsex = m.fsex;
                a.fdateofbirth = m.fb_date;

                System.TimeSpan ts = DateTime.Today.Subtract(m.fb_date.Value);
                string tss = (ts.TotalDays / 365).ToString("F0");

                a.fage = int.Parse(tss);

                }

            return View("AddMemberToCPList", a);

            }


        public ActionResult AddMemberToCPList_LoadSip(AddMemberToCPListViewModel a)
            {

            List<mem_sips> ms = new List<mem_sips>();
            ms = db.mem_sips.Where(b => b.fage == a.fage).ToList();

            if (ms.Count > 0)
                {

                if (a.fsex == "M")
                    {
                    a.ffactor = ms[0].fmale;
                    }
                else
                    {
                    a.ffactor = ms[0].female;
                    }

                decimal? thecost = a.ffactor * a.fannualsalary * a.fnoofyears;
                a.fcostofvalidation = thecost;

                }
            else
                {
                a.ffactor = 0;
                a.fcostofvalidation = 0;

                ViewBag.Message = "GIVEN AGE IS NOT ON FILE";
                }

            return View("AddMemberToCPList", a);

            }


        public ActionResult AddMemberToCPList_OK(AddMemberToCPListViewModel a)
            {

            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            if (a.fedit)
                {
                List<memsip_tr> mem = new List<memsip_tr>();
                mem = db.memsip_tr.Where(b => b.fssno == a.fssno).ToList();

                if (mem.Count > 0)
                    {
                    memsip_tr m = new memsip_tr();
                    m = mem[0];

                    m.ModifiedBy = Session["AccountID"].ToString();
                    m.ModifiedOn = DateTime.Today;

                    m.fsurname = a.fsurname;
                    m.firstname = a.firstname;
                    m.fothname = a.fothername;
                    m.fsex = a.fsex;
                    m.fb_date = a.fdateofbirth;
                    m.fage = a.fage;
                    m.factors = a.ffactor;
                    m.fannsal = a.fannualsalary;
                    m.fnoyr = a.fnoofyears;
                    //m.fuser_cap = Session["AccountID"].ToString();
                    m.fcost = a.fcostofvalidation;
                    m.fdateupd = DateTime.Today;
                    m.floc = a.fnassitpaypoint;

                    m.fappr_by = "";
                    m.fappr_cde = "";
                    m.fprnt = "";

                    db.memsip_tr.Attach(m);
                    var entry = db.Entry(m);
                    entry.State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    ViewBag.Message = "MEMBER SUCCESSFULLY UPDATE IN CREDIT PURCHASE LIST";

                    }
                }
            else
                {

                memsip_tr m = new memsip_tr();

                m.CreatedBy = Session["AccountID"].ToString();
                m.CreatedOn = DateTime.Today;

                m.ModifiedBy = Session["AccountID"].ToString();
                m.ModifiedOn = DateTime.Today;

                m.fssno = a.fssno;
                m.fsurname = a.fsurname;
                m.firstname = a.firstname;
                m.fothname = a.fothername;
                m.fsex = a.fsex;
                m.fb_date = a.fdateofbirth;
                m.fage = a.fage;
                m.factors = a.ffactor;
                m.fannsal = a.fannualsalary;
                m.fnoyr = a.fnoofyears;
                //m.fuser_cap = Session["AccountID"].ToString();
                m.fcost = a.fcostofvalidation;
                m.fdateupd = DateTime.Today;
                m.floc = a.fnassitpaypoint;

                m.fappr_by = "";
                m.fappr_cde = "";
                m.fprnt = "";

                db.memsip_tr.Add(m);
                db.SaveChanges();
                ViewBag.Message = "MEMBER SUCCESSFULLY ADDED TO CREDIT PURCHASE LIST";

                }

            AddMemberToCPListViewModel am = new AddMemberToCPListViewModel();
            am.fcostofvalidation = 0;
            am.ffactor = 0;
            am.fnoofyears = 0;


            return View("AddMemberToCPList", am);

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

            //CHECK HISTORY TRANSACTION AND SEE IT THE RECORD IS THERE WITH RESPECT
            //TO THE ferno and fcat
            //
            //IF NOT FOUND 
            //CHECK THE HISTORY MASTER
            //IF FOUND THEN
            //DO NOTHING SINCE THE CODE THAT WAS THERE WAS DESIGNED TO RETURN THE LAST ID

            //END IF

            //SELECT HISTORY TEMP
            //CHECK IF THE RECORD IS THERE ALSO
            //IF FOUND UPDATE THE TOTALWRK AND THE TOTALCR WITH THE NEW VALUES

            //ELSE IF NOT FOUND IN HISTORY TEMP
            //SELECT cr_ctrl
            //CHECK IF THE RECORD IS THERE
            //IF FOUND THEN
            //INSERT A NEW HISTORY TEMP RECORD WITH THE ferno, fcat, fwkrs = cr_ctrl.ftotwkr, fcont = cr_ctrl.ftotcr, 
            //ftotwkr, ftotcr

            //ELSE IF NOT FOUND
            //INSERT NEW RECORD IN HISTORY TEMP WITH ferno, fcat, fwkrs = 0, fcont = 0, 
            //ftotwkr, ftotcr

            //END IF


            List<hist_tr> htr = new List<hist_tr>();
            htr = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (htr.Count == 0)
                {

                }


            List<hist_tmp> htm = new List<hist_tmp>();
            htm = db.hist_tmp.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

            if (htm.Count > 0)
                {
                hist_tmp ht = new hist_tmp();
                ht = htm[0];

                ht.ftotcr = re.ftotalsalaryorcontribution;
                ht.ftotwkr = re.fnoofworkers;

                db.hist_tmp.Attach(ht);
                var entry = db.Entry(ht);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                }
            else
                {
                List<cr_ctrl> crs = new List<cr_ctrl>();
                crs = db.cr_ctrl.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).ToList();

                if (crs.Count > 0)
                    {

                    hist_tmp htemp = new hist_tmp();
                    htemp.CreatedBy = Session["AccountID"].ToString();
                    htemp.CreatedOn = DateTime.Today;
                    htemp.fcat = re.fcat;
                    htemp.ferno = re.ferno;
                    htemp.fmode = re.fmodesubmission;
                    htemp.ftotcr = re.ftotalsalaryorcontribution;
                    htemp.ftotwkr = re.fnoofworkers;

                    htemp.fwkrs = crs[0].ftotwkr;
                    htemp.fcont = crs[0].ftotcr;

                    htemp.ModifiedBy = Session["AccountID"].ToString();
                    htemp.ModifiedOn = DateTime.Today;

                    db.hist_tmp.Add(htemp);
                    db.SaveChanges();

                    }
                else
                    {

                    hist_tmp htemp = new hist_tmp();
                    htemp.CreatedBy = Session["AccountID"].ToString();
                    htemp.CreatedOn = DateTime.Today;
                    htemp.fcat = re.fcat;
                    htemp.ferno = re.ferno;
                    htemp.fmode = re.fmodesubmission;
                    htemp.ftotcr = re.ftotalsalaryorcontribution;
                    htemp.ftotwkr = re.fnoofworkers;

                    htemp.fwkrs = 0;
                    htemp.fcont = 0;

                    htemp.ModifiedBy = Session["AccountID"].ToString();
                    htemp.ModifiedOn = DateTime.Today;

                    db.hist_tmp.Add(htemp);
                    db.SaveChanges();

                    }

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

            return View("Backpay", newre);


            }



        public ActionResult Backpay_SummaryLoadLastEntry(HardCopyViewModel re)
            {

            TempData["MyMasterPeriods"] = GetMyMasterPeriods(re.ferno, re.fcat);

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
                re.TabIndex = 1;
                ViewBag.Message = "Staff Number is in use by another staff under the same Establishment.";
                return View("Backpay", re);
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

            re.TabIndex = 1;
            return View("Backpay", re);
            }

        public ActionResult Backpay_EditLoad(HardCopyViewModel re)
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

                re.TabIndex = 2;
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

                re.TabIndex = 2;
                return View("Backpay", re);
                }


            }



        public ActionResult Backpay_EditUndo(HardCopyViewModel re)
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

                re.TabIndex = 2;
                return View("Backpay", re);
                }
            else
                {

                re.TabIndex = 2;
                return View("Backpay", re);
                }


            }


        public ActionResult Backpay_EditAccept(HardCopyViewModel re)
            {

            if (ValidateStaffNo(re.ferno, re.fAddStaffNumber, re.fAddFirstContributionPeriod))
                {
                re.TabIndex = 2;
                ViewBag.Message = "Staff Number is in use by another staff under the same Establishment.";
                return View("Backpay", re);
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

            re.TabIndex = 2;
            return View("Backpay", re);


            }


        public ActionResult Backpay_EditRemove(HardCopyViewModel re)
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

                re.TabIndex = 2;
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

                re.TabIndex = 2;
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

                    return View("Backpay", re);

                    }

                return View("Backpay", new HardCopyViewModel());


                }
            else
                {
                return View("Backpay", new HardCopyViewModel());
                }


            }


        public ActionResult Backpay_PrintCheckList(HardCopyViewModel re)
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
                ViewBag.Message = "NO RECORD FOUND IN HISTORY TRANSACTION";

                re.TabIndex = 4;
                return View("Backpay", re);
                }

            }


        public ActionResult Backpay_MasterUpdateOK(HardCopyViewModel re)
            {

            if (Session["AccountID"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            decimal NASSITPercent = decimal.Parse("0.15");
            List<NASSITPercentage> nps = new List<NASSITPercentage>();
            nps = db.NASSITPercentages.ToList();

            if (nps.Count > 0)
                {
                NASSITPercent = nps[0].NPercentage;
                }

            //FIRST CHECK FOR RECORDS IN HISTORY TRANSACTION AND MOVE ALL RECORDS TO THE HISTORY MASTER
            //IF RECORDS HAVE BEEN MOVED TO HISTORY MASTER, THEN UPDATE TH EMPLOYER CONTRIBUTION REPORT 
            //AND THE MEMBER CONTRIBUTION REPORT


            List<hist_tr> histtr = new List<hist_tr>();
            histtr = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiodtext).ToList();

            if (histtr.Count > 0)
                {

                foreach (hist_tr ht in histtr)
                    {

                    hist_mst hm = new hist_mst();

                    hm.CreatedBy = Session["AccountID"].ToString();
                    hm.CreatedOn = DateTime.Today;

                    hm.fcat = ht.fcat;
                    hm.fcatbperd = "";
                    hm.fcurcr_perd = ht.fcurcr_perd;

                    if (re.fmodesubmission == "C")
                        {
                        hm.fcur_cr = ht.fcur_cr.Value;
                        }
                    else
                        {
                        hm.fcur_cr = ht.fcur_cr.Value * NASSITPercent;
                        }

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

                    hm.ModifiedBy = Session["AccountID"].ToString();
                    hm.ModifiedOn = DateTime.Today;

                    if (ht.fcorr_ssno != "" && ht.fcorr_ssno != null)
                        {
                        hm.fssno = ht.fcorr_ssno;
                        }


                    db.hist_mst.Add(hm);
                    db.SaveChanges();

                    ht.fid = "P";
                    ht.fcorr_ssno = "";

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

                        if (re.fmodesubmission == "C")
                            {
                            ct.ftotcr += ht.fcur_cr.Value;
                            }
                        else
                            {
                            ct.ftotcr += ht.fcur_cr.Value * NASSITPercent;
                            }

                        ct.ftotwkr += 1;

                        ct.ModifiedBy = Session["AccountID"].ToString();
                        ct.ModifiedOn = DateTime.Today;

                        db.cr_ctrl.Attach(ct);
                        var entry = db.Entry(ct);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }
                    else
                        {
                        cr_ctrl ct = new cr_ctrl();


                        ct.fcat = re.fcat;
                        ct.ferno = re.ferno;
                        ct.fmedia = "P";
                        ct.fmode = re.fmodesubmission;

                        if (re.fmodesubmission == "C")
                            {
                            ct.ftotcr = ht.fcur_cr.Value;
                            }
                        else
                            {
                            ct.ftotcr = ht.fcur_cr.Value * NASSITPercent;
                            }

                        ct.ftotwkr = 1;

                        ct.CreatedBy = Session["AccountID"].ToString();
                        ct.CreatedOn = DateTime.Today;


                        ct.ModifiedBy = Session["AccountID"].ToString();
                        ct.ModifiedOn = DateTime.Today;

                        ct.fdateupd = DateTime.Today;
                        //ct.fuser_code = Session["AccountID"].ToString();

                        db.cr_ctrl.Attach(ct);
                        var entry = db.Entry(ct);
                        entry.State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();

                        }

                    }


                //DELETE THE CRSREG RECORD

                //List<crsreg> htemps = new List<crsreg>();
                //htemps = db.crsregs.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fperiod == re.fmasterperiodtext).ToList();

                //foreach (crsreg ht in htemps)
                //    {

                //    db.crsregs.Attach(ht);
                //    var entry = db.Entry(ht);
                //    entry.State = System.Data.Entity.EntityState.Deleted;
                //    db.SaveChanges();

                //    }


                //DELETE THE HISTORY TRANSACTION

                List<hist_tr> htrans = new List<hist_tr>();
                htrans = db.hist_tr.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiodtext).ToList();

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

                re.TabIndex = 4;
                return View("Backpay", re);

                }
            else
                {

                List<hist_mst> hismast = new List<hist_mst>();
                hismast = db.hist_mst.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiodtext).ToList();

                if (hismast.Count > 0)
                    {

                    if (re.fMasterUpdateGenerateCR == true)
                        {

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

                                        if (re.fmodesubmission == "C")
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

                                        mcon.ModifiedBy = Session["AccountID"].ToString();
                                        mcon.ModifiedOn = DateTime.Today;

                                        db.memcr_tr.Attach(mcon);
                                        var entry = db.Entry(mcon);
                                        entry.State = System.Data.Entity.EntityState.Modified;
                                        db.SaveChanges();

                                        }
                                    else
                                        {

                                        memcr_tr mcon = new memcr_tr();

                                        mcon.fcat = hm.fcat;

                                        if (re.fmodesubmission == "C")
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
                                        mcon.fprocess = false;

                                        mcon.CreatedBy = Session["AccountID"].ToString();
                                        mcon.CreatedOn = DateTime.Today;

                                        db.memcr_tr.Add(mcon);
                                        db.SaveChanges();


                                        List<hist_tmp> htmps = new List<hist_tmp>();
                                        htmps = db.hist_tmp.Where(b => b.ferno == hm.ferno).Where(b => b.fcat == hm.fcat).ToList();

                                        if (htmps.Count > 0)
                                            {
                                            hist_tmp htp = new hist_tmp();
                                            htp = htmps[0];

                                            htp.fwkrs += 1;
                                            htp.fcont += hm.fcur_cr;

                                            htp.ModifiedBy = Session["AccountID"].ToString();
                                            htp.ModifiedOn = DateTime.Today;

                                            db.hist_tmp.Attach(htp);
                                            var entry = db.Entry(htp);
                                            entry.State = System.Data.Entity.EntityState.Modified;
                                            db.SaveChanges();


                                            }

                                        List<empcr_tr> ecs = new List<empcr_tr>();
                                        string ddftype = "R";

                                        ecs = db.empcr_tr.Where(b => b.ferno == hm.ferno).Where(b => b.ftype_cr == ddftype).Where(b => b.fcat == hm.fcat).Where(b => b.fperiod == hm.fcurcr_perd).ToList();

                                        if (ecs.Count > 0)
                                            {
                                            empcr_tr ec = new empcr_tr();
                                            ec = ecs[0];

                                            if (re.fmodesubmission == "C")
                                                {
                                                ec.ftot_cont += hm.fcur_cr;
                                                }
                                            else
                                                {
                                                ec.ftot_cont += (hm.fcur_cr * NASSITPercent);
                                                }


                                            //ERROR THE empcr_tr DELETES THE RECORD INSTEAD OF UPDATING THE RECORD

                                            ec.fdateupd = DateTime.Today;
                                            ec.fuser_code = Session["AccountID"].ToString();
                                            ec.ftype_cr = "R";
                                            ec.fno_wkr += 1;

                                            ec.ModifiedBy = Session["AccountID"].ToString();
                                            ec.ModifiedOn = DateTime.Today;

                                            db.empcr_tr.Attach(ec);
                                            var ventry = db.Entry(ec);
                                            ventry.State = System.Data.Entity.EntityState.Modified;
                                            db.SaveChanges();

                                            }
                                        else
                                            {

                                            empcr_tr ec = new empcr_tr();

                                            if (re.fmodesubmission == "C")
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

                                            ec.CreatedBy = Session["AccountID"].ToString();
                                            ec.CreatedOn = DateTime.Today;

                                            db.empcr_tr.Add(ec);
                                            db.SaveChanges();

                                            }
                                        }

                                    }
                                }



                            }


                        //List<crsreg> cregss = new List<crsreg>();
                        //string thetype = "R";
                        //cregss = db.crsregs.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fperiod == re.fmasterperiodtext).Where(b => b.ftype == thetype).ToList();

                        //if (cregss.Count > 0)
                        //    {

                        //    crsreg cr = new crsreg();
                        //    cr = cregss[0];

                        //    cr.fnowkr = re.fmasterperiodnoofworkers.Value;
                        //    cr.ftot_cr = re.fmastercontributiontext.Value;
                        //    cr.fstatus = "G";
                        //    cr.fdate_cap = DateTime.Today;
                        //    cr.fuser_cap = Session["AccountID"].ToString();

                        //    db.crsregs.Attach(cr);
                        //    var entry = db.Entry(cr);
                        //    entry.State = System.Data.Entity.EntityState.Modified;
                        //    db.SaveChanges();

                        //    }

                        }
                    else
                        {
                        ViewBag.Message = "Please check the Generte CR before proceeding on processing the Contribution Report";
                        }

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

                re.TabIndex = 4;
                return View("Backpay", re);
                }

            }


        public ActionResult Backpay_MasterPeriodLoad(HardCopyViewModel re)
            {

            re.fmastercontributiontext = GetTotalContribution(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodnoofworkers = GetTotalNoOfWorkers(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodtext = re.fmasterperiod;


            re.fmastercontributionCRControltext = GetTotalContributionCRControl(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodnoofworkersCRControl = GetTotalNoOfWorkersCRControl(re.ferno, re.fcat, re.fmasterperiod);
            re.fmasterperiodCRControltext = re.fmasterperiod;


            if (re.fmasterperiodnoofworkers == 0)
                {
                List<hist_mst> hm = new List<hist_mst>();
                hm = db.hist_mst.Where(b => b.ferno == re.ferno).Where(b => b.fcat == re.fcat).Where(b => b.fcurcr_perd == re.fmasterperiod).ToList();

                if (hm.Count > 0)
                    {
                    ViewBag.Message = "Ready to Generate the Contribution Report. Please check the Generate CR checkbox and click complete.";
                    }
                }


            if (re.fcat == null || re.fcat == "")
                {
                ViewBag.Message = "You have not selected the Staff Category from the Summary Tab. Please do and try again.";
                }

            re.TabIndex = 4;
            return View("Backpay", re);

            }



        #endregion

        }
    }
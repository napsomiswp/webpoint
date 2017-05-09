using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.Models;
using NAPSOMIS_Webpoint.ViewModels;

using System.Data;
using DevExpress.Web.Mvc;
using DevExpress.Web;
using System.Configuration;

namespace NAPSOMIS_Webpoint.Controllers
    {
    public class CaptureRegistrationFormsController : Controller
        {

        NAPSOMISModel db = new NAPSOMISModel();

        #region CAPTURE REGISTRATION FORMS

        // GET: CaptureRegistrationForms
        [HttpGet]
        public ActionResult Form()
            {
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


            return View("Form");
            }

        public ActionResult StartCaptureRegistrationForms(CaptureMemRegViewModel memb)
            {

            try
                {

                var refno = Request["fref_no_2"];

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

                if (refno != null)
                    {
                    List<mem_tr> mt = new List<mem_tr>();
                    mt = db.mem_tr.Where(r => r.fref_no == refno).ToList();

                    CaptureMemRegViewModel mvm = new CaptureMemRegViewModel();

                    mvm.fref_no = mt[0].fref_no;
                    mvm.firstname = mt[0].firstname;
                    mvm.fothname = mt[0].fothname;
                    mvm.fsurname = mt[0].fsurname;
                    mvm.fb_date = mt[0].fb_date;
                    mvm.fjoindate = mt[0].fjoindate;

                    TempData.Remove("Dependants");

                    if (mt.Count > 0)
                        {
                        return View("Form", mvm);
                        }
                    else
                        {
                        return View("Form");
                        }

                    }
                return View("Form");
                }
            catch (Exception)
                {
                return View("Form");
                }

            }



        public List<PDCTemplate> Province_LoadDitrict(CaptureMemRegViewModel memb)
            {

            try
                {

                TempData["MyDistricts"] = GetMyDistrict("N");
                List<PDCTemplate> mydistrict = (List<PDCTemplate>)TempData.Peek("MyDistricts");

                return mydistrict;

                }
            catch (Exception)
                {
                return new List<PDCTemplate>();
                }

            }


        public ActionResult District_LoadChiefdom(CaptureMemRegViewModel memb)
            {

            try
                {

                TempData["MyChiefdoms"] = GetMyChiefdom(memb.fdist, memb.fprovince);

                return View("Form", memb);

                }
            catch (Exception)
                {
                return View("Form");
                }

            }

        // POST: CaptureRegistrationForms/Create
        [HttpPost]
        public ActionResult CaptureRegistrationForms(CaptureMemRegViewModel c)
            {
            try
                {

                TempData["RegistrationForm"] = c;
                TempData["ReferenceNo"] = c.fref_no;

                if (TempData["MyRelations"] == null)
                    {
                    TempData["MyRelations"] = GetMyRelations();
                    }

                return RedirectToAction("CaptureDependants");
                }
            catch
                {
                throw;
                //return View();
                }
            }

        [HttpGet]
        public ActionResult CaptureDependants()
            {
            try
                {
                if (TempData.Peek("ReferenceNo") != null)
                    {
                    nom_tr ntp = new nom_tr();
                    ntp.fref_no = TempData.Peek("ReferenceNo").ToString();

                    return View("DependantCapture", ntp);
                    }
                else
                    {
                    return View("DependantCapture");
                    }

                }
            catch (Exception)
                {
                return View("DependantCapture");
                }

            }

        [HttpPost]
        public ActionResult CaptureDependants(nom_tr dependant)
            {
            if (TempData.Peek("Dependants") == null)
                {
                List<nom_tr> thedependants = new List<nom_tr>();
                dependant.nom_id = thedependants.Count + 1;
                thedependants.Add(dependant);
                TempData["Dependants"] = thedependants;
                }
            else
                {
                List<nom_tr> thedependants = (List<nom_tr>)TempData.Peek("Dependants");
                dependant.nom_id = thedependants.Count + 1;
                thedependants.Add(dependant);
                TempData["Dependants"] = thedependants;
                }

            nom_tr ntp = new nom_tr();
            ntp.fref_no = TempData.Peek("ReferenceNo").ToString();

            if (TempData.Peek("MyRelations") == null)
                {
                TempData["MyRelations"] = GetMyRelations();
                }

            return View("DependantCapture", ntp);
            }


        public ActionResult Delete(int id)
            {
            try
                {
                if (TempData.Peek("Dependants") != null)

                    {
                    nom_tr dependanttoremove = new nom_tr();
                    List<nom_tr> thedependants = (List<nom_tr>)TempData.Peek("Dependants");

                    foreach (nom_tr dp in thedependants)
                        {
                        if (dp.nom_id == id)
                            {
                            dependanttoremove = dp;
                            }
                        }

                    thedependants.Remove(dependanttoremove);

                    TempData["Dependants"] = thedependants;

                    nom_tr ntp = new nom_tr();
                    ntp.fref_no = TempData.Peek("ReferenceNo").ToString();

                    if (TempData.Peek("MyRelations") == null)
                        {
                        TempData["MyRelations"] = GetMyRelations();
                        }

                    return View("DependantCapture", ntp);

                    }
                else
                    {

                    List<nom_tr> thedependants = (List<nom_tr>)TempData.Peek("Dependants");
                    nom_tr ntp = new nom_tr();
                    ntp.fref_no = TempData.Peek("ReferenceNo").ToString();

                    if (TempData.Peek("MyRelations") == null)
                        {
                        TempData["MyRelations"] = GetMyRelations();
                        }

                    return View("DependantCapture", ntp);

                    }

                }
            catch (Exception)
                {
                List<nom_tr> thedependants = (List<nom_tr>)TempData.Peek("Dependants");
                nom_tr ntp = new nom_tr();
                ntp.fref_no = TempData.Peek("ReferenceNo").ToString();

                if (TempData.Peek("MyRelations") == null)
                    {
                    TempData["MyRelations"] = GetMyRelations();
                    }

                return View("DependantCapture", ntp);

                throw;
                }
            }

        [HttpPost]
        public ActionResult CompleteCapture(nom_tr dependants)
            {
            List<nom_tr> alldependants = (List<nom_tr>)TempData.Peek("Dependants");

            foreach (nom_tr dp in alldependants)
                {
                dp.nom_id = 0;
                dp.ModifiedBy = Session["AccountID"].ToString();
                dp.ModifiedOn = DateTime.Today;

                dp.CreatedBy = Session["AccountID"].ToString();
                dp.CreatedOn = DateTime.Today;

                db.nom_tr.Add(dp);
                db.SaveChanges();
                }


            CaptureMemRegViewModel c = (CaptureMemRegViewModel)TempData.Peek("RegistrationForm");

            parental p = new parental();
            p.fref_no = c.fref_no;
            p.ffirstname = c.ffirstname;
            p.ffsurname = c.ffsurname;
            p.ffothname = c.ffothname;

            p.fmfirstname = c.fmfirstname;
            p.fmsurname = c.fmsurname;
            p.fmothname = c.fmothname;

            p.ModifiedBy = Session["AccountID"].ToString();
            p.ModifiedOn = DateTime.Today;

            p.CreatedBy = Session["AccountID"].ToString();
            p.CreatedOn = DateTime.Today;

            db.parentals.Add(p);
            db.SaveChanges();


            List<mem_tr> mlist = new List<mem_tr>();
            mlist = db.mem_tr.Where(b => b.fref_no == c.fref_no).ToList();

            mem_tr m = new mem_tr();
            m = mlist[0];

            m.fref_no = c.fref_no;

            if (c.fb_date != null)
                {
                //m.fssno = GenerateSSNo(c.fprovince, c.fdist, c.fchief, c.fb_date.Value);
                }

            m.fsurname = c.fsurname;
            m.firstname = c.firstname;
            m.fothname = c.fothname;
            m.fper_addr = c.fper_addr;
            m.fcur_addr = c.fcur_addr;
            m.fm_stat = c.fm_stat;
            m.fnation = c.fnation;
            m.fb_country = c.fb_country;
            m.fsex = c.fsex;
            m.fprovince = c.fprovince;
            m.fdist = c.fdist;
            m.fchief = c.fchief;
            m.ftown = c.ftown;
            m.fb_date = c.fb_date;
            m.fjoindate = c.fjoindate;
            m.fincome = c.fincome;
            m.fnat_income = c.fnat_income;
            m.foccupation = c.foccupation;
            m.femp_name = c.femp_name;
            m.ferno = c.ferno;
            m.femp_addr = c.femp_addr;
            m.ftel_no = c.ftel_no;

            m.ModifiedBy = "DEFAULT";
            m.ModifiedOn = DateTime.Today;


            db.mem_tr.Attach(m);
            var entry = db.Entry(m);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();


            List<prevname> prev = new List<prevname>();
            prev = db.prevnames.Where(r => r.fref_no == m.fref_no).ToList();
            prevname previous = new prevname();

            if (prev.Count > 0)
                {

                previous = prev[0];

                previous.fref_no = c.fref_no;
                previous.fssno = c.fssno;

                //THE DATABASE IS SET TO VARCHAR(6) But This need more than varchar(6)
                //previous.fuser_code = "DEFAULT";

                previous.CreatedBy = "DEFAULT";
                previous.CreatedOn = DateTime.Today;
                previous.fpfirstname = c.fpfirstname;
                previous.fpothname = c.fpothname;
                previous.fpsurname = c.fpsurname;


                db.prevnames.Attach(previous);
                var pentry = db.Entry(previous);
                pentry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                }
            else
                {

                previous.fref_no = c.fref_no;
                previous.fssno = c.fssno;

                //THE DATABASE IS SET TO VARCHAR(6) But This need more than varchar(6)
                //previous.fuser_code = "DEFAULT";

                previous.fpfirstname = c.fpfirstname;
                previous.fpothname = c.fpothname;
                previous.fpsurname = c.fpsurname;

                previous.ModifiedBy = Session["AccountID"].ToString();
                previous.ModifiedOn = DateTime.Today;

                previous.CreatedBy = Session["AccountID"].ToString();
                previous.CreatedOn = DateTime.Today;

                db.prevnames.Add(previous);
                db.SaveChanges();
                }

            ViewBag.Message = "MEMBER FORM SUCCESSFULLY CAPTURED";
            return View("Form");

            }


        private string GenerateSSNo(string dProvince, string dDistrict, string dChiefdom, DateTime DateofBirth)
            {
            string NewSSNo = dProvince + dDistrict + dChiefdom + DateofBirth.ToString("yyyy") + DateofBirth.ToString("MM") + DateofBirth.ToString("dd");
            string Last4Digits = GetLastSimilarSSNoEnd4Digits(NewSSNo);

            if (Last4Digits == "0")
                {
                string CompleteSSNo = NewSSNo + "0001";
                return CompleteSSNo;
                }
            else
                {

                string CompleteSSNo = NewSSNo + CompleteStartNo((int.Parse(Last4Digits) + 1));
                return CompleteSSNo;
                }
            }

        private bool ValidateSSNo(string SSNo)
            {
            int thecount = db.mem_tr.Where(p => p.fssno == SSNo).Count();

            if (thecount > 0)
                {
                return true;
                }
            return false;
            }

        private string GetLastSimilarSSNoEnd4Digits(string SSNo)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT TOP 1 fssno From mem_tr WHERE fssno like '" + SSNo + "%'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string only4digits = mytable.Rows[0].Field<String>("fssno").ToString().Replace(SSNo, "");
                return CompleteStartNo(int.Parse(only4digits));
                }
            return "0";
            }

        private string CompleteStartNo(int TheNo)
            {
            string newValue = TheNo.ToString();

            if (TheNo < 10)
                {
                newValue = "000" + TheNo;
                }
            else if (TheNo >= 10 && TheNo < 100)
                {
                newValue = "00" + TheNo;
                }
            else if (TheNo >= 100 && TheNo < 1000)
                {
                newValue = "0" + TheNo;
                }
            else if (TheNo >= 1000 && TheNo < 10000)
                {
                newValue = "" + TheNo;
                }

            return newValue;
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


        #region "EDIT MEMBER DETAILS"

        public ActionResult EditForm(CaptureMemRegViewModel memb)
            {
            try
                {

                var refno = Request["fref_no_2"];

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

                if (refno != null)
                    {
                    List<mem_tr> mt = new List<mem_tr>();
                    mt = db.mem_tr.Where(r => r.fref_no == refno).ToList();

                    CaptureMemRegViewModel mvm = new CaptureMemRegViewModel();

                    if (mt.Count == 0) return View("EditForm", memb);

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
                    mvm.fgov_code = mt[0].fgov_code;
                    mvm.fincome = mt[0].fincome;
                    mvm.fm_stat = mt[0].fm_stat;
                    mvm.fnation = mt[0].fnation;
                    mvm.fnat_income = mt[0].fnat_income;
                    mvm.foccupation = mt[0].foccupation;
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
                    List<parental> p = new List<parental>();
                    p = db.parentals.Where(b => b.fref_no == refno).ToList();

                    if (p.Count > 0)
                        {

                        mvm.ffirstname = p[0].ffirstname;
                        mvm.ffothname = p[0].ffothname;
                        mvm.ffsurname = p[0].ffsurname;

                        mvm.fmfirstname = p[0].fmfirstname;
                        mvm.fmothname = p[0].fmothname;
                        mvm.fmsurname = p[0].fmsurname;

                        }


                    List<prevname> prev = new List<prevname>();
                    prev = db.prevnames.Where(r => r.fref_no == refno).ToList();
                    prevname previous = new prevname();

                    if (prev.Count > 0)
                        {

                        previous = prev[0];
                        mvm.fpfirstname = previous.fpfirstname;
                        mvm.fpothname = previous.fpothname;
                        mvm.fpsurname = previous.fpsurname;

                        }


                    if (mt.Count > 0)
                        {
                        return View("EditForm", mvm);
                        }
                    else
                        {
                        return View("EditForm");
                        }

                    }
                return View("EditForm");
                }
            catch (Exception)
                {

                throw;
                }
            }



        public void SaveFormbeforeDependants(CaptureMemRegViewModel c)
            {

            TempData["ReferenceNo"] = c.fref_no;

            List<parental> searchparental = new List<parental>();
            searchparental = db.parentals.Where(b => b.fref_no == c.fref_no).ToList();

            if (searchparental.Count > 0)
                {
parental p = new parental();
            p = searchparental[0];

            p.ffirstname = c.ffirstname;
            p.ffsurname = c.ffsurname;
            p.ffothname = c.ffothname;

            p.fmfirstname = c.fmfirstname;
            p.fmsurname = c.fmsurname;
            p.fmothname = c.fmothname;

            p.CreatedBy = Session["AccountID"].ToString();
            p.CreatedOn = DateTime.Today;

            p.ModifiedBy = Session["AccountID"].ToString();
            p.ModifiedOn = DateTime.Today;

            db.parentals.Attach(p);
            var entry = db.Entry(p);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
                }
            
              
            mem_tr m = new mem_tr();

            List<mem_tr> searchmember = new List<mem_tr>();
            searchmember = db.mem_tr.Where(b => b.fref_no == c.fref_no).ToList();

            if (searchmember.Count > 0)
                {
 m = searchmember[0];

            m.fref_no = c.fref_no;

            if (c.fb_date != null)
                {
                //m.fssno = GenerateSSNo(c.fprovince, c.fdist, c.fchief, c.fb_date.Value);
                }

            m.fsurname = c.fsurname;
            m.firstname = c.firstname;
            m.fothname = c.fothname;
            m.fper_addr = c.fper_addr;
            m.fcur_addr = c.fcur_addr;
            m.fm_stat = c.fm_stat;
            m.fnation = c.fnation;
            m.fb_country = c.fb_country;
            m.fsex = c.fsex;
            m.fprovince = c.fprovince;
            m.fdist = c.fdist;
            m.fchief = c.fchief;
            m.ftown = c.ftown;
            m.fb_date = c.fb_date;
            m.fjoindate = c.fjoindate;
            m.fincome = c.fincome;
            m.fnat_income = c.fnat_income;
            m.foccupation = c.foccupation;
            m.femp_name = c.femp_name;
            m.ferno = c.ferno;
            m.femp_addr = c.femp_addr;

            m.ftel_no = c.ftel_no;

            m.CreatedBy = Session["AccountID"].ToString();
            m.CreatedOn = DateTime.Today;

            m.ModifiedBy = Session["AccountID"].ToString();
            m.ModifiedOn = DateTime.Today;

            db.mem_tr.Attach(m);
            var dentry = db.Entry(m);
            dentry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

                }
           

            List<prevname> prev = new List<prevname>();
            prev = db.prevnames.Where(r => r.fref_no == m.fref_no).ToList();
            prevname previous = new prevname();

            if (prev.Count > 0)
                {

                previous = prev[0];

                previous.fref_no = c.fref_no;
                previous.fssno = c.fssno;

                //THE DATABASE IS SET TO VARCHAR(6) But This need more than varchar(6)
                //previous.fuser_code = "DEFAULT";

                previous.CreatedBy = Session["AccountID"].ToString();
                previous.CreatedOn = DateTime.Today;

                previous.ModifiedBy = Session["AccountID"].ToString();
                previous.ModifiedOn = DateTime.Today;

                previous.fpfirstname = c.fpfirstname;
                previous.fpothname = c.fpothname;
                previous.fpsurname = c.fpsurname;

                db.prevnames.Attach(previous);
                var pentry = db.Entry(previous);
                pentry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                }
            else
                {

                previous.fref_no = c.fref_no;
                previous.fssno = c.fssno;

                //THE DATABASE IS SET TO VARCHAR(6) But This need more than varchar(6)
                //previous.fuser_code = "DEFAULT";

                previous.CreatedBy = Session["AccountID"].ToString();
                previous.CreatedOn = DateTime.Today;

                previous.ModifiedBy = Session["AccountID"].ToString();
                previous.ModifiedOn = DateTime.Today;

                previous.fpfirstname = c.fpfirstname;
                previous.fpothname = c.fpothname;
                previous.fpsurname = c.fpsurname;

                db.prevnames.Add(previous);
                db.SaveChanges();
                }


            }

        [HttpPost]
        public ActionResult EditFormtoDependants(CaptureMemRegViewModel c)
            {
            try
                {

                SaveFormbeforeDependants(c);

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
                List<nom_tr> d = new List<nom_tr>();
                d = db.nom_tr.Where(b => b.fref_no == refno).ToList();

                return View("DependantEdit", d[0]);

                }
            catch (Exception)
                {
                return View("DependantEdit");
                }

            }


        [HttpGet]
        public ActionResult DeleteDependants(int id)
            {
            try
                {
                nom_tr dep = new nom_tr();
                dep = db.nom_tr.Find(id);

                db.nom_tr.Remove(dep);
                db.SaveChanges();

                if (TempData.Peek("MemberEditReferenceNo") != null)
                    {
                    nom_tr ntp = new nom_tr();
                    ntp.fref_no = TempData.Peek("MemberEditReferenceNo").ToString();

                    return View("DependantEdit", ntp);
                    }
                else
                    {
                    return View("DependantEdit");
                    }

                }
            catch (Exception)
                {
                return View("DependantEdit");
                }

            }


        [HttpGet]
        public ActionResult StartEditDependants(int id)
            {
            try
                {

                nom_tr dep = new nom_tr();
                dep = db.nom_tr.Find(id);

                return View("DependantEdit", dep);

                }
            catch (Exception)
                {
                return View("DependantEdit");
                }

            }



        public ActionResult PrepareAddNewDependant()
            {
            try
                {

                string refno = TempData.Peek("MemberEditReferenceNo").ToString();
                nom_tr d = new nom_tr();
                d.fref_no = refno;

                return View("DependantEdit", d);

                }
            catch (Exception)
                {
                return View("DependantEdit");
                }

            }


        public ActionResult SaveDependantEdit(nom_tr dependant)
            {
            try
                {

                nom_tr dep = new nom_tr();

                bool isNewRecord;

                if (dependant.nom_id == 0)
                    {
                    isNewRecord = true;
                    }
                else
                    {
                    isNewRecord = false;
                    dep = db.nom_tr.Find(dependant.nom_id);
                    }

                dep.fref_no = dependant.fref_no;
                dep.fbirth_date = dependant.fbirth_date;
                dep.fnfirstname = dependant.fnfirstname;
                dep.fnomsex = dependant.fnomsex;
                dep.fnom_ssno = dependant.fnom_ssno;
                dep.fnothname = dependant.fnothname;
                dep.fnsurname = dependant.fnsurname;
                dep.fper_addr = dependant.fper_addr;
                dep.frelation = dependant.frelation;
                dep.fres_addr = dependant.fres_addr;
                dep.fssno = dependant.fssno;

                dep.ModifiedOn = DateTime.Today;
                dep.ModifiedBy = Session["AccountID"].ToString();

                dep.CreatedOn = DateTime.Today;
                dep.CreatedBy = Session["AccountID"].ToString();

                if (!isNewRecord)
                    {

                    db.nom_tr.Attach(dep);
                    var entry = db.Entry(dep);
                    entry.State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();

                    }
                else
                    {

                    db.nom_tr.Add(dep);
                    db.SaveChanges();

                    }


                return View("DependantEdit", dep);

                }
            catch (Exception)
                {
                return View("DependantEdit");
                }

            }

        public ActionResult SaveFormEdit(CaptureMemRegViewModel c)
            {


            List<parental> searchparental = new List<parental>();
            searchparental = db.parentals.Where(b => b.fref_no == c.fref_no).ToList();

            parental p = new parental();
            p = searchparental[0];

            p.ffirstname = c.ffirstname;
            p.ffsurname = c.ffsurname;
            p.ffothname = c.ffothname;

            p.fmfirstname = c.fmfirstname;
            p.fmsurname = c.fmsurname;
            p.fmothname = c.fmothname;
            p.ModifiedBy = "DEFAULT";
            p.ModifiedOn = DateTime.Today;

            //UPDATING THE PARENTAL RECORD
            db.parentals.Attach(p);
            var entry = db.Entry(p);

            entry.Property(b => b.ffirstname).IsModified = true;
            entry.Property(b => b.ffothname).IsModified = true;
            entry.Property(b => b.ffsurname).IsModified = true;
            entry.Property(b => b.fmfirstname).IsModified = true;
            entry.Property(b => b.fmothname).IsModified = true;
            entry.Property(b => b.fmsurname).IsModified = true;
            entry.Property(b => b.fref_no).IsModified = true;
            entry.Property(b => b.fssno).IsModified = true;

            entry.Property(b => b.ModifiedOn).IsModified = true;
            entry.Property(b => b.ModifiedBy).IsModified = true;

            db.SaveChanges();



            List<mem_tr> sm = new List<mem_tr>();
            sm = db.mem_tr.Where(b => b.fref_no == c.fref_no).ToList();

            mem_tr m = new mem_tr();
            m = sm[0];

            m.fref_no = c.fref_no;

            if (c.fb_date != null)
                {
                //m.fssno = GenerateSSNo(c.fprovince, c.fdist, c.fchief, c.fb_date.Value);
                }

            m.fsurname = c.fsurname;
            m.firstname = c.firstname;
            m.fothname = c.fothname;
            m.fper_addr = c.fper_addr;
            m.fcur_addr = c.fcur_addr;
            m.fm_stat = c.fm_stat;
            m.fnation = c.fnation;
            m.fb_country = c.fb_country;
            m.fsex = c.fsex;
            m.fprovince = c.fprovince;
            m.fdist = c.fdist;
            m.fchief = c.fchief;
            m.ftown = c.ftown;
            m.fb_date = c.fb_date;
            m.fjoindate = c.fjoindate;
            m.fincome = c.fincome;
            m.fnat_income = c.fnat_income;
            m.foccupation = c.foccupation;
            m.femp_name = c.femp_name;
            m.ferno = c.ferno;
            m.femp_addr = c.femp_addr;

            m.ftel_no = c.ftel_no;

            m.ModifiedBy = "DEFAULT";
            m.ModifiedOn = DateTime.Today;

            m.fdateupd = DateTime.Now;


            //CODE FOR UPDATING THE ENTIRY RECORD IN THE DATABASE
            db.mem_tr.Attach(m);
            var theentry = db.Entry(m);
            theentry.State = System.Data.Entity.EntityState.Modified;

            //entry.Property(e => e.ID_SBTS).IsModified = false;
            db.SaveChanges();


            List<prevname> prev = new List<prevname>();
            prev = db.prevnames.Where(r => r.fref_no == m.fref_no).ToList();
            prevname previous = new prevname();

            if (prev.Count > 0)
                {

                previous = prev[0];

                previous.fref_no = c.fref_no;
                previous.fssno = c.fssno;

                //THE DATABASE IS SET TO VARCHAR(6) But This need more than varchar(6)
                //previous.fuser_code = "DEFAULT";

                previous.CreatedBy = "DEFAULT";
                previous.CreatedOn = DateTime.Today;
                previous.fpfirstname = c.fpfirstname;
                previous.fpothname = c.fpothname;
                previous.fpsurname = c.fpsurname;


                db.prevnames.Attach(previous);
                var pentry = db.Entry(previous);
                pentry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                }
            else
                {

                previous.fref_no = c.fref_no;
                previous.fssno = c.fssno;

                //THE DATABASE IS SET TO VARCHAR(6) But This need more than varchar(6)
                //previous.fuser_code = "DEFAULT";

                previous.CreatedBy = "DEFAULT";
                previous.CreatedOn = DateTime.Today;
                previous.fpfirstname = c.fpfirstname;
                previous.fpothname = c.fpothname;
                previous.fpsurname = c.fpsurname;

                db.prevnames.Add(previous);
                db.SaveChanges();
                }

            if (m.fref_no != c.fref_no || m.fssno != c.fssno)
                {
                List<nom_tr> depen = new List<nom_tr>();
                depen = db.nom_tr.Where(b => b.fref_no == m.fref_no).ToList();

                if (depen.Count > 0)
                    {
                    foreach (var de in depen)
                        {

                        de.fref_no = c.fref_no;
                        de.fssno = c.fssno;

                        db.nom_tr.Attach(de);
                        var sentry = db.Entry(de);
                        sentry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }
                    }
                }

            ViewBag.Message = "MEMBER FORM SUCCESSFULLY EDITED";
            return View("EditForm", c);

            }

        [HttpPost]
        public ActionResult CompleteEdit(nom_tr dependants)
            {

            return RedirectToAction("EditForm");

            }


        #endregion


        }
    }

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

        // GET: CaptureRegistrationForms
        [HttpGet]
        public ActionResult CaptureRegistrationForms()
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


            return View("CaptureRegistrationForms");
            }


        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Index(FormCollection collection)
        //{
        //    string valueFromNameTextBox = collection["name"];
        //}

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
                    List<MemberTransaction> mt = new List<MemberTransaction>();
                    mt = db.MemberTransactions.Where(r => r.fref_no == refno).ToList();

                    CaptureMemRegViewModel mvm = new CaptureMemRegViewModel();

                    mvm.fref_no = mt[0].fref_no;
                    mvm.firstname = mt[0].firstname;
                    mvm.fothname = mt[0].fothname;
                    mvm.fsurname = mt[0].fsurname;
                    mvm.fb_date = mt[0].fb_date;
                    mvm.fjoindate = mt[0].fjoindate;

                    if (mt.Count > 0)
                        {
                        return View("CaptureRegistrationForms", mvm);
                        }
                    else
                        {
                        return View("CaptureRegistrationForms");
                        }

                    }
                return View("CaptureRegistrationForms");
                }
            catch (Exception)
                {
                return View("CaptureRegistrationForms");
                }

            }

        // POST: CaptureRegistrationForms/Create
        [HttpPost]
        public ActionResult CaptureRegistrationForms(CaptureMemRegViewModel c)
            {
            try
                {
                //MemberTransaction m = new MemberTransaction();

                //m.fref_no = c.fref_no;
                //m.fssno = c.fssno;
                //m.fsurname = c.fsurname;
                //m.firstname = c.firstname;
                //m.fothname = c.fothname;
                //m.fper_addr = c.fper_addr;
                //m.fcur_addr = c.fcur_addr;
                //m.fm_stat = c.fm_stat;
                //m.fnation = c.fnation;
                //m.fb_country = c.fb_country;
                //m.fsex = c.fsex;
                //m.fprovince = c.fprovince;
                //m.fdist = c.fdist;
                //m.fchief = c.fchief;
                //m.ftown = c.ftown;
                //m.fb_date = c.fb_date;
                //m.fjoindate = c.fjoindate;
                //m.fincome = c.fincome;
                //m.fnat_income = c.fnat_income;
                //m.foccupation = c.foccupation;
                //m.femp_name = c.femp_name;
                //m.ferno = c.ferno;
                //m.femp_addr = c.femp_addr;
                //m.ftel_no = c.ftel_no;

                //Parental p = new Parental();

                //p.fref_no = c.fref_no;
                //p.fssno = c.fssno;
                //p.ffsurname = c.ffsurname;
                //p.ffirstname = c.ffirstname;
                //p.ffothname = c.ffothname;
                //p.fmsurname = c.fmsurname;
                //p.fmfirstname = c.fmfirstname;
                //p.fmothname = c.fmothname;


                //db.Parentals.Add(p);
                //db.MemberTransactions.Add(m);
                //db.SaveChanges();

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
                return View();
                }
            }

        [HttpGet]
        public ActionResult CaptureDependants()
            {
            try
                {
                if (TempData.Peek("ReferenceNo") != null)
                    {
                    NomTemp ntp = new NomTemp();
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
        public ActionResult CaptureDependants(NomTemp dependant)
            {
            if (TempData.Peek("Dependants") == null)
                {
                List<NomTemp> thedependants = new List<NomTemp>();
                dependant.ID_SBTS = thedependants.Count + 1;
                thedependants.Add(dependant);
                TempData["Dependants"] = thedependants;
                }
            else
                {
                List<NomTemp> thedependants = (List<NomTemp>)TempData.Peek("Dependants");
                dependant.ID_SBTS = thedependants.Count + 1;
                thedependants.Add(dependant);
                TempData["Dependants"] = thedependants;
                }

            NomTemp ntp = new NomTemp();
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
                    NomTemp dependanttoremove = new NomTemp();
                    List<NomTemp> thedependants = (List<NomTemp>)TempData.Peek("Dependants");

                    foreach (NomTemp dp in thedependants)
                        {
                        if (dp.ID_SBTS == id)
                            {
                            dependanttoremove = dp;
                            }
                        }

                    thedependants.Remove(dependanttoremove);

                    TempData["Dependants"] = thedependants;

                    NomTemp ntp = new NomTemp();
                    ntp.fref_no = TempData.Peek("ReferenceNo").ToString();

                    if (TempData.Peek("MyRelations") == null)
                        {
                        TempData["MyRelations"] = GetMyRelations();
                        }

                    return View("DependantCapture", ntp);

                    }
                else
                    {

                    List<NomTemp> thedependants = (List<NomTemp>)TempData.Peek("Dependants");
                    NomTemp ntp = new NomTemp();
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
                List<NomTemp> thedependants = (List<NomTemp>)TempData.Peek("Dependants");
                NomTemp ntp = new NomTemp();
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
        public ActionResult CompleteCapture(NomTemp dependants)
            {
            List<NomTemp> alldependants = (List<NomTemp>)TempData.Peek("Dependants");

            foreach (NomTemp dp in alldependants)
                {
                db.NomTemps.Add(dp);
                db.SaveChanges();
                }


            CaptureMemRegViewModel c = (CaptureMemRegViewModel)TempData.Peek("RegistrationForm");

            ParentalTemp p = new ParentalTemp();
            p.fref_no = c.fref_no;
            p.ffirstname = c.ffirstname;
            p.ffsurname = c.ffsurname;
            p.ffothname = c.ffothname;

            p.fmfirstname = c.fmfirstname;
            p.fmsurname = c.fmsurname;
            p.fmothname = c.fmothname;

            db.ParentalTemps.Add(p);
            db.SaveChanges();


            MemberTransaction m = new MemberTransaction();

            m.fref_no = c.fref_no;

            if (c.fb_date != null)
                {
                m.fssno = GenerateSSNo(c.fprovince , c.fdist, c.fchief, c.fb_date.Value);
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
            m.CreatedOn = DateTime.Now;
            m.CreatedBy = "DEFAULT";
            m.ModifiedOn = DateTime.Now;

            db.MemberTransactions.Add(m);
            db.SaveChanges();

            return RedirectToAction("CaptureRegistrationForms");

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
            int thecount = db.MemberValids.Where(p => p.fssno == SSNo).Count();

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
            string Query = "SELECT TOP 1 fssno From MemberValid WHERE fssno like '" + SSNo + "%'";
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
            string Query = "SELECT fcode, fdescr From Occupations";
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


        public List<PDCTemplate> GetMyDistrict()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT d_code, d_desc From District";
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



        public List<PDCTemplate> GetMyChiefdom()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fc_code, fdescr From Chiefdom ORDER BY fc_code ASC";
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
            string Query = "SELECT TOP 20 ferno, femp_name, faddress1, faddress2, ftown, ftelno From EmployMastersheet";
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
            string Query = "SELECT frel_code, frel_desc From RelativesTypesMaster";
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
                    ct.Name = myp.Field<String>("frel_desc");

                    mylist.Add(ct);
                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }




        }
    }

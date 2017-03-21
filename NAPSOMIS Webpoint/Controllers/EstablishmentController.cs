using NAPSOMIS_Webpoint.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.Models;

namespace NAPSOMIS_Webpoint.Controllers
    {
    public class EstablishmentController : Controller
        {

        NAPSOMISModel db = new NAPSOMISModel();

        #region "Register New Establishment"


        // GET: Register New Establishment
        public ActionResult RegisterNew()
            {
            if (TempData.Peek("MyZones") == null)
                {
                TempData["MyZones"] = GetMyZones();
                }

            if (TempData.Peek("MyEconActivities") == null)
                {
                TempData["MyEconActivities"] = GetMyEconActivities();
                }

            return View();
            }


        public ActionResult RegisterNew_Save(EmployMastersheet emp)
            {

            try
                {

                if (ModelState.IsValid)
                    {
                    string erno = "";

                    int startno = 0;

                    while (true)
                        {
                        startno += 1;
                        string fullstartno = CompleteStartNo(startno);

                        erno = "W01" + emp.fecon_act.ToString() + emp.freg_date.ToString("yyyy") + fullstartno;

                        if (checkifernoisused(erno) == false) break;

                        }

                    emp.ferno = erno;
                    emp.CreatedBy = "DEFAULT";
                    emp.CreatedOn = DateTime.Today;


                    db.EmployMastersheets.Add(emp);
                    db.SaveChanges();

                    return View("RegisterNew", emp);
                    }
                else
                    {
                    return View("RegisterNew", emp);
                    }

                }
            catch (Exception)
                {

                throw;
                }

            }


        private bool checkifernoisused(string erno)
            {
            int thecount = db.EmployMastersheets.Where(p => p.ferno == erno).Count();

            if (thecount > 0)
                {
                return true;
                }
            return false;
            }

        private string CompleteStartNo(int TheNo)
            {
            string newValue = TheNo.ToString();

            if (TheNo < 10)
                {
                newValue = "00" + TheNo;
                }
            else if (TheNo >= 10 && TheNo < 100)
                {
                newValue = "0" + TheNo;
                }
            else if (TheNo >= 100 && TheNo < 1000)
                {
                newValue = "" + TheNo;
                }

            return newValue;
            }

        #endregion



        // GET: Add Existing Establishment
        public ActionResult AddExisting()
            {
            return View();
            }


        #region "RePrint Acknowledgement Letter"

        // GET:  RePrint Acknowledgement Letter
        public ActionResult RePrint()
            {

            if (TempData.Peek("MyEstablishments") == null)
                {
                TempData["MyEstablishments"] = GetMyEstablishments();
                }

            return View("RePrint");
            }


        public ActionResult RePrint_Filter(ReprintAckLetterViewModel emp)
            {

            TempData["MyEstablishments"] = GetMyEstablishmentsbyFilter(emp.fsearch);

            return View("RePrint", emp);
            }

        public ActionResult RePrint_Print(ReprintAckLetterViewModel emp)
            {

            if (emp.ferno != "" && emp.ferno != null)
                {

                List<EmployMastersheet> employer = new List<EmployMastersheet>();
                employer = db.EmployMastersheets.Where(b => b.ferno == emp.ferno).ToList();

                if (employer.Count > 0)
                    {
                    XtraReportRePrintAckLetter mydocument = new XtraReportRePrintAckLetter();
                    mydocument.EmployerMasterDataSource.DataSource = employer[0];

                    mydocument.CreateDocument();

                    return View("PrintPreview", mydocument);

                    }
                else
                    {
                    return View("RePrint");
                    }

                }
            return View("RePrint");
            }

        #endregion



        #region "Update Establishment Record"

        // GET:  Update Establishment Record
        public ActionResult UpdateEstablishment()
            {
            return View("UpdateEstablishment");
            }
        
        public ActionResult UpdateEstablishment_Search(EmployMastersheet emp)
            {

            var refno = Request["ferno_search"];

            List<EmployMastersheet> employer = new List<EmployMastersheet>();
            employer = db.EmployMastersheets.Where(b => b.ferno == refno).ToList();

            if (employer.Count > 0)
                {
                return View("UpdateEstablishment", employer[0]);
                }
            else
                {
                ViewBag.Error = "No record was found matching the ERNo: " + emp.ferno + ". Please verify and try again.";
                return View("UpdateEstablishment");
                }

            }

        public ActionResult UpdateEstablishment_Update(EmployMastersheet emp)
            {

            List<EmployMastersheet> employer = new List<EmployMastersheet>();
            employer = db.EmployMastersheets.Where(b => b.ferno == emp.ferno).ToList();

            EmployMastersheet demp = new EmployMastersheet();

            //This checks if the an employer record was collected

            if (employer.Count > 0)
                {

                demp = employer[0];
                demp.faddress1 = emp.faddress1;
                demp.faddress2 = emp.faddress2;
                demp.fbusn_type = emp.fbusn_type;
                demp.fcert_date = emp.fcert_date;
                demp.fcert_no = emp.fcert_no;
                demp.fcomm_cno = emp.fcomm_cno;
                demp.fcomm_date = emp.fcomm_date;
                demp.fcontact = emp.fcontact;
                demp.fcov_date = emp.fcov_date;
                demp.fdateupd = DateTime.Today;
                demp.fecon_act = emp.fecon_act;
                demp.femp_name = emp.femp_name;
                demp.ferno = emp.ferno;
                demp.fest_type = emp.fest_type;
                demp.fiecon_act = emp.fiecon_act;
                demp.finsp_date = emp.finsp_date;
                demp.floc = emp.floc;
                demp.fnature = emp.fnature;
                demp.fowner = emp.fowner;
                demp.freg_date = emp.freg_date;
                demp.fsalpatt = emp.fsalpatt;
                demp.fschme = emp.fschme;
                demp.fsite = emp.fsite;
                demp.fstatus = emp.fstatus;
                demp.ftelno = emp.ftelno;
                demp.ftown = emp.ftown;
                demp.fzone = emp.fzone;
                demp.ModifiedBy = "DEFAULT";
                demp.ModifiedOn = DateTime.Today;


                db.EmployMastersheets.Attach(demp);
                var entry = db.Entry(demp);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                }
            else
                {

                emp.CreatedOn = DateTime.Today;
                emp.CreatedBy = "DEFAULT";

                db.EmployMastersheets.Add(emp);
                db.SaveChanges();
                }

            return View("UpdateEstablishment", emp);

            }

        #endregion

        // GET: Update Director Information 
        public ActionResult UpdateDirector()
            {
            return View();
            }

        // GET:  Update Employer Categories
        public ActionResult UpdateEmployer()
            {
            return View();
            }

        // GET:  Transfer Establishment To Head Office
        public ActionResult TransferEstablishment()
            {
            return View();
            }

        // GET:  Deactivate Establishment
        public ActionResult DeactiveEstablishment()
            {
            return View();
            }

        // GET:  ReActivate Establishment
        public ActionResult ReActivateEstablishment()
            {
            return View();
            }


        public List<PDCTemplate> GetMyZones()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fzone, fzone_name From ZoneCode";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("fzone");
                    ct.Name = myp.Field<String>("fzone_name");

                    mylist.Add(ct);

                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }



        public List<PDCTemplate> GetMyEconActivities()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fcode, fdesc From econ_act";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

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


        public List<PDCTemplate> GetMyEstablishments()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT TOP 200 ferno, femp_name From EmployMastersheet ORDER BY femp_name ASC";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("ferno");
                    ct.Name = myp.Field<String>("femp_name");

                    mylist.Add(ct);

                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }


        public List<PDCTemplate> GetMyEstablishmentsbyFilter(string Search)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query;

            if (Search != "")
                {
                Query = "SELECT ferno, femp_name From EmployMastersheet WHERE femp_name LIKE '" + Search + "%' ORDER BY femp_name ASC";

                }
            else
                {
                Query = "SELECT TOP 200 ferno, femp_name From EmployMastersheet ORDER BY femp_name ASC";

                }
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("ferno");
                    ct.Name = myp.Field<String>("femp_name");

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
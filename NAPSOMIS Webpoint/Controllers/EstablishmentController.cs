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


        public ActionResult RegisterNew_Save(emp_mst emp)
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

                        erno = "W01" + emp.fecon_act.ToString() + emp.freg_date.Value.ToString("yyyy") + fullstartno;

                        if (checkifernoisused(erno) == false) break;

                        }

                    emp.ferno = erno;
                    emp.CreatedBy = "DEFAULT";
                    emp.CreatedOn = DateTime.Today;


                    db.emp_mst.Add(emp);
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
            int thecount = db.emp_mst.Where(p => p.ferno == erno).Count();

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

                List<emp_mst> employer = new List<emp_mst>();
                employer = db.emp_mst.Where(b => b.ferno == emp.ferno).ToList();

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

        public ActionResult UpdateEstablishment_Search(emp_mst emp)
            {

            var refno = Request["ferno_search"];

            List<emp_mst> employer = new List<emp_mst>();
            employer = db.emp_mst.Where(b => b.ferno == refno).ToList();

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

        public ActionResult UpdateEstablishment_Update(emp_mst emp)
            {

            List<emp_mst> employer = new List<emp_mst>();
            employer = db.emp_mst.Where(b => b.ferno == emp.ferno).ToList();

            emp_mst demp = new emp_mst();

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
                //demp.fstatus = emp.fstatus;
                demp.ftelno = emp.ftelno;
                demp.ftown = emp.ftown;
                demp.fzone = emp.fzone;
                demp.ModifiedBy = "DEFAULT";
                demp.ModifiedOn = DateTime.Today;


                db.emp_mst.Attach(demp);
                var entry = db.Entry(demp);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                }
            else
                {

                emp.CreatedOn = DateTime.Today;
                emp.CreatedBy = "DEFAULT";

                db.emp_mst.Add(emp);
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
            string Query = "SELECT TOP 200 ferno, femp_name From emp_mst ORDER BY femp_name ASC";
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
                Query = "SELECT ferno, femp_name From emp_mst WHERE femp_name LIKE '" + Search + "%' ORDER BY femp_name ASC";

                }
            else
                {
                Query = "SELECT TOP 200 ferno, femp_name From emp_mst ORDER BY femp_name ASC";

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

        #region "UPDATE MAIN EMPLOYER CATEGORIES"

        public ActionResult UpdateEmployerMain()
            {

            TempData["MyMainCategories"] = GetMainCategories();

            return View("UpdateEmployerMain");
            }


        public ActionResult UpdateEmployerMain_Save(main_cat m)
            {

            string searchCat = Request["cat_code_search"].ToString();

            if (searchCat != "")
                {
                string[] thesplit = searchCat.Split(';');
                string thecode = thesplit[0];

                List<main_cat> themain = new List<main_cat>();
                themain = db.main_cat.Where(b => b.cat_code == thecode).ToList();

                if (themain.Count > 0)
                    {
                    themain[0].cat_code = m.cat_code;
                    themain[0].description = m.description;

                    db.main_cat.Attach(themain[0]);
                    var entry = db.Entry(themain[0]);
                    entry.State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                    }

                }
            else
                {
                main_cat themain = new main_cat();
                themain.cat_code = m.cat_code;
                themain.description = m.description;

                db.main_cat.Add(themain);
                db.SaveChanges();
                }

            return RedirectToAction("UpdateEmployerMain");
            }

        private List<PDCTemplate> GetMainCategories()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT cat_code, description From main_cat";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<District> district = db.Districts.SqlQuery("SELECT ID_SBTS, d_code, d_desc From District").ToList();

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



        #endregion


        #region "UPDATE STAFF CATEGORIES"

        public ActionResult UpdateEmployerStaff()
            {

            TempData["MyStaffCategories"] = null;

            return View("UpdateEmployerStaff");
            }

        public ActionResult UpdateEmployerStaff_ERNO(staf_cat m)
            {


            string ferno = m.ferno;
            TempData["MyStaffCategories"] = GetStaffCategories(ferno);

            staf_cat s = new staf_cat();
            s.ferno = m.ferno;

            return View("UpdateEmployerStaff", s);
            }

        public ActionResult UpdateEmployerStaff_Save(staf_cat m)
            {

            string searchCat = Request["cat_code_search"].ToString();

            if (searchCat != "")
                {
                string[] thesplit = searchCat.Split(';');
                string thecode = thesplit[0];

                List<staf_cat> themain = new List<staf_cat>();
                themain = db.staf_cat.Where(b => b.fcat == thecode).Where(c => c.ferno == m.ferno).ToList();

                if (themain.Count > 0)
                    {
                    themain[0].fcat = m.fcat;
                    themain[0].fdesc = m.fdesc;
                    themain[0].ferno = m.ferno;
                    themain[0].fmedia = m.fmedia;

                    db.staf_cat.Attach(themain[0]);
                    var entry = db.Entry(themain[0]);
                    entry.State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                    }

                staf_cat st = new staf_cat();
                st.ferno = m.ferno;

                return RedirectToAction("UpdateEmployerStaff_ERNO", st);

                }
            else
                {
                staf_cat themain = new staf_cat();
                themain.fcat = m.fcat;
                themain.fdesc = m.fdesc;
                themain.ferno = m.ferno;
                themain.fmedia = m.fmedia;

                db.staf_cat.Add(themain);
                db.SaveChanges();

                return RedirectToAction("UpdateEmployerStaff_ERNO", themain);
                }


            }

        private List<PDCTemplate> GetStaffCategories(string erno)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT cat_code, description From Staf_Cat WHERE ferno = '" + erno + "'";

            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<District> district = db.Districts.SqlQuery("SELECT ID_SBTS, d_code, d_desc From District").ToList();

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


        #endregion


        #region "DEACTIVATE ESTABLISHMENT"
        public ActionResult Deactivate()
            {
            TempData["MyEstablishments"] = GetMyEstablishmentsbyFilter("");

            return View("Deactivate");
            }


        public ActionResult Deactivate_OK(EstablishmentDeactReactViewModel est)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == est.ferno).ToList();

            if (emp.Count > 0)
                {

                emp_mst newemp = new emp_mst();
                newemp = emp[0];
                newemp.fstatus = "D";

                db.emp_mst.Attach(newemp);
                var entry = db.Entry(newemp);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


                est_deac estd = new est_deac();
                estd.flast_cr = est.contribution.Value;
                estd.ferno = est.ferno;
                estd.flast_period = est.last_period;
                estd.flast_lf = est.labour_force.Value;

                db.est_deac.Add(estd);
                db.SaveChanges();

                return RedirectToAction("Deactivate");

                }
            else
                {
                return RedirectToAction("Deactivate");
                }


            }


        public ActionResult Deactivate_CLOSE(EstablishmentDeactReactViewModel est)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == est.ferno).ToList();

            if (emp.Count > 0)
                {

                emp_mst newemp = new emp_mst();
                newemp = emp[0];
                newemp.fstatus = "C";

                db.emp_mst.Attach(newemp);
                var entry = db.Entry(newemp);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


                est_deac estd = new est_deac();
                estd.flast_cr = est.contribution.Value;
                estd.ferno = est.ferno;
                estd.flast_period = est.last_period;
                estd.flast_lf = est.labour_force.Value;

                db.est_deac.Add(estd);
                db.SaveChanges();

                return RedirectToAction("Deactivate");

                }
            else
                {
                return RedirectToAction("Deactivate");
                }


            }

        public ActionResult Deactivate_Load(EstablishmentDeactReactViewModel est)
            {

            List<emp_mst> ed = new List<emp_mst>();
            ed = db.emp_mst.Where(b => b.ferno == est.ferno).ToList();

            if (ed.Count > 0)
                {

                List<PDCTemplate> mylist = new List<PDCTemplate>();

                PDCTemplate ct = new PDCTemplate();
                ct.Code = ed[0].ferno;
                ct.Name = ed[0].femp_name; 
                mylist.Add(ct);

                TempData["MyEstablishments"] = mylist;

                EstablishmentDeactReactViewModel estmodel = new EstablishmentDeactReactViewModel();
                estmodel.ferno = est.ferno;

                return View("Deactivate", estmodel);
                }

            return View("Deactivate", est);
            }


        public ActionResult Deactivate_Filter(EstablishmentDeactReactViewModel est)
            {

            TempData["MyEstablishments"] = GetMyEstablishmentsbyFilter(est.fsearch);

            return View("Deactivate", est);
            }



        #endregion


        #region "DEACTIVATE ESTABLISHMENT"
        public ActionResult ReActivate()
            {
            TempData["MyEstablishments"] = GetMyEstablishmentsbyFilter("");

            return View("ReActivate");
            }


        public ActionResult ReActivate_OK(EstablishmentDeactReactViewModel est)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == est.ferno).ToList();

            if (emp.Count > 0)
                {

                emp_mst newemp = new emp_mst();
                newemp = emp[0];
                newemp.fstatus = "A";

                db.emp_mst.Attach(newemp);
                var entry = db.Entry(newemp);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


                est_deac estd = new est_deac();
                estd.flast_cr = est.contribution.Value;
                estd.ferno = est.ferno;
                estd.flast_period = est.last_period;
                estd.flast_lf = est.labour_force.Value;
                estd.freact_period = est.begin_period;

                db.est_deac.Add(estd);
                db.SaveChanges();

                return RedirectToAction("ReActivate");

                }
            else
                {
                return RedirectToAction("ReActivate");
                }


            }

        public ActionResult ReActivate_Filter(EstablishmentDeactReactViewModel est)
            {

            TempData["MyEstablishments"] = GetMyEstablishmentsbyFilter(est.fsearch);

            return View("ReActivate", est);
            }


        public ActionResult ReActivate_Load(EstablishmentDeactReactViewModel est)
            {

            List<est_deac> ed = new List<est_deac>();
            ed = db.est_deac.Where(b => b.ferno == est.ferno).ToList();

            if (ed.Count > 0)
                {
                EstablishmentDeactReactViewModel estmodel = new EstablishmentDeactReactViewModel();
                estmodel.contribution = ed[0].flast_cr;
                estmodel.ferno = ed[0].ferno;
                estmodel.labour_force = ed[0].flast_lf;
                estmodel.last_period = ed[0].flast_period;

                return View("ReActivate", estmodel);
                }

            return View("ReActivate", est);
            }

        #endregion

        }

    }
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
                    List<MemberTransaction> mt = new List<MemberTransaction>();
                    mt = db.MemberTransactions.Where(r => r.fref_no == refno).ToList();

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
                    List<MemberTransaction> mt = new List<MemberTransaction>();
                    mt = db.MemberTransactions.Where(r => r.fref_no == refno).ToList();

                    CaptureMemRegViewModel mvm = new CaptureMemRegViewModel();

                    if (mt.Count == 0) return View("EditForm");

                    mvm.fref_no = mt[0].fref_no;
                    mvm.firstname = mt[0].firstname;
                    mvm.fothname = mt[0].fothname;
                    mvm.fsurname = mt[0].fsurname;
                    mvm.fb_date = mt[0].fb_date;
                    mvm.fjoindate = mt[0].fjoindate;
                    mvm.fbatch = mt[0].fbatch;

                    mvm.fbatch = mt[0].fbatch;
                    mvm.fb_country = mt[0].fb_country;

                    mvm.fchief = mt[0].fchief;
                    mvm.fcur_addr = mt[0].fcur_addr;
                    mvm.fdist = mt[0].fdist;
                    mvm.femp_addr = mt[0].femp_addr;
                    mvm.femp_name = mt[0].femp_name;
                    mvm.ferno = mt[0].ferno;

                    mvm.fgen_date = mt[0].fgen_date;
                    mvm.fgov_code = mt[0].fgov_code;
                    mvm.fincome = mt[0].fincome;
                    mvm.fm_stat = mt[0].fm_stat;
                    mvm.fnation = mt[0].fnation;
                    mvm.fnat_income = mt[0].fnat_income;
                    mvm.foccupation = mt[0].foccupation;
                    mvm.fper_addr = mt[0].fper_addr;
                    mvm.fprovince = mt[0].fprovince;
                    mvm.freg_date = mt[0].freg_date;
                    mvm.fsex = mt[0].fsex;

                    mvm.fssno = mt[0].fssno;

                    mvm.ftel_no = mt[0].ftel_no;
                    mvm.ftown = mt[0].ftown;
                    mvm.ID_SBTS = mt[0].ID_SBTS;

                    mvm.ModifiedBy = "DEFAULT";
                    mvm.ModifiedOn = DateTime.Today;

                    //GET PARENTS INFORMATION 
                    List<ParentalTemp> p = new List<ParentalTemp>();
                    p = db.ParentalTemps.Where(b => b.fref_no == refno).ToList();

                    mvm.ffirstname = p[0].ffirstname;
                    mvm.ffothname = p[0].ffothname;
                    mvm.ffsurname = p[0].ffsurname;

                    mvm.fmfirstname = p[0].fmfirstname;
                    mvm.fmothname = p[0].fmothname;
                    mvm.fmsurname = p[0].fmsurname;


                    List<PreviousName> prev = new List<PreviousName>();
                    prev = db.PreviousNames.Where(r => r.fref_no == refno).ToList();
                    PreviousName previous = new PreviousName();

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


            ParentalTemp searchparental = new ParentalTemp();
            searchparental = db.ParentalTemps.Where(b => b.fref_no == c.fref_no).Single();

            ParentalTemp p = new ParentalTemp();
            p = db.ParentalTemps.Find(searchparental.ID_SBTS);

            p.ffirstname = c.ffirstname;
            p.ffsurname = c.ffsurname;
            p.ffothname = c.ffothname;

            p.fmfirstname = c.fmfirstname;
            p.fmsurname = c.fmsurname;
            p.fmothname = c.fmothname;

            db.ParentalTemps.Remove(searchparental);
            db.SaveChanges();

            db.ParentalTemps.Add(p);
            db.SaveChanges();


            MemberTransaction searchmember = new MemberTransaction();
            searchmember = db.MemberTransactions.Where(b => b.fref_no == c.fref_no).Single();

            db.MemberTransactions.Remove(searchmember);
            db.SaveChanges();


            MemberTransaction m = new MemberTransaction();

            m.fref_no = c.fref_no;

            if (c.fb_date != null)
                {
                m.fssno = GenerateSSNo(c.fprovince, c.fdist, c.fchief, c.fb_date.Value);
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

            db.MemberTransactions.Add(m);
            db.SaveChanges();


            List<PreviousName> prev = new List<PreviousName>();
            prev = db.PreviousNames.Where(r => r.fref_no == m.fref_no).ToList();
            PreviousName previous = new PreviousName();

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

                db.PreviousNames.Attach(previous);
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

                db.PreviousNames.Add(previous);
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
                List<NomTemp> d = new List<NomTemp>();
                d = db.NomTemps.Where(b => b.fref_no == refno).ToList();

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
                NomTemp dep = new NomTemp();
                dep = db.NomTemps.Find(id);

                db.NomTemps.Remove(dep);
                db.SaveChanges();

                if (TempData.Peek("MemberEditReferenceNo") != null)
                    {
                    NomTemp ntp = new NomTemp();
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

                NomTemp dep = new NomTemp();
                dep = db.NomTemps.Find(id);

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
                NomTemp d = new NomTemp();
                d.fref_no = refno;

                return View("DependantEdit", d);

                }
            catch (Exception)
                {
                return View("DependantEdit");
                }

            }


        public ActionResult SaveDependantEdit(NomTemp dependant)
            {
            try
                {

                NomTemp dep = new NomTemp();

                bool isNewRecord;

                if (dependant.ID_SBTS == 0)
                    {
                    isNewRecord = true;
                    }
                else
                    {
                    isNewRecord = false;
                    dep = db.NomTemps.Find(dependant.ID_SBTS);
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
                dep.ModifiedBy = "DEFAULT";

                if (!isNewRecord)
                    {

                    db.NomTemps.Attach(dep);
                    var entry = db.Entry(dep);
                    entry.State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();

                    }
                else
                    {
                    db.NomTemps.Add(dep);
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


            ParentalTemp searchparental = new ParentalTemp();
            searchparental = db.ParentalTemps.Where(b => b.fref_no == c.fref_no).Single();

            ParentalTemp p = new ParentalTemp();
            p = db.ParentalTemps.Find(searchparental.ID_SBTS);

            p.ffirstname = c.ffirstname;
            p.ffsurname = c.ffsurname;
            p.ffothname = c.ffothname;

            p.fmfirstname = c.fmfirstname;
            p.fmsurname = c.fmsurname;
            p.fmothname = c.fmothname;
            p.ModifiedBy = "DEFAULT";
            p.ModifiedOn = DateTime.Today;

            //UPDATING THE PARENTAL RECORD
            db.ParentalTemps.Attach(p);
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



            MemberTransaction sm = new MemberTransaction();
            sm = db.MemberTransactions.Where(b => b.fref_no == c.fref_no).Single();

            MemberTransaction m = new MemberTransaction();
            m = db.MemberTransactions.Find(sm.ID_SBTS);

            m.fref_no = c.fref_no;

            if (c.fb_date != null)
                {
                m.fssno = GenerateSSNo(c.fprovince, c.fdist, c.fchief, c.fb_date.Value);
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
            db.MemberTransactions.Attach(m);
            var theentry = db.Entry(m);
            theentry.State = System.Data.Entity.EntityState.Modified;

            entry.Property(e => e.ID_SBTS).IsModified = false;
            db.SaveChanges();


            List<PreviousName> prev = new List<PreviousName>();
            prev = db.PreviousNames.Where(r => r.fref_no == m.fref_no).ToList();
            PreviousName previous = new PreviousName();

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


                db.PreviousNames.Attach(previous);
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

                db.PreviousNames.Add(previous);
                db.SaveChanges();
                }

            if (m.fref_no != c.fref_no || m.fssno != c.fssno)
                {
                List<NomTemp> depen = new List<NomTemp>();
                depen = db.NomTemps.Where(b => b.fref_no == m.fref_no).ToList();

                if (depen.Count > 0)
                    {
                    foreach (var de in depen)
                        {

                        de.fref_no = c.fref_no;
                        de.fssno = c.fssno;

                        db.NomTemps.Attach(de);
                        var sentry = db.Entry(de);
                        sentry.State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        }
                    }
                }

            return RedirectToAction("EditForm", c);

            }

        [HttpPost]
        public ActionResult CompleteEdit(NomTemp dependants)
            {

            return RedirectToAction("EditForm");

            }


        #endregion

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


            List<MemberTransaction> mlist = new List<MemberTransaction>();
            mlist = db.MemberTransactions.Where(b => b.fref_no == c.fref_no).ToList();

            MemberTransaction m = new MemberTransaction();
            m = mlist[0];

            m.fref_no = c.fref_no;

            if (c.fb_date != null)
                {
                m.fssno = GenerateSSNo(c.fprovince, c.fdist, c.fchief, c.fb_date.Value);
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


            db.MemberTransactions.Attach(m);
            var entry = db.Entry(m);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();


            List<PreviousName> prev = new List<PreviousName>();
            prev = db.PreviousNames.Where(r => r.fref_no == m.fref_no).ToList();
            PreviousName previous = new PreviousName();

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


                db.PreviousNames.Attach(previous);
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

                db.PreviousNames.Add(previous);
                db.SaveChanges();
                }

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

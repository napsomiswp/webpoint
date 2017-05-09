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
    public class AccountPaymentController : Controller
        {

        NAPSOMISModel db = new NAPSOMISModel();

        #region CASH PAYMENTS

        // GET: AccountPayment
        public ActionResult ManualPayments()
            {

            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            TempData["CashPaymentBreakdowns"] = null;
            TempData["Balance"] = null;

            TempData["MyBanks"] = GetMyBanks();
            TempData["MyAreaOffices"] = GetMyZones();
            TempData["MyPaymentTypes"] = GetMyPaymentTypes();


            return View("ManualPayments", new AccountPaymentViewModel() { cashcummulated = 0, cashbalance = 0 });

            }

        public ActionResult CashPayments_LoadSSNo(AccountPaymentViewModel a)
            {

            List<mper_mst> mp = new List<mper_mst>();
            mp = db.mper_mst.Where(b => b.fssno == a.cashssno).ToList();

            if (mp.Count > 0)
                {
                a.cashmembername = mp[0].fsurname + ", " + mp[0].firstname + " " + mp[0].fothname;
                }
            else
                {
                ViewBag.Message = "INVALID S.S. NUMBER. PLEASE VERIFY AND TRY AGAIN.";
                a.cashmembername = "";
                }

            return View("ManualPayments", a);
            }

        public ActionResult CashPayments_LoadERNo(AccountPaymentViewModel a)
            {

            a.cashestablishment = GetEmployerName(a.cashERNO);

            if (a.cashestablishment == "")
                {
                ViewBag.Message = "INVALID ER No. PLEASE VERIFY AND TRY AGAIN.";
                }

            return View("ManualPayments", a);
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

        private string GetEmployerBusinessType(string ferno)
            {
            List<emp_mst> emp = new List<emp_mst>();
            emp = db.emp_mst.Where(b => b.ferno == ferno).ToList();

            if (emp.Count > 0)
                {

                return emp[0].fbusn_type;
                }
            else
                {
                return "";
                }
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

        public List<PDCTemplate> GetMyPaymentTypes()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT code, descr From ctype";

            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("code");
                    ct.Name = myp.Field<String>("descr");

                    mylist.Add(ct);
                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }

        public List<PDCTemplate> GetMyPaypoint()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fp_code, fp_desc From p_point";

            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("fp_code");
                    ct.Name = myp.Field<String>("fp_desc");

                    mylist.Add(ct);
                    }

                return mylist;
                }
            else
                {
                return mylist;
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

        public ActionResult CashPayments_OK(AccountPaymentViewModel a)
            {


            if (TempData.Peek("Balance") != null)
                {

                if ((decimal.Parse(TempData.Peek("Balance").ToString()) - a.cashamount) < 0)
                    {
                    ViewBag.Message = "AMOUNT STATED MUST NOT EXCEED THE AVAILABLE BALANCE";
                    return View("ManualPayments", a);
                    }

                a.cashbalance = decimal.Parse(TempData.Peek("Balance").ToString()) - a.cashamount;
                TempData["Balance"] = a.cashbalance;
                }
            else
                {

                if (a.cashtotalamount - a.cashamount < 0)
                    {
                    ViewBag.Message = "AMOUNT STATED MUST NOT EXCEED THE AVAILABLE BALANCE";
                    return View("ManualPayments", a);
                    }

                TempData["Balance"] = a.cashtotalamount - a.cashamount;
                a.cashbalance = a.cashtotalamount - a.cashamount;

                }


            a.cashcummulated += a.cashamount;

            CashPaymentBreakdownViewModel p = new CashPaymentBreakdownViewModel();
            p.fType = a.cashtype;
            p.fCode = "CR";
            p.fFrom = a.cashfrom;
            p.fTo = a.cashto;
            p.fAmount = a.cashamount;
            p.fLF = a.cashlabourforce;

            if (TempData.Peek("CashPaymentBreakdowns") == null)
                {
                List<CashPaymentBreakdownViewModel> cp = new List<CashPaymentBreakdownViewModel>();
                cp.Add(p);

                TempData["CashPaymentBreakdowns"] = cp;

                }
            else
                {

                List<CashPaymentBreakdownViewModel> cp = new List<CashPaymentBreakdownViewModel>();
                cp = (List<CashPaymentBreakdownViewModel>)TempData.Peek("CashPaymentBreakdowns");

                cp.Add(p);
                TempData["CashPaymentBreakdowns"] = cp;

                }


            int dmonth = int.Parse(a.cashfrom.Substring(4, 2));
            int dyear = int.Parse(a.cashfrom.Substring(0, 4));

            if (dmonth < 12)
                {
                dmonth += 1;
                }
            else
                {
                dyear += 1;
                dmonth = 1;
                }

            string themonth = "";

            if (dmonth < 10)
                {
                themonth = "0" + dmonth;
                }
            else
                {
                themonth = dmonth.ToString();
                }

            a.cashfrom = dyear + themonth;

            return View("ManualPayments", a);

            }

        public ActionResult CashPayments_Accept(AccountPaymentViewModel a)
            {

            int? dcount = db.empay_tr.Where(b => b.frecptno == a.cashreceiptno).Count();

            if (dcount != null)
                {
                if (dcount.Value > 0)
                    {
                    ViewBag.Message = "RECEIPT NO IS ALREADY ON FILE. PLEASE VERIFY AND TRYAGIN.";
                    return View("ManualPayments", a);
                    }
                }

            //txttype 
            //1 = CASH
            //2 = CHEQUE
            //3 = BANK TRANSFER

            int txttype = 1;

            DateTime? j_perd = null;
            DateTime? neg_perd = null;

            List<jdebt_tr> j = new List<jdebt_tr>();
            j = db.jdebt_tr.Where(b => b.ferno == a.cashERNO).ToList();

            if (j.Count > 0)
                {
                j_perd = j[0].fj_date;
                }


            List<eneg_mst> en = new List<eneg_mst>();
            en = db.eneg_mst.Where(b => b.ferno == a.cashERNO).ToList();

            if (en.Count > 0)
                {
                neg_perd = en[0].fneg_date;
                }

            //IF IT IS A LOST CARD
            if (a.cashLostCard)
                {
                paymt_tr p = new paymt_tr();

                p.fpaytype = "LC";
                p.frecptno = a.cashreceiptno;
                p.frecptdate = a.cashreceiptdate;
                p.famount = a.cashtotalamount;
                p.fmode = "1";
                p.fuser_code = Session["AccountID"].ToString();
                p.fschme = a.cashscheme;
                p.fdateupd = DateTime.Today;

                p.CreatedBy = Session["AccountID"].ToString();
                p.CreatedOn = DateTime.Today;

                p.ModifiedBy = Session["AccountID"].ToString();
                p.ModifiedOn = DateTime.Today;

                db.paymt_tr.Add(p);
                db.SaveChanges();
                }


            decimal mbak = 0;
            decimal mpen = 0;
            decimal mjge = 0;
            decimal marr = 0;
            decimal mbnk = 0;
            decimal mint = 0;
            decimal mreg = 0;
            decimal mlc = 0;

            List<CashPaymentBreakdownViewModel> cp = new List<CashPaymentBreakdownViewModel>();
            cp = (List<CashPaymentBreakdownViewModel>)TempData.Peek("CashPaymentBreakdowns");

            bool mvolu = false;

            if (cp.Count > 0)
                {
                foreach (CashPaymentBreakdownViewModel item in cp)
                    {

                    if (mvolu == false)
                        {

                        empay_tr e = new empay_tr();
                        e.ferno = a.cashERNO;
                        e.fperiod = item.fFrom;
                        e.fpaytype = item.fCode;
                        e.fe_period = item.fTo;
                        e.frecptno = a.cashreceiptno;
                        e.frecptdate = a.cashreceiptdate;

                        DateTime? pdate = a.cashreceiptdate;

                        if (a.cashtype == "CP")
                            {
                            //GET DATE FROM PAGE 5 fdate
                            pdate = a.cashreceiptdate;
                            }
                        else
                            {
                            pdate = a.cashreceiptdate;
                            }

                        e.fpaymt_date = pdate;
                        e.famount = item.fAmount;

                        int lf;

                        if (a.cashtype == "CP")
                            {
                            lf = 0;
                            }
                        else
                            {
                            lf = item.fLF.Value;
                            }

                        e.flf = lf;
                        e.fr_loc = a.cashdistcode;

                        e.fuser_code = Session["AccountID"].ToString();
                        e.fe_period = "";
                        e.fused = "";

                        e.fdateupd = DateTime.Today;
                        e.CreatedBy = Session["AccountID"].ToString();
                        e.CreatedOn = DateTime.Today;

                        if (a.cashscheme == null)
                            {
                            e.fschme = "";
                            }
                        else
                            {
                            e.fschme = a.cashscheme;
                            }

                        DateTime? chkdate = null;

                        if (item.fType == "CN")
                            {
                            //THIS IS INCORRECT BUT FOR NOW I JUST HAD TO SET IT TO DATE.TODAY
                            chkdate = neg_perd;
                            }
                        else if (item.fType == "CJ")
                            {
                            //THIS IS INCORRECT BUT FOR NOW I JUST HAD TO SET IT TO DATE.TODAY
                            chkdate = j_perd;

                            }

                        if (chkdate.HasValue)
                            {
                            e.fchk_date = chkdate.Value;
                            }

                        db.empay_tr.Add(e);
                        db.SaveChanges();

                        }
                    else
                        {

                        vpay_tr v = new vpay_tr();
                        v.fssno = a.cashssno;
                        v.ferno = a.cashERNO;
                        v.fperiod = item.fFrom;
                        v.fpaytype = item.fCode;
                        v.fe_period = item.fTo;
                        v.frecptno = a.cashreceiptno;
                        v.frecptdate = a.cashreceiptdate;

                        DateTime? pdate = a.cashreceiptdate;

                        if (a.cashtype == "CP")
                            {
                            //GET DATE FROM PAGE 5 fdate
                            }
                        else
                            {
                            pdate = a.cashreceiptdate;
                            }

                        v.fpaymt_date = pdate;
                        v.famount = item.fAmount;

                        v.flf = 1;

                        v.fr_loc = a.cashdistcode;
                        v.fschme = a.cashscheme;
                        v.fuser_code = Session["AccountID"].ToString();
                        v.fdateupd = DateTime.Today;


                        db.vpay_tr.Add(v);
                        db.SaveChanges();

                        }


                    if (a.cashtype == "CN")
                        {
                        List<eneg_mst> eng = new List<eneg_mst>();
                        eng = db.eneg_mst.Where(b => b.ferno == a.cashERNO).ToList();

                        if (eng.Count > 0)
                            {
                            eneg_mst en2 = new eneg_mst();
                            en2 = eng[0];

                            en2.ftnegpay += item.fAmount;
                            en2.flpaydate = a.cashreceiptdate;

                            db.eneg_mst.Attach(en2);
                            var entry = db.Entry(en2);
                            entry.State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            }
                        }
                    else if (a.cashtype == "CJ")
                        {

                        List<jdebt_tr> jb = new List<jdebt_tr>();
                        jb = db.jdebt_tr.Where(b => b.ferno == a.cashERNO).ToList();

                        if (jb.Count > 0)
                            {
                            jdebt_tr jb2 = new jdebt_tr();
                            jb2 = jb[0];

                            jb2.fpaid += item.fAmount;
                            jb2.fdateupd = a.cashreceiptdate;

                            db.jdebt_tr.Attach(jb2);
                            var entry = db.Entry(jb2);
                            entry.State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            }


                        }

                    switch (a.cashtype)
                        {
                        case "CR":
                            mreg += item.fAmount.Value;
                            break;

                        case "CB":
                            mbak += item.fAmount.Value;
                            break;

                        case "CP":
                            mpen += item.fAmount.Value;
                            break;

                        case "CJ":
                            mjge += item.fAmount.Value;
                            break;

                        case "CN":
                            marr += item.fAmount.Value;
                            break;

                        case "CS":
                            mbnk += item.fAmount.Value;
                            break;

                        case "CI":
                            mint += item.fAmount.Value;
                            break;

                        default:
                            break;
                        }

                    }


                if (a.cashdistcode == Session["Branch"].ToString())
                    {
                    if (cp.Count > 0)
                        {

                        if (mreg > 0)
                            {
                            paymt_tr pt = new paymt_tr();

                            string ferno = "";

                            if (mvolu == false)
                                {
                                ferno = a.cashERNO;
                                }
                            else
                                {
                                ferno = a.cashssno;
                                }

                            pt.ferno = ferno;
                            pt.fpaytype = "CR";
                            pt.frecptno = a.cashreceiptno;
                            pt.frecptdate = a.cashreceiptdate;
                            pt.famount = mreg;
                            pt.fuser_code = Session["AccountID"].ToString();

                            if (a.cashscheme == null)
                                {
                                pt.fschme = "";
                                }
                            else
                                {
                                pt.fschme = a.cashscheme;
                                }
                            pt.fnarration = "";

                            int dmode = 0;

                            if (txttype == 1)
                                {
                                dmode = 1;
                                }
                            else if (txttype == 2)
                                {
                                dmode = 2;
                                }
                            else
                                {
                                dmode = 3;
                                }

                            pt.fmode = dmode.ToString();
                            pt.fdateupd = DateTime.Today;

                            pt.CreatedBy = Session["AccountID"].ToString();
                            pt.CreatedOn = DateTime.Today;



                            db.paymt_tr.Add(pt);
                            db.SaveChanges();

                            }

                        if (mbak > 0)
                            {
                            paymt_tr pt = new paymt_tr();

                            string ferno = "";

                            if (mvolu == false)
                                {
                                ferno = a.cashERNO;
                                }
                            else
                                {
                                ferno = a.cashssno;
                                }

                            pt.ferno = ferno;
                            pt.fpaytype = "CB";
                            pt.frecptno = a.cashreceiptno;
                            pt.frecptdate = a.cashreceiptdate;
                            pt.famount = mbak;
                            pt.fuser_code = Session["AccountID"].ToString();
                            if (a.cashscheme == null)
                                {
                                pt.fschme = "";
                                }
                            else
                                {
                                pt.fschme = a.cashscheme;
                                }
                            pt.fnarration = "";

                            int dmode = 0;

                            if (txttype == 1)
                                {
                                dmode = 1;
                                }
                            else if (txttype == 2)
                                {
                                dmode = 2;
                                }
                            else
                                {
                                dmode = 3;
                                }

                            pt.fmode = dmode.ToString();
                            pt.fdateupd = DateTime.Today;

                            pt.CreatedBy = Session["AccountID"].ToString();
                            pt.CreatedOn = DateTime.Today;

                            db.paymt_tr.Add(pt);
                            db.SaveChanges();

                            }

                        if (mpen > 0)
                            {
                            paymt_tr pt = new paymt_tr();

                            string ferno = "";

                            if (mvolu == false)
                                {
                                ferno = a.cashERNO;
                                }
                            else
                                {
                                ferno = a.cashssno;
                                }

                            pt.ferno = ferno;
                            pt.fpaytype = "CP";
                            pt.frecptno = a.cashreceiptno;
                            pt.frecptdate = a.cashreceiptdate;
                            pt.famount = mpen;
                            pt.fuser_code = Session["AccountID"].ToString();
                            if (a.cashscheme == null)
                                {
                                pt.fschme = "";
                                }
                            else
                                {
                                pt.fschme = a.cashscheme;
                                }
                            pt.fnarration = "";

                            int dmode = 0;

                            if (txttype == 1)
                                {
                                dmode = 1;
                                }
                            else if (txttype == 2)
                                {
                                dmode = 2;
                                }
                            else
                                {
                                dmode = 3;
                                }

                            pt.fmode = dmode.ToString();
                            pt.fdateupd = DateTime.Today;

                            pt.CreatedBy = Session["AccountID"].ToString();
                            pt.CreatedOn = DateTime.Today;

                            db.paymt_tr.Add(pt);
                            db.SaveChanges();

                            }


                        if (mjge > 0)
                            {
                            paymt_tr pt = new paymt_tr();

                            string ferno = "";

                            if (mvolu == false)
                                {
                                ferno = a.cashERNO;
                                }
                            else
                                {
                                ferno = a.cashssno;
                                }

                            pt.ferno = ferno;
                            pt.fpaytype = "CJ";
                            pt.frecptno = a.cashreceiptno;
                            pt.frecptdate = a.cashreceiptdate;
                            pt.famount = mjge;
                            pt.fuser_code = Session["AccountID"].ToString();
                            if (a.cashscheme == null)
                                {
                                pt.fschme = "";
                                }
                            else
                                {
                                pt.fschme = a.cashscheme;
                                }
                            pt.fnarration = "";

                            int dmode = 0;

                            if (txttype == 1)
                                {
                                dmode = 1;
                                }
                            else if (txttype == 2)
                                {
                                dmode = 2;
                                }
                            else
                                {
                                dmode = 3;
                                }

                            pt.fmode = dmode.ToString();
                            pt.fdateupd = DateTime.Today;

                            pt.CreatedBy = Session["AccountID"].ToString();
                            pt.CreatedOn = DateTime.Today;

                            db.paymt_tr.Add(pt);
                            db.SaveChanges();

                            }


                        if (marr > 0)
                            {
                            paymt_tr pt = new paymt_tr();

                            string ferno = "";

                            if (mvolu == false)
                                {
                                ferno = a.cashERNO;
                                }
                            else
                                {
                                ferno = a.cashssno;
                                }

                            pt.ferno = ferno;
                            pt.fpaytype = "CN";
                            pt.frecptno = a.cashreceiptno;
                            pt.frecptdate = a.cashreceiptdate;
                            pt.famount = marr;
                            pt.fuser_code = Session["AccountID"].ToString();
                            if (a.cashscheme == null)
                                {
                                pt.fschme = "";
                                }
                            else
                                {
                                pt.fschme = a.cashscheme;
                                }
                            pt.fnarration = "";

                            int dmode = 0;

                            if (txttype == 1)
                                {
                                dmode = 1;
                                }
                            else if (txttype == 2)
                                {
                                dmode = 2;
                                }
                            else
                                {
                                dmode = 3;
                                }

                            pt.fmode = dmode.ToString();
                            pt.fdateupd = DateTime.Today;

                            pt.CreatedBy = Session["AccountID"].ToString();
                            pt.CreatedOn = DateTime.Today;

                            db.paymt_tr.Add(pt);
                            db.SaveChanges();

                            }


                        if (mbnk > 0)
                            {
                            paymt_tr pt = new paymt_tr();

                            string ferno = "";

                            if (mvolu == false)
                                {
                                ferno = a.cashERNO;
                                }
                            else
                                {
                                ferno = a.cashssno;
                                }

                            pt.ferno = ferno;
                            pt.fpaytype = "BC";
                            pt.frecptno = a.cashreceiptno;
                            pt.frecptdate = a.cashreceiptdate;
                            pt.famount = mbnk;
                            pt.fuser_code = Session["AccountID"].ToString();
                            if (a.cashscheme == null)
                                {
                                pt.fschme = "";
                                }
                            else
                                {
                                pt.fschme = a.cashscheme;
                                }
                            pt.fnarration = "";

                            int dmode = 0;

                            if (txttype == 1)
                                {
                                dmode = 1;
                                }
                            else if (txttype == 2)
                                {
                                dmode = 2;
                                }
                            else
                                {
                                dmode = 3;
                                }

                            pt.fmode = dmode.ToString();
                            pt.fdateupd = DateTime.Today;

                            pt.CreatedBy = Session["AccountID"].ToString();
                            pt.CreatedOn = DateTime.Today;

                            db.paymt_tr.Add(pt);
                            db.SaveChanges();

                            }


                        if (mint > 0)
                            {
                            paymt_tr pt = new paymt_tr();

                            string ferno = "";

                            if (mvolu == false)
                                {
                                ferno = a.cashERNO;
                                }
                            else
                                {
                                ferno = a.cashssno;
                                }

                            pt.ferno = ferno;
                            pt.fpaytype = "CI";
                            pt.frecptno = a.cashreceiptno;
                            pt.frecptdate = a.cashreceiptdate;
                            pt.famount = mint;
                            pt.fuser_code = Session["AccountID"].ToString();
                            if (a.cashscheme == null)
                                {
                                pt.fschme = "";
                                }
                            else
                                {
                                pt.fschme = a.cashscheme;
                                }
                            pt.fnarration = "";


                            int dmode = 0;

                            if (txttype == 1)
                                {
                                dmode = 1;
                                }
                            else if (txttype == 2)
                                {
                                dmode = 2;
                                }
                            else
                                {
                                dmode = 3;
                                }

                            pt.fmode = dmode.ToString();
                            pt.fdateupd = DateTime.Today;

                            pt.CreatedBy = Session["AccountID"].ToString();
                            pt.CreatedOn = DateTime.Today;

                            db.paymt_tr.Add(pt);
                            db.SaveChanges();

                            }


                        }


                    }


                }

            ViewBag.Message = "CASH RECEIPT SUCCESSFULLY CAPTURED";
            return View("ManualPayments", a);

            }

        #endregion

        #region CHEQUE PAYMENTS

        public ActionResult ChequePayments_LoadERNo(AccountPaymentViewModel a)
            {

            a.chequeEstablishment = GetEmployerName(a.chequeERNO);

            if (a.chequeEstablishment == "")
                {
                ViewBag.Message = "INVALID ER No. PLEASE VERIFY AND TRY AGAIN.";
                }

            a.TabIndex = 1;
            return View("ManualPayments", a);
            }

        public List<PDCTemplate> GetMyBanks()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fcode, fbank From bank";

            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("fcode");
                    ct.Name = myp.Field<String>("fbank");

                    mylist.Add(ct);
                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }

        public List<PDCTemplate> GetMyBankBranches(string bankcode)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fbrnch_code, fbrnch_name From b_brnch WHERE fbnk_code ='" + bankcode + "'";

            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("fbrnch_code");
                    ct.Name = myp.Field<String>("fbrnch_name");

                    mylist.Add(ct);
                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }

        public ActionResult ChequePayments_LoadBranches(AccountPaymentViewModel a)
            {

            TempData["MyBankBranches"] = GetMyBankBranches(a.chequebank);

            a.TabIndex = 1;

            return View("ManualPayments", a);

            }

        public ActionResult ChequePayments_OK(AccountPaymentViewModel a)
            {

            if (TempData.Peek("ChequeCumulated") != null)
                {

                decimal thecumulated = decimal.Parse(TempData.Peek("ChequeCumulated").ToString());

                TempData["ChequeCumulated"] = a.chequetotalamount + thecumulated;

                }
            else
                {

                TempData["ChequeCumulated"] = a.chequetotalamount;

                }


            a.chequecummulated = decimal.Parse(TempData.Peek("ChequeCumulated").ToString());

            ChequePaymentBreakdownViewModel p = new ChequePaymentBreakdownViewModel();
            p.fChequeNo = a.chequechequeno;
            p.fDate = a.chequedate;
            p.fAmount = a.chequetotalamount;
            p.fBank = a.chequebank;
            p.fBranch = a.chequebranch;

            if (TempData.Peek("ChequePaymentBreakdowns") == null)
                {
                List<ChequePaymentBreakdownViewModel> cp = new List<ChequePaymentBreakdownViewModel>();
                cp.Add(p);

                TempData["ChequePaymentBreakdowns"] = cp;

                }
            else
                {

                List<ChequePaymentBreakdownViewModel> cp = new List<ChequePaymentBreakdownViewModel>();
                cp = (List<ChequePaymentBreakdownViewModel>)TempData.Peek("ChequePaymentBreakdowns");

                cp.Add(p);
                TempData["ChequePaymentBreakdowns"] = cp;

                }

            a.TabIndex = 1;
            return View("ManualPayments", a);

            }

        public ActionResult ChequePayments_Accept(AccountPaymentViewModel a)
            {

            int? dreceiptcount = db.cheq_tr.Where(b => b.frecptno == a.chequereceiptno).Count();

            if (dreceiptcount != null)
                {
                if (dreceiptcount.Value > 0)
                    {
                    a.TabIndex = 1;
                    ViewBag.Message = "RECEIPT NO IS ALREADY ON FILE. PLEASE VERIFY AND TRYAGIN.";
                    return View("ManualPayments", a);
                    }
                }


            int? dchequecount = db.cheq_tr.Where(b => b.fcheqno == a.chequechequeno).Count();

            if (dchequecount != null)
                {
                if (dchequecount.Value > 0)
                    {
                    a.TabIndex = 1;
                    ViewBag.Message = "CHEQUE NO IS ALREADY ON FILE. PLEASE VERIFY AND TRYAGIN.";
                    return View("ManualPayments", a);
                    }
                }

            //txttype 
            //1 = cheque
            //2 = CHEQUE
            //3 = BANK TRANSFER

            int txttype = 2;


            //CHEQUE OPERATIONS

            if (txttype == 2)
                {

                List<ChequePaymentBreakdownViewModel> chp = new List<ChequePaymentBreakdownViewModel>();
                chp = (List<ChequePaymentBreakdownViewModel>)TempData.Peek("ChequePaymentBreakdowns");

                if (chp.Count > 0)
                    {
                    foreach (ChequePaymentBreakdownViewModel item in chp)
                        {

                        cheq_tr ch = new cheq_tr();
                        ch.ferno = a.chequeERNO;
                        ch.fcheqno = a.chequechequeno;
                        ch.frecptno = a.chequereceiptno;
                        ch.fcheqdate = a.chequedate;
                        ch.frecptdate = a.chequereceiptdate;
                        ch.famount = item.fAmount;
                        ch.fbank_code = a.chequebank;
                        ch.fr_loc = a.chequedistcode;
                        ch.fuser_code = Session["AccountID"].ToString();
                        ch.fdateupd = DateTime.Today;

                        ch.CreatedBy = Session["AccountID"].ToString();
                        ch.CreatedOn = DateTime.Today;

                        db.cheq_tr.Add(ch);
                        db.SaveChanges();

                        }


                    }


                }

            ViewBag.Message = "CHEQUE RECEIPT SUCCESSFULLY CAPTURED";
            a.TabIndex = 1;
            return View("ManualPayments", a);

            }

        #endregion

        #region BANK TRANSFER PAYMENTS

        public ActionResult BankPayments_LoadERNo(AccountPaymentViewModel a)
            {

            a.banktEstablishment = GetEmployerName(a.banktERNO);

            if (a.banktEstablishment == "")
                {
                ViewBag.Message = "INVALID ER No. PLEASE VERIFY AND TRY AGAIN.";
                }

            a.TabIndex = 2;
            return View("ManualPayments", a);
            }

        public ActionResult BankPayments_LoadBranches(AccountPaymentViewModel a)
            {

            TempData["MyBankBranches"] = GetMyBankBranches(a.banktbank);

            a.TabIndex = 2;

            return View("ManualPayments", a);

            }

        public ActionResult BankPayments_Accept(AccountPaymentViewModel a)
            {

            int? dreceiptcount = db.cheq_tr.Where(b => b.frecptno == a.banktadviceno).Count();

            if (dreceiptcount != null)
                {
                if (dreceiptcount.Value > 0)
                    {
                    a.TabIndex = 2;
                    ViewBag.Message = "RECEIPT NO IS ALREADY ON FILE. PLEASE VERIFY AND TRYAGIN.";
                    return View("ManualPayments", a);
                    }
                }


            int? dbanktcount = db.cheq_tr.Where(b => b.fcheqno == a.banktadviceno).Count();

            if (dbanktcount != null)
                {
                if (dbanktcount.Value > 0)
                    {
                    a.TabIndex = 2;
                    ViewBag.Message = "CHEQUE NO IS ALREADY ON FILE. PLEASE VERIFY AND TRY AGAIN.";
                    return View("ManualPayments", a);
                    }
                }

            //txttype 
            //1 = bankt
            //2 = CHEQUE
            //3 = BANK TRANSFER

            int txttype = 3;


            //BANK TRANSFER OPERATIONS

            if (txttype == 3)
                {

                cheq_tr ch = new cheq_tr();
                ch.ferno = a.banktERNO;
                ch.fcheqno = a.banktadviceno;
                ch.frecptno = a.banktadviceno;
                ch.fcheqdate = a.banktdate;
                ch.frecptdate = a.banktdate;
                ch.famount = a.banktamount;
                ch.fbank_code = a.banktbank;
                ch.fr_loc = a.banktdistcode;
                ch.fuser_code = Session["AccountID"].ToString();
                ch.fdateupd = DateTime.Today;

                ch.CreatedBy = Session["AccountID"].ToString();
                ch.CreatedOn = DateTime.Today;

                db.cheq_tr.Add(ch);
                db.SaveChanges();

                }

            ViewBag.Message = "BANK TRANSFER RECEIPT SUCCESSFULLY CAPTURED";

            a.TabIndex = 2;
            return View("ManualPayments", a);

            }

        public ActionResult BankPayments_Validate(AccountPaymentViewModel a)
            {
            a.TabIndex = 2;
            return View("ManualPayments", a);
            }

        #endregion

        #region PAYMENT JOURNAL

        public ActionResult PaymentJournal()
            {
            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            TempData["MyBanks"] = GetMyBanks();

            return View("PaymentJournal", new PaymentJournalViewModel());
            }

        public ActionResult PaymentJournal_LoadERNo(PaymentJournalViewModel a)
            {

            a.festablishment = GetEmployerName(a.ferno);

            if (a.festablishment == "")
                {
                ViewBag.Message = "INVALID ER No. PLEASE VERIFY AND TRY AGAIN.";
                }

            return View("PaymentJournal", a);
            }

        public ActionResult PaymentJournal_LoadBranches(PaymentJournalViewModel a)
            {

            TempData["MyBankBranches"] = GetMyBankBranches(a.fbank);

            return View("PaymentJournal", a);

            }

        public ActionResult PaymentJournal_Accept(PaymentJournalViewModel a)
            {

            TempData["PaymentJournal"] = a;

            return RedirectToAction("PaymentJournalCapture");

            }



        #endregion

        #region PAYMENT JOUNRAL CAPTURE

        public ActionResult PaymentJournalCapture()
            {
            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            TempData["MyPaymentTypes"] = GetMyPaymentTypes();

            return View("PaymentJournalCapture", new AccountPaymentViewModel());
            }

        public ActionResult PaymentJournalCapture_LoadSSNo(AccountPaymentViewModel a)
            {

            List<mper_mst> mp = new List<mper_mst>();
            mp = db.mper_mst.Where(b => b.fssno == a.cashssno).ToList();

            if (mp.Count > 0)
                {
                a.cashmembername = mp[0].fsurname + ", " + mp[0].firstname + " " + mp[0].fothname;
                }
            else
                {
                ViewBag.Message = "INVALID S.S. NUMBER. PLEASE VERIFY AND TRY AGAIN.";
                a.cashmembername = "";
                }

            return View("PaymentJournalCapture", a);
            }

        public ActionResult PaymentJournalCapture_LoadERNo(AccountPaymentViewModel a)
            {

            a.cashestablishment = GetEmployerName(a.cashERNO);

            if (a.cashestablishment == "")
                {
                ViewBag.Message = "INVALID ER No. PLEASE VERIFY AND TRY AGAIN.";
                }

            return View("PaymentJournalCapture", a);
            }


        public ActionResult PaymentJournalCapture_OK(AccountPaymentViewModel a)
            {


            if (TempData.Peek("PJBalance") != null)
                {

                if ((decimal.Parse(TempData.Peek("PJBalance").ToString()) - a.cashamount) < 0)
                    {
                    ViewBag.Message = "AMOUNT STATED MUST NOT EXCEED THE AVAILABLE BALANCE";
                    return View("ManualPayments", a);
                    }

                a.cashbalance = decimal.Parse(TempData.Peek("PJBalance").ToString()) - a.cashamount;
                TempData["PJBalance"] = a.cashbalance;
                }
            else
                {

                if (a.cashtotalamount - a.cashamount < 0)
                    {
                    ViewBag.Message = "AMOUNT STATED MUST NOT EXCEED THE AVAILABLE BALANCE";
                    return View("ManualPayments", a);
                    }

                TempData["PJBalance"] = a.cashtotalamount - a.cashamount;
                a.cashbalance = a.cashtotalamount - a.cashamount;

                }


            a.cashcummulated += a.cashamount;

            CashPaymentBreakdownViewModel p = new CashPaymentBreakdownViewModel();
            p.fType = a.cashtype;
            p.fCode = "CR";
            p.fFrom = a.cashfrom;
            p.fTo = a.cashto;
            p.fAmount = a.cashamount;
            p.fLF = a.cashlabourforce;

            if (TempData.Peek("PaymentJournalBreakdowns") == null)
                {
                List<CashPaymentBreakdownViewModel> cp = new List<CashPaymentBreakdownViewModel>();
                cp.Add(p);

                TempData["PaymentJournalBreakdowns"] = cp;

                }
            else
                {

                List<CashPaymentBreakdownViewModel> cp = new List<CashPaymentBreakdownViewModel>();
                cp = (List<CashPaymentBreakdownViewModel>)TempData.Peek("PaymentJournalBreakdowns");

                cp.Add(p);
                TempData["PaymentJournalBreakdowns"] = cp;

                }


            int dmonth = int.Parse(a.cashfrom.Substring(4, 2));
            int dyear = int.Parse(a.cashfrom.Substring(0, 4));

            if (dmonth < 12)
                {
                dmonth += 1;
                }
            else
                {
                dyear += 1;
                dmonth = 1;
                }

            string themonth = "";

            if (dmonth < 10)
                {
                themonth = "0" + dmonth;
                }
            else
                {
                themonth = dmonth.ToString();
                }

            a.cashfrom = dyear + themonth;

            return View("PaymentJournalCapture", a);

            }


        public ActionResult PaymentJournalCapture_Accept(AccountPaymentViewModel a)
            {
            bool mupd = false;
            string UserID = Session["AccountID"].ToString();

            if (!a.RePrintReceipt)
                {

                List<c_cashpt> cp = new List<c_cashpt>();
                cp = db.c_cashpt.Where(b => b.CreatedBy == UserID).ToList();

                if (cp.Count > 0)
                    {
                    string mno = cp[0].fno;
                    List<rec_stem> rc = new List<rec_stem>();
                    rc = db.rec_stem.Where(b => b.fcash_p == mno).ToList();

                    string fullcode;
                    fullcode = Session["Branch"].ToString() + DateTime.Today.Year + DateTime.Today.ToString("MM");

                    if (rc.Count > 0)
                        {

                        if (rc[0].fstem == fullcode)
                            {
                            decimal mserno = rc[0].fser_no.Value + 1;

                            a.chequereceiptno = Session["Branch"].ToString() + mno + fullcode.Substring(5, 4) + mserno;

                            rc[0].fser_no = mserno;
                            db.rec_stem.Attach(rc[0]);
                            var entry = db.Entry(rc[0]);
                            entry.State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            }
                        else
                            {
                            decimal mserno = 1;
                            rc[0].fser_no = mserno;
                            rc[0].fstem = fullcode;

                            a.chequereceiptno = Session["Branch"].ToString() + mno + fullcode.Substring(5, 4) + mserno;

                            db.rec_stem.Attach(rc[0]);
                            var entry = db.Entry(rc[0]);
                            entry.State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            }

                        }
                    else
                        {

                        rec_stem r = new rec_stem();
                        r.fcash_p = mno;
                        r.fstem = fullcode;
                        r.fser_no = 1;
                        a.chequereceiptno = Session["Branch"].ToString() + mno + fullcode.Substring(5, 4) + 1;

                        r.CreatedBy = Session["AccountID"].ToString();
                        r.CreatedOn = DateTime.Today;

                        db.rec_stem.Add(r);
                        db.SaveChanges();

                        }
                    }
                else
                    {
                    ViewBag.Message = "CASH POINT IS NOT SET FOR THIS MACHINE. PLEASE SET CASH POINT AND TRY AGAIN.";
                    return View("PaymentJournalCapture", a);
                    }


                }
            else
                {

                }

            List<empay_tr> emp = new List<empay_tr>();
            emp = db.empay_tr.Where(b => b.frecptno == a.chequereceiptno).ToList();

            if (emp.Count > 0)
                {
                mupd = false;

                ViewBag.Message = "THERE IS A PROBLEM WITH YOUR SYSTEM DATE. RECEIPT CANNOT BE GENERATED. PLEASE INFORM YOUR SYSTEM ANALYST";
                return View("PaymentJournalCapture", a);
                }
            else
                {
                mupd = true;
                }


            return View("PaymentJournalCapture", a);

            }
        #endregion

        #region CAPTURE BANK LODGEMENT

        public ActionResult CaptureBankLodgment()
            {
            return View("CaptureBankLodgment", new CaptureBankLodgementViewModel());
            }

        private DataTable GetPaymentRecordsToProcess(DateTime? ddate)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT Sum(famount) as Total, fmode from paymt_tr where frecptdate = '" + ddate.Value.ToString("yyyy-MM-dd") + "' Group by fmode";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            return mytable;
            }


        public ActionResult CaptureBankLodgment_Search(CaptureBankLodgementViewModel c)
            {

            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            string UserID = Session["AccountID"].ToString();

            List<bk_log> bk = new List<bk_log>();
            bk = db.bk_log.Where(b => b.frecptdate == c.receiptdate).Where(b => b.fuser_code == UserID).ToList();

            if (bk.Count > 0)
                {

                ViewBag.Message = "GIVEN DAY'S LODGEMENT HAS ALREADY BEEN CAPTURED";
                return View("CaptureBankLodgment", c);

                }
            else
                {


                List<paymt_tr> pm = new List<paymt_tr>();
                pm = db.paymt_tr.Where(b => b.frecptdate == c.receiptdate).Where(b => b.fuser_code == UserID).ToList();

                if (pm.Count > 0)
                    {
                    DataTable mytable = new DataTable();

                    mytable = GetPaymentRecordsToProcess(c.receiptdate);

                    if (mytable.Rows.Count > 0)
                        {

                        c.cheque = 0;
                        c.cash = 0;
                        c.bankadvice = 0;
                        c.journaltransfer = 0;

                        c.totalcollected = 0;
                        c.totaltobank = 0;

                        foreach (DataRow item in mytable.Rows)
                            {
                            if (item.Field<String>("fmode") == "1")
                                {
                                c.cash = item.Field<Decimal>("Total");
                                c.totalcollected += c.cash;
                                }

                            if (item.Field<String>("fmode") == "2")
                                {
                                c.cheque = item.Field<Decimal>("Total");
                                c.totalcollected += c.cheque;
                                }

                            if (item.Field<String>("fmode") == "3")
                                {
                                c.bankadvice = item.Field<Decimal>("Total");
                                c.totalcollected += c.bankadvice;
                                c.totaltobank += c.bankadvice;
                                }

                            if (item.Field<String>("fmode") == "4")
                                {
                                c.journaltransfer = item.Field<Decimal>("Total");
                                c.totalcollected += c.journaltransfer;
                                c.totaltobank += c.journaltransfer;
                                }

                            }

                        c.totaltobank = c.totalcollected - c.totaltobank;

                        return View("CaptureBankLodgment", c);

                        }
                    else
                        {
                        ViewBag.Message = "THERE ARE NO PAYMENTS FOR THE GIVEN PERIOD";
                        return View("CaptureBankLodgment", c);
                        }
                    }
                else
                    {
                    ViewBag.Message = "THERE ARE NO PAYMENTS FOR THE GIVEN PERIOD";
                    return View("CaptureBankLodgment", c);
                    }
                }

            }

        public ActionResult CaptureBankLodgment_Accept(CaptureBankLodgementViewModel c)
            {

            bk_log b = new bk_log();
            b.fcash = c.cash;
            b.fcheq = c.cheque;
            b.fadvice = c.bankadvice;
            b.fjournal = c.journaltransfer;
            b.frecptdate = c.receiptdate;
            b.fuser_code = Session["AccountID"].ToString();

            b.CreatedBy = Session["AccountID"].ToString();
            b.CreatedOn = DateTime.Today;

            db.bk_log.Add(b);
            db.SaveChanges();

            ViewBag.Message = "Bank Lodgement Successfully Captured";
            return View("CaptureBankLodgment", new CaptureBankLodgementViewModel());
            }
        #endregion

        #region CASH CONTROL
        public ActionResult CashControl()
            {

            TempData["MyDenomination"] = GetMyDenominations();
            TempData["DenominationBreakdown"] = null;

            return View("CashControl", new CashControlViewModel());
            }

        private decimal GetDenominationValue(string fcode)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fvalue From cash_deno WHERE fcode = '" + fcode + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string Total = mytable.Rows[0].Field<Decimal?>("fvalue").ToString();

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

        private string GetDenominationDesc(string fcode)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fdesc From cash_deno WHERE fcode = '" + fcode + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string Desc = mytable.Rows[0].Field<String>("fdesc").ToString();
                return Desc;
                }
            return "";

            }

        private string GetDenominationCode(string desc)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fcode From cash_deno WHERE fdesc = '" + desc + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string Desc = mytable.Rows[0].Field<String>("fcode").ToString();
                return Desc;
                }
            return "";

            }

        private string GetDenominationType(string fcode)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT ftype From cash_deno WHERE fcode = '" + fcode + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string Desc = mytable.Rows[0].Field<Decimal>("ftype").ToString();
                return Desc;
                }
            return "";

            }


        public ActionResult CashControl_Process(CashControlViewModel c)
            {
            try
                {

                decimal fvalue = GetDenominationValue(c.currency);
                c.currencytotalamount = c.currencyquantity * fvalue;
                return View("CashControl", c);

                }
            catch (Exception)
                {
                ViewBag.Message = "ERROR OCCURED DURING THE COMPUTATION. PLEASE VERIFY THE INPUT";
                return View("CashControl", c);

                }

            }

        public ActionResult CashControl_Search(CashControlViewModel c)
            {

            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            string UserID = Session["AccountID"].ToString();

            List<cashctrl_tr> ct = new List<cashctrl_tr>();
            ct = db.cashctrl_tr.Where(b => b.frecptdate == c.receiptdate).Where(b => b.fuser_code == UserID).ToList();

            if (ct.Count > 0)
                {

                ViewBag.Message = "CASH DENOMINATION ALREADY PROCESSED BY USER";
                return View("CashControl", c);

                }
            else
                {


                List<paymt_tr> pm = new List<paymt_tr>();
                pm = db.paymt_tr.Where(b => b.frecptdate == c.receiptdate).Where(b => b.fuser_code == UserID).ToList();

                if (pm.Count > 0)
                    {
                    DataTable mytable = new DataTable();

                    mytable = GetPaymentRecordsToProcess(c.receiptdate);

                    if (mytable.Rows.Count > 0)
                        {

                        c.cheque = 0;
                        c.cash = 0;
                        c.bankadvice = 0;
                        c.journaltransfer = 0;
                        c.totalcaptured = 0;

                        c.totalamount = 0;

                        foreach (DataRow item in mytable.Rows)
                            {
                            if (item.Field<String>("fmode") == "1")
                                {
                                c.cash = item.Field<Decimal>("Total");
                                c.totalamount += c.cash;
                                }

                            if (item.Field<String>("fmode") == "2")
                                {
                                c.cheque = item.Field<Decimal>("Total");
                                c.totalamount += c.cheque;
                                }

                            if (item.Field<String>("fmode") == "3")
                                {
                                c.bankadvice = item.Field<Decimal>("Total");
                                c.totalamount += c.bankadvice;

                                }

                            if (item.Field<String>("fmode") == "4")
                                {
                                c.journaltransfer = item.Field<Decimal>("Total");
                                c.totalamount += c.journaltransfer;

                                }

                            }

                        c.totaldifference = c.cash;
                        return View("CashControl", c);

                        }
                    else
                        {
                        ViewBag.Message = "THERE ARE NO PAYMENTS FOR THE GIVEN PERIOD";
                        return View("CashControl", c);
                        }
                    }
                else
                    {
                    ViewBag.Message = "THERE ARE NO PAYMENTS FOR THE GIVEN PERIOD";
                    return View("CashControl", c);
                    }
                }
            }

        public ActionResult CashControl_Edit(int id)
            {
            CashControlViewModel c = (CashControlViewModel)TempData.Peek("CashControl");

            if (TempData.Peek("DenominationBreakdown") != null)
                {
                List<CashControlBreakdownViewModel> cashcontrolb = (List<CashControlBreakdownViewModel>)TempData.Peek("DenominationBreakdown");

                if (cashcontrolb.Count > 0)
                    {
                    foreach (CashControlBreakdownViewModel item in cashcontrolb)
                        {
                        if (item.id == id)
                            {

                            c.currency = GetDenominationCode(item.denomination);
                            c.currencyquantity = item.number;
                            c.currencytotalamount = item.amount;
                            c.edit = true;

                            }
                        }
                    }

                }

            return View("CashControl", c);
            }


        public ActionResult CashControl_Delete(int id)
            {

            if (TempData.Peek("DenominationBreakdown") != null)
                {
                CashControlViewModel c = (CashControlViewModel)TempData.Peek("CashControl");
                List<CashControlBreakdownViewModel> cashcontrolb = (List<CashControlBreakdownViewModel>)TempData.Peek("DenominationBreakdown");
                List<CashControlBreakdownViewModel> newlist = new List<CashControlBreakdownViewModel>();

                decimal totalcaptured = 0;

                if (cashcontrolb.Count > 0)
                    {
                    foreach (CashControlBreakdownViewModel item in cashcontrolb)
                        {
                        if (item.id != id)
                            {
                            totalcaptured += item.amount;
                            newlist.Add(item);
                            }
                        }

                    }

                c.totalcaptured = totalcaptured;

                TempData["DenominationBreakdown"] = newlist;
                return View("CashControl", c);
                }
            else
                {
                return View("CashControl", new CashControlViewModel());
                }



            }

        public ActionResult CashControl_OK(CashControlViewModel c)
            {

            if ((c.totaldifference - c.currencytotalamount) < 0)
                {
                ViewBag.Message = "AMOUNT SPECIFIED MUST NOT EXCEED THE BALANCE LEFT";
                return View("CashControl", c);
                }

            if (TempData.Peek("DenominationBreakdown") != null)
                {
                List<CashControlBreakdownViewModel> cashcontrolb2 = (List<CashControlBreakdownViewModel>)TempData.Peek("DenominationBreakdown");

                if (cashcontrolb2.Count > 0)
                    {
                    foreach (CashControlBreakdownViewModel item in cashcontrolb2)
                        {
                        if (item.denomination == GetDenominationDesc(c.currency))
                            {
                            if (!c.edit)
                                {
                                ViewBag.Message = "THIS CASH DENOMINATION HAS ALREADY BEEN CAPTURED. PLEASE EDIT OR DELETE IF NECESSARY.";
                                return View("CashControl", c);

                                }
                            }
                        }
                    }
                }


            if (TempData.Peek("DenominationBreakdown") == null)
                {
                List<CashControlBreakdownViewModel> cashcontrolb = new List<CashControlBreakdownViewModel>();

                CashControlBreakdownViewModel cd = new CashControlBreakdownViewModel();
                cd.id = cashcontrolb.Count;

                cd.denomination = GetDenominationDesc(c.currency);
                cd.amount = c.currencytotalamount;
                cd.number = int.Parse(c.currencyquantity.ToString());
                cd.type = GetDenominationType(c.currency);

                cashcontrolb.Add(cd);
                TempData["DenominationBreakdown"] = cashcontrolb;

                c.totalcaptured += c.currencytotalamount;
                c.totaldifference = c.cash - c.totalcaptured;


                }
            else
                {
                List<CashControlBreakdownViewModel> cashcontrolb = (List<CashControlBreakdownViewModel>)TempData.Peek("DenominationBreakdown");

                List<CashControlBreakdownViewModel> newlist = new List<CashControlBreakdownViewModel>();

                decimal totalcaptured = 0;

                foreach (CashControlBreakdownViewModel item in cashcontrolb)
                    {
                    if (item.denomination != GetDenominationDesc(c.currency))
                        {
                        totalcaptured += item.amount;
                        newlist.Add(item);
                        }
                    }

                CashControlBreakdownViewModel cd = new CashControlBreakdownViewModel();

                totalcaptured += c.currencytotalamount;
                c.totaldifference = c.cash - totalcaptured;

                cd.id = cashcontrolb.Count;
                cd.denomination = GetDenominationDesc(c.currency);
                cd.amount = c.currencytotalamount;
                cd.number = int.Parse(c.currencyquantity.ToString());
                cd.type = GetDenominationType(c.currency);

                newlist.Add(cd);

                TempData["DenominationBreakdown"] = newlist;
                }

            c.edit = false;
            c.currency = null;
            c.currencyquantity = 0;
            c.currencytotalamount = 0;

            TempData["CashControl"] = c;

            return View("CashControl", c);
            }

        public List<PDCTemplate> GetMyDenominations()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fcode, fdesc From cash_deno";
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

        public ActionResult CashControl_Accept(CashControlViewModel c)
            {

            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            string UserID = Session["AccountID"].ToString();


            if (TempData.Peek("DenominationBreakdown") != null)
                {
                List<CashControlBreakdownViewModel> cashcontrolb = (List<CashControlBreakdownViewModel>)TempData.Peek("DenominationBreakdown");

                if (cashcontrolb.Count > 0)
                    {
                    foreach (CashControlBreakdownViewModel item in cashcontrolb)
                        {

                        cashctrl_tr ct = new cashctrl_tr();
                        ct.CreatedBy = UserID;
                        ct.CreatedOn = DateTime.Today;
                        ct.famount = item.amount;
                        ct.fdesc = item.denomination;
                        ct.fno = item.number;
                        ct.frecptdate = c.receiptdate;
                        ct.ftype = item.type.Substring(0, 1);
                        ct.fuser_code = UserID;

                        db.cashctrl_tr.Add(ct);
                        db.SaveChanges();

                        }
                    }

                }

            ViewBag.Message = "Cash control successfully capture by user";

            TempData["DenominationBreakdown"] = null;
            return View("CashControl", new CashControlViewModel());

            }

        #endregion

        #region CASH CONTROL REPORT
        public ActionResult CashControlReport()
            {
            return View("CashControlReport", new CashControlReportViewModel());
            }

        private decimal GetAmountForDenomination(string fdenomination, DateTime receiptdate)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT famount From cashctrl_tr WHERE fdesc = '" + fdenomination + "' and frecptdate = '" + receiptdate.ToString("yyyy-MM-dd") + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string Total = mytable.Rows[0].Field<Decimal?>("famount").ToString();

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

        private decimal GetQuantityForDenomination(string fdenomination, DateTime receiptdate)
            {

            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT fno From cashctrl_tr WHERE fdesc = '" + fdenomination + "' and frecptdate = '" + receiptdate.ToString("yyyy-MM-dd") + "'";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            if (mytable.Rows.Count > 0)
                {
                string Total = mytable.Rows[0].Field<Decimal?>("fno").ToString();

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

        public ActionResult CashControlReport_Accept(CashControlReportViewModel cc)
            {

            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            string UserID = Session["AccountID"].ToString();


            List<cash_deno> cd = new List<cash_deno>();
            cd = db.cash_deno.OrderBy(b => b.fcode).ToList();

            List<CashControlPrintViewModel> cps = new List<CashControlPrintViewModel>();

            if (cd.Count > 0)
                {

                foreach (cash_deno item in cd)
                    {
                    CashControlPrintViewModel cp = new CashControlPrintViewModel();
                    cp.amount = GetAmountForDenomination(item.fdesc, cc.receiptdate.Value);
                    cp.cashier = UserID;

                    if (item.ftype == 1)
                        {
                        cp.cashtype = "Notes";
                        }
                    else
                        {
                        cp.cashtype = "Coins";
                        }

                    cp.denomination = item.fdesc;
                    cp.location = Session["Branch"].ToString() + "-" + GetZoneName(Session["Branch"].ToString());
                    cp.number = GetQuantityForDenomination(item.fdesc, cc.receiptdate.Value);
                    cp.receiptdate = cc.receiptdate.Value;

                    cps.Add(cp);

                    }

                XtraReportCashControl mydocument = new XtraReportCashControl();
                mydocument.CashControlDataSource.DataSource = cps;
                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);

                }
            else
                {
                ViewBag.Message = "NO CASH DENOMINATION RECORDS WERE FOUND. PLEASE INPUT SOME IN cash_deno TABLE";
                }


            return View("CashControlReport", cc);
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


        #endregion

        #region CHEQUE CONTROL REPORT

        public ActionResult ChequeControlReport()
            {
            return View("ChequeControlReport", new CashControlReportViewModel());
            }

        public ActionResult ChequeControlReport_Accept(CashControlReportViewModel c)
            {

            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            string UserID = Session["AccountID"].ToString();


            if (c.receiptdate == null)
                {
                ViewBag.Message = "PLEASE SPECIFY OR RESELECT THE RECEIPT DATE.";
                return View("ChequeControlReport", c);
                }

            List<ChequeContorlPrintViewModel> cps = new List<ChequeContorlPrintViewModel>();

            List<cheq_tr> ch = new List<cheq_tr>();
            ch = db.cheq_tr.Where(b => b.frecptdate == c.receiptdate).ToList();

            if (ch.Count > 0)
                {

                foreach (cheq_tr item in ch)
                    {
                    ChequeContorlPrintViewModel cp = new ChequeContorlPrintViewModel();
                    cp.chequenumber = item.fcheqno;
                    cp.amount = item.famount.Value;
                    cp.cashier = UserID;
                    cp.location = Session["Branch"].ToString() + "-" + GetZoneName(Session["Branch"].ToString());
                    cp.receiptdate = c.receiptdate.Value;

                    cps.Add(cp);
                    }

                XtraReportChequeControl mydocument = new XtraReportChequeControl();
                mydocument.ChequeControlDataSource.DataSource = cps;
                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);

                }
            else
                {
                ViewBag.Message = "NO CHEQUE TRANSACTION WAS FOUND FOR THE DATE SPECIFIED.";
                return View("ChequeControlReport", c);
                }


            }

        #endregion

        #region BANK LODGMENT REPORT
        public ActionResult BankLodgementReport()
            {

            return View("BankLodgementReport", new CashControlReportViewModel());
            }

        public ActionResult BankLodgementReport_Accept(CashControlReportViewModel c)
            {
            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            string UserID = Session["AccountID"].ToString();


            List<BankLodgementReportPrintViewModel> bs = new List<BankLodgementReportPrintViewModel>();

            List<bk_log> bk = new List<bk_log>();
            bk = db.bk_log.Where(b => b.frecptdate == c.receiptdate).ToList();

            if (bk.Count > 0)
                {
                BankLodgementReportPrintViewModel b = new BankLodgementReportPrintViewModel();

                decimal totalbankedfortheday = 0;
                decimal totalfortheday = 0;

                foreach (bk_log item in bk)
                    {

                    b.bankadvice = item.fadvice.Value;
                    b.cash = item.fcash.Value;
                    b.cheque = item.fcheq.Value;
                    b.journaltransfer = item.fjournal.Value;

                    b.totalbankedbycashier = b.cash + b.cheque;
                    b.totalbankedforday = b.totalbankedbycashier;
                    b.totalcollectedbycashier = b.cash + b.cheque + b.bankadvice + b.journaltransfer;
                    b.totalfortheday = b.cash + b.cheque + b.bankadvice + b.journaltransfer;

                    b.cashier = item.fuser_code;
                    b.location = Session["Branch"].ToString() + "-" + GetZoneName(Session["Branch"].ToString());
                    b.receiptdate = c.receiptdate.Value;


                    totalbankedfortheday += b.totalbankedforday;
                    totalfortheday += b.totalfortheday;


                    bs.Add(b);

                    }


                foreach (BankLodgementReportPrintViewModel item in bs)
                    {
                    item.totalfortheday = totalfortheday;
                    item.totalbankedforday = totalbankedfortheday;
                    }

                XtraReportBankLodgement mydocument = new XtraReportBankLodgement();
                mydocument.BankLodgementDataSource.DataSource = bs;
                mydocument.CreateDocument();

                return View("PrintPreview", mydocument);

                }

            else
                {
                ViewBag.Message = "NO RECORD WAS FOUND FOR THE DATE SPECIRIED";
                return View("BankLodgementReport", c);
                }


            }

        #endregion

        #region GENERATE SUN TRANSACTION
        public ActionResult GenerateSunTransaction()
            {
            return View("GenerateSunTransaction", new GenerateSunTransactionViewModel());
            }

        public ActionResult GenerateSunTransaction_Search(GenerateSunTransactionViewModel g)
            {

            if (Session["Branch"] == null)
                {
                return RedirectToAction("Login", "Accounts");
                }

            bool mtrue;

            List<paymt_tr> pmt = new List<paymt_tr>();
            pmt = db.paymt_tr.Where(b => b.frecptdate == g.receiptdate).ToList();
            g.journaltransfer = 0;

            if (pmt.Count > 0)
                {

                foreach (paymt_tr item in pmt)
                    {
                    if (item.fmode == "4")
                        {
                        g.journaltransfer += item.famount;
                        }

                    }

                string Branch = Session["Branch"].ToString();
                string bankcode = "";

                List<dist_loc> dc = new List<dist_loc>();
                dc = db.dist_loc.Where(b => b.floc == Branch).ToList();

                if (dc.Count > 0)
                    {
                    bankcode = dc[0].fbnk_code;
                    }

                g.totalreceipt = 0;

                foreach (paymt_tr item in pmt)
                    {
                    g.totalreceipt += item.famount;

                    }

                List<bk_log> bks = new List<bk_log>();
                bks = db.bk_log.Where(b => b.frecptdate == g.receiptdate).ToList();

                if (bks.Count > 0)
                    {
                    bk_log b = new bk_log();
                    b = bks[0];

                    g.totalbanked = b.fcash.Value + b.fcheq.Value + b.fadvice.Value; ;

                    if (g.totalbanked.Value + g.journaltransfer.Value + g.totalreceipt.Value > 0)
                        {
                        g.balance = g.totalreceipt - g.totalbanked;

                        if (bankcode == "")
                            {
                            ViewBag.Message = "THE BANK FOR THIS OFFICE HAS NOT BEEN SET";
                            mtrue = false;

                            }
                        else
                            {
                            mtrue = true;
                            }
                        }
                    else
                        {
                        mtrue = true;

                        }
                    }
                else
                    {
                    ViewBag.Message = "BANK LODGEMENT NOT CAPTURED FOR GIVEN DAY";
                    mtrue = false;

                    }

                }
            else
                {
                ViewBag.Message = "THERE IS NO PAYMENT FOR THE GIVEN DATE";
                mtrue = false;

                }


            if (mtrue)
                {
                g.balance = g.totalreceipt - g.totalbanked;
                }

            return View("GenerateSunTransaction", g);

            }

        public ActionResult GenerateSunTransaction_Generate(GenerateSunTransactionViewModel g)
            {

            string ref_no = "";
            int mserno = 0;

            string mcrgov_code = "";
            string mcrpar_code = "";
            string mcrngo_code = "";
            string mcrpri_code = "";
            string mcroth_code = "";

            string mpengov_code = "";
            string mpenpar_code = "";
            string mpenngo_code = "";
            string mpenpri_code = "";
            string mpenoth_code = "";

            string mintngo_code = "";
            string mintpar_code = "";
            string mintgov_code = "";
            string mintpri_code = "";
            string mintoth_code = "";

            string mlostcard_code = "";


            List<acct_chart> act = new List<acct_chart>();
            act = db.acct_chart.ToList();

            if (act.Count > 0)
                {
                foreach (acct_chart item in act)
                    {
                    if (item.fbus_type == "1" && item.fpay_type == "C")
                        {
                        mcrgov_code = item.fcode;
                        }

                    if (item.fbus_type == "2" && item.fpay_type == "C")
                        {
                        mcrpar_code = item.fcode;
                        }

                    if (item.fbus_type == "3" && item.fpay_type == "C")
                        {
                        mcrngo_code = item.fcode;
                        }

                    if (item.fbus_type == "4" && item.fpay_type == "C")
                        {
                        mcrpri_code = item.fcode;
                        }

                    if (item.fbus_type == "5" && item.fpay_type == "C")
                        {
                        mcroth_code = item.fcode;
                        }



                    if (item.fbus_type == "1" && item.fpay_type == "P")
                        {
                        mpengov_code = item.fcode;
                        }

                    if (item.fbus_type == "2" && item.fpay_type == "P")
                        {
                        mpenpar_code = item.fcode;
                        }

                    if (item.fbus_type == "3" && item.fpay_type == "P")
                        {
                        mpenngo_code = item.fcode;
                        }

                    if (item.fbus_type == "4" && item.fpay_type == "P")
                        {
                        mpenpri_code = item.fcode;
                        }

                    if (item.fbus_type == "5" && item.fpay_type == "P")
                        {
                        mpenoth_code = item.fcode;
                        }



                    if (item.fbus_type == "1" && item.fpay_type == "I")
                        {
                        mintgov_code = item.fcode;
                        }

                    if (item.fbus_type == "2" && item.fpay_type == "I")
                        {
                        mintpar_code = item.fcode;
                        }

                    if (item.fbus_type == "3" && item.fpay_type == "I")
                        {
                        mintngo_code = item.fcode;
                        }

                    if (item.fbus_type == "4" && item.fpay_type == "I")
                        {
                        mintpri_code = item.fcode;
                        }

                    if (item.fbus_type == "5" && item.fpay_type == "I")
                        {
                        mintoth_code = item.fcode;
                        }



                    if (item.fbus_type == "5" && item.fpay_type == "L")
                        {
                        mlostcard_code = item.fcode;
                        }


                    }

                string period = g.receiptdate.Value.ToString("yyyy") + g.receiptdate.Value.ToString("MM");
                DateTime transdate = g.receiptdate.Value;

                DateTime mdate1 = g.receiptdate.Value;

                List<paymt_tr> pmt = new List<paymt_tr>();
                pmt = db.paymt_tr.Where(b => b.frecptdate == g.receiptdate).ToList();

                if (pmt.Count > 0)
                    {
                    foreach (paymt_tr item in pmt)
                        {
                        if (item.fmode != "4")
                            {

                            string establishment = "";
                            string establishmentbustype = "";

                            string mptype = item.fpaytype;
                            string mcheqno = "";
                            string mpmode = item.fmode;
                            string merno = item.ferno;

                            if (item.fmode == mpmode || item.fmode == "2" || item.fmode == "3")
                                {
                                List<cheq_tr> chq = new List<cheq_tr>();
                                chq = db.cheq_tr.Where(b => b.frecptdate == g.receiptdate).ToList();

                                if (chq.Count > 0)
                                    {
                                    mcheqno = chq[0].fcheqno;
                                    }
                                else
                                    {
                                    if (mpmode == "3")
                                        {
                                        mcheqno = "ADV";
                                        }
                                    else
                                        {
                                        mcheqno = "CHQ";
                                        }
                                    }
                                }
                            else
                                {
                                mcheqno = "CASH";
                                }

                            if (merno.ToCharArray().Count() < 17)
                                {
                                merno = merno.Substring(0, 11);
                                establishment = GetEmployerName(item.ferno);
                                establishmentbustype = GetEmployerBusinessType(item.ferno);
                                }
                            else
                                {
                                establishment = "VOLUNTARY";
                                establishmentbustype = "5";
                                }

                            if (establishmentbustype == "")
                                {
                                establishmentbustype = "5";
                                }

                            if (establishmentbustype == "1" && mptype == "CR" || mptype == "CB" || mptype == "CJ" || mptype == "CN")
                                {
                                mserno += 1;
                                ref_no = item.frecptno;
                                //WriteSun()
                                }
                            else
                                {

                                }

                            }
                        }
                    }
                else
                    {

                    }

                }
            else
                {

                }
            return View("GenerateSunTransaction", g);
            }

        private void WriteSun(string mcr_acct, string mref_no, string mTrndate, string macc_perd, string mdesc, decimal? mtamount, string mdate, string mchq, string MER_NO)
            {
            trnfile tf = new trnfile();
            tf.CREATEDBY = Session["AccountID"].ToString();
            tf.CREATEDON = DateTime.Today;

            tf.facct_code = mcr_acct;
            tf.facct_per = macc_perd;
            tf.falloc_ind = "";
            tf.famount = mtamount;
            tf.fasset_cod = "";
            tf.fasset_ind = "";
            tf.fass_subco = "";
            tf.fblank1 = "";
            tf.fblank2 = "";
            tf.fblank3 = "";
            tf.fconv_code = "";
            tf.fconv_rate = "";
            tf.fdescr = mdesc;
            tf.fdr_cr_mak = "";
            tf.fdue_date = "";
            tf.fentry_dat = "";
            tf.fentry_per = "";
            tf.ffiller = "";
            tf.fid_oper1 = "";
            tf.fid_oper2 = "";
            tf.fid_oper3 = "";
            tf.fin_use_fg = "";
            tf.fjour_line = "";
            tf.fjour_no = "";
            tf.fno_dec_pl = "";
            tf.fother_amt = 0;
            tf.fpay_aldat = "";
            tf.fpay_allpe = "";
            tf.fpay_allrf = "";
            tf.fpost_date = DateTime.Today;
            tf.frec_type = "";
            tf.freversal = "";
            tf.fr_book_fg = "";
            tf.fsource = "";
            tf.ftext = "";
            tf.ftrana_co0 = "";
            tf.ftrana_co1 = "";
            tf.ftrana_co2 = "";
            tf.ftrana_co3 = "";
            tf.ftrana_co4 = "";
            tf.ftrana_co5 = "";
            tf.ftrana_co6 = "";
            tf.ftrana_co7 = "";
            tf.ftrana_co8 = "";
            tf.ftrana_co9 = "";
            tf.ftr_date = mTrndate;
            tf.ftr_jr_typ = "";
            tf.ftr_ref = "";
            tf.fup_or_bal = "";

            db.trnfiles.Add(tf);
            db.SaveChanges();

            }

        #endregion

        #region REVERSE PAYMENT
        public ActionResult ReversePayment()
            {
            TempData["ReversePaymentBreakdowns"] = null;

            return View("ReversePayment", new ReversePaymentsViewModel());
            }

        public ActionResult ReversePayment_Search(ReversePaymentsViewModel r)
            {
            bool mfnd;
            decimal mreg = 0;
            decimal mbak = 0;
            decimal mneg = 0;
            decimal mjge = 0;
            decimal mint = 0;
            decimal mbnk = 0;
            decimal mpen = 0;
            decimal mlc = 0;

            string merno = "";

            List<paymt_tr> pmt = new List<paymt_tr>();
            pmt = db.paymt_tr.Where(b => b.frecptno == r.receiptno).ToList();

            if (pmt.Count > 0)
                {
                merno = pmt[0].ferno;
                mfnd = true;

                r.receiptdate = pmt[0].frecptdate;

                foreach (paymt_tr item in pmt)
                    {
                    if (item.fpaytype == "CR")
                        {
                        mreg += item.famount.Value;
                        }

                    if (item.fpaytype == "CB")
                        {
                        mbak += item.famount.Value;
                        }

                    if (item.fpaytype == "CP")
                        {
                        mpen += item.famount.Value;
                        }

                    if (item.fpaytype == "CJ")
                        {
                        mjge += item.famount.Value;
                        }

                    if (item.fpaytype == "CN")
                        {
                        mneg += item.famount.Value;
                        }

                    if (item.fpaytype == "CI")
                        {
                        mint += item.famount.Value;
                        }

                    if (item.fpaytype == "BC")
                        {
                        mbnk += item.famount.Value;
                        }

                    if (item.fpaytype == "LC")
                        {
                        mlc += item.famount.Value;
                        }

                    }

                }
            else
                {

                List<paymt_h> ph = new List<paymt_h>();
                ph = db.paymt_h.Where(b => b.frecptno == r.receiptno).ToList();

                if (ph.Count > 0)
                    {
                    mfnd = true;
                    merno = ph[0].ferno;

                    r.receiptdate = ph[0].frecptdate;

                    foreach (paymt_h item in ph)
                        {
                        if (item.fpaytype == "CR")
                            {
                            mreg += item.famount.Value;
                            }

                        if (item.fpaytype == "CB")
                            {
                            mbak += item.famount.Value;
                            }

                        if (item.fpaytype == "CP")
                            {
                            mpen += item.famount.Value;
                            }

                        if (item.fpaytype == "CJ")
                            {
                            mjge += item.famount.Value;
                            }

                        if (item.fpaytype == "CN")
                            {
                            mneg += item.famount.Value;
                            }

                        if (item.fpaytype == "CI")
                            {
                            mint += item.famount.Value;
                            }

                        if (item.fpaytype == "BC")
                            {
                            mbnk += item.famount.Value;
                            }

                        if (item.fpaytype == "LC")
                            {
                            mlc += item.famount.Value;
                            }

                        }

                    }
                else
                    {
                    List<empay_tr> emp = new List<empay_tr>();
                    emp = db.empay_tr.Where(b => b.frecptno == r.receiptno).ToList();

                    if (emp.Count > 0)
                        {
                        foreach (empay_tr item in emp)
                            {
                            merno = item.ferno;

                            db.empay_tr.Attach(item);
                            var entry = db.Entry(item);
                            entry.State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();

                            }
                        }


                    List<cheq_tr> chq = new List<cheq_tr>();
                    chq = db.cheq_tr.Where(b => b.frecptno == r.receiptno).ToList();

                    if (chq.Count > 0)
                        {
                        db.cheq_tr.Attach(chq[0]);
                        var entry = db.Entry(chq[0]);
                        entry.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        }

                    List<memsipcr_tr> memsip = new List<memsipcr_tr>();
                    memsip = db.memsipcr_tr.Where(b => b.frecptno == r.receiptno).ToList();

                    if (memsip.Count > 0)
                        {

                        db.memsipcr_tr.Attach(memsip[0]);
                        var entry = db.Entry(memsip[0]);
                        entry.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();


                        List<memsip_tr> mems = new List<memsip_tr>();
                        mems = db.memsip_tr.Where(b => b.fssno == memsip[0].fssno).ToList();

                        if (mems.Count > 0)
                            {
                            memsip_tr mem = new memsip_tr();
                            mem = mems[0];

                            mem.ftotmths -= memsip[0].fnomths;
                            mem.ftotamt -= memsip[0].famt_paid;

                            db.memsip_tr.Attach(mem);
                            var entry2 = db.Entry(mem);
                            entry2.State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();

                            }

                        }

                    List<vpay_tr> vpay = new List<vpay_tr>();
                    vpay = db.vpay_tr.Where(b => b.frecptno == r.receiptno).ToList();

                    if (vpay.Count > 0)
                        {
                        db.vpay_tr.Attach(vpay[0]);
                        var entry2 = db.Entry(vpay[0]);
                        entry2.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        }


                    List<payprint> pp = new List<payprint>();
                    pp = db.payprints.Where(b => b.frecptno == r.receiptno).ToList();

                    if (pp.Count > 0)
                        {
                        db.vpay_tr.Attach(vpay[0]);
                        var entry2 = db.Entry(vpay[0]);
                        entry2.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        }

                    ViewBag.Message = "GIVEN RECEIPT NOT ON FILE";
                    mfnd = false;
                    }

                }


            if (mfnd)
                {
                if (merno.ToCharArray().Count() == 17)
                    {
                    r.ferno = merno;

                    List<mper_mst> ms = new List<mper_mst>();
                    ms = db.mper_mst.Where(b => b.ferno == merno).ToList();

                    if (ms.Count > 0)
                        {
                        r.establishment = ms[0].femp_name;
                        }
                    }
                else
                    {
                    r.ferno = merno;

                    List<emp_mst> ms = new List<emp_mst>();
                    ms = db.emp_mst.Where(b => b.ferno == merno.Substring(0, 11)).ToList();

                    if (ms.Count > 0)
                        {
                        r.establishment = ms[0].femp_name;
                        }
                    }

                List<ReversePaymentBreakdownViewModel> rvs = new List<ReversePaymentBreakdownViewModel>();


                if (mreg > 0)
                    {
                    ReversePaymentBreakdownViewModel rv = new ReversePaymentBreakdownViewModel();
                    rv.fcode = "CR";
                    rv.fdesc = "Regular Contribution";
                    rv.famount = mreg;
                    rvs.Add(rv);
                    }


                if (mbak > 0)
                    {
                    ReversePaymentBreakdownViewModel rv = new ReversePaymentBreakdownViewModel();
                    rv.fcode = "CB";
                    rv.fdesc = "Backpay Contribution";
                    rv.famount = mbak;
                    rvs.Add(rv);
                    }

                if (mpen > 0)
                    {
                    ReversePaymentBreakdownViewModel rv = new ReversePaymentBreakdownViewModel();
                    rv.fcode = "CP";
                    rv.fdesc = "Penalty";
                    rv.famount = mpen;
                    rvs.Add(rv);
                    }


                if (mjge > 0)
                    {
                    ReversePaymentBreakdownViewModel rv = new ReversePaymentBreakdownViewModel();
                    rv.fcode = "CJ";
                    rv.fdesc = "Judgement Debt";
                    rv.famount = mjge;
                    rvs.Add(rv);
                    }

                if (mneg > 0)
                    {
                    ReversePaymentBreakdownViewModel rv = new ReversePaymentBreakdownViewModel();
                    rv.fcode = "CN";
                    rv.fdesc = "Negotiated Arrears";
                    rv.famount = mneg;
                    rvs.Add(rv);
                    }

                if (mint > 0)
                    {
                    ReversePaymentBreakdownViewModel rv = new ReversePaymentBreakdownViewModel();
                    rv.fcode = "CI";
                    rv.fdesc = "Interest";
                    rv.famount = mint;
                    rvs.Add(rv);
                    }


                if (mbnk > 0)
                    {
                    ReversePaymentBreakdownViewModel rv = new ReversePaymentBreakdownViewModel();
                    rv.fcode = "BC";
                    rv.fdesc = "Bank Charges";
                    rv.famount = mbnk;
                    rvs.Add(rv);
                    }


                if (mlc > 0)
                    {
                    ReversePaymentBreakdownViewModel rv = new ReversePaymentBreakdownViewModel();
                    rv.fcode = "LC";
                    rv.fdesc = "Lost Card Payment";
                    rv.famount = mlc;
                    rvs.Add(rv);
                    }

                TempData["ReversePaymentBreakdowns"] = rvs;

                }

            r.ferno = merno;

            r.totalamount = mreg + mbak + mneg + mjge + mint + mbnk + mpen + mlc;

            return View("ReversePayment", r);

            }

        public ActionResult ReversePayment_Reverse(ReversePaymentsViewModel r)
            {

            pay_re p = new pay_re();

            p.CreatedBy = Session["AccountID"].ToString();
            p.CreatedOn = DateTime.Today;

            p.ferno = r.ferno;
            p.frecptno = r.receiptno;
            p.freason = r.reason;
            p.frecptdate = r.receiptdate;
            p.famount = r.totalamount;
            p.fuser_code = Session["AccountID"].ToString();
            p.fdateupd = DateTime.Today;

            db.pay_re.Add(p);
            db.SaveChanges();


            string merno;
            string period;

            List<empay_tr> emp = new List<empay_tr>();
            emp = db.empay_tr.Where(b => b.frecptno == r.receiptno).ToList();

            if (emp.Count > 0)
                {
                foreach (empay_tr item in emp)
                    {
                    merno = item.ferno;
                    period = item.frecptdate.Value.ToString("yyyy") + item.frecptdate.Value.ToString("MM");

                    db.empay_tr.Attach(item);
                    var entry = db.Entry(item);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }
                }


            List<cheq_tr> ch = new List<cheq_tr>();
            ch = db.cheq_tr.Where(b => b.frecptno == r.receiptno).ToList();

            if (ch.Count > 0)
                {
                db.cheq_tr.Attach(ch[0]);
                var entry2 = db.Entry(ch[0]);
                entry2.State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                }


            List<paymt_tr> pt = new List<paymt_tr>();
            pt = db.paymt_tr.Where(b => b.frecptno == r.receiptno).ToList();

            if (pt.Count > 0)
                {
                db.paymt_tr.Attach(pt[0]);
                var entry2 = db.Entry(pt[0]);
                entry2.State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                }


            List<paymt_h> ph = new List<paymt_h>();
            ph = db.paymt_h.Where(b => b.frecptno == r.receiptno).ToList();

            if (ph.Count > 0)
                {
                db.paymt_h.Attach(ph[0]);
                var entry2 = db.Entry(ph[0]);
                entry2.State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                }


            List<payprint> pp = new List<payprint>();
            pp = db.payprints.Where(b => b.frecptno == r.receiptno).ToList();

            if (pp.Count > 0)
                {
                db.payprints.Attach(pp[0]);
                var entry2 = db.Entry(pp[0]);
                entry2.State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                }


            List<memsipcr_tr> memsip = new List<memsipcr_tr>();
            memsip = db.memsipcr_tr.Where(b => b.frecptno == r.receiptno).ToList();

            if (memsip.Count > 0)
                {

                db.memsipcr_tr.Attach(memsip[0]);
                var entry = db.Entry(memsip[0]);
                entry.State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();


                List<memsip_tr> mems = new List<memsip_tr>();
                mems = db.memsip_tr.Where(b => b.fssno == memsip[0].fssno).ToList();

                if (mems.Count > 0)
                    {
                    memsip_tr mem = new memsip_tr();
                    mem = mems[0];

                    mem.ftotmths -= memsip[0].fnomths;
                    mem.ftotamt -= memsip[0].famt_paid;

                    db.memsip_tr.Attach(mem);
                    var entry2 = db.Entry(mem);
                    entry2.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    }

                }

             
            List<vpay_tr> vpay = new List<vpay_tr>();
            vpay = db.vpay_tr.Where(b => b.frecptno == r.receiptno).ToList();

            if (vpay.Count > 0)
                {
                db.vpay_tr.Attach(vpay[0]);
                var entry2 = db.Entry(vpay[0]);
                entry2.State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                }


            TempData["ReversePaymentBreakdowns"] = null;

            ViewBag.Message = "GIVEN RECEIPT NO HAS BEEN DELETED FROM FILE";
            return View("ReversePayment", new ReversePaymentsViewModel());

            }

        #endregion
        }

    }
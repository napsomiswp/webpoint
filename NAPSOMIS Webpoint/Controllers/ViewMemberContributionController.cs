using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.ViewModels;
using System.Data;
using System.Configuration;
using NAPSOMIS_Webpoint.Models;

namespace NAPSOMIS_Webpoint.Controllers
    {
    public class ViewMemberContributionController : Controller
        {

        NAPSOMISModel db = new NAPSOMISModel();

        // GET: ViewMemberContribution
        public ActionResult ViewStatement()
            {
            TempData["MyEstablishments"] = null;
            return View("ViewStatement");
            }

        public ActionResult ViewStatement_LoadSSNo(MemberStatementViewModel mv)
            {
            List<mem_tr> mvs = new List<mem_tr>();
            mvs = db.mem_tr.Where(b => b.fssno == mv.SSNo).ToList();

            if (mvs.Count > 0)
                {
                mv.NameOfMember = mvs[0].fsurname + ", " + mvs[0].firstname + ", " + mvs[0].fothname;
                TempData["MyEstablishments"] = GetMyEstablishmentsbyFilter(mv.SSNo);

                }
            else
                {
                mv.NameOfMember = "";
                TempData["MyEstablishments"] = null;
                }

            return View("ViewStatement", mv);
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

        public List<PDCTemplate> GetMyEstablishmentsbyFilter(string SSNO)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query;

            Query = "SELECT Distinct(ferno) From MemberStatements WHERE fssno = '" + SSNO + "'";

            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("ferno");
                    ct.Name = GetEmployerName(myp.Field<String>("ferno"));

                    mylist.Add(ct);

                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }


        public ActionResult ViewStatement_OK(MemberStatementViewModel mv)
            {

            List<MemberStatementPrintViewModel> mpvms = new List<MemberStatementPrintViewModel>();

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


                ViewBag.Message = "No Data was found for the selected establishment and year.";

                return View("ViewStatement", mv);

                }


            }


        public ActionResult Contribution()
            {
            return View("ViewContribution");
            }

        }
    }
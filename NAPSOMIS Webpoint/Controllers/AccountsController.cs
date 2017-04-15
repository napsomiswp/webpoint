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

    public class AccountsController : Controller
        {

        NAPSOMISModel db = new NAPSOMISModel();

        // GET: Accounts
        public ActionResult Login()
            {
            return View("Login");
            }

        public ActionResult AccountSpecs()
            {
            return View("AccountSpecs");
            }

        public ActionResult Logout()
            {
            Session.Clear();
            return View("Logout");
            }

        [ValidateAntiForgeryToken]
        public ActionResult Login_Check(LoginViewModel l)
            {

            DataTable logintable = GetLogin(l.UserName, l.Password);

            if (logintable.Rows.Count > 0)
                {
                DataRow drow = logintable.Rows[0];

                if (drow.Field<String>("AccountStatus") != "Enabled")
                    {
                    ViewBag.ErrorMessage = "This account is disabled!";

                    return View("Login");
                    }
                else
                    {
                    Session["AccountID"] = drow.Field<String>("AccountID");
                    Session["UserName"] = l.UserName;
                    Session["AccessibleFeatures"] = drow.Field<String>("AccessibleFeatures");
                    Session["UserGroup"] = drow.Field<String>("UserGroup");
                    Session["AccountStatus"] = drow.Field<String>("AccountStatus");
                    Session["Department"] = drow.Field<String>("Department");
                    Session["Branch"] = drow.Field<String>("Branch");
                    Session["RecordAccessLevel"] = drow.Field<String>("RecordAccessLevel").ToString().Replace(",", ", ");
                    Session["LoginDate"] = DateTime.Today.ToString("dd/MM/yyyy");
                    Session["LoginTime"] = DateTime.Now.ToString("HH:mm:ss");

                    string FullName;
                    if (drow.Field<String>("MiddleName") != "")
                        {
                        FullName = String.Format("{0} {1} {2}", drow.Field<String>("FirstName"), drow.Field<String>("MiddleName"), drow.Field<String>("LastName"));
                        }
                    else
                        {
                        FullName = String.Format("{0} {1}", drow.Field<String>("FirstName"), drow.Field<String>("LastName"));
                        }

                    Session["FullNameofUser"] = FullName;

                    return RedirectToRoute(new { Controller = "Pages", ACtion = "Home" });
                    }



                }
            else
                {
                ViewBag.ErrorMessage = "Invalid Username or Password!";

                return View("Login");
                }

            }

        private DataTable GetLogin(string username, string password)
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "Select AccountID, FirstName, MiddleName, LastName, CAST(DECRYPTBYPASSPHRASE(N'mYpas4word!', UserGroup) AS NVARCHAR(1000)) AS UserGroup, AccountStatus, Branch, Department, CAST(DECRYPTBYPASSPHRASE(N'mYpas4word!',AccessibleFeatures) AS NVARCHAR(4000)) AS AccessibleFeatures, CAST(DECRYPTBYPASSPHRASE(N'mYpas4word!', RecordAccessLevel) AS NVARCHAR(1000)) AS RecordAccessLevel From mainlogin Where Username = '" + username + "' And Convert(nvarchar(100), DECRYPTBYPASSPHRASE(N'mYpas4word!', Password)) = @Password ";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.SelectCommand.Parameters.AddWithValue("@Password", password);

            dp.Fill(mytable);

            return mytable;

            }

        #region "MESSENGER"

        public ActionResult Messenger()
            {
            
            return View("Messenger");

            }

        public ActionResult Messenger_Compose()
            {

            ViewBag.Operation = "Compose";
            TempData["Accounts"] = GetMyAccounts();

            return View("Messenger");

            }


        public ActionResult Messenger_ComposeSend(Message m)
            {

            var receipientdetails = Request["ReceipientID"];
            string[] splitdetails = receipientdetails.ToString().Split(';');

            Message nm = new Message();
            nm.ReceipientID = splitdetails[0];
            nm.SenderID = Session["AccountID"].ToString();
            nm.SenderName = Session["FullNameofUser"].ToString();
            nm.Urgency = m.Urgency;
            nm.ReceipientName = splitdetails[1];
            nm.MessageSubject = m.MessageSubject;
            nm.MessageBody = m.MessageBody;
            nm.InputDate = DateTime.Today;
            nm.MessageStatus = "UnRead";

            db.Messages.Add(nm);
            db.SaveChanges();

            return View("Messenger");

            }

        public List<PDCTemplate> GetMyAccounts()
            {
            DataTable mytable = new DataTable();

            string myConn = ConfigurationManager.ConnectionStrings["ReferenceNoModel"].ToString();
            string Query = "SELECT AccountID, FirstName, MiddleName, LastName From MainLogin";
            System.Data.SqlClient.SqlDataAdapter dp = new System.Data.SqlClient.SqlDataAdapter(Query, myConn);
            dp.Fill(mytable);

            //List<Province> provinces = db.Provinces.SqlQuery("SELECT ID_SBTS, fcode, fdesc From Province").ToList(); 

            List<PDCTemplate> mylist = new List<PDCTemplate>();

            if (mytable.Rows.Count > 0)
                {
                foreach (DataRow myp in mytable.Rows)
                    {
                    string FullName;
                    if (myp.Field<String>("MiddleName") != "")
                        {
                        FullName = String.Format("{0} {1} {2}", myp.Field<String>("FirstName"), myp.Field<String>("MiddleName"), myp.Field<String>("LastName"));
                        }
                    else
                        {
                        FullName = String.Format("{0} {1}", myp.Field<String>("FirstName"), myp.Field<String>("LastName"));
                        }


                    PDCTemplate ct = new PDCTemplate();
                    ct.Code = myp.Field<String>("AccountID");
                    ct.Name =  FullName;

                    mylist.Add(ct);

                    }

                return mylist;
                }
            else
                {
                return mylist;
                }
            }

        public ActionResult Messenger_Inbox()
            {
            ViewBag.Operation = "Inbox";
            return View("Messenger");

            }

        public ActionResult Messenger_Sent()
            {
            ViewBag.Operation = "Sent";
            return View("Messenger");

            }

        public ActionResult Messenger_Summary()
            {
            ViewBag.Operation = "Summary";
            return View("Messenger");

            }

         public ActionResult Messenger_View(int id)
            {
            ViewBag.Operation = "View";
            return View("Messenger", new Message() { MessageID = id });

            }


        #endregion


        }
    }
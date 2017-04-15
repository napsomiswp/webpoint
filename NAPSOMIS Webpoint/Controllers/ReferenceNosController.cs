using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.Models;
using System.Net;

namespace NAPSOMIS_Webpoint.Controllers
    {
    public class ReferenceNosController : Controller
        {

        private ReferenceNoModel db = new ReferenceNoModel();

        [HttpGet]
        public ActionResult ReferenceNos()
            {
            List<ReferenceNo> mylastrefs = db.ReferenceNos.SqlQuery("SELECT TOP 1 * From ReferenceNos ORDER BY ReferenceID DESC").ToList();


            if (mylastrefs.Count > 0)
                {
                ReferenceNo mylastref = mylastrefs[0];

                mylastref.TodaysDate = DateTime.Today;

                mylastref.QuantityToGenerate = 0;

                return View("ReferenceNos", mylastref);
                }
            return View("ReferenceNos");
            }

        private int GetLastGeneratedRefNo(string Filter)
            {
            List<ReferenceNo> myrefs = db.ReferenceNos.SqlQuery("SELECT TOP 1 * From ReferenceNos WHERE GeneratedRange like '%" + Filter + "%' ORDER BY ReferenceID DESC").ToList();

            if (myrefs.Count > 0)
                {
                string referencerange = myrefs[0].Range;
                var refsplit = referencerange.Split('-');

                return int.Parse(refsplit[1].ToString());
                }
            return 1;
            }

        // POST: ReferenceNo/Generate
        [HttpPost]
        public ActionResult ReferenceNos(ReferenceNo rn)
            {
            //try
            //{

            DateTime ddate = rn.TodaysDate;
            int Quantity = rn.QuantityToGenerate;

            string branch = Session["Branch"].ToString();

            string thefilter = branch + "0" + ddate.ToString("yy");

            int StartNo = GetLastGeneratedRefNo(thefilter) + 1;

            string range = StartNo.ToString() + "-" + (StartNo + Quantity - 1);

            string GeneratedStart = branch + "0" + ddate.ToString("yy") + CompleteStartNo(StartNo);

            string GeneratedEnd = "";

            List<ReferenceNoforPrint> myreferences = new List<ReferenceNoforPrint>();

            if (Quantity > 0)
                {
                for (int i = 0; i < Quantity; i++)
                    {
                    int newNo = StartNo + i;
                    string NewReferenceNo = branch + "0" + ddate.ToString("yy") + CompleteStartNo(newNo);

                    ReferenceNoforPrint mysinglereference = new ReferenceNoforPrint();

                    mysinglereference.ReferenceNo = NewReferenceNo;

                    myreferences.Add(mysinglereference);

                    if (i == (Quantity - 1))
                        {
                        GeneratedEnd = NewReferenceNo;
                        }

                    }

                ReferenceNo mysingledbreference = new ReferenceNo();
                mysingledbreference.CurrentYear = DateTime.Now.Year.ToString();
                mysingledbreference.GeneratedBy = Session["AccountID"].ToString();

                mysingledbreference.QuantityToGenerate = Quantity;
                mysingledbreference.Range = range;
                mysingledbreference.DateGenerated = DateTime.Today;
                mysingledbreference.Centre = Session["Branch"].ToString();

                mysingledbreference.GeneratedRange = GeneratedStart + "-" + GeneratedEnd;
                mysingledbreference.TodaysDate = DateTime.Today;

                db.ReferenceNos.Add(mysingledbreference);
                db.SaveChanges();

                XtraReportReferenceNos myreport = new XtraReportReferenceNos();

                myreport.RequestParameters = false;
                myreport.objectDataSource1.DataSource = myreferences;
                myreport.CreateDocument();

                return View("PrintPreview", myreport);

                }
            else
                {
                return RedirectToAction("ReferenceNos");
                }

            //}
            //        catch
            //        {
            //            return new HttpStatusCodeResult(HttpStatusCode.ExpectationFailed);
            //}

            }

        private void SaveGeneratedRefNos(List<ReferenceNo> thereferences)
            {
            foreach (ReferenceNo myref in thereferences)
                {
                db.ReferenceNos.Add(myref);
                }

            db.SaveChanges();
            }


        private string CompleteStartNo(int TheNo)
            {
            string newValue;

            if (TheNo < 10)
                {
                newValue = "00000" + TheNo;
                }
            else if (TheNo >= 10 && TheNo < 100)
                {
                newValue = "0000" + TheNo;
                }
            else if (TheNo >= 100 && TheNo < 1000)
                {
                newValue = "000" + TheNo;
                }
            else if (TheNo >= 1000 && TheNo < 10000)
                {
                newValue = "00" + TheNo;
                }
            else if (TheNo >= 10000 && TheNo < 100000)
                {
                newValue = "0" + TheNo;
                }
            else
                {
                newValue = TheNo.ToString();
                }

            return newValue;
            }

        }
    }

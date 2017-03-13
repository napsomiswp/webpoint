using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.Models;

namespace NAPSOMIS_Webpoint.Controllers
{
    public class BanksController : Controller
    {
        private NAPSOMISModel db = new NAPSOMISModel();

        // GET: Banks
        public ActionResult Index()
        {
            return View(db.Banks.Take(100));
        }

        // GET: Banks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            { 
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank bank = db.Banks.Find(id);
            if (bank == null)
            {
                return HttpNotFound();
            }
            return View(bank);
        }

        public ActionResult PrintAll()
        {
            List<Bank> AllBanks = db.Banks.ToList();
            XtraReportBankList myReport = new XtraReportBankList();
            myReport.DesignerOptions.ShowDesignerHints = true;
            myReport.RequestParameters = false;
            myReport.objectDataSource1.DataSource = AllBanks;
            myReport.CreateDocument();
            return View("Print", myReport);
             
        }

        public ActionResult Print(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bank bank = db.Banks.Find(id);

            if (bank == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
             
                   XtraReportBankList BankReport = new XtraReportBankList();
             
                   Bank thebank = db.Banks.Find(id);

                    BankReport.objectDataSource1.DataSource  = thebank;
                    
                    BankReport.CreateDocument();
                     
                    return View(BankReport);
                
            }
  
        // GET: Banks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Banks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SBTS,fcode,fbank,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,DeleteFlag")] Bank bank)
        {
            if (ModelState.IsValid)
            {
                db.Banks.Add(bank);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bank);
        }

        // GET: Banks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank bank = db.Banks.Find(id);
            if (bank == null)
            {
                return HttpNotFound();
            }
            return View(bank);
        }

        // POST: Banks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SBTS,fcode,fbank,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,DeleteFlag")] Bank bank)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bank).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bank);
        }

        // GET: Banks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bank bank = db.Banks.Find(id);
            if (bank == null)
            {
                return HttpNotFound();
            }
            return View(bank);
        }

        // POST: Banks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bank bank = db.Banks.Find(id);
            db.Banks.Remove(bank);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

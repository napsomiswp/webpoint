using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAPSOMIS_Webpoint.Models;

namespace NAPSOMIS_Webpoint.Controllers
    {
    public class DeleteRecordsController : Controller
        {
        NAPSOMISModel db = new NAPSOMISModel();

        // GET: DeleteRecords
        public ActionResult Index()
            {
            return View();
            }

        public ActionResult Delete(MemberTransaction m)
            {
            try
                {
                List<MemberTransaction> mem = new List<MemberTransaction>();
                mem = db.MemberTransactions.Where(b => b.fref_no == m.fref_no).ToList();

                if (mem.Count > 0)
                    {
                    //db.MemberTransactions.Attach(mem[0]);
                    var entry = db.Entry(mem[0]);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();


                    List<ParentalTemp> p = new List<ParentalTemp>();
                    p = db.ParentalTemps.Where(b => b.fref_no == m.fref_no).ToList();

                    if (p.Count > 0)
                        {
                        var entryparental = db.Entry(p[0]);
                        entryparental.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();

                        }


                    List<NomTemp> n = new List<NomTemp>();
                    n = db.NomTemps.Where(b => b.fref_no == m.fref_no).ToList();

                    if (n.Count > 0)
                        {
                        foreach (var nom in n)
                            {
                            var entrydependants = db.Entry(nom);
                            entrydependants.State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();
                            }
                         
                        }
 
                    }
                }

            catch (Exception ex)
                {
                throw;
                }
             
            return View("Index");

            }

        public ActionResult Search(MemberTransaction m)
            {
            try
                {
                List<MemberTransaction> mem = new List<MemberTransaction>();
                mem = db.MemberTransactions.Where(b => b.fref_no == m.fref_no).ToList();

                if (mem.Count > 0)
                    {
                    return View("Index", mem[0]);
                    }
                else
                    {
                    return View("Index");
                    }
                }
            catch (Exception)
                {

                throw;
                }

            }

        }
    }
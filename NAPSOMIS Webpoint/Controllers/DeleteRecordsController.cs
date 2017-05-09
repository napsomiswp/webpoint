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
            return View("Index", new mem_tr());
            }

        public ActionResult Delete(mem_tr m)
            {
            try
                {
                List<mem_tr> mem = new List<mem_tr>();
                mem = db.mem_tr.Where(b => b.fref_no == m.fref_no).ToList();

                if (mem.Count > 0)
                    {
                    //db.MemberTransactions.Attach(mem[0]);

                    //mem_tr nm1 = new mem_tr();
                    //nm1 = mem[0];
                    //nm1.ModifiedBy = Session["AccountID"].ToString();
                    //nm1.ModifiedOn = DateTime.Today; 

                    //var uentry1 = db.Entry(nm1);
                    //uentry1.State = System.Data.Entity.EntityState.Modified;
                    //db.SaveChanges();


                    var entry = db.Entry(mem[0]);
                    entry.State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();


                    List<parental> p = new List<parental>();
                    p = db.parentals.Where(b => b.fref_no == m.fref_no).ToList();

                    if (p.Count > 0)
                        {
                        if (p[0].ModifiedBy == null)
                            {

                            p[0].ModifiedBy = Session["AccountID"].ToString();
                            p[0].ModifiedOn = DateTime.Today;
                            db.parentals.Attach(p[0]);
                            var upentry = db.Entry(p[0]);
                            upentry.State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                            }

                        var entryparental = db.Entry(p[0]);
                        entryparental.State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();

                        }


                    List<nom_tr> n = new List<nom_tr>();
                    n = db.nom_tr.Where(b => b.fref_no == m.fref_no).ToList();

                    if (n.Count > 0)
                        {
                        foreach (var nom in n)
                            {

                            if (nom.ModifiedBy == null)
                                {

                                nom.ModifiedBy = Session["AccountID"].ToString();
                                nom.ModifiedOn = DateTime.Today;
                                db.nom_tr.Attach(nom);
                                var upentry = db.Entry(nom);
                                upentry.State = System.Data.Entity.EntityState.Modified;
                                db.SaveChanges();

                                }

                            var entrydependants = db.Entry(nom);
                            entrydependants.State = System.Data.Entity.EntityState.Deleted;
                            db.SaveChanges();
                            }

                        }

                    ViewBag.Message = "MEMBER RECORD WAS SUCCESSFULLY DELETED";

                    }
                }

            catch (Exception)
                {
                throw;
                }

            return View("Index", new mem_tr());

            }

        public ActionResult Search(mem_tr m)
            {
            try
                {
                List<mem_tr> mem = new List<mem_tr>();
                mem = db.mem_tr.Where(b => b.fref_no == m.fref_no).ToList();

                if (mem.Count > 0)
                    {

                    return View("Index", mem[0]);
                    }
                else
                    {
                    mem_tr nm = new mem_tr();
                    nm.fref_no = m.fref_no;

                    ViewBag.Message = "NO RECORD FOUND FOR ERNO: " + nm.fref_no;
                    return View("Index", nm);
                    }
                }
            catch (Exception)
                {

                throw;
                }

            }

        }
    }
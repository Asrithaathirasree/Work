using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ETAHN;

namespace ETAHN.Controllers
{
    public class Report_By_PersonController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Report_By_Person
        public ActionResult Index()
        {
            return View(db.Report_By_Person.ToList());
        }

        // GET: Report_By_Person/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Person report_By_Person = db.Report_By_Person.Find(id);
            if (report_By_Person == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Person);
        }

        // GET: Report_By_Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Report_By_Person/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Person,TotalIncome,Till_Date")] Report_By_Person report_By_Person)
        {
            if (ModelState.IsValid)
            {
                db.Report_By_Person.Add(report_By_Person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(report_By_Person);
        }

        // GET: Report_By_Person/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Person report_By_Person = db.Report_By_Person.Find(id);
            if (report_By_Person == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Person);
        }

        // POST: Report_By_Person/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Person,TotalIncome,Till_Date")] Report_By_Person report_By_Person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(report_By_Person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(report_By_Person);
        }

        // GET: Report_By_Person/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Person report_By_Person = db.Report_By_Person.Find(id);
            if (report_By_Person == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Person);
        }

        // POST: Report_By_Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Report_By_Person report_By_Person = db.Report_By_Person.Find(id);
            db.Report_By_Person.Remove(report_By_Person);
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

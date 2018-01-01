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
    public class Report_By_DateController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Report_By_Date
        public ActionResult Index()
        {
            return View(db.Report_By_Date.ToList());
        }

        // GET: Report_By_Date/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Date report_By_Date = db.Report_By_Date.Find(id);
            if (report_By_Date == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Date);
        }

        // GET: Report_By_Date/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Report_By_Date/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,Total_Income")] Report_By_Date report_By_Date)
        {
            if (ModelState.IsValid)
            {
                db.Report_By_Date.Add(report_By_Date);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(report_By_Date);
        }

        // GET: Report_By_Date/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Date report_By_Date = db.Report_By_Date.Find(id);
            if (report_By_Date == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Date);
        }

        // POST: Report_By_Date/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,Total_Income")] Report_By_Date report_By_Date)
        {
            if (ModelState.IsValid)
            {
                db.Entry(report_By_Date).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(report_By_Date);
        }

        // GET: Report_By_Date/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Date report_By_Date = db.Report_By_Date.Find(id);
            if (report_By_Date == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Date);
        }

        // POST: Report_By_Date/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Report_By_Date report_By_Date = db.Report_By_Date.Find(id);
            db.Report_By_Date.Remove(report_By_Date);
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

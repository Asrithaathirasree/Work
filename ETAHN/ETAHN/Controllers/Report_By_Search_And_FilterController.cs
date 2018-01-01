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
    public class Report_By_Search_And_FilterController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Report_By_Search_And_Filter
        public ActionResult Index()
        {
            return View(db.Report_By_Search_And_Filter.ToList());
        }

        // GET: Report_By_Search_And_Filter/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Search_And_Filter report_By_Search_And_Filter = db.Report_By_Search_And_Filter.Find(id);
            if (report_By_Search_And_Filter == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Search_And_Filter);
        }

        // GET: Report_By_Search_And_Filter/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Report_By_Search_And_Filter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Person,Date,Category,Description")] Report_By_Search_And_Filter report_By_Search_And_Filter)
        {
            if (ModelState.IsValid)
            {
                db.Report_By_Search_And_Filter.Add(report_By_Search_And_Filter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(report_By_Search_And_Filter);
        }

        // GET: Report_By_Search_And_Filter/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Search_And_Filter report_By_Search_And_Filter = db.Report_By_Search_And_Filter.Find(id);
            if (report_By_Search_And_Filter == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Search_And_Filter);
        }

        // POST: Report_By_Search_And_Filter/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Person,Date,Category,Description")] Report_By_Search_And_Filter report_By_Search_And_Filter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(report_By_Search_And_Filter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(report_By_Search_And_Filter);
        }

        // GET: Report_By_Search_And_Filter/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Search_And_Filter report_By_Search_And_Filter = db.Report_By_Search_And_Filter.Find(id);
            if (report_By_Search_And_Filter == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Search_And_Filter);
        }

        // POST: Report_By_Search_And_Filter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Report_By_Search_And_Filter report_By_Search_And_Filter = db.Report_By_Search_And_Filter.Find(id);
            db.Report_By_Search_And_Filter.Remove(report_By_Search_And_Filter);
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

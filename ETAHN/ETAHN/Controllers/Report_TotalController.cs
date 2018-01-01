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
    public class Report_TotalController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Report_Total
        public ActionResult Index()
        {
            return View(db.Report_Total.ToList());
        }

        // GET: Report_Total/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_Total report_Total = db.Report_Total.Find(id);
            if (report_Total == null)
            {
                return HttpNotFound();
            }
            return View(report_Total);
        }

        // GET: Report_Total/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Report_Total/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Total_Income,Till_Date")] Report_Total report_Total)
        {
            if (ModelState.IsValid)
            {
                db.Report_Total.Add(report_Total);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(report_Total);
        }

        // GET: Report_Total/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_Total report_Total = db.Report_Total.Find(id);
            if (report_Total == null)
            {
                return HttpNotFound();
            }
            return View(report_Total);
        }

        // POST: Report_Total/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Total_Income,Till_Date")] Report_Total report_Total)
        {
            if (ModelState.IsValid)
            {
                db.Entry(report_Total).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(report_Total);
        }

        // GET: Report_Total/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_Total report_Total = db.Report_Total.Find(id);
            if (report_Total == null)
            {
                return HttpNotFound();
            }
            return View(report_Total);
        }

        // POST: Report_Total/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Report_Total report_Total = db.Report_Total.Find(id);
            db.Report_Total.Remove(report_Total);
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

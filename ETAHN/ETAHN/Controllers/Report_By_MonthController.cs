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
    public class Report_By_MonthController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Report_By_Month
        public ActionResult Index()
        {
            return View(db.Report_By_Month.ToList());
        }

        // GET: Report_By_Month/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Month report_By_Month = db.Report_By_Month.Find(id);
            if (report_By_Month == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Month);
        }

        // GET: Report_By_Month/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Report_By_Month/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Month_Name,Total_Income,Till_Month")] Report_By_Month report_By_Month)
        {
            if (ModelState.IsValid)
            {
                db.Report_By_Month.Add(report_By_Month);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(report_By_Month);
        }

        // GET: Report_By_Month/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Month report_By_Month = db.Report_By_Month.Find(id);
            if (report_By_Month == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Month);
        }

        // POST: Report_By_Month/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Month_Name,Total_Income,Till_Month")] Report_By_Month report_By_Month)
        {
            if (ModelState.IsValid)
            {
                db.Entry(report_By_Month).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(report_By_Month);
        }

        // GET: Report_By_Month/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report_By_Month report_By_Month = db.Report_By_Month.Find(id);
            if (report_By_Month == null)
            {
                return HttpNotFound();
            }
            return View(report_By_Month);
        }

        // POST: Report_By_Month/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Report_By_Month report_By_Month = db.Report_By_Month.Find(id);
            db.Report_By_Month.Remove(report_By_Month);
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

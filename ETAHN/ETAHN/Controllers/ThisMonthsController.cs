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
    public class ThisMonthsController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: ThisMonths
        public ActionResult Index()
        {
            var thisMonths = db.ThisMonths.Include(t => t.ExpenseTracker);
            return View(thisMonths.ToList());
        }

        // GET: ThisMonths/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThisMonth thisMonth = db.ThisMonths.Find(id);
            if (thisMonth == null)
            {
                return HttpNotFound();
            }
            return View(thisMonth);
        }

        // GET: ThisMonths/Create
        public ActionResult Create()
        {
            ViewBag.ExpenseTrackerId = new SelectList(db.ExpenseTrackers, "Id", "Name");
            return View();
        }

        // POST: ThisMonths/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Salary_Balance,Amount_Spent,ExpenseTrackerId")] ThisMonth thisMonth)
        {
            if (ModelState.IsValid)
            {
                db.ThisMonths.Add(thisMonth);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ExpenseTrackerId = new SelectList(db.ExpenseTrackers, "Id", "Name", thisMonth.ExpenseTrackerId);
            return View(thisMonth);
        }

        // GET: ThisMonths/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThisMonth thisMonth = db.ThisMonths.Find(id);
            if (thisMonth == null)
            {
                return HttpNotFound();
            }
            ViewBag.ExpenseTrackerId = new SelectList(db.ExpenseTrackers, "Id", "Name", thisMonth.ExpenseTrackerId);
            return View(thisMonth);
        }

        // POST: ThisMonths/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Salary_Balance,Amount_Spent,ExpenseTrackerId")] ThisMonth thisMonth)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thisMonth).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ExpenseTrackerId = new SelectList(db.ExpenseTrackers, "Id", "Name", thisMonth.ExpenseTrackerId);
            return View(thisMonth);
        }

        // GET: ThisMonths/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThisMonth thisMonth = db.ThisMonths.Find(id);
            if (thisMonth == null)
            {
                return HttpNotFound();
            }
            return View(thisMonth);
        }

        // POST: ThisMonths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThisMonth thisMonth = db.ThisMonths.Find(id);
            db.ThisMonths.Remove(thisMonth);
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

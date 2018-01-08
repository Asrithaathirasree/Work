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
    public class ExpenseTrackerAndHomeNeedsController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: ExpenseTrackerAndHomeNeeds
        public ActionResult Index()
        {
            var expenseTrackerAndHomeNeeds = db.ExpenseTrackerAndHomeNeeds.Include(e => e.Home_Needs).Include(e => e.ExpenseTracker);
            return View(expenseTrackerAndHomeNeeds.ToList());
        }

        // GET: ExpenseTrackerAndHomeNeeds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseTrackerAndHomeNeeds expenseTrackerAndHomeNeeds = db.ExpenseTrackerAndHomeNeeds.Find(id);
            if (expenseTrackerAndHomeNeeds == null)
            {
                return HttpNotFound();
            }
            return View(expenseTrackerAndHomeNeeds);
        }

        // GET: ExpenseTrackerAndHomeNeeds/Create
        public ActionResult Create()
        {
            ViewBag.Home_NeedsId = new SelectList(db.Home_Needs, "Id", "Entity");
            ViewBag.ExpenseTrackerId = new SelectList(db.ExpenseTrackers, "Id", "Name");
            return View();
        }

        // POST: ExpenseTrackerAndHomeNeeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Home_NeedsId,ExpenseTrackerId")] ExpenseTrackerAndHomeNeeds expenseTrackerAndHomeNeeds)
        {
            if (ModelState.IsValid)
            {
                db.ExpenseTrackerAndHomeNeeds.Add(expenseTrackerAndHomeNeeds);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Home_NeedsId = new SelectList(db.Home_Needs, "Id", "Entity", expenseTrackerAndHomeNeeds.Home_NeedsId);
            ViewBag.ExpenseTrackerId = new SelectList(db.ExpenseTrackers, "Id", "Name", expenseTrackerAndHomeNeeds.ExpenseTrackerId);
            return View(expenseTrackerAndHomeNeeds);
        }

        // GET: ExpenseTrackerAndHomeNeeds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseTrackerAndHomeNeeds expenseTrackerAndHomeNeeds = db.ExpenseTrackerAndHomeNeeds.Find(id);
            if (expenseTrackerAndHomeNeeds == null)
            {
                return HttpNotFound();
            }
            ViewBag.Home_NeedsId = new SelectList(db.Home_Needs, "Id", "Entity", expenseTrackerAndHomeNeeds.Home_NeedsId);
            ViewBag.ExpenseTrackerId = new SelectList(db.ExpenseTrackers, "Id", "Name", expenseTrackerAndHomeNeeds.ExpenseTrackerId);
            return View(expenseTrackerAndHomeNeeds);
        }

        // POST: ExpenseTrackerAndHomeNeeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Home_NeedsId,ExpenseTrackerId")] ExpenseTrackerAndHomeNeeds expenseTrackerAndHomeNeeds)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expenseTrackerAndHomeNeeds).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Home_NeedsId = new SelectList(db.Home_Needs, "Id", "Entity", expenseTrackerAndHomeNeeds.Home_NeedsId);
            ViewBag.ExpenseTrackerId = new SelectList(db.ExpenseTrackers, "Id", "Name", expenseTrackerAndHomeNeeds.ExpenseTrackerId);
            return View(expenseTrackerAndHomeNeeds);
        }

        // GET: ExpenseTrackerAndHomeNeeds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseTrackerAndHomeNeeds expenseTrackerAndHomeNeeds = db.ExpenseTrackerAndHomeNeeds.Find(id);
            if (expenseTrackerAndHomeNeeds == null)
            {
                return HttpNotFound();
            }
            return View(expenseTrackerAndHomeNeeds);
        }

        // POST: ExpenseTrackerAndHomeNeeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExpenseTrackerAndHomeNeeds expenseTrackerAndHomeNeeds = db.ExpenseTrackerAndHomeNeeds.Find(id);
            db.ExpenseTrackerAndHomeNeeds.Remove(expenseTrackerAndHomeNeeds);
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

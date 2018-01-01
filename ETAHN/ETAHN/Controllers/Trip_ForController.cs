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
    public class Trip_ForController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Trip_For
        public ActionResult Index()
        {
            return View(db.Trip_For.ToList());
        }

        // GET: Trip_For/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip_For trip_For = db.Trip_For.Find(id);
            if (trip_For == null)
            {
                return HttpNotFound();
            }
            return View(trip_For);
        }

        // GET: Trip_For/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trip_For/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Study,Employment,Tour")] Trip_For trip_For)
        {
            if (ModelState.IsValid)
            {
                db.Trip_For.Add(trip_For);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trip_For);
        }

        // GET: Trip_For/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip_For trip_For = db.Trip_For.Find(id);
            if (trip_For == null)
            {
                return HttpNotFound();
            }
            return View(trip_For);
        }

        // POST: Trip_For/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Study,Employment,Tour")] Trip_For trip_For)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trip_For).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trip_For);
        }

        // GET: Trip_For/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip_For trip_For = db.Trip_For.Find(id);
            if (trip_For == null)
            {
                return HttpNotFound();
            }
            return View(trip_For);
        }

        // POST: Trip_For/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trip_For trip_For = db.Trip_For.Find(id);
            db.Trip_For.Remove(trip_For);
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

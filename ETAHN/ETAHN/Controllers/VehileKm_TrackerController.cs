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
    public class VehileKm_TrackerController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: VehileKm_Tracker
        public ActionResult Index()
        {
            return View(db.VehileKm_Tracker.ToList());
        }

        // GET: VehileKm_Tracker/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehileKm_Tracker vehileKm_Tracker = db.VehileKm_Tracker.Find(id);
            if (vehileKm_Tracker == null)
            {
                return HttpNotFound();
            }
            return View(vehileKm_Tracker);
        }

        // GET: VehileKm_Tracker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehileKm_Tracker/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Distance_Covered,From,To,Date,Fuel_FillUp_Amount")] VehileKm_Tracker vehileKm_Tracker)
        {
            if (ModelState.IsValid)
            {
                db.VehileKm_Tracker.Add(vehileKm_Tracker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehileKm_Tracker);
        }

        // GET: VehileKm_Tracker/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehileKm_Tracker vehileKm_Tracker = db.VehileKm_Tracker.Find(id);
            if (vehileKm_Tracker == null)
            {
                return HttpNotFound();
            }
            return View(vehileKm_Tracker);
        }

        // POST: VehileKm_Tracker/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Distance_Covered,From,To,Date,Fuel_FillUp_Amount")] VehileKm_Tracker vehileKm_Tracker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehileKm_Tracker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehileKm_Tracker);
        }

        // GET: VehileKm_Tracker/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehileKm_Tracker vehileKm_Tracker = db.VehileKm_Tracker.Find(id);
            if (vehileKm_Tracker == null)
            {
                return HttpNotFound();
            }
            return View(vehileKm_Tracker);
        }

        // POST: VehileKm_Tracker/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VehileKm_Tracker vehileKm_Tracker = db.VehileKm_Tracker.Find(id);
            db.VehileKm_Tracker.Remove(vehileKm_Tracker);
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

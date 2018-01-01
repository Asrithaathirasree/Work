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
    public class LicencedForsController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: LicencedFors
        public ActionResult Index()
        {
            return View(db.LicencedFors.ToList());
        }

        // GET: LicencedFors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LicencedFor licencedFor = db.LicencedFors.Find(id);
            if (licencedFor == null)
            {
                return HttpNotFound();
            }
            return View(licencedFor);
        }

        // GET: LicencedFors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LicencedFors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Car,Bike")] LicencedFor licencedFor)
        {
            if (ModelState.IsValid)
            {
                db.LicencedFors.Add(licencedFor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(licencedFor);
        }

        // GET: LicencedFors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LicencedFor licencedFor = db.LicencedFors.Find(id);
            if (licencedFor == null)
            {
                return HttpNotFound();
            }
            return View(licencedFor);
        }

        // POST: LicencedFors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Car,Bike")] LicencedFor licencedFor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(licencedFor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(licencedFor);
        }

        // GET: LicencedFors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LicencedFor licencedFor = db.LicencedFors.Find(id);
            if (licencedFor == null)
            {
                return HttpNotFound();
            }
            return View(licencedFor);
        }

        // POST: LicencedFors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LicencedFor licencedFor = db.LicencedFors.Find(id);
            db.LicencedFors.Remove(licencedFor);
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

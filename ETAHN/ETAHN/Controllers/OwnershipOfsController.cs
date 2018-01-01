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
    public class OwnershipOfsController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: OwnershipOfs
        public ActionResult Index()
        {
            return View(db.OwnershipOfs.ToList());
        }

        // GET: OwnershipOfs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnershipOf ownershipOf = db.OwnershipOfs.Find(id);
            if (ownershipOf == null)
            {
                return HttpNotFound();
            }
            return View(ownershipOf);
        }

        // GET: OwnershipOfs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OwnershipOfs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Bike,Car")] OwnershipOf ownershipOf)
        {
            if (ModelState.IsValid)
            {
                db.OwnershipOfs.Add(ownershipOf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ownershipOf);
        }

        // GET: OwnershipOfs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnershipOf ownershipOf = db.OwnershipOfs.Find(id);
            if (ownershipOf == null)
            {
                return HttpNotFound();
            }
            return View(ownershipOf);
        }

        // POST: OwnershipOfs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Bike,Car")] OwnershipOf ownershipOf)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ownershipOf).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ownershipOf);
        }

        // GET: OwnershipOfs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnershipOf ownershipOf = db.OwnershipOfs.Find(id);
            if (ownershipOf == null)
            {
                return HttpNotFound();
            }
            return View(ownershipOf);
        }

        // POST: OwnershipOfs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OwnershipOf ownershipOf = db.OwnershipOfs.Find(id);
            db.OwnershipOfs.Remove(ownershipOf);
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

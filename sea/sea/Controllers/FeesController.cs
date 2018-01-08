using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sea;

namespace sea.Controllers
{
    public class FeesController : Controller
    {
        private studentformContainer db = new studentformContainer();

        // GET: Fees
        public ActionResult Index()
        {
            return View(db.Fees.ToList());
        }

        // GET: Fees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fees fees = db.Fees.Find(id);
            if (fees == null)
            {
                return HttpNotFound();
            }
            return View(fees);
        }

        // GET: Fees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fee_Amount,Department,Student_Regno,Student_Name,Date,Semester,Year")] Fees fees)
        {
            if (ModelState.IsValid)
            {
                db.Fees.Add(fees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fees);
        }

        // GET: Fees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fees fees = db.Fees.Find(id);
            if (fees == null)
            {
                return HttpNotFound();
            }
            return View(fees);
        }

        // POST: Fees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Fee_Amount,Department,Student_Regno,Student_Name,Date,Semester,Year")] Fees fees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fees);
        }

        // GET: Fees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fees fees = db.Fees.Find(id);
            if (fees == null)
            {
                return HttpNotFound();
            }
            return View(fees);
        }

        // POST: Fees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fees fees = db.Fees.Find(id);
            db.Fees.Remove(fees);
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

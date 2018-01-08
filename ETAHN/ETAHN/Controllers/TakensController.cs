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
    public class TakensController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Takens
        public ActionResult Index()
        {
            return View(db.Takens.ToList());
        }

        // GET: Takens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taken taken = db.Takens.Find(id);
            if (taken == null)
            {
                return HttpNotFound();
            }
            return View(taken);
        }

        // GET: Takens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Takens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Yes,no")] Taken taken)
        {
            if (ModelState.IsValid)
            {
                db.Takens.Add(taken);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taken);
        }

        // GET: Takens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taken taken = db.Takens.Find(id);
            if (taken == null)
            {
                return HttpNotFound();
            }
            return View(taken);
        }

        // POST: Takens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Yes,no")] Taken taken)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taken).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taken);
        }

        // GET: Takens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taken taken = db.Takens.Find(id);
            if (taken == null)
            {
                return HttpNotFound();
            }
            return View(taken);
        }

        // POST: Takens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Taken taken = db.Takens.Find(id);
            db.Takens.Remove(taken);
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

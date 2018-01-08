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
    public class Having_LicenceController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Having_Licence
        public ActionResult Index()
        {
            return View(db.Having_Licence.ToList());
        }

        // GET: Having_Licence/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Having_Licence having_Licence = db.Having_Licence.Find(id);
            if (having_Licence == null)
            {
                return HttpNotFound();
            }
            return View(having_Licence);
        }

        // GET: Having_Licence/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Having_Licence/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Yes,No")] Having_Licence having_Licence)
        {
            if (ModelState.IsValid)
            {
                db.Having_Licence.Add(having_Licence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(having_Licence);
        }

        // GET: Having_Licence/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Having_Licence having_Licence = db.Having_Licence.Find(id);
            if (having_Licence == null)
            {
                return HttpNotFound();
            }
            return View(having_Licence);
        }

        // POST: Having_Licence/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Yes,No")] Having_Licence having_Licence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(having_Licence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(having_Licence);
        }

        // GET: Having_Licence/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Having_Licence having_Licence = db.Having_Licence.Find(id);
            if (having_Licence == null)
            {
                return HttpNotFound();
            }
            return View(having_Licence);
        }

        // POST: Having_Licence/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Having_Licence having_Licence = db.Having_Licence.Find(id);
            db.Having_Licence.Remove(having_Licence);
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

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
    public class Monthly_NeedsController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Monthly_Needs
        public ActionResult Index()
        {
            var monthly_Needs = db.Monthly_Needs.Include(m => m.Need_Name);
            return View(monthly_Needs.ToList());
        }

        // GET: Monthly_Needs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monthly_Needs monthly_Needs = db.Monthly_Needs.Find(id);
            if (monthly_Needs == null)
            {
                return HttpNotFound();
            }
            return View(monthly_Needs);
        }

        // GET: Monthly_Needs/Create
        public ActionResult Create()
        {
            ViewBag.Need_NameId = new SelectList(db.Need_Name, "Id", "Id");
            return View();
        }

        // POST: Monthly_Needs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Location,Amount,Description,Need_NameId")] Monthly_Needs monthly_Needs)
        {
            if (ModelState.IsValid)
            {
                db.Monthly_Needs.Add(monthly_Needs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Need_NameId = new SelectList(db.Need_Name, "Id", "Id", monthly_Needs.Need_NameId);
            return View(monthly_Needs);
        }

        // GET: Monthly_Needs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monthly_Needs monthly_Needs = db.Monthly_Needs.Find(id);
            if (monthly_Needs == null)
            {
                return HttpNotFound();
            }
            ViewBag.Need_NameId = new SelectList(db.Need_Name, "Id", "Id", monthly_Needs.Need_NameId);
            return View(monthly_Needs);
        }

        // POST: Monthly_Needs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Location,Amount,Description,Need_NameId")] Monthly_Needs monthly_Needs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monthly_Needs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Need_NameId = new SelectList(db.Need_Name, "Id", "Id", monthly_Needs.Need_NameId);
            return View(monthly_Needs);
        }

        // GET: Monthly_Needs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monthly_Needs monthly_Needs = db.Monthly_Needs.Find(id);
            if (monthly_Needs == null)
            {
                return HttpNotFound();
            }
            return View(monthly_Needs);
        }

        // POST: Monthly_Needs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Monthly_Needs monthly_Needs = db.Monthly_Needs.Find(id);
            db.Monthly_Needs.Remove(monthly_Needs);
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

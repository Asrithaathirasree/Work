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
    public class Expense_categoryController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Expense_category
        public ActionResult Index()
        {
            return View(db.Expense_category.ToList());
        }

        // GET: Expense_category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expense_category expense_category = db.Expense_category.Find(id);
            if (expense_category == null)
            {
                return HttpNotFound();
            }
            return View(expense_category);
        }

        // GET: Expense_category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Expense_category/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Grocery,Bills,Travel")] Expense_category expense_category)
        {
            if (ModelState.IsValid)
            {
                db.Expense_category.Add(expense_category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(expense_category);
        }

        // GET: Expense_category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expense_category expense_category = db.Expense_category.Find(id);
            if (expense_category == null)
            {
                return HttpNotFound();
            }
            return View(expense_category);
        }

        // POST: Expense_category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Grocery,Bills,Travel")] Expense_category expense_category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expense_category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expense_category);
        }

        // GET: Expense_category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expense_category expense_category = db.Expense_category.Find(id);
            if (expense_category == null)
            {
                return HttpNotFound();
            }
            return View(expense_category);
        }

        // POST: Expense_category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Expense_category expense_category = db.Expense_category.Find(id);
            db.Expense_category.Remove(expense_category);
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

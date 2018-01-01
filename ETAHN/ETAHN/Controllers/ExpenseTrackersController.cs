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
    public class ExpenseTrackersController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: ExpenseTrackers
        public ActionResult Index()
        {
            var expenseTrackers = db.ExpenseTrackers.Include(e => e.Person_Details).Include(e => e.Expense).Include(e => e.Report_Total).Include(e => e.Report_By_Person).Include(e => e.Person).Include(e => e.Report_By_Search_And_Filter).Include(e => e.Report_By_Date).Include(e => e.Report_By_Month);
            return View(expenseTrackers.ToList());
        }

        // GET: ExpenseTrackers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseTracker expenseTracker = db.ExpenseTrackers.Find(id);
            if (expenseTracker == null)
            {
                return HttpNotFound();
            }
            return View(expenseTracker);
        }

        // GET: ExpenseTrackers/Create
        public ActionResult Create()
        {
            ViewBag.Person_DetailsId = new SelectList(db.Person_Details, "Id", "Name");
            ViewBag.ExpenseId = new SelectList(db.Expenses, "Id", "Description");
            ViewBag.Report_TotalId = new SelectList(db.Report_Total, "Id", "Till_Date");
            ViewBag.Report_By_PersonId = new SelectList(db.Report_By_Person, "Id", "Person");
            ViewBag.PersonId1 = new SelectList(db.People, "Id", "Name");
            ViewBag.Report_By_Search_And_FilterId1 = new SelectList(db.Report_By_Search_And_Filter, "Id", "Person");
            ViewBag.Report_By_DateId1 = new SelectList(db.Report_By_Date, "Id", "Date");
            ViewBag.Report_By_MonthId1 = new SelectList(db.Report_By_Month, "Id", "Month_Name");
            return View();
        }

        // POST: ExpenseTrackers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,PersonId,Person_DetailsId,ExpenseId,Home_NeedsId,Report_TotalId,Report_By_PersonId,Report_By_MonthId,Report_By_DateId,Report_By_Search_And_FilterId,Family_MembersId,PersonId1,Report_By_Search_And_FilterId1,Report_By_DateId1,Report_By_MonthId1")] ExpenseTracker expenseTracker)
        {
            if (ModelState.IsValid)
            {
                db.ExpenseTrackers.Add(expenseTracker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Person_DetailsId = new SelectList(db.Person_Details, "Id", "Name", expenseTracker.Person_DetailsId);
            ViewBag.ExpenseId = new SelectList(db.Expenses, "Id", "Description", expenseTracker.ExpenseId);
            ViewBag.Report_TotalId = new SelectList(db.Report_Total, "Id", "Till_Date", expenseTracker.Report_TotalId);
            ViewBag.Report_By_PersonId = new SelectList(db.Report_By_Person, "Id", "Person", expenseTracker.Report_By_PersonId);
            ViewBag.PersonId1 = new SelectList(db.People, "Id", "Name", expenseTracker.PersonId1);
            ViewBag.Report_By_Search_And_FilterId1 = new SelectList(db.Report_By_Search_And_Filter, "Id", "Person", expenseTracker.Report_By_Search_And_FilterId1);
            ViewBag.Report_By_DateId1 = new SelectList(db.Report_By_Date, "Id", "Date", expenseTracker.Report_By_DateId1);
            ViewBag.Report_By_MonthId1 = new SelectList(db.Report_By_Month, "Id", "Month_Name", expenseTracker.Report_By_MonthId1);
            return View(expenseTracker);
        }

        // GET: ExpenseTrackers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseTracker expenseTracker = db.ExpenseTrackers.Find(id);
            if (expenseTracker == null)
            {
                return HttpNotFound();
            }
            ViewBag.Person_DetailsId = new SelectList(db.Person_Details, "Id", "Name", expenseTracker.Person_DetailsId);
            ViewBag.ExpenseId = new SelectList(db.Expenses, "Id", "Description", expenseTracker.ExpenseId);
            ViewBag.Report_TotalId = new SelectList(db.Report_Total, "Id", "Till_Date", expenseTracker.Report_TotalId);
            ViewBag.Report_By_PersonId = new SelectList(db.Report_By_Person, "Id", "Person", expenseTracker.Report_By_PersonId);
            ViewBag.PersonId1 = new SelectList(db.People, "Id", "Name", expenseTracker.PersonId1);
            ViewBag.Report_By_Search_And_FilterId1 = new SelectList(db.Report_By_Search_And_Filter, "Id", "Person", expenseTracker.Report_By_Search_And_FilterId1);
            ViewBag.Report_By_DateId1 = new SelectList(db.Report_By_Date, "Id", "Date", expenseTracker.Report_By_DateId1);
            ViewBag.Report_By_MonthId1 = new SelectList(db.Report_By_Month, "Id", "Month_Name", expenseTracker.Report_By_MonthId1);
            return View(expenseTracker);
        }

        // POST: ExpenseTrackers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,PersonId,Person_DetailsId,ExpenseId,Home_NeedsId,Report_TotalId,Report_By_PersonId,Report_By_MonthId,Report_By_DateId,Report_By_Search_And_FilterId,Family_MembersId,PersonId1,Report_By_Search_And_FilterId1,Report_By_DateId1,Report_By_MonthId1")] ExpenseTracker expenseTracker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expenseTracker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Person_DetailsId = new SelectList(db.Person_Details, "Id", "Name", expenseTracker.Person_DetailsId);
            ViewBag.ExpenseId = new SelectList(db.Expenses, "Id", "Description", expenseTracker.ExpenseId);
            ViewBag.Report_TotalId = new SelectList(db.Report_Total, "Id", "Till_Date", expenseTracker.Report_TotalId);
            ViewBag.Report_By_PersonId = new SelectList(db.Report_By_Person, "Id", "Person", expenseTracker.Report_By_PersonId);
            ViewBag.PersonId1 = new SelectList(db.People, "Id", "Name", expenseTracker.PersonId1);
            ViewBag.Report_By_Search_And_FilterId1 = new SelectList(db.Report_By_Search_And_Filter, "Id", "Person", expenseTracker.Report_By_Search_And_FilterId1);
            ViewBag.Report_By_DateId1 = new SelectList(db.Report_By_Date, "Id", "Date", expenseTracker.Report_By_DateId1);
            ViewBag.Report_By_MonthId1 = new SelectList(db.Report_By_Month, "Id", "Month_Name", expenseTracker.Report_By_MonthId1);
            return View(expenseTracker);
        }

        // GET: ExpenseTrackers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseTracker expenseTracker = db.ExpenseTrackers.Find(id);
            if (expenseTracker == null)
            {
                return HttpNotFound();
            }
            return View(expenseTracker);
        }

        // POST: ExpenseTrackers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExpenseTracker expenseTracker = db.ExpenseTrackers.Find(id);
            db.ExpenseTrackers.Remove(expenseTracker);
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

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
    public class Check_ListController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Check_List
        public ActionResult Index()
        {
            var check_List = db.Check_List.Include(c => c.Status);
            return View(check_List.ToList());
        }

        // GET: Check_List/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Check_List check_List = db.Check_List.Find(id);
            if (check_List == null)
            {
                return HttpNotFound();
            }
            return View(check_List);
        }

        // GET: Check_List/Create
        public ActionResult Create()
        {
            ViewBag.StatusId = new SelectList(db.Status, "Id", "InProcess");
            return View();
        }

        // POST: Check_List/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,Category,ToDo,Location,Property1,StatusId")] Check_List check_List)
        {
            if (ModelState.IsValid)
            {
                db.Check_List.Add(check_List);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StatusId = new SelectList(db.Status, "Id", "InProcess", check_List.StatusId);
            return View(check_List);
        }

        // GET: Check_List/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Check_List check_List = db.Check_List.Find(id);
            if (check_List == null)
            {
                return HttpNotFound();
            }
            ViewBag.StatusId = new SelectList(db.Status, "Id", "InProcess", check_List.StatusId);
            return View(check_List);
        }

        // POST: Check_List/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,Category,ToDo,Location,Property1,StatusId")] Check_List check_List)
        {
            if (ModelState.IsValid)
            {
                db.Entry(check_List).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StatusId = new SelectList(db.Status, "Id", "InProcess", check_List.StatusId);
            return View(check_List);
        }

        // GET: Check_List/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Check_List check_List = db.Check_List.Find(id);
            if (check_List == null)
            {
                return HttpNotFound();
            }
            return View(check_List);
        }

        // POST: Check_List/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Check_List check_List = db.Check_List.Find(id);
            db.Check_List.Remove(check_List);
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

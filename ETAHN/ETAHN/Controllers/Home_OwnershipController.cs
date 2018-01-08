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
    public class Home_OwnershipController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Home_Ownership
        public ActionResult Index()
        {
            var home_Ownership = db.Home_Ownership.Include(h => h.Family_Members);
            return View(home_Ownership.ToList());
        }

        // GET: Home_Ownership/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Home_Ownership home_Ownership = db.Home_Ownership.Find(id);
            if (home_Ownership == null)
            {
                return HttpNotFound();
            }
            return View(home_Ownership);
        }

        // GET: Home_Ownership/Create
        public ActionResult Create()
        {
            ViewBag.Family_MembersId = new SelectList(db.Family_Members, "Id", "Name");
            return View();
        }

        // POST: Home_Ownership/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Rent,Own,Family_MembersId")] Home_Ownership home_Ownership)
        {
            if (ModelState.IsValid)
            {
                db.Home_Ownership.Add(home_Ownership);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Family_MembersId = new SelectList(db.Family_Members, "Id", "Name", home_Ownership.Family_MembersId);
            return View(home_Ownership);
        }

        // GET: Home_Ownership/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Home_Ownership home_Ownership = db.Home_Ownership.Find(id);
            if (home_Ownership == null)
            {
                return HttpNotFound();
            }
            ViewBag.Family_MembersId = new SelectList(db.Family_Members, "Id", "Name", home_Ownership.Family_MembersId);
            return View(home_Ownership);
        }

        // POST: Home_Ownership/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Rent,Own,Family_MembersId")] Home_Ownership home_Ownership)
        {
            if (ModelState.IsValid)
            {
                db.Entry(home_Ownership).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Family_MembersId = new SelectList(db.Family_Members, "Id", "Name", home_Ownership.Family_MembersId);
            return View(home_Ownership);
        }

        // GET: Home_Ownership/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Home_Ownership home_Ownership = db.Home_Ownership.Find(id);
            if (home_Ownership == null)
            {
                return HttpNotFound();
            }
            return View(home_Ownership);
        }

        // POST: Home_Ownership/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Home_Ownership home_Ownership = db.Home_Ownership.Find(id);
            db.Home_Ownership.Remove(home_Ownership);
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

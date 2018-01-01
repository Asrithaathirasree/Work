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
    public class Person_DetailsController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Person_Details
        public ActionResult Index()
        {
            var person_Details = db.Person_Details.Include(p => p.Person_Type);
            return View(person_Details.ToList());
        }

        // GET: Person_Details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person_Details person_Details = db.Person_Details.Find(id);
            if (person_Details == null)
            {
                return HttpNotFound();
            }
            return View(person_Details);
        }

        // GET: Person_Details/Create
        public ActionResult Create()
        {
            ViewBag.Person_TypeId = new SelectList(db.Person_Type, "Id", "Father");
            return View();
        }

        // POST: Person_Details/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,EntityId,PhoneNumber1,PhoneNumber2,EmailId,Occupation,OccupativeAddress,Salary,Person_TypeId")] Person_Details person_Details)
        {
            if (ModelState.IsValid)
            {
                db.Person_Details.Add(person_Details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Person_TypeId = new SelectList(db.Person_Type, "Id", "Father", person_Details.Person_TypeId);
            return View(person_Details);
        }

        // GET: Person_Details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person_Details person_Details = db.Person_Details.Find(id);
            if (person_Details == null)
            {
                return HttpNotFound();
            }
            ViewBag.Person_TypeId = new SelectList(db.Person_Type, "Id", "Father", person_Details.Person_TypeId);
            return View(person_Details);
        }

        // POST: Person_Details/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,EntityId,PhoneNumber1,PhoneNumber2,EmailId,Occupation,OccupativeAddress,Salary,Person_TypeId")] Person_Details person_Details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person_Details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Person_TypeId = new SelectList(db.Person_Type, "Id", "Father", person_Details.Person_TypeId);
            return View(person_Details);
        }

        // GET: Person_Details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person_Details person_Details = db.Person_Details.Find(id);
            if (person_Details == null)
            {
                return HttpNotFound();
            }
            return View(person_Details);
        }

        // POST: Person_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person_Details person_Details = db.Person_Details.Find(id);
            db.Person_Details.Remove(person_Details);
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

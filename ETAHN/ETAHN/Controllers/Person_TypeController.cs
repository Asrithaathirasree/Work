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
    public class Person_TypeController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Person_Type
        public ActionResult Index()
        {
            return View(db.Person_Type.ToList());
        }

        // GET: Person_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person_Type person_Type = db.Person_Type.Find(id);
            if (person_Type == null)
            {
                return HttpNotFound();
            }
            return View(person_Type);
        }

        // GET: Person_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Father,Mother,Daughter,Son")] Person_Type person_Type)
        {
            if (ModelState.IsValid)
            {
                db.Person_Type.Add(person_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person_Type);
        }

        // GET: Person_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person_Type person_Type = db.Person_Type.Find(id);
            if (person_Type == null)
            {
                return HttpNotFound();
            }
            return View(person_Type);
        }

        // POST: Person_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Father,Mother,Daughter,Son")] Person_Type person_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person_Type);
        }

        // GET: Person_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person_Type person_Type = db.Person_Type.Find(id);
            if (person_Type == null)
            {
                return HttpNotFound();
            }
            return View(person_Type);
        }

        // POST: Person_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person_Type person_Type = db.Person_Type.Find(id);
            db.Person_Type.Remove(person_Type);
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

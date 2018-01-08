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
    public class Student_TypeController : Controller
    {
        private studentformContainer db = new studentformContainer();

        // GET: Student_Type
        public ActionResult Index()
        {
            return View(db.Student_Type.ToList());
        }

        // GET: Student_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Type student_Type = db.Student_Type.Find(id);
            if (student_Type == null)
            {
                return HttpNotFound();
            }
            return View(student_Type);
        }

        // GET: Student_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Student_Type student_Type)
        {
            if (ModelState.IsValid)
            {
                db.Student_Type.Add(student_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student_Type);
        }

        // GET: Student_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Type student_Type = db.Student_Type.Find(id);
            if (student_Type == null)
            {
                return HttpNotFound();
            }
            return View(student_Type);
        }

        // POST: Student_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Student_Type student_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_Type);
        }

        // GET: Student_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Type student_Type = db.Student_Type.Find(id);
            if (student_Type == null)
            {
                return HttpNotFound();
            }
            return View(student_Type);
        }

        // POST: Student_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student_Type student_Type = db.Student_Type.Find(id);
            db.Student_Type.Remove(student_Type);
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

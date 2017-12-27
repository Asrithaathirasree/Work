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
    public class Staff_TypeController : Controller
    {
        private studentformContainer db = new studentformContainer();

        // GET: Staff_Type
        public ActionResult Index()
        {
            return View(db.Staff_Type.ToList());
        }

        // GET: Staff_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Type staff_Type = db.Staff_Type.Find(id);
            if (staff_Type == null)
            {
                return HttpNotFound();
            }
            return View(staff_Type);
        }

        // GET: Staff_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Staff_Type staff_Type)
        {
            if (ModelState.IsValid)
            {
                db.Staff_Type.Add(staff_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(staff_Type);
        }

        // GET: Staff_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Type staff_Type = db.Staff_Type.Find(id);
            if (staff_Type == null)
            {
                return HttpNotFound();
            }
            return View(staff_Type);
        }

        // POST: Staff_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Staff_Type staff_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(staff_Type);
        }

        // GET: Staff_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff_Type staff_Type = db.Staff_Type.Find(id);
            if (staff_Type == null)
            {
                return HttpNotFound();
            }
            return View(staff_Type);
        }

        // POST: Staff_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Staff_Type staff_Type = db.Staff_Type.Find(id);
            db.Staff_Type.Remove(staff_Type);
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

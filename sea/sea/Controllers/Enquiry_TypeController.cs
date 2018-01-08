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
    public class Enquiry_TypeController : Controller
    {
        private studentformContainer db = new studentformContainer();

        // GET: Enquiry_Type
        public ActionResult Index()
        {
            return View(db.Enquiry_Type.ToList());
        }

        // GET: Enquiry_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enquiry_Type enquiry_Type = db.Enquiry_Type.Find(id);
            if (enquiry_Type == null)
            {
                return HttpNotFound();
            }
            return View(enquiry_Type);
        }

        // GET: Enquiry_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enquiry_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Enquiry_Type enquiry_Type)
        {
            if (ModelState.IsValid)
            {
                db.Enquiry_Type.Add(enquiry_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enquiry_Type);
        }

        // GET: Enquiry_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enquiry_Type enquiry_Type = db.Enquiry_Type.Find(id);
            if (enquiry_Type == null)
            {
                return HttpNotFound();
            }
            return View(enquiry_Type);
        }

        // POST: Enquiry_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Enquiry_Type enquiry_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enquiry_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enquiry_Type);
        }

        // GET: Enquiry_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enquiry_Type enquiry_Type = db.Enquiry_Type.Find(id);
            if (enquiry_Type == null)
            {
                return HttpNotFound();
            }
            return View(enquiry_Type);
        }

        // POST: Enquiry_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enquiry_Type enquiry_Type = db.Enquiry_Type.Find(id);
            db.Enquiry_Type.Remove(enquiry_Type);
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

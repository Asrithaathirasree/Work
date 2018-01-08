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
    public class Admission_formController : Controller
    {
        private studentformContainer db = new studentformContainer();

        // GET: Admission_form
        public ActionResult Index()
        {
            var admission_form = db.Admission_form.Include(a => a.Enquiry_Type).Include(a => a.Student_Type).Include(a => a.Quota);
            return View(admission_form.ToList());
        }

        // GET: Admission_form/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admission_form admission_form = db.Admission_form.Find(id);
            if (admission_form == null)
            {
                return HttpNotFound();
            }
            return View(admission_form);
        }

        // GET: Admission_form/Create
        public ActionResult Create()
        {
            ViewBag.Enquiry_TypeId = new SelectList(db.Enquiry_Type, "Id", "Name");
            ViewBag.Student_TypeId = new SelectList(db.Student_Type, "Id", "Name");
            ViewBag.QuotaId = new SelectList(db.Quotas, "Id", "Name");
            return View();
        }

        // POST: Admission_form/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Enquiry_TypeId,Department,Student_TypeId,QuotaId,Tenth_Percentage,Plustwo_Percentage,Address,Email,Phone_Num")] Admission_form admission_form)
        {
            if (ModelState.IsValid)
            {
                db.Admission_form.Add(admission_form);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Enquiry_TypeId = new SelectList(db.Enquiry_Type, "Id", "Name", admission_form.Enquiry_TypeId);
            ViewBag.Student_TypeId = new SelectList(db.Student_Type, "Id", "Name", admission_form.Student_TypeId);
            ViewBag.QuotaId = new SelectList(db.Quotas, "Id", "Name", admission_form.QuotaId);
            return View(admission_form);
        }

        // GET: Admission_form/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admission_form admission_form = db.Admission_form.Find(id);
            if (admission_form == null)
            {
                return HttpNotFound();
            }
            ViewBag.Enquiry_TypeId = new SelectList(db.Enquiry_Type, "Id", "Name", admission_form.Enquiry_TypeId);
            ViewBag.Student_TypeId = new SelectList(db.Student_Type, "Id", "Name", admission_form.Student_TypeId);
            ViewBag.QuotaId = new SelectList(db.Quotas, "Id", "Name", admission_form.QuotaId);
            return View(admission_form);
        }

        // POST: Admission_form/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Enquiry_TypeId,Department,Student_TypeId,QuotaId,Tenth_Percentage,Plustwo_Percentage,Address,Email,Phone_Num")] Admission_form admission_form)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admission_form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Enquiry_TypeId = new SelectList(db.Enquiry_Type, "Id", "Name", admission_form.Enquiry_TypeId);
            ViewBag.Student_TypeId = new SelectList(db.Student_Type, "Id", "Name", admission_form.Student_TypeId);
            ViewBag.QuotaId = new SelectList(db.Quotas, "Id", "Name", admission_form.QuotaId);
            return View(admission_form);
        }

        // GET: Admission_form/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admission_form admission_form = db.Admission_form.Find(id);
            if (admission_form == null)
            {
                return HttpNotFound();
            }
            return View(admission_form);
        }

        // POST: Admission_form/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Admission_form admission_form = db.Admission_form.Find(id);
            db.Admission_form.Remove(admission_form);
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

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
    public class Family_MembersController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Family_Members
        public ActionResult Index()
        {
            var family_Members = db.Family_Members.Include(f => f.Member_Type).Include(f => f.LicencedFor);
            return View(family_Members.ToList());
        }

        // GET: Family_Members/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Family_Members family_Members = db.Family_Members.Find(id);
            if (family_Members == null)
            {
                return HttpNotFound();
            }
            return View(family_Members);
        }

        // GET: Family_Members/Create
        public ActionResult Create()
        {
            ViewBag.Member_TypeId = new SelectList(db.Member_Type, "Id", "Father");
            ViewBag.LicencedForId1 = new SelectList(db.LicencedFors, "Id", "Car");
            return View();
        }

        // POST: Family_Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email_id,Adhar_Number,PAN_CardNumber,Election_CardNumber,Licence_Number,Bank_Account_detais,Mobile_Number1,Mobile_Number2,Landline,Occupation,Occupation_Location,Home_OwnershipId,LicencedForId,Member_TypeId,Home_OwnershipId1,LicencedForId1")] Family_Members family_Members)
        {
            if (ModelState.IsValid)
            {
                db.Family_Members.Add(family_Members);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Member_TypeId = new SelectList(db.Member_Type, "Id", "Father", family_Members.Member_TypeId);
            ViewBag.LicencedForId1 = new SelectList(db.LicencedFors, "Id", "Car", family_Members.LicencedForId1);
            return View(family_Members);
        }

        // GET: Family_Members/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Family_Members family_Members = db.Family_Members.Find(id);
            if (family_Members == null)
            {
                return HttpNotFound();
            }
            ViewBag.Member_TypeId = new SelectList(db.Member_Type, "Id", "Father", family_Members.Member_TypeId);
            ViewBag.LicencedForId1 = new SelectList(db.LicencedFors, "Id", "Car", family_Members.LicencedForId1);
            return View(family_Members);
        }

        // POST: Family_Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email_id,Adhar_Number,PAN_CardNumber,Election_CardNumber,Licence_Number,Bank_Account_detais,Mobile_Number1,Mobile_Number2,Landline,Occupation,Occupation_Location,Home_OwnershipId,LicencedForId,Member_TypeId,Home_OwnershipId1,LicencedForId1")] Family_Members family_Members)
        {
            if (ModelState.IsValid)
            {
                db.Entry(family_Members).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Member_TypeId = new SelectList(db.Member_Type, "Id", "Father", family_Members.Member_TypeId);
            ViewBag.LicencedForId1 = new SelectList(db.LicencedFors, "Id", "Car", family_Members.LicencedForId1);
            return View(family_Members);
        }

        // GET: Family_Members/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Family_Members family_Members = db.Family_Members.Find(id);
            if (family_Members == null)
            {
                return HttpNotFound();
            }
            return View(family_Members);
        }

        // POST: Family_Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Family_Members family_Members = db.Family_Members.Find(id);
            db.Family_Members.Remove(family_Members);
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

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
    public class Member_TypeController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Member_Type
        public ActionResult Index()
        {
            return View(db.Member_Type.ToList());
        }

        // GET: Member_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member_Type member_Type = db.Member_Type.Find(id);
            if (member_Type == null)
            {
                return HttpNotFound();
            }
            return View(member_Type);
        }

        // GET: Member_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Member_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Father,Mother,Son1")] Member_Type member_Type)
        {
            if (ModelState.IsValid)
            {
                db.Member_Type.Add(member_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(member_Type);
        }

        // GET: Member_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member_Type member_Type = db.Member_Type.Find(id);
            if (member_Type == null)
            {
                return HttpNotFound();
            }
            return View(member_Type);
        }

        // POST: Member_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Father,Mother,Son1")] Member_Type member_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(member_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(member_Type);
        }

        // GET: Member_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member_Type member_Type = db.Member_Type.Find(id);
            if (member_Type == null)
            {
                return HttpNotFound();
            }
            return View(member_Type);
        }

        // POST: Member_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Member_Type member_Type = db.Member_Type.Find(id);
            db.Member_Type.Remove(member_Type);
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

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
    public class Need_NameController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Need_Name
        public ActionResult Index()
        {
            return View(db.Need_Name.ToList());
        }

        // GET: Need_Name/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Need_Name need_Name = db.Need_Name.Find(id);
            if (need_Name == null)
            {
                return HttpNotFound();
            }
            return View(need_Name);
        }

        // GET: Need_Name/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Need_Name/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Electricity_Bill,Fund")] Need_Name need_Name)
        {
            if (ModelState.IsValid)
            {
                db.Need_Name.Add(need_Name);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(need_Name);
        }

        // GET: Need_Name/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Need_Name need_Name = db.Need_Name.Find(id);
            if (need_Name == null)
            {
                return HttpNotFound();
            }
            return View(need_Name);
        }

        // POST: Need_Name/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Electricity_Bill,Fund")] Need_Name need_Name)
        {
            if (ModelState.IsValid)
            {
                db.Entry(need_Name).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(need_Name);
        }

        // GET: Need_Name/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Need_Name need_Name = db.Need_Name.Find(id);
            if (need_Name == null)
            {
                return HttpNotFound();
            }
            return View(need_Name);
        }

        // POST: Need_Name/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Need_Name need_Name = db.Need_Name.Find(id);
            db.Need_Name.Remove(need_Name);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sample;

namespace Sample.Controllers
{
    public class Sample1Controller : Controller
    {
        private Model1Container db = new Model1Container();

        // GET: Sample1
        public ActionResult Index()
        {
            return View(db.Sample1.ToList());
        }

        // GET: Sample1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sample1 sample1 = db.Sample1.Find(id);
            if (sample1 == null)
            {
                return HttpNotFound();
            }
            return View(sample1);
        }

        // GET: Sample1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sample1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Sample1 sample1)
        {
            if (ModelState.IsValid)
            {
                db.Sample1.Add(sample1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sample1);
        }

        // GET: Sample1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sample1 sample1 = db.Sample1.Find(id);
            if (sample1 == null)
            {
                return HttpNotFound();
            }
            return View(sample1);
        }

        // POST: Sample1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Sample1 sample1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sample1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sample1);
        }

        // GET: Sample1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sample1 sample1 = db.Sample1.Find(id);
            if (sample1 == null)
            {
                return HttpNotFound();
            }
            return View(sample1);
        }

        // POST: Sample1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sample1 sample1 = db.Sample1.Find(id);
            db.Sample1.Remove(sample1);
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

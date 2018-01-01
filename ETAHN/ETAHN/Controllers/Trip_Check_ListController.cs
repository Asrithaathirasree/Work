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
    public class Trip_Check_ListController : Controller
    {
        private ExpenseTrackerContainer db = new ExpenseTrackerContainer();

        // GET: Trip_Check_List
        public ActionResult Index()
        {
            var trip_Check_List = db.Trip_Check_List.Include(t => t.Trip_For).Include(t => t.Taken);
            return View(trip_Check_List.ToList());
        }

        // GET: Trip_Check_List/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip_Check_List trip_Check_List = db.Trip_Check_List.Find(id);
            if (trip_Check_List == null)
            {
                return HttpNotFound();
            }
            return View(trip_Check_List);
        }

        // GET: Trip_Check_List/Create
        public ActionResult Create()
        {
            ViewBag.Trip_ForId1 = new SelectList(db.Trip_For, "Id", "Study");
            ViewBag.TakenId1 = new SelectList(db.Takens, "Id", "Yes");
            return View();
        }

        // POST: Trip_Check_List/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Thing_Name,Unit,description,Trip_ForId,TakenId,Trip_ForId1,TakenId1")] Trip_Check_List trip_Check_List)
        {
            if (ModelState.IsValid)
            {
                db.Trip_Check_List.Add(trip_Check_List);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Trip_ForId1 = new SelectList(db.Trip_For, "Id", "Study", trip_Check_List.Trip_ForId1);
            ViewBag.TakenId1 = new SelectList(db.Takens, "Id", "Yes", trip_Check_List.TakenId1);
            return View(trip_Check_List);
        }

        // GET: Trip_Check_List/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip_Check_List trip_Check_List = db.Trip_Check_List.Find(id);
            if (trip_Check_List == null)
            {
                return HttpNotFound();
            }
            ViewBag.Trip_ForId1 = new SelectList(db.Trip_For, "Id", "Study", trip_Check_List.Trip_ForId1);
            ViewBag.TakenId1 = new SelectList(db.Takens, "Id", "Yes", trip_Check_List.TakenId1);
            return View(trip_Check_List);
        }

        // POST: Trip_Check_List/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Thing_Name,Unit,description,Trip_ForId,TakenId,Trip_ForId1,TakenId1")] Trip_Check_List trip_Check_List)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trip_Check_List).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Trip_ForId1 = new SelectList(db.Trip_For, "Id", "Study", trip_Check_List.Trip_ForId1);
            ViewBag.TakenId1 = new SelectList(db.Takens, "Id", "Yes", trip_Check_List.TakenId1);
            return View(trip_Check_List);
        }

        // GET: Trip_Check_List/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip_Check_List trip_Check_List = db.Trip_Check_List.Find(id);
            if (trip_Check_List == null)
            {
                return HttpNotFound();
            }
            return View(trip_Check_List);
        }

        // POST: Trip_Check_List/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trip_Check_List trip_Check_List = db.Trip_Check_List.Find(id);
            db.Trip_Check_List.Remove(trip_Check_List);
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

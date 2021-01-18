using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DNCH.Models;

namespace DNCH.Controllers
{
    public class ResidentDailyLogsController : Controller
    {
        private DailyLogContext db = new DailyLogContext();

        // GET: ResidentDailyLogs
        public ActionResult Index()
        {
            return View(db.ResidentDailyLogs.ToList());
        }

        // GET: ResidentDailyLogs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentDailyLog residentDailyLog = db.ResidentDailyLogs.Find(id);
            if (residentDailyLog == null)
            {
                return HttpNotFound();
            }
            return View(residentDailyLog);
        }

        // GET: ResidentDailyLogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResidentDailyLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FullName,NotesTime,DailNotes,StaffName")] ResidentDailyLog residentDailyLog)
        {
            if (ModelState.IsValid)
            {
                db.ResidentDailyLogs.Add(residentDailyLog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(residentDailyLog);
        }

        // GET: ResidentDailyLogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentDailyLog residentDailyLog = db.ResidentDailyLogs.Find(id);
            if (residentDailyLog == null)
            {
                return HttpNotFound();
            }
            return View(residentDailyLog);
        }

        // POST: ResidentDailyLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FullName,NotesTime,DailNotes,StaffName")] ResidentDailyLog residentDailyLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(residentDailyLog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(residentDailyLog);
        }

        // GET: ResidentDailyLogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentDailyLog residentDailyLog = db.ResidentDailyLogs.Find(id);
            if (residentDailyLog == null)
            {
                return HttpNotFound();
            }
            return View(residentDailyLog);
        }

        // POST: ResidentDailyLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ResidentDailyLog residentDailyLog = db.ResidentDailyLogs.Find(id);
            db.ResidentDailyLogs.Remove(residentDailyLog);
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

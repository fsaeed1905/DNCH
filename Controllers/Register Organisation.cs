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
    public class NursingCareHomesController : Controller
    {
        private CareProviderContext db = new CareProviderContext();

        // GET: NursingCareHomes
        public ActionResult Index()
        {
            return View(db.NursingCareHomes.ToList());
        }

        // GET: NursingCareHomes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NursingCareHome nursingCareHome = db.NursingCareHomes.Find(id);
            if (nursingCareHome == null)
            {
                return HttpNotFound();
            }
            return View(nursingCareHome);
        }

        // GET: NursingCareHomes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NursingCareHomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,RegistrationNo,Address,Caringtype")] NursingCareHome nursingCareHome)
        {
            if (ModelState.IsValid)
            {
                db.NursingCareHomes.Add(nursingCareHome);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nursingCareHome);
        }

        // GET: NursingCareHomes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NursingCareHome nursingCareHome = db.NursingCareHomes.Find(id);
            if (nursingCareHome == null)
            {
                return HttpNotFound();
            }
            return View(nursingCareHome);
        }

        // POST: NursingCareHomes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,RegistrationNo,Address,Caringtype")] NursingCareHome nursingCareHome)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nursingCareHome).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nursingCareHome);
        }

        // GET: NursingCareHomes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NursingCareHome nursingCareHome = db.NursingCareHomes.Find(id);
            if (nursingCareHome == null)
            {
                return HttpNotFound();
            }
            return View(nursingCareHome);
        }

        // POST: NursingCareHomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NursingCareHome nursingCareHome = db.NursingCareHomes.Find(id);
            db.NursingCareHomes.Remove(nursingCareHome);
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

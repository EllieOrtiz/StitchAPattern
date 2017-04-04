using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StitchAPattern.Models;
using StitchAPattern.StitchingModels;

namespace StitchAPattern.Controllers
{
    public class PatternGeneratorController : Controller
    {
        private StitchAPatternDb db = new StitchAPatternDb();

        // GET: PatternGenerator
        public ActionResult Index()
        {
            return View(db.Patterns.ToList());
        }

        // GET: PatternGenerator/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pattern pattern = db.Patterns.Find(id);
            if (pattern == null)
            {
                return HttpNotFound();
            }
            return View(pattern);
        }

        // GET: PatternGenerator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatternGenerator/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Body")] Pattern pattern)
        {
            if (ModelState.IsValid)
            {
                db.Patterns.Add(pattern);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pattern);
        }

        // GET: PatternGenerator/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pattern pattern = db.Patterns.Find(id);
            if (pattern == null)
            {
                return HttpNotFound();
            }
            return View(pattern);
        }

        // POST: PatternGenerator/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Body")] Pattern pattern)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pattern).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pattern);
        }

        // GET: PatternGenerator/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pattern pattern = db.Patterns.Find(id);
            if (pattern == null)
            {
                return HttpNotFound();
            }
            return View(pattern);
        }

        // POST: PatternGenerator/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pattern pattern = db.Patterns.Find(id);
            db.Patterns.Remove(pattern);
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

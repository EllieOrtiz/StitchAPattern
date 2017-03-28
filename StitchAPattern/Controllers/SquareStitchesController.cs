using StitchAPattern.Models;
using StitchAPattern.StitchingModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StitchAPattern.Controllers
{
    public class SquareStitchesController : Controller
    {
        private StitchAPatternDb db = new StitchAPatternDb();

        // GET: SquareStitches
        public ActionResult Index()
        {
            return View(db.SquareStitches.ToList());
        }

        // GET: SquareStitches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SquareStitch squareStitch = db.SquareStitches.Find(id);
            if (squareStitch == null)
            {
                return HttpNotFound();
            }
            return View(squareStitch);
        }

        // GET: SquareStitches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SquareStitches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Body")] SquareStitch squareStitch)
        {
            if (ModelState.IsValid)
            {
                db.SquareStitches.Add(squareStitch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(squareStitch);
        }

        // GET: SquareStitches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SquareStitch squareStitch = db.SquareStitches.Find(id);
            if (squareStitch == null)
            {
                return HttpNotFound();
            }
            return View(squareStitch);
        }

        // POST: SquareStitches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Body")] SquareStitch squareStitch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(squareStitch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(squareStitch);
        }

        // GET: SquareStitches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SquareStitch squareStitch = db.SquareStitches.Find(id);
            if (squareStitch == null)
            {
                return HttpNotFound();
            }
            return View(squareStitch);
        }

        // POST: SquareStitches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SquareStitch squareStitch = db.SquareStitches.Find(id);
            db.SquareStitches.Remove(squareStitch);
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

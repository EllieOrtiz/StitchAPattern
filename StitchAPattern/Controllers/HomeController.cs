using StitchAPattern.Models;
using StitchAPattern.StitchingModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace StitchAPattern.Controllers
{
    public class HomeController : Controller
    {
        StitchAPatternDb _db = new StitchAPatternDb();

        public ActionResult Index()
        {
            var model = _db.Patterns.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "eli";
            model.Location = "Caguas, PR";
  
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PatternLibrary()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
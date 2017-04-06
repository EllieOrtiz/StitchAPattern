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

        public ActionResult Index(string searchTerm = null)
        {
            var model =
                _db.Patterns
                .OrderByDescending(s => s.Name)
                .Where(s => searchTerm == null || s.Name.StartsWith(searchTerm))
                .Take(3)
                .Select(s => new SquareStitch
                {
                    Name = s.Name,
                    Description = s.Description,
                    
                });

          return View(model);
        }

        public ActionResult PatternGenerator()
        {
            return View();
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
using CourseSelection.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseSelection.Controllers
{
    public class CourseController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidante candidante)
        {
            if (Repository.Applications.Any(c => c.Email == candidante.Email))
            {
                ModelState.AddModelError("","There is already and application for you");
            }
            if (ModelState.IsValid)
            {
                Repository.Add(candidante);
                return View("Feedback", candidante);

            }
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using teachersWorkload.Models;
using teachersWorkload.Services;

namespace teachersWorkload.Controllers
{
    public class BusynessController : Controller
    {
        private readonly ISubjectRepository repository;

        public BusynessController(ISubjectRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index() => View(repository.GetAll());

        [HttpPost]
        public IActionResult ToggleStatus(int id)
        {
            var subject = this.repository.GetById(id);
            if (subject != null)
            {
                subject.IsOnline = !subject.IsOnline;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Change(int? id)
        {
            if (id == null) return View(new Subject());
            var subject = repository.GetById(id.Value);
            return View(subject);
        }

        [HttpPost]
        public IActionResult Change(Subject subject)
        {
            if (!ModelState.IsValid) return View(subject);

            if (subject.Id == 0) repository.Add(subject);
            else repository.Update(subject);

            return RedirectToAction("Index");
        }
    }
}

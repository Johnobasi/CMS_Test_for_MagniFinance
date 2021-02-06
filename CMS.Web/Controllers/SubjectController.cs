using CMS.Data.Core;
using CMS.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Web.Controllers
{
    public class SubjectController : Controller
    {

        private readonly ISubjectRepository _subjectRepository;
        public SubjectController(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        [HttpGet]
        public IActionResult GetAllSubjects()
        {
            var subjects = _subjectRepository.GetAll();
            return View(subjects);
        }

        [HttpGet]
        public IActionResult GetSubject(int id)
        {
            var subject = _subjectRepository.GetSubjectById(id);
            return View(subject);
        }


        [HttpPost]
        public IActionResult AddSubject(Subject request)
        {
            _subjectRepository.Add(request);
            return RedirectToAction(nameof(GetAllSubjects));
        }

        [HttpGet]
        public IActionResult AddSubject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateSubject(Subject request)
        {
            _subjectRepository.Update(request);
            return RedirectToAction(nameof(GetAllSubjects));
        }

        [HttpGet]
        public IActionResult UpdateSubject(int id)
        {
            var model = _subjectRepository.GetSubjectById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteSubject(int id, IFormCollection keyValuePairs)
        {
            var model = _subjectRepository.GetSubjectById(id);
            _subjectRepository.Delete(model);
            return RedirectToAction(nameof(GetAllSubjects));
        }

        [HttpGet]
        public IActionResult DeleteSubject(int id)
        {
            var model = _subjectRepository.GetSubjectById(id);

            return View(model);
        }
    }
}

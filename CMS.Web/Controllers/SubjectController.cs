using CMS.Data.Repositories;
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
    }
}

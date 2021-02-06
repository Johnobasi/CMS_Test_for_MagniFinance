using CMS.Data.Core;
using CMS.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = _studentRepository.GetAll();
            return View(students);
        }

        public IActionResult GetStudent(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult AddStudent(Student request)
        {
            _studentRepository.Add(request);
            return RedirectToAction(nameof(GetAllStudents));
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student request)
        {
            _studentRepository.Update(request);
            return RedirectToAction(nameof(GetAllStudents));
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var model = _studentRepository.GetStudentById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteStudent(int id, IFormCollection keyValuePairs)
        {
            var model = _studentRepository.GetStudentById(id);
            _studentRepository.Delete(model);
            return RedirectToAction(nameof(GetAllStudents));
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            var model = _studentRepository.GetStudentById(id);

            return View(model);
        }
    }
}

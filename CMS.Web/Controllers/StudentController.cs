using CMS.Data.Repositories;
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
    }
}

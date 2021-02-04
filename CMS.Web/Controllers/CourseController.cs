using CMS.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICoursesRepository _coursesRepository;
        public CourseController(ICoursesRepository coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }
        
        [HttpGet]
        public IActionResult GetAllCourses()
        {
            var courses = _coursesRepository.GetAll();
            return View(courses);
        }

        public IActionResult GetCourse(int id)
        {
            var course = _coursesRepository.GetCourseById(id);
            return View(course);
        }
    }
}

using CMS.Data.Core;
using CMS.Data.Repositories;
using Microsoft.AspNetCore.Http;
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


        [HttpGet]
        public IActionResult GetCourse(int id)
        {
            var course = _coursesRepository.GetCourseById(id);
            return View(course);
        }


        [HttpPost]
        public IActionResult AddCourse(Course request)
        {
            _coursesRepository.Add(request);
            return RedirectToAction(nameof(GetAllCourses));
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateCourse(Course request)
        {
            _coursesRepository.Update(request);
            return RedirectToAction(nameof(GetAllCourses));
        }

        [HttpGet]
        public IActionResult UpdateCourse(int id)
        {
            var model = _coursesRepository.GetCourseById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteCourse(int id, IFormCollection keyValuePairs)
        {
            var model = _coursesRepository.GetCourseById(id);
            _coursesRepository.Delete(model);
            return RedirectToAction(nameof(GetAllCourses));
        }

        [HttpGet]
        public IActionResult DeleteCourse(int id)
        {
            var model = _coursesRepository.GetCourseById(id);

            return View(model);
        }
    }
}

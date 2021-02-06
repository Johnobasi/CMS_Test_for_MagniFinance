using CMS.Data.Core;
using CMS.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        public IActionResult GetAllTreachers()
        {
            var teachers = _teacherRepository.GetAll();
            return View(teachers);
        }

        [HttpGet]
        public IActionResult GetTreacher(int id)
        {
            var teacher = _teacherRepository.GetTeacherById(id);
            return View(teacher);
        }


        [HttpPost]
        public IActionResult AddSubject(Teacher request)
        {
            _teacherRepository.Add(request);
            return RedirectToAction(nameof(GetAllTreachers));
        }

        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateTeacher(Teacher request)
        {
            _teacherRepository.Update(request);
            return RedirectToAction(nameof(GetAllTreachers));
        }

        [HttpGet]
        public IActionResult UpdateTeacher(int id)
        {
            var model = _teacherRepository.GetTeacherById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteTeacher(int id, IFormCollection keyValuePairs)
        {
            var model = _teacherRepository.GetTeacherById(id);
            _teacherRepository.Delete(model);
            return RedirectToAction(nameof(GetAllTreachers));
        }

        [HttpGet]
        public IActionResult DeleteTeacher(int id)
        {
            var model = _teacherRepository.GetTeacherById(id);

            return View(model);
        }
    }
}

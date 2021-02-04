using CMS.Data.Repositories;
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
    }
}

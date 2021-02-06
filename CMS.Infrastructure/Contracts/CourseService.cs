using CMS.Data;
using CMS.Data.Core;
using CMS.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Infrastructure.Contracts
{
    public class CourseService : ICoursesRepository
    {
        private readonly ApplicationDbContext _context;
        public CourseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Course newCourse)
        {
            _context.Add(newCourse);
            _context.SaveChanges();
        }

        public void Delete(Course deletedCourse)
        {
            _context.Remove(deletedCourse);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses.Include(r => r.CourseManagement)
                .ThenInclude(r => r.Students)
                .Include(r => r.CourseManagement)
                .ThenInclude(r => r.Teachers);
            ;
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.ID == id);
        }

        public void Update(Course updatedCourse)
        {
            _context.Update(updatedCourse);
            _context.SaveChanges();

        }
    }
}

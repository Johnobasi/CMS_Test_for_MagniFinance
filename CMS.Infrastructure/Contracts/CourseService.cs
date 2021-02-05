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

        public Course Add(Course newCourse)
        {
            throw new System.NotImplementedException();
        }

        public Course Delete(Course deletedCourse)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses
                .Include(c=>c.CMDData);
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.ID == id);
        }

        public Course Update(Course updatedCourse)
        {
            throw new System.NotImplementedException();
        }
    }
}

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
        public IEnumerable<Course> GetAll()
        {
            return _context.Courses
                .Include(c=>c.CMDData);
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.ID == id);
        }
    }
}

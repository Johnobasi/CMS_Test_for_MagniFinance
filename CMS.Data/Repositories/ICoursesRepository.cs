using CMS.Data.Core;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public interface ICoursesRepository
    {
        IEnumerable<Course> GetAll();
        Course GetCourseById(int id);

        void Add(Course newCourse);
        void Update(Course updatedCourse);
        void Delete(Course deletedCourse);
    }
}

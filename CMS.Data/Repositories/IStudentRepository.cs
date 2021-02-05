using CMS.Data.Core;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetStudentById(int Id);
        Student Add(Student newStudent);
        Student Update(Student updatedStudent);
        Student Delete(Student deletedStudent);

    }
}

using CMS.Data.Core;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetStudentById(int Id);
        void Add(Student newStudent);
        void Update(Student updatedStudent);
        void Delete(Student deletedStudent);

    }
}

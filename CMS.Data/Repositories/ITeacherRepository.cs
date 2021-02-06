using CMS.Data.Core;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();
        Teacher GetTeacherById(int id);

        void Add(Teacher newTeacher);
        void Update(Teacher updatedTeacher);
        void Delete(Teacher deletedTeacher);
    }
}

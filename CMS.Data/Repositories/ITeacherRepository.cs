using CMS.Data.Core;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();
        Teacher GetTeacherById(int id);

        Teacher Add(Teacher newTeacher);
        Teacher Update(Teacher updatedTeacher);
        Teacher Delete(Teacher deletedTeacher);
    }
}

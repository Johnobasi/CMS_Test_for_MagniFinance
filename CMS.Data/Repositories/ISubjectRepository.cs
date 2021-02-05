using CMS.Data.Core;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetAll();
        Subject GetSubjectById(int id);

        Subject Add(Student newSubject);
        Subject Update(Student updatedSubject);
        Subject Delete(Student deletedSubject);
    }
}

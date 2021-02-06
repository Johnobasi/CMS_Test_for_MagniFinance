using CMS.Data.Core;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetAll();
        Subject GetSubjectById(int id);

        void Add(Student newSubject);
        void Update(Student updatedSubject);
        void Delete(Student deletedSubject);
    }
}

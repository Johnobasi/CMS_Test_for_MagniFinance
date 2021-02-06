using CMS.Data.Core;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetAll();
        Subject GetSubjectById(int id);

        void Add(Subject newSubject);
        void Update(Subject updatedSubject);
        void Delete(Subject deletedSubject);
    }
}

using CMS.Data;
using CMS.Data.Core;
using CMS.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Infrastructure.Contracts
{
    public class SubjectService : ISubjectRepository
    {
        private readonly ApplicationDbContext _context;
        public SubjectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Subject newSubject)
        {
            _context.Add(newSubject);
            _context.SaveChanges();
        }

        public void Delete(Subject deletedSubject)
        {
            _context.Remove(deletedSubject);
            _context.SaveChanges();
        }

        public IEnumerable<Subject> GetAll()
        {
            return _context.Subjects
                .Include(s => s.Teacher)
                    .ThenInclude(c=>c.Student);
        }

        public Subject GetSubjectById(int id)
        {
            return _context.Subjects
                .FirstOrDefault(s => s.Id == id);
        }

        public void Update(Subject updatedSubject)
        {
            _context.Update(updatedSubject);
            _context.SaveChanges();
        }
    }
}

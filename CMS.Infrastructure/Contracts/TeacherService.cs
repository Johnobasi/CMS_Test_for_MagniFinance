using CMS.Data;
using CMS.Data.Core;
using CMS.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Infrastructure.Contracts
{
    public class TeacherService : ITeacherRepository
    {
        private readonly ApplicationDbContext _context;
        public TeacherService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Teacher newTeacher)
        {
            _context.Add(newTeacher);
            _context.SaveChanges();
        }

        public void Delete(Teacher deletedTeacher)
        {
            _context.Remove(deletedTeacher);
            _context.SaveChanges();
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers
                .Include(t => t.Student);

        }

        public Teacher GetTeacherById(int id)
        {
            return _context.Teachers.FirstOrDefault(t => t.ID == id);
        }

        public void Update(Teacher updatedTeacher)
        {
            _context.Update(updatedTeacher);
            _context.SaveChanges();
        }
    }
}

using CMS.Data;
using CMS.Data.Core;
using CMS.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Infrastructure.Contracts
{
    public class StudentServices : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public Student Add(Student newStudent)
        {
            throw new System.NotImplementedException();
        }

        public Student Delete(Student deletedStudent)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students
                .Include(s => s.CMDData);
        }

        public Student GetStudentById(int Id)
        {
            return _context.Students.FirstOrDefault(s => s.ID == Id);
        }

        public Student Update(Student updatedStudent)
        {
            throw new System.NotImplementedException();
        }
    }
}

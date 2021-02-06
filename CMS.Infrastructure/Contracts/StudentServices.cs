using CMS.Data;
using CMS.Data.Core;
using CMS.Data.Repositories;
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

        public IEnumerable<Student> GetAll()
        {
            return _context.Students;
        }

        public Student GetStudentById(int Id)
        {
            return _context.Students.FirstOrDefault(s => s.ID == Id);
        }

        public void Update(Student updatedStudent)
        {
            _context.Update(updatedStudent);
            _context.SaveChanges();
        }

        public void Add(Student newStudent)
        {
            _context.Add(newStudent);
            _context.SaveChanges();
        }

        public void Delete(Student deletedStudent)
        {
            _context.Remove(deletedStudent);
            _context.SaveChanges();
        }

    }
}

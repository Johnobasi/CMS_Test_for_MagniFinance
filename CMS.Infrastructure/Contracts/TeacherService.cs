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
        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers
                .Include(t => t.CMDData);
        }

        public Teacher GetTeacherById(int id)
        {
            return _context.Teachers.FirstOrDefault(t => t.ID == id);
        }
    }
}

﻿using CMS.Data;
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
        public IEnumerable<Student> GetAll()
        {
            return _context.Students
                .Include(s => s.CMDData);
        }

        public Student GetStudentById(int Id)
        {
            return _context.Students.FirstOrDefault(s => s.ID == Id);
        }
    }
}

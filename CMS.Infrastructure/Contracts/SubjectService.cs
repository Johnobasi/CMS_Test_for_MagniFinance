﻿using CMS.Data;
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
        public IEnumerable<Subject> GetAll()
        {
            return _context.Subjects
                .Include(s => s.CMDData);
        }

        public Subject GetSubjectById(int id)
        {
            return _context.Subjects
                .FirstOrDefault(s => s.Id == id);
        }
    }
}

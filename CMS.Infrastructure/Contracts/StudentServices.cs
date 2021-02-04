using CMS.Data.Core;
using CMS.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infrastructure.Contracts
{
    public class StudentServices : IStudentRepository
    {
        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

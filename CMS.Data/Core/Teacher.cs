using System;
using System.Collections.Generic;

namespace CMS.Data.Core
{
    public class Teacher
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }
        public virtual ICollection<Subject> Subject { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}

using System;
using static CMS.Data.Core.Teacher;

namespace CMS.Data.Core
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Grade? StudentGrades { get; set; }
        public virtual Course Course { get; set; }
    }
}

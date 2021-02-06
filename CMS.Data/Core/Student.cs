using System;
using System.Collections.Generic;
using static CMS.Data.Core.Teacher;

namespace CMS.Data.Core
{
    public class Student
    {
        public enum Grade
        {
            A, B, C, D, F
        }

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime BirthdayDay { get; set; }
        public string RegistrationNumber { get; set; }

        public Grade? Grades { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}

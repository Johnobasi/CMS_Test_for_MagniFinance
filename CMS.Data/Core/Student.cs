using System;
using System.ComponentModel.DataAnnotations;

namespace CMS.Data.Core
{
    public class Student
    {
        public enum Grade
        {
            A, B, C, D, F
        }

        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter your LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your FistName")]
        public string FirstMidName { get; set; }

        [Required(ErrorMessage = "Please enter your Birthday")]
        [DataType(DataType.Date)]
        public DateTime BirthdayDay { get; set; }

        [Required(ErrorMessage = "Please enter your Reg Number")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Please enter your name")]

        public Grade? Grades { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}

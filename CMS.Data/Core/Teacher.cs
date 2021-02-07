using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Data.Core
{
    public class Teacher
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter your Lastname")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your firstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your birthday")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid, enter like # or #.##")]
        public decimal Salary { get; set; }
        public virtual ICollection<Subject> Subject { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Data.Core
{
    public class Course
    {
       
       
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter your credit")]
        public int Credits { get; set; }

        public virtual ICollection<Subject> Subject { get; set; }
        public virtual ICollection<CourseManagement> CourseManagement { get; set; }

    }
}

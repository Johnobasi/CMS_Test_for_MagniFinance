using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Data.Core
{
    public class Course
    {
       
       
        public int Id { get; set; }

        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Subject> Subject { get; set; }
        public virtual ICollection<CourseManagement> CourseManagement { get; set; }

    }
}

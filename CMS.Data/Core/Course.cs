using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Data.Core
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }


        public virtual ICollection<Teacher> CourseTeacher { get; set; }
        public virtual ICollection<Student> CourseStudent { get; set; }
    }
}

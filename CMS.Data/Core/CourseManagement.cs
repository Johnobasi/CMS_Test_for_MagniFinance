using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Data.Core
{
    public class CourseManagement
    {

        [Key]
        public int CourseManagementId { get; set; }

        [Display(Name ="Teacher ID")]
        [ForeignKey("FK_CourseManagement_Teacher")]
        public int TeacherId { get; set; }

        [Display(Name = "Student ID")]
        [ForeignKey("FK_CourseManagement_Student")]
        public int StudentId { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}

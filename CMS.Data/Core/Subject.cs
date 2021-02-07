using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Data.Core
{
    public class Subject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        public virtual Course Course  { get; set; }
        public virtual Teacher Teacher { get; set; }
        //public virtual ICollection<CMSSummary> CMDData { get; set; }
    }
}

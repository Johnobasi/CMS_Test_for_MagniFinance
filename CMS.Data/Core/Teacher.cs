using System.Collections.Generic;

namespace CMS.Data.Core
{
    public class Teacher
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public virtual ICollection<CMSSummary> CMDData { get; set; }
    }
}

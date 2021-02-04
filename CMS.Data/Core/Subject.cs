using System.Collections.Generic;

namespace CMS.Data.Core
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CMSSummary> CMDData { get; set; }
    }
}

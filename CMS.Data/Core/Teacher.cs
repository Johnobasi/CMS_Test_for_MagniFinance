namespace CMS.Data.Core
{
    public class Teacher
    {
        public enum Grade
        {
            A, B, C, D, F
        }

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public Grade? Grades { get; set; }

        public virtual Course Course { get; set; }
        public virtual Subject Subject { get; set; }
    }
}

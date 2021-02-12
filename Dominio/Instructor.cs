using System.Collections.Generic;

namespace Dominio
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public byte[] Photo { get; set; }

        public ICollection<CourseInstructor> CourseList {get; set;}
    }
}
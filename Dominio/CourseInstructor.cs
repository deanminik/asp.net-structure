namespace Dominio
{
    public class CourseInstructor
    {
        public int CourseID { get; set; }

        public Course Course { get; set; }//anchor 
        public int InstructorID { get; set; }

        public Instructor Instructor { get; set; }//anchor 

        
    }
}
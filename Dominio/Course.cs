using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Course_Title { get; set; }
        public string Course_Description { get; set; }
        public DateTime Course_Date { get; set; }
        public byte[] Course_Photo { get; set; }

        public Price PricePromotion {get; set;}

        public ICollection<Comment> CommentList {get; set;} // now create the anchor in comment class -
        public ICollection<CourseInstructor> CourseInstructorList {get; set;}//now create the anchor in CourseInstructor class -
   
    }
}

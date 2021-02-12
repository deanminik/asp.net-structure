namespace Dominio
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Student { get; set; }
        public int Score { get; set; }
        public string CommentText { get; set; }
        public int CourseID { get; set; }

        public Course Course  { get; set; }//anchor from Comments
    }
}
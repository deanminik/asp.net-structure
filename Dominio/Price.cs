namespace Dominio
{
    public class Price
    {
        public int PriceID { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal Promotion { get; set; }
        public int CourseID { get; set; }

        public Course Course { get; set; }//anchor from Course 1-1
    }
}
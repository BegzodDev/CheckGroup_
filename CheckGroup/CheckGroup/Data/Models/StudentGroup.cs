namespace CheckGroup.Data.Models
{
    public class StudentGroup
    {
        public int StudentId { get; set; }
        public Student Student { get; set;}
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}

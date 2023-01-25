namespace CheckGroup.Data.Models
{
    public class Group
    {
        public int Id { get; set; }

        public Teacher TeacherId { get; set; }
        public Student StudentId { get; set; }
    }
}

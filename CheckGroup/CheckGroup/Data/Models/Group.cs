namespace CheckGroup.Data.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int SrudentId { get; set; }
        public Student Student { get; set; }
    }
}

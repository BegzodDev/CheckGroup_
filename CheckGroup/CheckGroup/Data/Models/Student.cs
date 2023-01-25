namespace CheckGroup.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Group GroupId { get; set; }
    }
}

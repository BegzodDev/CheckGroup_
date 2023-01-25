namespace CheckGroup.Data.Models
{
    public class Teacher
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Passwordhash { get; set; }

        public Group Groups { get; set; }
    }
}

using CheckGroup.DTOs;

namespace CheckGroup.Entities
{
    public class Teacher
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public static implicit operator Teacher(RegistrationDTO registrationDTO)
        {
            return new Teacher()
            {

            }
        }
    }
}

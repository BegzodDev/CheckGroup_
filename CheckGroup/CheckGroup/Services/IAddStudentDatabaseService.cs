using CheckGroup.DTOs;

namespace CheckGroup.Services
{
    public interface IAddStudentDatabaseService
    {
        public void Add(CreateStudentDTO createStudentDTO);
    }
}

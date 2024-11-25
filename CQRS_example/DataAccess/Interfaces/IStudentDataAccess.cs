using CQRS_example.Models;

namespace CQRS_example.DataAccess.Interfaces
{
    public interface IStudentDataAccess
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        Student AddStudent(string firstName, string lastName, double age);
        Student UpdateStudent(int id, Student student);
        void DeleteStudent(int id);
    }
}

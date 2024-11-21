using CQRS_example.Models;

namespace CQRS_example.DataAccess
{
    public interface IDataAccess
    {
        List<Student> GetStudents();
        Student AddStudent(string firstName, string lastName, double age);
        Student GetStudentById(int id);
    }
}

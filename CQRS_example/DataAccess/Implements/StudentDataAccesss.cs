using CQRS_example.DataAccess.Interfaces;
using CQRS_example.Models;

namespace CQRS_example.DataAccess.Implements
{
    public class StudentDataAccesss : IStudentDataAccess
    {
        private readonly Ex_DbContext _context;

        public StudentDataAccesss(Ex_DbContext context)
        {
            _context = context;
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(t => t.Id == id);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public Student AddStudent(string firstName, string lastName, double age)
        {
            var student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student UpdateStudent(int id, Student student)
        {
            var existingStudent = _context.Students.Find(id);
            if (existingStudent != null)
            {
                existingStudent.FirstName = student.FirstName;
                existingStudent.LastName = student.LastName;
                existingStudent.Age = student.Age;
                existingStudent.ClassId = student.ClassId;
                existingStudent.CourseId = student.CourseId;
                _context.SaveChanges();
            }
            return existingStudent;
        }

        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}

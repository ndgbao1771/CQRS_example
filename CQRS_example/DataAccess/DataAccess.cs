using CQRS_example.Models;
using System;

namespace CQRS_example.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private readonly Ex_DbContext _context;

        public DataAccess(Ex_DbContext context)
        {
            _context = context;

            // Thêm dữ liệu mẫu nếu cơ sở dữ liệu trống
            if (!_context.Students.Any())
            {
                _context.Students.AddRange(
                    new Student { Id = 1, FirstName = "Jhon", LastName = "Doe", Age = 18 },
                    new Student { Id = 2, FirstName = "Amelia", LastName = "Amy", Age = 16 }
                );
                _context.SaveChanges();
            }
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
    }
}

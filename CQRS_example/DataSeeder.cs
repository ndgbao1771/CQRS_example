using CQRS_example.Models;

namespace CQRS_example
{
    public class DataSeeder
    {
        public static void Seed(Ex_DbContext context)
        {
            if (!context.Classes.Any())
            {
                var classes = new List<Class>
        {
            new Class { ClassName = "Class A" },
            new Class { ClassName = "Class B" },
            new Class { ClassName = "Class C" }
        };
                context.Classes.AddRange(classes);
                context.SaveChanges(); // Lưu thay đổi để có ID cho các lớp
            }

            if (!context.Courses.Any())
            {
                var courses = new List<Course>
        {
            new Course { CourseName = "Mathematics" },
            new Course { CourseName = "Science" },
            new Course { CourseName = "History" }
        };
                context.Courses.AddRange(courses);
                context.SaveChanges(); // Lưu thay đổi để có ID cho các khóa học
            }

            if (!context.Teachers.Any())
            {
                var teachers = new List<Teacher>
        {
            new Teacher { FirstName = "Alice", LastName = "Johnson" },
            new Teacher { FirstName = "Bob", LastName = "Smith" },
            new Teacher { FirstName = "Charlie", LastName = "Brown" }
        };
                context.Teachers.AddRange(teachers);
                context.SaveChanges(); // Lưu thay đổi để có ID cho các giáo viên
            }

            if (!context.Students.Any())
            {
                var students = new List<Student>
        {
            new Student { FirstName = "John", LastName = "Doe", Age = 20, ClassId = 1, CourseId = 1 },
            new Student { FirstName = "Jane", LastName = "Smith", Age = 22, ClassId = 1, CourseId = 1 },
            new Student { FirstName = "Michael", LastName = "Johnson", Age = 19, ClassId = 2, CourseId = 2 },
            new Student { FirstName = "Emily", LastName = "Davis", Age = 21, ClassId = 2, CourseId = 2 },
            new Student { FirstName = "Chris", LastName = "Brown", Age = 23, ClassId = 3, CourseId = 3 },
            new Student { FirstName = "Jessica", LastName = "Wilson", Age = 20, ClassId = 3, CourseId = 3 },
            new Student { FirstName = "David", LastName = "Martinez", Age = 22, ClassId = 1, CourseId = 1 },
            new Student { FirstName = "Sarah", LastName = "Garcia", Age = 19, ClassId = 2, CourseId = 2 },
            new Student { FirstName = "Daniel", LastName = "Rodriguez", Age = 21, ClassId = 3, CourseId = 3 },
            new Student { FirstName = "Laura", LastName = "Hernandez", Age = 20, ClassId = 1, CourseId = 1 }
        };
                context.Students.AddRange(students);
                context.SaveChanges(); // Lưu thay đổi để có ID cho các sinh viên
            }

            if (!context.TeacherStudents.Any())
            {
                var teacherStudents = new List<TeacherStudent>
        {
            new TeacherStudent { TeacherId = 1, StudentId = 1 },
            new TeacherStudent { TeacherId = 1, StudentId = 2 },
            new TeacherStudent { TeacherId = 2, StudentId = 3 },
            new TeacherStudent { TeacherId = 2, StudentId = 4 },
            new TeacherStudent { TeacherId = 3, StudentId = 5 },
            new TeacherStudent { TeacherId = 3, StudentId = 6 }
        };
                context.TeacherStudents.AddRange(teacherStudents);
                context.SaveChanges(); // Lưu thay đổi để có ID cho các bản ghi TeacherStudent
            }
        }
    }
}

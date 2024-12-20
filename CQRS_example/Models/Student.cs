﻿namespace CQRS_example.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Age { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public ICollection<TeacherStudent> TeacherStudents { get; set; }
    }
}

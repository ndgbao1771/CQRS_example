﻿namespace CQRS_example.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
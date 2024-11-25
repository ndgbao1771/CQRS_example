﻿namespace CQRS_example.Models
{
    public class TeacherStudent
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}

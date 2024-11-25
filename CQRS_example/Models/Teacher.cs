namespace CQRS_example.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<TeacherStudent> TeacherStudents { get; set; }
    }
}

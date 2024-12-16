using CQRS_example.Configurations;
using CQRS_example.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_example
{
    public class Ex_DbContext : DbContext
    {
        public Ex_DbContext(DbContextOptions<Ex_DbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherStudentConfiguration());
        }

    }
}

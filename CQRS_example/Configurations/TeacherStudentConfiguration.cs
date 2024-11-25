using CQRS_example.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRS_example.Configurations
{
    public class TeacherStudentConfiguration : IEntityTypeConfiguration<TeacherStudent>
    {
        public void Configure(EntityTypeBuilder<TeacherStudent> builder)
        {
            builder.ToTable("TeacherStudents");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Student).WithMany(x => x.TeacherStudents).HasForeignKey(x => x.StudentId);
            builder.HasOne(x => x.Teacher).WithMany(x => x.TeacherStudents).HasForeignKey(x => x.TeacherId);
        }
    }
}

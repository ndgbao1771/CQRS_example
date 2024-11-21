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

    }
}

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ScalFoldDemo1.Models
{
    public class SbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=StudentCourseDB2;Trusted_Connection=True;");
        }

    }
}

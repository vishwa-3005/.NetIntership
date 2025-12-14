using Microsoft.EntityFrameworkCore;

namespace EFDemo02
{
        public class StudentConext : DbContext
        {
            public DbSet<Student> students { get; set; }
            public DbSet<Course> courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(LocalDB)\\MSSQLLocalDB;Database=CollegeDB;Trusted_connection=True;");
        }

    }
        
   }

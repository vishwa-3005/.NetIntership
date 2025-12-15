using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(LocalDB)\\MSSQLLocalDB;Database=StudentDbMVC;Trusted_Connection=True;");
        }

    }
}

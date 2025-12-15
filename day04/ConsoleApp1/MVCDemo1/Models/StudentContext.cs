using Microsoft.EntityFrameworkCore;

namespace MVCDemo1.Models
{
    public class StudentContext : DbContext

    {
        public DbSet<Student> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=StudentMvcDD;Trusted_Connection=True;");
        }

    }
}

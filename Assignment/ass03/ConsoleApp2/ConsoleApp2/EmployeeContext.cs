using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Manager> Managers { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }

        public DbSet<Staff> Staffs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=EmployeeManagementDB; Trusted_Connection=True;");
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IndentityDemo.Models;
using Microsoft.EntityFrameworkCore;
namespace IdentityDemo
{



    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }

}



using DotNet_Student_Management_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Student_Management_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}

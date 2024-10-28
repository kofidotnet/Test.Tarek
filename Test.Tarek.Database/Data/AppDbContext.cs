using Microsoft.EntityFrameworkCore;
using Test.Tarek.Models.Entities;

namespace Test.Tarek.Database.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<UserModel> Users { get; set; }
    }
}

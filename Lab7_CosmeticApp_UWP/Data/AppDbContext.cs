using Microsoft.EntityFrameworkCore;
using Lab7_CosmeticApp_UWP.Models;

namespace Lab7_CosmeticApp_UWP.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CosmeticProduct> CosmeticProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=uwpapp.db");
        }
    }
}
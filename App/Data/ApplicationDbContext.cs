using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}

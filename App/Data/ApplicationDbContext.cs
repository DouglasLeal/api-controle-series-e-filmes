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

            modelBuilder.Entity<Filme>(f => 
            {
                f.ToTable("Filmes");
                f.HasKey(f => f.Id);
                f.Property(f => f.TituloOriginal).HasColumnType("NVARCHAR(150)");
                f.Property(f => f.TituloBrasileiro).HasColumnType("NVARCHAR(150)");
                f.Property(f => f.Descricao).HasColumnType("TEXT");
                f.Property(f => f.Nota).HasColumnType("INTEGER");
                f.Property(f => f.Lancamento).HasColumnType("DATETIME");
                f.Property(f => f.Genero).HasConversion<string>();
                f.Property(f => f.Assistido).HasDefaultValue(false); ;
            });
        }

    }
}

using Microsoft.EntityFrameworkCore;
using MinhaAplicacao.Domain.Entities;

namespace MinhaAplicacao.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Entity> Entities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configurações adicionais podem ser aplicadas aqui
        }
    }
}
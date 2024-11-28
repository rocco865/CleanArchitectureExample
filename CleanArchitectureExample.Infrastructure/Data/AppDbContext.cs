using CleanArchitectureExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureExample.Infrastructure.Data
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            // Configurazione specifica del modello
        }
    }
}

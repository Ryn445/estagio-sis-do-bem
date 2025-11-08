using Microsoft.EntityFrameworkCore;
using SisDoBem.Models;

namespace SisDoBem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Donatario> Donatario { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Saida> Saida { get; set; }
        
    }
}
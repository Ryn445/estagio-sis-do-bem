using Microsoft.EntityFrameworkCore;
using SisDoBem.Models;

namespace SisDoBem.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }
        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Donatario> Donatario { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Saida> Saida { get; set; }
        
    }
}
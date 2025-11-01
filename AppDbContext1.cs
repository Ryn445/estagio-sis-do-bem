using SistemaONG.Models;

namespace SistemaONG.Data
{
    public class AppDbContext : DbContext
    {
        private DbSet<Voluntario> voluntarios;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Donatario> Donatario { get; set; }
        public DbSet<HistoricoDoacao> HistoricoDoacao { get; set; }

        private DbSet<Voluntario> voluntarios1;

        public DbSet<Voluntario> GetVoluntarios()
        {
            return voluntarios1;
        }

        public void SetVoluntarios(DbSet<Voluntario> value)
        {
            voluntarios1 = value;
        }

        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }//
        public DbSet<Voluntario> Voluntarios { get => voluntarios; set => voluntarios = value; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    }
        
}
        // Define your DbSets and configurations here
    

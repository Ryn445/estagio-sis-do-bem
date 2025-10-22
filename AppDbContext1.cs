using System;
using Microsoft.EntityFrameworkCore;

namespace SistemaONG.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Donatario> Donatario { get; set; }
        public DbSet<HistoricoDoacao> HistoricoDoacao { get; set; }
        public DbSet<Voluntario> Voluntarios { get; set; }
        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }//
        public DbSet<Voluntario> Voluntarios { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        }
        {
        }
        // Define your DbSets and configurations here
    }
}
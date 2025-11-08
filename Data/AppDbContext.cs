using SisDoBem.Models;

namespace SisDoBem.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Campanha> Campanhas { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Voluntario> Voluntarios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Donatario> Donatario { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Saida> Saida { get; set; }
        
    }
}
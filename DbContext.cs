
namespace SistemaONG.Data
{
    public class DbContext
    {
        private DbContextOptions<AppDbContext> options;
        private DbContextOptions<DoaçõesApp.Data.AppContext> options1;

        public DbContext(DbContextOptions<AppDbContext> options)
        {
            this.options = options;
        }

        public DbContext(DbContextOptions<DoaçõesApp.Data.AppContext> options1)
        {
            this.options1 = options1;
        }
    }
}
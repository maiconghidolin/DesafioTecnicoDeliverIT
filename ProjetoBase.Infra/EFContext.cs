using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ProjetoBase.Infra
{
    public class EFContext : DbContext
    {

        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFContext).GetTypeInfo().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringDeConexao = "Server=localhost;Port=5432;Database=ProjetoBase;User Id=postgres;Password=123;Pooling=false;Integrated security=true;";
           
            optionsBuilder
                .UseNpgsql(stringDeConexao, b => b.MigrationsAssembly("ProjetoBase"))
                .UseLowerCaseNamingConvention();

            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoBase.Domain.Interfaces;
using ProjetoBase.Infra;
using ProjetoBase.Infra.Repositories;

namespace ProjetoBase
{
    public static class IoCConfig
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<IRepository, RepositorioGenerico>();
            services.AddScoped<EFContext>();
            services.AddScoped<DbContext>(x => x.GetRequiredService<EFContext>());
        }

    }
}

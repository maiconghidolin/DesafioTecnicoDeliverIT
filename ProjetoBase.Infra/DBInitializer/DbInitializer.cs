using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ProjetoBase.Infra.DBInitializer
{

    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<EFContext>();
            context.Database.Migrate();
        }
    }

}

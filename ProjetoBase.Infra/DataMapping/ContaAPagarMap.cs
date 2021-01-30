using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBase.Domain.Entidades;

namespace ProjetoBase.Infra.DataMapping
{
    class ContaAPagarMap : IEntityTypeConfiguration<ContaAPagar>
    {
        public void Configure(EntityTypeBuilder<ContaAPagar> builder)
        {
           
        }
    }
}

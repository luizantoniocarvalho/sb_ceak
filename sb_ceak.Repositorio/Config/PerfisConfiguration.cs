using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class PerfisConfiguration : IEntityTypeConfiguration<Perfis>
    {
        public void Configure(EntityTypeBuilder<Perfis> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}

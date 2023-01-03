using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class ObrasConfiguration : IEntityTypeConfiguration<Obras>
    {
        public void Configure(EntityTypeBuilder<Obras> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}

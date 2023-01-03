using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class TelefonesConfiguration : IEntityTypeConfiguration<Telefones>
    {
        public void Configure(EntityTypeBuilder<Telefones> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}

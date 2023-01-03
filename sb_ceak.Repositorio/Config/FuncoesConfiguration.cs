using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class FuncoesConfiguration : IEntityTypeConfiguration<Funcoes>
    {
        public void Configure(EntityTypeBuilder<Funcoes> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sb_ceak.Dominio.Entidade;

namespace sb_ceak.Repositorio.Config
{
    public class OperacoesConfiguration : IEntityTypeConfiguration<Operacoes>
    {
        public void Configure(EntityTypeBuilder<Operacoes> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}

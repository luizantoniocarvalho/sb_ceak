using sb_ceak.Dominio.Entidade;
using sb_ceak.Dominio.Repositorios;
using sb_ceak.Repositorio.Contexto;

namespace sb_ceak.Repositorio.Repositorios
{
    public class AutorRepositorio : BaseRepositorio<Autores>, IAutorRepositorio
    {
        public AutorRepositorio(SB_CEAKContexto sb_CEAKContexto) : base(sb_CEAKContexto)
        {

        }
    }
}

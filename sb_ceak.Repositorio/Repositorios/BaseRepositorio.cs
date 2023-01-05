using sb_ceak.Dominio.Repositorios;
using sb_ceak.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace sb_ceak.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly SB_CEAKContexto _sb_CEAKContexo;

        public BaseRepositorio(SB_CEAKContexto sb_CEAKContexto)
        {
            _sb_CEAKContexo = sb_CEAKContexto; 
        }

        public void Adicionar(TEntity entity)
        {
            _sb_CEAKContexo.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _sb_CEAKContexo.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}

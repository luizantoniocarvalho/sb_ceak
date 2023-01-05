using sb_ceak.Dominio.Repositorios;
using sb_ceak.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace sb_ceak.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected  readonly SB_CEAKContexto SB_CEAKContexo;
        
        public BaseRepositorio(SB_CEAKContexto sb_CEAKContexto)
        {
            SB_CEAKContexo = sb_CEAKContexto; 
        }

        public void Adicionar(TEntity entity)
        {
            SB_CEAKContexo.Set<TEntity>().Add(entity);
            SB_CEAKContexo.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            SB_CEAKContexo.Set<TEntity>().Update(entity);
            SB_CEAKContexo.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return SB_CEAKContexo.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return SB_CEAKContexo.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            SB_CEAKContexo.Remove(entity);
            SB_CEAKContexo.SaveChanges();
        }

        public void Dispose()
        {
            SB_CEAKContexo.Dispose();
        }
    }
}

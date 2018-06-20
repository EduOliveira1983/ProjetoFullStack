using ProjetoFullStack.Dominio.Entidades;
using ProjetoFullStack.Dominio.Interfaces.Entidades;
using ProjetoFullStack.Infra.Data.EF.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ProjetoFullStack.Infra.Data.EF.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T>  where T : EntidadeBase
    {
        protected readonly DataContext DataContext = new DataContext();        

        public RepositorioBase()
        {
        }
    
        public virtual IList<T> ListarTodos()
        {
            return DataContext.Set<T>().ToList();
        }

        public IList<T> Buscar(Expression<Func<T, bool>> where)
        {
            return DataContext.Set<T>().Where(where).ToList();
        }        

        public IList<T> BuscarComInclude(string include, Expression<Func<T, bool>> where)
        {
            return DataContext.Set<T>().Include(include).Where(where).ToList();
        }

        public virtual void Inserir(T obj)
        {           
            DataContext.Set<T>().Add(obj);
            DataContext.SaveChanges();
        }

        public virtual void Alterar(T obj)
        {
            DataContext.Entry(obj).State = EntityState.Modified;
            DataContext.SaveChanges();
        }

        public virtual void Excluir(T obj)
        {
            DataContext.Set<T>().Remove(obj);
            DataContext.SaveChanges();
        }

        public void Dispose()
        {
            DataContext.Dispose();
        }        
    }
}

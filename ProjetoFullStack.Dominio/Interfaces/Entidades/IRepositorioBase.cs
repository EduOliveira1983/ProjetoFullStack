using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ProjetoFullStack.Dominio.Interfaces.Entidades
{
    public interface IRepositorioBase<T> :IDisposable where T :class 
    {       
        IList<T> Buscar(Expression<Func<T, bool>> where);
        IList<T> ListarTodos();
        void Inserir(T obj);
        void Alterar(T obj);
        void Excluir(T obj);
    }
}

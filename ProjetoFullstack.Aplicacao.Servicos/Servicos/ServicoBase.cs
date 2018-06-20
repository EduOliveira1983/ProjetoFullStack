using ProjetoFullStack.Dominio.Entidades;
using ProjetoFullStack.Infra.Data.EF.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFullstack.Aplicacao.Servicos.Servicos
{
    public abstract class ServicoBase<T> where T : EntidadeBase
    {
        protected RepositorioBase<T> _repositorio;

        public ServicoBase()
        {
            _repositorio = new RepositorioBase<T>();
        }



    }
}

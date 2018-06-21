using ProjetoFullStack.Dominio.Entidades;
using ProjetoFullStack.Infra.Data.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProjetoFullStack.Infra.Data.EF.Repositorios
{
    public class paisRepositorio : RepositorioBase<pais>
    {
        public pais BuscarPorID (int id_pais)
        {
            return DataContext.paises.Where(x => x.id_pais == id_pais).FirstOrDefault();
        }

        public List<pais> ListarPaisEstados(Expression<Func<pais, bool>> where)
        {
            return Buscar("estados.cidades.bairros.ruas.ruas_cep", where).ToList();
        }
        
    }

}

using ProjetoFullStack.Dominio.Entidades;
using ProjetoFullStack.Infra.Data.EF.Data;
using System.Linq;

namespace ProjetoFullStack.Infra.Data.EF.Repositorios
{
    public class paisRepositorio : RepositorioBase<pais>
    {
        public pais BuscarPorID (int id_pais)
        {
            return DataContext.paises.Where(x => x.id_pais == id_pais).FirstOrDefault();
        }
        
    }

}

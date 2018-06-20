using ProjetoFullStack.Dominio.Entidades;
using System.Collections;

namespace ProjetoFullStack.Infra.Data.EF.Repositorios
{
    public class usuarioRepositorio : RepositorioBase<usuario>
    {
        public override void Inserir(usuario obj)
        {
            obj.Validar();
            if (obj.Valido())
                base.Inserir(obj);
        }      

    }
}

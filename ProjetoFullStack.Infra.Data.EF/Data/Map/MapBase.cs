using ProjetoFullStack.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFullStack.Infra.Data.EF.Data.Map
{
    public abstract class MapBase :EntityTypeConfiguration<EntidadeBase>
    {
        public MapBase()
        {

        }
    }
}

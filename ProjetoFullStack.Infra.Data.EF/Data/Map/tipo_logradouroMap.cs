using ProjetoFullStack.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFullStack.Infra.Data.EF.Data.Map
{
    public class tipo_logradouroMap : EntityTypeConfiguration<tipo_logradouro>
    {
        public tipo_logradouroMap()
        {
            ToTable("tipo_logradouro");

            HasKey(x => x.id_tipo_logradouro);

            Property(x => x.sigla)
                .IsRequired();

            Property(x => x.descricao)
                .IsRequired();

        }
    }
}

using ProjetoFullStack.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFullStack.Infra.Data.EF.Data.Map
{
    public class ruaMap : EntityTypeConfiguration<rua>
    {
        public ruaMap()
        {
            ToTable("rua");
            HasKey(x => x.id_rua);

            Property(x => x.id_bairro)
                .IsRequired();

            Property(x => x.id_tipo_logradouro)
                .IsRequired();

            Property(x => x.nome)
                .HasMaxLength(80)
                .IsRequired();
        }
    }
}

using ProjetoFullStack.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFullStack.Infra.Data.EF.Data.Map
{
    public  class estadoMap : EntityTypeConfiguration<estado>
    {
        public estadoMap()
        {
            ToTable("estado");

            HasKey(x => x.id_estado);

            Property(x => x.nome)
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.sigla)
                .HasMaxLength(2)
                .IsFixedLength()
                .IsRequired();

            Property(x => x.id_pais)
                .IsRequired();

        }
    }
}

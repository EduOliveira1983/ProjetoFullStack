using ProjetoFullStack.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFullStack.Infra.Data.EF.Data.Map
{
    public class paisMap : EntityTypeConfiguration<pais>
    {
        public paisMap()
        {
            ToTable("pais");
            HasKey(x => x.id_pais);

            Property(x => x.id_pais)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);                          

            Property(x => x.sigla)
                .HasMaxLength(2)
                .IsFixedLength()
                .IsRequired();

            Property(x => x.nome)
                .HasMaxLength(80)
                .IsRequired();

            Property(x => x.data_cadastro)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }
}

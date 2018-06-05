using ProjetoFullStack.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFullStack.Infra.Data.EF.Data.Map
{
    public class bairroMap : EntityTypeConfiguration<bairro>
    {
        public bairroMap()
        {
            ToTable("bairro");

            HasKey(x => x.id_bairro);

            Property(x => x.id_cidade)
                .IsRequired();

            Property(x => x.nome)
                .HasMaxLength(80)
                .IsRequired();
        }
    }
}

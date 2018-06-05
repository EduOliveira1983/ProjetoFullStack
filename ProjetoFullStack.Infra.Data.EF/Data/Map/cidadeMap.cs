using ProjetoFullStack.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFullStack.Infra.Data.EF.Data.Map
{
    public class cidadeMap : EntityTypeConfiguration<cidade>
    {
        public cidadeMap()
        {
            ToTable("cidade");
            HasKey(x => x.id_cidade);

            Property(x => x.id_estado).IsRequired();

            Property(x => x.nome)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}

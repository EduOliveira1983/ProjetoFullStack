using ProjetoFullStack.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFullStack.Infra.Data.EF.Data.Map
{
    public class usuarioMap : EntityTypeConfiguration<usuario>
    {
        public usuarioMap()
        {
            ToTable("usuario");

            HasKey(x => x.id_usuario);

            Property(x => x.nome)
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.email)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}

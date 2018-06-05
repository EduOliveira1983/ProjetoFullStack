using ProjetoFullStack.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoFullStack.Infra.Data.EF.Data.Map
{
    public class rua_cepMap: EntityTypeConfiguration<rua_cep>
    {
        public rua_cepMap()
        {
            ToTable("rua_cep");

            HasKey(x => x.id_rua_cep);

            Property(x => x.id_rua)
                .IsRequired();

            Property(x => x.cep)
                .IsRequired();

            Property(x => x.numero_inicial)
                .IsRequired();
        }
    
    }
}

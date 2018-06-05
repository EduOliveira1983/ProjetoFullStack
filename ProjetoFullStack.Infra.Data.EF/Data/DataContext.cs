using ProjetoFullStack.Dominio.Entidades;
using ProjetoFullStack.Infra.Data.EF.Data.Map;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoFullStack.Infra.Data.EF.Data
{
    public class DataContext : DbContext 
    {
        public DataContext() : base("ConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<pais> paises { get; set; }
        public DbSet<estado> estados { get; set; }
        public DbSet<cidade> cidades { get; set; }
        public DbSet<bairro> bairros { get; set; }
        public DbSet<rua> ruas { get; set; }
        public DbSet<rua_cep> rua_ceps { get; set; }
        public DbSet<tipo_logradouro> tipos_logradouro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            
            modelBuilder.Configurations.Add(new paisMap());
            modelBuilder.Configurations.Add(new estadoMap());
            modelBuilder.Configurations.Add(new cidadeMap());
            modelBuilder.Configurations.Add(new bairroMap());
            modelBuilder.Configurations.Add(new ruaMap());
            modelBuilder.Configurations.Add(new rua_cepMap());
            modelBuilder.Configurations.Add(new tipo_logradouroMap());

        }
    }
}

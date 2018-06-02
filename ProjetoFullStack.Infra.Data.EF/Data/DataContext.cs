using ProjetoFullStack.Dominio.Entidades;
using ProjetoFullStack.Infra.Data.EF.Data.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //public DbSet<estado> estados { get; set; }
        //public DbSet<cidade> cidades { get; set; }
        //public DbSet<bairro> bairros { get; set; }
        //public DbSet<rua> ruas { get; set; }
        //public DbSet<rua_cep> rua_ceps { get; set; }
        //public DbSet<tipo_logradouro> tipos_logradouro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new paisMap());
        }


    }
}

using ProjetoFullStack.Infra.Data.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace ProjetoFullStack.Startup
{
    public static class ResolucaoDependencia
    {
        public static void Resolver(UnityContainer container)
        {
            container.RegisterType<DataContext, DataContext>(new HierarchicalLifetimeManager());


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFullStack.Apresentacao.MVC.Models.PlanetaTerra
{
    public class PlanetaTerraViewModel
    {
        public int id_Pais { get; set; }
        public string Nome { get; set; }
        public int Qtde_Cidades { get; set; }
                
        public IEnumerable<PlanetaTerraViewModel> ListarPaisesComCidades()
        {
            var lstCidades = new Cidades().Listar();
            var lstPaises = new Paises().Listar();
            IList<PlanetaTerraViewModel> lstModel = new List<PlanetaTerraViewModel>();

            IEnumerable<PlanetaTerraViewModel> lstDados = new List<PlanetaTerraViewModel>();

            var resultado = (from c in lstCidades
                             from p in lstPaises
                             where c.id_Pais == p.id_Pais
                             select new PlanetaTerraViewModel { id_Pais = p.id_Pais, Nome = p.Nome, Qtde_Cidades = lstCidades.Distinct().Count(x => x.id_Pais == c.id_Pais) })
                             .GroupBy(x => x.id_Pais)
                             .Distinct();

            foreach (var item in resultado)
            {
                foreach (var itemlist in item.Take(1).ToList())
                {
                    lstModel.Add(new PlanetaTerraViewModel { id_Pais = itemlist.id_Pais, Nome = itemlist.Nome, Qtde_Cidades = itemlist.Qtde_Cidades });
                }
            }

            return lstModel;
            
        }    
    }
}
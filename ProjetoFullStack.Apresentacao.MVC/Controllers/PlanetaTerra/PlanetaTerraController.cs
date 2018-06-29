using ProjetoFullStack.Apresentacao.MVC.Models.PlanetaTerra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFullStack.Apresentacao.MVC.Controllers.PlanetaTerra
{
    public class PlanetaTerraController : Controller
    {
        // GET: PlanetaTerra
        public ActionResult Index()
        {
            ViewBag.Cidades = new Cidades().Listar();
            return View(new PlanetaTerraViewModel().ListarPaisesComCidades());
        }

        [HttpGet]
        public ActionResult ListarPaises()
        {            
            return PartialView(new PlanetaTerraViewModel().ListarPaisesComCidades());
        }
       
        [HttpGet]
        public ActionResult ListarCidades(int id_pais)
        {
            var _cidades = new Cidades().BuscarPorPais(id_pais);
            return PartialView(_cidades);
        }
    }
}
using ProjetoFullStack.Apresentacao.MVC.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFullStack.Apresentacao.MVC.Controllers.Usuarios
{
    public class UsuarioController : Controller
    {        
        public ActionResult Index(IEnumerable<UsuarioModel> model)
        {
            if (model == null)
            {
                var usuario = new UsuarioModel();
                var lstUsuario = usuario.Listar();
                return View(lstUsuario);
            }
            else
                return View(model);
        }

        public ActionResult AlterarSenha(int id)
        {
            var _UsuarioTrocarSenhaViewModel = new UsuarioTrocarSenhaViewModel { id_usuario = id };
            return PartialView(_UsuarioTrocarSenhaViewModel);
        }

        [HttpPost]
        public ActionResult AlterarSenha(UsuarioTrocarSenhaViewModel _UsuarioTrocarSenhaViewModel)
        {
            if(ModelState.IsValid)
            {
                IEnumerable<UsuarioModel> _UsuarioModel = new UsuarioModel().Listar(_UsuarioTrocarSenhaViewModel.id_usuario, 
                                                              _UsuarioTrocarSenhaViewModel.novasenha);
                TempData["successmessage"] = "Senha alterada com sucesso";
                return View("Index", _UsuarioModel);
            }
            else
                return PartialView(_UsuarioTrocarSenhaViewModel);
        }

        public ActionResult Editar(int id)
        {
            var _UsuarioModel = new UsuarioModel();
            return View();
        }

        public ActionResult Excluir(int id)
        {
            return View();
        }

       
        public JsonResult VerificarUsuario(int id_usuario, string senha)
        {
            var _UsuarioModel = new UsuarioModel();
            return Json(_UsuarioModel.ValidarSenha(id_usuario, senha, null), JsonRequestBehavior.AllowGet);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFullStack.Apresentacao.MVC.Models.Usuarios
{
    public class UsuarioModel
    {
        public int id_usuario { get; private set; }
        public string nome { get; private set; }
        public string email { get; private set; }
        public string senha { get; private set; }
        public bool? inativo { get; private set; }
        

        public IEnumerable<UsuarioModel> Listar()
        {
            var lstUsuarioModel = new List<UsuarioModel>();

            lstUsuarioModel.Add(new UsuarioModel { id_usuario = 1, nome="Eduardo Oliveira", email="eduardo@teste.com.br", senha="1234", inativo = true});
            lstUsuarioModel.Add(new UsuarioModel { id_usuario = 2, nome = "Daiana Oliveira", email = "daiana@teste.com.br", senha = "1234", inativo = false });
            lstUsuarioModel.Add(new UsuarioModel { id_usuario = 3, nome = "Carlos Oliveira", email = "carlos@teste.com.br", senha = "1234", inativo = false });
            lstUsuarioModel.Add(new UsuarioModel { id_usuario = 4, nome = "Mariana Oliveira", email = "mariana@teste.com.br", senha = "1234", inativo = false });

            return lstUsuarioModel;

        }

        public IEnumerable<UsuarioModel> Listar(int _id_usuario, string _senha)
        {
            var Usuarios = Listar();

            foreach (var item in Usuarios)
            {
                if (item.id_usuario == _id_usuario)
                    item.senha = _senha;
            }

            return Usuarios;
        }

        public UsuarioModel Buscar(int _id_usuario, IEnumerable<UsuarioModel> model )
        {
            if (model == null)
                model = Listar();

            foreach (var item in model)
            {
                if (item.id_usuario == _id_usuario)
                    return item;
            }

            return null;            
        }

        public bool ValidarSenha(int _id_usuario, string _senha, IEnumerable<UsuarioModel> model)
        {
            if (model == null)
                model = Listar();

            foreach (var item in model)
            {
                if (item.id_usuario == _id_usuario)
                {
                    if (item.senha == _senha)
                        return true;
                    else
                        return false;
                }
            }

            return false; 

        }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjetoFullStack.Apresentacao.MVC.Models.Usuarios
{
    public class UsuarioTrocarSenhaViewModel
    {
        public int id_usuario { get; set; }
                

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Informe a Senha")]
        [Remote("VerificarUsuario", "Usuario", AdditionalFields = "id_usuario", ErrorMessage = "Senha Inválida")]
        public string senha { get; set; }

        [DataType(DataType.Password)]        
        [Required(ErrorMessage ="Informe a nova senha")]        
        public string novasenha { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Informe a confirmação da senha")]
        [System.ComponentModel.DataAnnotations.Compare("novasenha",ErrorMessage ="As senhas não coincidem")]
        public string confirmarsenha { get; set; }

    }
}
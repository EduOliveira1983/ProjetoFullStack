using ProjetoFullStack.Dominio.Entidades;
using ProjetoFullStack.Util.Helper;
using ProjetoFullStack.Util.Validacoes;
using System.Collections;

namespace ProjetoFullstack.Aplicacao.Servicos.Servicos
{
    public class UsuarioServicos : ServicoBase<usuario>
    {
        public bool CompararSenhas(byte[] senha, byte[] confirmacaosenha)
        {
            return StructuralComparisons.StructuralEqualityComparer.Equals(senha, confirmacaosenha);
        }

        public bool Logar(string _email, string _senha)
        {
            var senha = BytesHelper.StringToByte(_senha);
            if (!ValidacaoEmail.Validar(_email)) return false;
            return (_repositorio.Buscar(x => x.email == _email && x.senha == senha).Count == 1);
        }

    }
}

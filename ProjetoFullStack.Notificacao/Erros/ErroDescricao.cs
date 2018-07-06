using ProjetoFullStack.Util.Notificacoes.Interfaces.Erros;

namespace ProjetoFullStack.Util.Notificacoes.Erros
{
    public class ErroDescricao : Descricao
    {
        public INivel Nivel { get; }

        public ErroDescricao(string _Mensagem, INivel _Nivel, params string[] args) : base(_Mensagem, args)
        {
            Nivel = _Nivel;
        }
    }
}

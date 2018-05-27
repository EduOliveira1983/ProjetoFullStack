using ProjetoFullStack.Util.Notificacoes.Interfaces;

namespace ProjetoFullStack.Util.Notificacoes
{
    public abstract class Descricao : IDescricao
    {
        public string Mensagem { get; }

        protected Descricao(string _Mensagem, params string[] args)
        {
            Mensagem = _Mensagem;

            for (int i = 0; i < args.Length; i++)
            {
                Mensagem = Mensagem.Replace("{" + i + "}", args[i]);
            }
        }

        public override string ToString() => Mensagem;       
    }
}

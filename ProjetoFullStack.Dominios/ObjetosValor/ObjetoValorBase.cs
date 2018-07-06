using ProjetoFullStack.Util.Notificacoes.Erros;

namespace ProjetoFullStack.Dominio.ObjetosValor
{
    public class ObjetoValorBase
    {
        public Erro Notificacao { get; } = new Erro();

        protected virtual void Validar() { }

        protected void Falhou(bool condicao, ErroDescricao erro)
        {
            if (condicao)
                Notificacao.Incluir(erro);
        }

        public bool Valido()
        {
            return !Notificacao.TemCriticos;
        }



    }
}

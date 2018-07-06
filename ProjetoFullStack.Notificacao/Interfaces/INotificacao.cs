using System.Collections.Generic;

namespace ProjetoFullStack.Util.Notificacoes.Interfaces
{
    public interface INotificacao
    {
        IList<object> Lista { get; }
        bool TemNotificacao { get; }
        bool Contem(Descricao erro);
        void Incluir(Descricao erro);
        void LimparNotificacao();
    }
}

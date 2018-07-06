using ProjetoFullStack.Util.Notificacoes.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFullStack.Util.Notificacoes
{
    public abstract class Notificacao : INotificacao
    {
        public IList<object> Lista { get; } = new List<object>();

        public bool TemNotificacao => Lista.Any();

        public bool Contem(Descricao erro)
        {
            return Lista.Contains(erro);
        }

        public void Incluir(Descricao erro)
        {
            Lista.Add(erro);
        }

        public void LimparNotificacao()
        {
            Lista.Clear();
        }
    }
}

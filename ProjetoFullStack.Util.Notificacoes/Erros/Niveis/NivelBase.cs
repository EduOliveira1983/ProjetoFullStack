using ProjetoFullStack.Util.Notificacoes.Interfaces.Erros;

namespace ProjetoFullStack.Util.Notificacoes.Erros.Niveis
{
    public abstract class NivelBase : INivel
    {
        public string Descricao { get; }

        public override string ToString() => Descricao;

        public NivelBase(string _Descricao)
        {
            Descricao = _Descricao;
        }        
    }
}

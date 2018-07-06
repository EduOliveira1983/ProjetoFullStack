using System.Collections.Generic;
using System.Linq;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;

namespace ProjetoFullStack.Util.Notificacoes.Erros
{
    public class Erro : Notificacao
    {
        public IList<ErroDescricao> Criticos => Lista.Cast<ErroDescricao>().Where(x => x.Nivel is Critico).ToList();
        public IList<ErroDescricao> Advertencias => Lista.Cast<ErroDescricao>().Where(x => x.Nivel is Advertencia).ToList();
        public IList<ErroDescricao> Informacoes => Lista.Cast<ErroDescricao>().Where(x => x.Nivel is Informacao).ToList();

        public bool TemCriticos => Lista.Cast<ErroDescricao>().Any(x => x.Nivel is Critico);
        public bool TemAdvertencias => Lista.Cast<ErroDescricao>().Any(x => x.Nivel is Advertencia);
        public bool TemInformacoes => Lista.Cast<ErroDescricao>().Any(x => x.Nivel is Informacao);
        

    }
}

using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using ProjetoFullStack.Util.Resources;

namespace ProjetoFullStack.Dominio.ObjetosValor
{
    public class CEP :ObjetoValorBase
    {
        #region Propriedade
        public string CodigoPostal { get;}
        #endregion

        #region Construtor
        protected CEP()
        {
        }

        public CEP(string _CodigoPostal)
        {
            CodigoPostal = _CodigoPostal;
            Validar();
        }
        #endregion

        #region Metodos

        #region Validacao
        protected sealed override void Validar()
        {
            Falhou(string.IsNullOrEmpty(CodigoPostal), CEPInvalido);
            Falhou(!int.TryParse(CodigoPostal, out int n), CEPSomenteNumeros);
        }
        #endregion

        #endregion

        #region ErrosDescricao
        public static readonly ErroDescricao CEPInvalido = new ErroDescricao(Mensagens.Erro_CEPInvalido, new Critico());
        public static readonly ErroDescricao CEPSomenteNumeros = new ErroDescricao(Mensagens.Erro_CEPSomenteNumeros, new Critico());

        #endregion
    }
}

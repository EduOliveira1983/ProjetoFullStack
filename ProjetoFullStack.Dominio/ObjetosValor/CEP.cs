using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;

namespace ProjetoFullStack.Dominio.ObjetosValor
{
    public class CEP :ObjetoValorBase
    {
        #region Propriedade
        public string CodigoPostal { get;}
        #endregion

        #region Construtor
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
        protected static ErroDescricao CEPInvalido = new ErroDescricao("CEP Inválido", new Critico());
        protected static ErroDescricao CEPSomenteNumeros = new ErroDescricao("O CEP deve conter somente números", new Critico());
        #endregion
    }
}

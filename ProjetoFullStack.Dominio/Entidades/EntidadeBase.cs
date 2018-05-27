using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class EntidadeBase
    {
        #region Propriedades
        public Erro Erros { get; } = new Erro();
        #endregion

        #region "Metodos"

        public virtual void Validar() { }

        protected void Falhou(bool condicao, ErroDescricao erro)
        {
            if (condicao)
                Erros.Incluir(erro);
        }

        public bool Valido()
        {
            return !Erros.TemCriticos;
        }

        #endregion

        #region "Validacoes"
        protected void ValidarNome(String _nome)
        {
            Falhou(string.IsNullOrEmpty(_nome), NomeInvalido);
        }

        protected void ValidarDescricao(String _descricao)
        {
            Falhou(string.IsNullOrEmpty(_descricao), DescricaoInvalida);
        }
        #endregion

        #region "Erros"

        protected static ErroDescricao NomeInvalido = new ErroDescricao("Nome Inválido", new Critico());
        protected static ErroDescricao DescricaoInvalida = new ErroDescricao("Descrição Inválida", new Critico());
        

        #endregion
    }
}

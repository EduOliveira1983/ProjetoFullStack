using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using ProjetoFullStack.Util.Resources;
using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class pais : EntidadeBase
    {
        #region Propriedades
        public int id_pais { get; private set; }
        public string sigla { get; private set; }
        public string nome { get; private set; }
        public DateTime data_cadastro { get; private set; }
        #endregion

        #region Construtor
        protected pais(){ }

        public pais(int _id_pais, string _sigla, string _nome, DateTime _data_cadastro)
        {
            id_pais = _id_pais;
            sigla = _sigla;
            nome = _nome;
            data_cadastro = _data_cadastro;
        }

        public pais(string _sigla, string _nome)
        {
            sigla = _sigla;
            nome = _nome;
        }

        #endregion

        #region Metodos

        public void AlterarSigla(string _sigla)
        {
            sigla = _sigla;
            Falhou(string.IsNullOrEmpty(sigla), SiglaPaisInvalida);
        }

        public void AlterarNome(string _nome)
        {
            nome = nome;
            ValidarNome(nome);
        }

        #region Validacao
        public sealed override void Validar()
        {
            ValidarNome(nome);
            Falhou(id_pais == 0, IDPaisInvalido);
            Falhou(string.IsNullOrEmpty(sigla), SiglaPaisInvalida);
        }

        #endregion
        #endregion

        #region Erros
        public static readonly ErroDescricao IDPaisVazio = new ErroDescricao(Mensagens.Erro_IDPaisVazio, new Critico());
        public static readonly ErroDescricao IDPaisInvalido = new ErroDescricao(Mensagens.Erro_IDPaisInvalido, new Critico());
        public static readonly ErroDescricao SiglaPaisVazia = new ErroDescricao(Mensagens.Erro_SiglaPaisVazia, new Critico());
        public static readonly ErroDescricao SiglaPaisInvalida = new ErroDescricao(Mensagens.Erro_SiglaPaisInvalida, new Critico());

        #endregion

    }

}

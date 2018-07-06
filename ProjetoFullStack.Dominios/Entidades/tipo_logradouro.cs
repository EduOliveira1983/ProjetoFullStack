using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using ProjetoFullStack.Util.Resources;
using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class tipo_logradouro : EntidadeBase
    {
        #region Propriedades
        public int id_tipo_logradouro { get; private set; }
        public string sigla { get; private set; }
        public string descricao { get; private set; }
        public DateTime data_cadastro { get; private set; }
        #endregion

        #region Construtores
        protected tipo_logradouro()
        {
        }

        public tipo_logradouro(int _id_tipo_logradouro, string _sigla, string _descricao, DateTime _data_cadastro)
        {
            id_tipo_logradouro = _id_tipo_logradouro;
            sigla = _sigla;
            descricao = _descricao;
            data_cadastro = _data_cadastro;
        }

        public tipo_logradouro(string _sigla, string _descricao)
        {
            sigla = _sigla;
            descricao = _descricao;
        }
        #endregion

        #region Metodos

        #region Validacao

        public override void Validar()
        {
            ValidarDescricao(descricao);
            Falhou(string.IsNullOrEmpty(sigla), SiglaTipoLogradouroInvalida);
        }

        #endregion

        #endregion  

        #region Erros
        public static readonly ErroDescricao IDTipoLogradouroInvalido = new ErroDescricao(Mensagens.Erro_IDTipoLogradouroInvalido, new Critico());
        public static readonly ErroDescricao SiglaTipoLogradouroInvalida = new ErroDescricao(Mensagens.Erro_SiglaTipoLogradouroInvalida, new Critico());
        #endregion

    }
}

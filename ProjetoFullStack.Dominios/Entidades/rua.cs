using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using ProjetoFullStack.Util.Resources;
using System;
using System.Collections.Generic;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class rua : EntidadeBase
    {
        #region Propriedades
        public int id_rua { get; private set; }
        public int id_bairro { get; private set; }
        public int id_tipo_logradouro { get; private set; }
        public string nome { get; private set; }
        public DateTime data_cadastro { get; private set; }
        public virtual ICollection<rua_cep> ruas_cep { get; private set; }
        #endregion

        #region Construtores
        public rua()
        {
        }

        public rua(int _id_rua, int _id_bairro, int _id_tipo_logradouro, string _nome, DateTime _data_cadastro)
        {
            id_rua = _id_rua;
            id_bairro = _id_bairro;
            id_tipo_logradouro = _id_tipo_logradouro;
            nome = _nome;
            data_cadastro = _data_cadastro;
            Validar();
        }

        public rua(int _id_bairro, int _id_tipo_logradouro, string _nome)
        {
            id_bairro = _id_bairro;
            id_tipo_logradouro = _id_tipo_logradouro;
            nome = _nome;
            Validar();
        }

        #endregion

        #region "Metodos"

        public void AlterarBairro(int _id_bairro)
        {
            id_bairro = id_bairro;
            Falhou(id_bairro == 0, bairro.IDBairroInvalido);
        }

        public void AlterarTipoLogradouro(int _id_tipo_logradouro)
        {
            id_tipo_logradouro = _id_tipo_logradouro;
            Falhou(id_tipo_logradouro == 0, tipo_logradouro.IDTipoLogradouroInvalido);
        }

        public void AlterarNome(string _nome)
        {
            nome = _nome;
            ValidarNome(nome);
        }

        #region Validacao

        public sealed override void Validar()
        {
            ValidarNome(nome);
            Falhou(id_bairro == 0, bairro.IDBairroInvalido);
            Falhou(id_tipo_logradouro == 0, tipo_logradouro.IDTipoLogradouroInvalido);            
        }
        #endregion

        #endregion

        #region Erros

        protected static ErroDescricao IDRuaInvalido = new ErroDescricao(Mensagens.Erro_IDRuaInvalido, new Critico());

        #endregion

    }

}

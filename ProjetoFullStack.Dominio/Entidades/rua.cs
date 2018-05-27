using ProjetoFullStack.Dominio.ObjetosValor;
using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class rua : EntidadeBase
    {
        #region Propriedades
        public int id_rua { get; private set; }
        public int id_bairro { get; private set; }
        public int id_tipo_logradouro { get; private set; }
        public string nome { get; private set; }
        public CEP cep { get; private set; }
        public DateTime data_cadastro { get; private set; }
        #endregion

        #region Construtores
        public rua()
        {
        }

        public rua(int _id_rua, int _id_bairro, int _id_tipo_logradouro, string _nome, CEP _cep, DateTime _data_cadastro)
        {
            id_rua = _id_rua;
            id_bairro = _id_bairro;
            id_tipo_logradouro = _id_tipo_logradouro;
            nome = _nome;
            cep = _cep;
            data_cadastro = _data_cadastro;
            Validar();
        }

        public rua(int _id_bairro, int _id_tipo_logradouro, string _nome, CEP _cep)
        {
            id_bairro = _id_bairro;
            id_tipo_logradouro = _id_tipo_logradouro;
            nome = _nome;
            cep = _cep;
            Validar();
        }

        #endregion

        #region "Metodos"

        #region Validacao

        public sealed override void Validar()
        {
            ValidarNome(nome);
            Falhou(id_bairro == 0, bairro.CodigoBairroVazio);

        }
        #endregion

        #endregion

        #region Erros

        protected static ErroDescricao CodigoRuaVazio = new ErroDescricao("O Código da Rua não pode ser vazio", new Critico());

        #endregion


    }



}

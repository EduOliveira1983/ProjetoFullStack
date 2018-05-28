using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using ProjetoFullStack.Util.Resources;
using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class bairro : EntidadeBase
    {

        #region Propriedades

        public int id_bairro { get; private set; }
        public int id_cidade { get; private set; }
        public string nome { get; private set; }
        public string codigo_ibge { get; private set; }
        public DateTime data_cadastro { get; private set; }

        #endregion

        #region Construtores

        protected bairro()
        {
        }

        public bairro(int _id_bairro, int _id_cidade, string _nome, string _codigo_ibge, DateTime _data_cadastro)
        {
            id_bairro = _id_bairro;
            id_cidade = _id_cidade;
            nome = _nome;
            codigo_ibge = _codigo_ibge;
            data_cadastro = _data_cadastro;
            Validar();
        }

        public bairro(int _id_cidade, string _nome, string _codigo_ibge)
        {
            id_cidade = _id_cidade;
            nome = _nome;
            codigo_ibge = _codigo_ibge;
            Validar();
        }

        #endregion

        #region Metodos

        #region Validacao
        public sealed override void Validar()
        {
            ValidarNome(nome);
            ValidarCodigoIBGE(codigo_ibge, 10);
            Falhou(id_cidade == 0, cidade.IDCidadeInvalido);
        }

        #endregion

        #endregion

        #region ErroDescricao

        public static readonly ErroDescricao IDBairroInvalido = new ErroDescricao(Mensagens.Erro_IDBairroInvalido, new Critico());

        #endregion


    }

}

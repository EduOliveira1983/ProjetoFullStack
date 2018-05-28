using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using ProjetoFullStack.Util.Resources;
using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class cidade :EntidadeBase
    {
        #region Propriedades
        public int id_cidade { get; private set; }
        public string nome { get; private set; }
        public string codigo_ibge { get; private set; }
        public int id_estado { get; private set; }
        public DateTime data_cadastro { get; private set; }
        #endregion

        #region Construtores
        protected cidade()
        {
        }

        public cidade(int _id_cidade, string _nome, string _codigo_ibge, int _id_estado, DateTime _data_cadastro)
        {
            id_cidade = _id_cidade;
            nome = _nome;
            codigo_ibge = _codigo_ibge;
            id_estado = _id_estado;
            data_cadastro = _data_cadastro;
        }

        public cidade(string _nome, string _codigo_ibge, int _id_estado)
        {
            nome = _nome;
            codigo_ibge = _codigo_ibge;
            id_estado = _id_estado;
        }
        #endregion

        #region Metodos

        #region Validacao

        public override void Validar()
        {
            ValidarNome(nome);
            ValidarCodigoIBGE(codigo_ibge, 7);
            Falhou(id_estado == 0, estado.IDEstadoInvalido);
        }

        #endregion

        #endregion

        #region Erros
        public static readonly ErroDescricao IDCidadeInvalido = new ErroDescricao(Mensagens.Erro_IDCidadeInvalido, new Critico());
        #endregion
    }

}

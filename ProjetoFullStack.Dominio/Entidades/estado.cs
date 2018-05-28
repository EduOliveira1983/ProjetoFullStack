using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using ProjetoFullStack.Util.Resources;
using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class estado : EntidadeBase
    {
        #region Propriedades
        public int id_estado { get; private set; }
        public string nome { get; private set; }
        public int id_pais { get; private set; }
        public string sigla { get; private set; }
        public DateTime data_cadastro { get; private set; }
        public string codigo_ibge { get; private set; }
        #endregion

        #region Construtor
        protected estado()
        {
        }

        public estado(int _id_estado, string _nome, int _id_pais, string _sigla, DateTime _data_cadastro, string _codigo_ibge)
        {
            id_estado = _id_estado;
            nome = _nome;
            id_pais = _id_pais;
            sigla = _sigla;
            data_cadastro = _data_cadastro;
            codigo_ibge = _codigo_ibge;
        }

        public estado(string _nome, int _id_pais, string _sigla, string _codigo_ibge)
        {
            nome = _nome;
            id_pais = _id_pais;
            sigla = _sigla;
            codigo_ibge = _codigo_ibge;
        }

        #endregion

        #region Metodos

        #region Validacao
        public override void Validar()
        {
            ValidarNome(nome);            
            Falhou(id_pais == 0, pais.IDPaisInvalido);
            Falhou(string.IsNullOrEmpty(sigla), SiglaEstadoVazia);
            ValidarCodigoIBGE(codigo_ibge, 2);

        }

        #endregion

        #endregion

        #region Erros
        public static readonly ErroDescricao IDEstadoInvalido = new ErroDescricao(Mensagens.Erro_IDEstadoInvalido, new Critico());
        public static readonly ErroDescricao SiglaEstadoInvalida = new ErroDescricao(Mensagens.Erro_SiglaEstadoInvalida, new Critico());
        public static readonly ErroDescricao SiglaEstadoVazia = new ErroDescricao(Mensagens.Erro_SiglaEstadoVazia, new Critico());       
        #endregion

    }

}

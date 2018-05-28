using ProjetoFullStack.Dominio.ObjetosValor;
using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using ProjetoFullStack.Util.Resources;
using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class rua_cep : EntidadeBase
    {
        #region Propriedades
        public int id_rua_cep { get; set; }
        public int id_rua { get; set; }
        public string cep { get; set; }
        public int numero_inicial { get; set; }
        public int? numero_final { get; set; }
        public string obs { get; set; }
        public DateTime data_cadastro { get; set; }
        #endregion

        #region Construtores
        protected rua_cep()
        {
        }

        public rua_cep(int _id_rua_cep, int _id_rua, CEP _cep, int _numero_inicial, int? _numero_final, string _obs, DateTime _data_cadastro)
        {
            id_rua_cep = _id_rua_cep;
            id_rua = _id_rua;
            cep = _cep.ToString();
            numero_inicial = _numero_inicial;
            numero_final = _numero_final;
            obs = _obs;
            data_cadastro = _data_cadastro;
        }

        public rua_cep(int _id_rua, CEP _cep, int _numero_inicial, int _numero_final, string _obs)
        {
            id_rua = _id_rua;
            cep = _cep.ToString();
            numero_inicial = _numero_inicial;
            numero_final = _numero_final;
            obs = _obs;
        }
        #endregion

        #region Metodos

        #region Validacao
        public override void Validar()
        {
            Falhou(numero_inicial == 0, NumeroInicialVazio);
            Falhou(numero_inicial == numero_final.Value, NumeroInicialIgual);
            Falhou(numero_final.Value < numero_inicial, NumeroFinalMenor);
        }

        #endregion

        #endregion

        #region Erro
        public static readonly ErroDescricao NumeroInicialVazio = new ErroDescricao(Mensagens.Erro_RuaCepNumeroInicialVazio, new Critico());
        public static readonly ErroDescricao NumeroInicialIgual = new ErroDescricao(Mensagens.Erro_RuaCepNumeroInicialIgual, new Critico());
        public static readonly ErroDescricao NumeroFinalMenor = new ErroDescricao(Mensagens.Erro_RuaCepNumeroFinalMenor, new Critico());
        #endregion

    }

}

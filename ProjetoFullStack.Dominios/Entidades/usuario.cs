using ProjetoFullStack.Util.Notificacoes.Erros;
using ProjetoFullStack.Util.Notificacoes.Erros.Niveis;
using ProjetoFullStack.Util.Resources;
using ProjetoFullStack.Util.Validacoes;
using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class usuario : EntidadeBase
    {
        #region Propriedades
        public int id_usuario { get; private set; }
        public string nome { get; private set; }
        public string email { get; private set; }
        public byte[] senha { get; private set; }
        public bool? inativo { get; private set; }
        public DateTime? data_cadastro { get; private set; }
        #endregion

        #region Construtor
        public usuario() { }       

        public usuario(int _id_usuario, string _nome, string _email, byte[] _senha, bool? _inativo, DateTime? _data_cadastro)
        {
            id_usuario = _id_usuario;
            nome = _nome;
            email = _email;
            senha = _senha;
            inativo = _inativo;
            data_cadastro = _data_cadastro;
        }

        public usuario(int _id_usuario, string _nome, string _email, bool? _inativo)
        {
            id_usuario = _id_usuario;
            nome = _nome;
            email = _email;
            inativo = _inativo;
        }
        #endregion

        #region Metodos
        public void AlterarNome(string _nome)
        {
            nome = _nome;
            ValidarNome(nome);
        }

        public void AlterarEmail (string _email)
        {
            email = _email;
            Falhou(!ValidacaoEmail.Validar(email), EmailInvalido);
        }       

        public void AlterarSenha(byte[] _senha)
        {
            senha = _senha;
            Falhou(senha == null, SenhaInvalida);
        }        

        public sealed override void Validar()
        {
            ValidarNome(nome);            
            Falhou(inativo.Value == true, UsuarioInativo);
            Falhou(senha == null, SenhaInvalida);
            Falhou(!ValidacaoEmail.Validar(email), EmailInvalido);
        }

        #endregion

        #region Erros
        public static readonly ErroDescricao SenhaInvalida = new ErroDescricao(Mensagens.Erro_UsuarioSenhaInvalida, new Critico());
        public static readonly ErroDescricao UsuarioNaoEncontrado = new ErroDescricao(Mensagens.Erro_UsuarioNaoEncontrado, new Critico());
        public static readonly ErroDescricao UsuarioInativo = new ErroDescricao(Mensagens.Erro_UsuarioInativo, new Critico());
        public static readonly ErroDescricao SenhasDiferentes = new ErroDescricao(Mensagens.Erro_UsuarioSenhasDiferentes, new Critico());
        public static readonly ErroDescricao EmailInvalido = new ErroDescricao(Mensagens.Erro_UsuarioEmailInvalido, new Critico());
        #endregion
    }
}

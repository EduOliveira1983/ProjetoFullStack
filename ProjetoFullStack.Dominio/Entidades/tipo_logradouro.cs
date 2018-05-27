using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class tipo_logradouro
    {
        public int id_tipo_logradouro { get; private set; }
        public string sigla { get; private set; }
        public string descricao { get; private set; }
        public DateTime data_cadastro { get; private set; }

        public tipo_logradouro()
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
    }
}

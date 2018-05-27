using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class estado
    {
        public int id_estado { get; private set; }
        public string nome { get; private set; }
        public int id_pais { get; private set; }
        public string sigla { get; private set; }
        public DateTime data_cadastro { get; private set; }
        public string codigo_ibge { get; private set; }

        public estado()
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



    }

}

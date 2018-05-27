using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class pais
    {
        public int id_pais { get; private set; }
        public string sigla { get; private set; }
        public string nome { get; private set; }
        public DateTime data_cadastro { get; private set; }
        
        public pais()
        {
        }

        public pais(int _id_pais, string _sigla, string _nome, DateTime _data_cadastro)
        {
            id_pais = _id_pais;
            sigla = _sigla;
            nome = _nome;
            data_cadastro = _data_cadastro;
        }

        public pais(string _sigla, string _nome)
        {
            sigla = _sigla;
            nome = _nome;
        }
        
    }

}

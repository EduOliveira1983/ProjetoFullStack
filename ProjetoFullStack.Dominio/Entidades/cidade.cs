using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class cidade
    {
        public int id_cidade { get; set; }
        public string nome { get; set; }
        public string codigo_ibge { get; set; }
        public int? id_estado { get; set; }
        public DateTime data_cadastro { get; set; }

        public cidade()
        {
        }
    }

}

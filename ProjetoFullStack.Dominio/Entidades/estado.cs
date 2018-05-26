using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class estado
    {
        public int id_estado { get; set; }
        public string nome { get; set; }
        public int? id_pais { get; set; }
        public string sigla { get; set; }
        public DateTime? data_cadastro { get; set; }
        public string codigo_ibge { get; set; }

        public estado()
        {
        }
    }

}

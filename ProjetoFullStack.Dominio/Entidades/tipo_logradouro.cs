using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class tipo_logradouro
    {
        public int id_tipo_logradouro { get; set; }
        public string sigla { get; set; }
        public string descricao { get; set; }
        public DateTime? data_cadastro { get; set; }
    }
}

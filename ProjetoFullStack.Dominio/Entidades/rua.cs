using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class rua
    {
        public int id_rua { get; set; }
        public int id_bairro { get; set; }
        public int id_tipo_logradouro { get; set; }
        public string nome { get; set; }
        public string cep { get; set; }
        public DateTime? data_cadastro { get; set; }
    }

}

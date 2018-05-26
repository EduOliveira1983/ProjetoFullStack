using System;

namespace ProjetoFullStack.Dominio.Entidades
{
    public class pais
    {
        public int id_pais { get; set; }
        public string sigla { get; set; }
        public string nome { get; set; }
        public DateTime data_cadastro { get; set; }
        
        public pais()
        {
        }
        
    }

}

using ProjetoFullStack.Dominio.Entidades;
using ProjetoFullStack.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFullStack.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var objCEP = new CEP("06286060");
            if (!objCEP.Notificacao.TemCriticos)
            {
                var objrua = new rua(1, 1, "Amazonita", objCEP);
                var teste = objrua.Valido();
            }
            else
            {
                var erros = objCEP.Notificacao.Criticos;
            }
                
                
            
        }
    }
}

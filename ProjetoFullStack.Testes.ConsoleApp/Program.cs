using ProjetoFullStack.Dominio.Entidades;
using ProjetoFullStack.Dominio.ObjetosValor;
using ProjetoFullStack.Infra.Data.EF.Repositorios;
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
            var paisrepo = new paisRepositorio();

            var paises = paisrepo.ListarPaisEstados(x => x.sigla == "BR");

            var br = paisrepo.Buscar(x => x.sigla == "BR");


            var pais = new pais("WW", "Teste");
            
            if (pais.Valido())
                paisrepo.Inserir(pais);

            var retorno = paisrepo.Buscar(x => x.sigla == "WW");

            foreach (pais item in retorno)
            {                
                item.AlterarNome("Alterado");
                item.AlterarSigla(string.Empty);
                
                if (item.Valido())                
                    paisrepo.Alterar(item);

                item.Revalidar();
                item.AlterarSigla("XJ");
                if (item.Valido())
                    paisrepo.Alterar(item);
            }

            var alterado = paisrepo.Buscar(x => x.sigla == "XJ");

            foreach (var item in alterado)
            {
                paisrepo.Excluir(item);
            }

            var excluidos = paisrepo.Buscar(x => x.sigla == "XJ");

        }
    }
}

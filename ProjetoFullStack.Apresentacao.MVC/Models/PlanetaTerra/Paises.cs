using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFullStack.Apresentacao.MVC.Models.PlanetaTerra
{
    public class Paises
    {
        public int id_Pais { get; set; }
        public string Nome { get; set; }
        public string Continente { get; set; }

        public IEnumerable<Paises> Listar()
        {
            var lstPaises = new List<Paises>();

            lstPaises.Add(new Paises { id_Pais = 1, Nome = "Brasil", Continente = "América do Sul" });
            lstPaises.Add(new Paises { id_Pais = 2, Nome = "Argentina", Continente = "América do Sul" });
            lstPaises.Add(new Paises { id_Pais = 3, Nome = "Canadá", Continente = "América do Norte" });
            lstPaises.Add(new Paises { id_Pais = 4, Nome = "Estados Unidos", Continente = "América do Norte" });
            lstPaises.Add(new Paises { id_Pais = 5, Nome = "Africa do Sul", Continente = "Africa" });
            lstPaises.Add(new Paises { id_Pais = 6, Nome = "Australia", Continente = "Oceani" });
            lstPaises.Add(new Paises { id_Pais = 7, Nome = "Russia", Continente = "Europa" });
            lstPaises.Add(new Paises { id_Pais = 8, Nome = "Japão", Continente = "Asia" });

            return lstPaises;
        }       
    }
    //Sei que é jegue deixar duas classes no mesmo arquivo, mas estou fazendo apenas para estudo e 
    //para agilizar o processo. Tá, não justifica, mas dá um desconto, pq tá osso!
    public class Cidades
    {
        public int id_Cidade { get; set; }
        public int id_Pais { get; set; }
        public string Nome { get; set; }
        public string PontoTuristico { get; set; }

        public IEnumerable<Cidades> Listar()
        {
            var lstCidades = new List<Cidades>();
            lstCidades.Add(new Cidades { id_Cidade = 1, id_Pais = 1, Nome = "São Paulo", PontoTuristico = "Ibirapuera" });
            lstCidades.Add(new Cidades { id_Cidade = 2, id_Pais = 1, Nome = "Rio de Janeiro", PontoTuristico = "Cristo Redentor" });
            lstCidades.Add(new Cidades { id_Cidade = 3, id_Pais = 2, Nome = "Buenos Aires", PontoTuristico = "El Caminito" });
            lstCidades.Add(new Cidades { id_Cidade = 4, id_Pais = 3, Nome = "Niágara", PontoTuristico = "Cataradas do Niágara" });
            lstCidades.Add(new Cidades { id_Cidade = 5, id_Pais = 4, Nome = "Orlando", PontoTuristico = "Magic Kingdom" });
            lstCidades.Add(new Cidades { id_Cidade = 6, id_Pais = 4, Nome = "Nova York", PontoTuristico = "Central Park" });
            lstCidades.Add(new Cidades { id_Cidade = 7, id_Pais = 5, Nome = "Cape Town", PontoTuristico = "Monumento para o Mandela" });
            lstCidades.Add(new Cidades { id_Cidade = 8, id_Pais = 6, Nome = "Sidney", PontoTuristico = "Opera House" });
            lstCidades.Add(new Cidades { id_Cidade = 9, id_Pais = 7, Nome = "Moscou", PontoTuristico = "Praça Vermelha" });
            lstCidades.Add(new Cidades { id_Cidade = 10, id_Pais = 7, Nome = "Moscou", PontoTuristico = "Tumulo Lenin" });
            lstCidades.Add(new Cidades { id_Cidade = 11, id_Pais = 8, Nome = "Tokyo", PontoTuristico = "Tokyo Tower" });
            lstCidades.Add(new Cidades { id_Cidade = 12, id_Pais = 8, Nome = "Tokyo", PontoTuristico = "Shibuya" });

            return lstCidades;
        }

        public IEnumerable<Cidades> BuscarPorPais(int _id_Pais)
        {
            return Listar().Where(x => x.id_Pais == _id_Pais);
        }
    }
}
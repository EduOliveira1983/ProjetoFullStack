﻿using ProjetoFullstack.Aplicacao.Servicos.Servicos;
using ProjetoFullStack.Dominio.Entidades;
using ProjetoFullStack.Dominio.ObjetosValor;
using ProjetoFullStack.Infra.Data.EF.Repositorios;
using ProjetoFullStack.Util.Helper;
using System;
using System.Collections;
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
            var usuServ = new UsuarioServicos();
            var retorno = usuServ.Logar("eduardooliveira_jr@hotmail.com", "Testes");
        }
    }
}

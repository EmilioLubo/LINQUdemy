﻿using LINQConsola.Operadores;
using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new Ordenacion().Ordenar();

            //new Conjuntos().Conjunto();

            new Filtrado().Filtrar();

            Console.ReadKey();
        }
    }
}
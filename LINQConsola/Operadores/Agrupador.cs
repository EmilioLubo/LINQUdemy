using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Agrupador
    {
        public void Agrupar()
        {
            //GROUPBY

            //var numeros = new List<int>() { 3, 27, 92, 51, 7, 37, 22, 8, 45, 99 };

            //var nGrupos = numeros.GroupBy(x => x % 2);

            //foreach (var item in nGrupos) 
            //{
            //    if (item.Key % 2 == 0)
            //    {
            //        Console.WriteLine("Números Pares");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Números Impares");
            //    }
            //    foreach (var n in item)
            //    {
            //        Console.WriteLine($"\t{n}");
            //    }
            //    Console.WriteLine(Environment.NewLine);
            //}

            using (var db = new CursosVirtualesEntities())
            {
                //var grupoXPrecio = db.Cursos.ToList().GroupBy(c =>
                //{
                //    if(c.Precio <= 9.99)
                //    {
                //        return "$0.00 - $9.99 (Barato)";
                //    }
                //    else if(c.Precio <= 24.99)
                //    {
                //        return "$10.00 - $24.99 (Promedio)";
                //    }
                //    else
                //    {
                //        return "$25.00 - $MAX (Caro)";
                //    }
                //});

                //foreach (var item in grupoXPrecio)
                //{
                //    Console.WriteLine($"Cursos con un precio de: {item.Key}: {item.Count()}");

                //    foreach(var c in item)
                //    {
                //        Console.WriteLine($"\t {c.Precio.ToString("C2")} {c.Nombre}");
                //    }

                //    Console.WriteLine(Environment.NewLine);
                //}

                //var result = from p in db.Personas
                //             group p by p.Paises.Nombre;

                //foreach(var item in result)
                //{
                //    Console.WriteLine(item.Key + Environment.NewLine);

                //    foreach(var p in item)
                //    {
                //        Console.WriteLine($"{p.Nombre} {p.Apellido}");
                //    }
                //    Console.WriteLine(Environment.NewLine);
                //}

                //TOLOOKUP

                //var personasXPais = db.Personas.ToLookup(p => p.Paises.Nombre);

                var personasXPais = (from p in db.Personas
                                     select p).ToLookup(p => p.Paises.Nombre);

                foreach (var item in personasXPais)
                {
                    Console.WriteLine(item.Key);

                    foreach (var p in item)
                    {
                        Console.WriteLine($"\t{p.Nombre} {p.Apellido}");
                    }
                    Console.WriteLine(Environment.NewLine);
                }
            }
        }
    }
}

using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class DeElementos
    {
        public void SobreElementos()
        {
            using (var db = new CursosVirtualesEntities())
            {
                //ELEMENTAT


                //var elegido = paises.AsEnumerable().ElementAt(9);

                //Console.WriteLine(elegido.Nombre);

                //var paises = db.Paises.Take(10);

                //foreach (var p in paises)
                //{
                //    Console.WriteLine(p.Nombre);
                //}

                //Console.WriteLine(Environment.NewLine);

                //ELEMENTATORDEFAULT

                //int index = 18;

                //var elegido = paises.AsEnumerable().ElementAtOrDefault(index);

                //Console.WriteLine("El país {0} es: {1}", index, elegido == null ? "no hay país" : elegido.Nombre); 

                //FIRST

                //var cursos999 = db.Cursos.Where(c => c.Precio == 9.99).ToList();

                //foreach (var c in cursos999)
                //{
                //    Console.WriteLine(c.Nombre);
                //}

                //Console.WriteLine(Environment.NewLine);

                //var curso = cursos999.First(c => c.Nombre.Contains("3"));

                //Console.WriteLine(curso.Nombre);

                //FIRSTORDEFAULT


                //var curso = cursos999.FirstOrDefault(c => c.Nombre.Contains("x3"));

                //Console.WriteLine(curso == null ? "No hay curso" : curso.Nombre);

                //LAST

                //var curso = cursos999.AsEnumerable().Last(e => !e.Nombre.Contains("3"));

                //Console.WriteLine(curso.Nombre);

                //LASTORDEFAULT

                //var curso = cursos999.AsEnumerable().LastOrDefault(e => e.Nombre.Contains("x3"));

                //Console.WriteLine(curso == null ? "No hay cursos" : curso.Nombre);

                //SINGLE

                //var curso = db.Cursos.Single(c => c.Nombre.Equals("programación orientada a objetos"));

                //Console.WriteLine(curso.Nombre);

                //SINGLEORDEFAULT

                var curso = db.Cursos.SingleOrDefault(c => c.Nombre.Equals("x3"));

                Console.WriteLine(curso == null ? "No hay cursos" : curso.Nombre);

            }
        }
    }
}

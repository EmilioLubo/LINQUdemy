using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Agregacion
    {
        public void Agregar()
        {
            //AGGREGATE

            //var enteros = new int[] { 2, 4, 5, 7 };

            //var pares = enteros.Aggregate(0, (t , n) => n % 2 == 0 ? t + 1 : t);

            //Console.WriteLine(pares);

            //var suma = enteros.Aggregate((t, n) => t + n);

            //Console.WriteLine(suma);

            //var letras = new[] { "h", "a", "o", "l" };

            //var palabra = letras.Aggregate(new StringBuilder(),(acc, next) => acc.Append(next));

            //Console.WriteLine(palabra);

            //AVERAGE

            //var numeros = new List<int>() { 2, 1, 4, 6, 2, 1, 5, 3, 7 };

            //var promedio = numeros.Average();

            //Console.WriteLine(promedio);

            using (var db = new CursosVirtualesEntities())
            {
                var cursos = db.Cursos;

                ////COUNT

                //Console.WriteLine(cursos.Count(c => c.Idioma.Equals("ingles")));

                ////LONGCOUNT

                //Console.WriteLine(cursos.LongCount());

                //MAX

                //var caro = cursos.Max(c => c.Precio);

                //Console.WriteLine(caro);

                //MIN

                //var barato = cursos.Min(c => c.Precio);

                //Console.WriteLine(barato);

                //SUM

                var suma = cursos.Sum(c => c.Precio);

                Console.WriteLine(suma.ToString("C2"));
            }
        }
    }
}

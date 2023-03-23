using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Generador
    {
        public void Generar()
        {
            using (var db = new CursosVirtualesEntities())
            {
                Cursos xDefecto = new Cursos
                {
                    CursoId = 0,
                    Nombre = "None",
                    Idioma = "None",
                    Precio = 0,
                    FechaRegistro = DateTime.MinValue,
                    FechaModificacion = DateTime.MinValue,
                    Estado = false
                };

                //DEFAULTIFEMPTY

                //var cursos = db.Cursos
                //    .Where(c => c.Precio > 1000)
                //    .Take(5);

                //foreach (var c in cursos.AsEnumerable().DefaultIfEmpty(xDefecto))
                //{
                //    Console.WriteLine($"Id: {c.CursoId}, " +
                //        $"Nombre: {c.Nombre}, " +
                //        $"Idioma: {c.Idioma}, " +
                //        $"Precio: {c.Precio.ToString("C2")}");
                //}

                //EMPTY

                //var vacio = Enumerable.Empty<int>();

                //Console.WriteLine(vacio.Count());

                //RANGE

                //var numeros = Enumerable.Range(50, 10);

                //foreach (var n in numeros) 
                //{
                //    Console.WriteLine(n);
                //}

                //REPEAT

                var cursos = Enumerable.Repeat(xDefecto, 5);

                foreach (var x in cursos)
                {
                    Console.WriteLine(x.Nombre);
                }
            }
        }
    }
}

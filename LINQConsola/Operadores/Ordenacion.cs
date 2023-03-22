using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Ordenacion
    {
        public void Ordenar()
        {
            string[] colores = new string[] { "azul", "amarillo", "naranja", "verde", "rojo", "rosa", "violeta", "negro", "blanco", "gris" };


            //ASCENDING
            //IEnumerable<string> coloresOrden = from c in colores
            //                                   orderby c ascending
            //                                   select c;
            //DESCENDING
            //IEnumerable<string> coloresOrden = from c in colores
            //                                   orderby c descending
            //                                   select c;
            //foreach (string col in coloresOrden)
            //{
            //    Console.WriteLine($"{col}");
            //}

            using (var db = new CursosVirtualesEntities()) 
            {
                //IEnumerable<Cursos> cursos = from c in db.Cursos
                //                             select c;
                //IDIOMA ASC
                //IEnumerable<Cursos> cursos = from c in db.Cursos
                //                             orderby c.Idioma
                //                             select c;
                //IDIOMA DESC
                //IEnumerable<Cursos> cursos = from c in db.Cursos
                //                             orderby c.Idioma descending
                //                             select c;
                //ORDEN SECUNDARIO
                //IEnumerable<Cursos> cursos = from c in db.Cursos
                //                             orderby c.Idioma, c.Nombre
                //                             select c;
                //ORDEN SECUNDARIO DESC
                //IEnumerable<Cursos> cursos = from c in db.Cursos
                //                             orderby c.Idioma, c.Nombre descending
                //                             select c;
                //SINTAXIS DE METODO
                //IEnumerable<Cursos> cursos = db.Cursos;
                //ASC
                //IEnumerable<Cursos> cursos = db.Cursos.OrderBy(c => c.Idioma);
                //DESC
                //IEnumerable<Cursos> cursos = db.Cursos.OrderByDescending(c => c.Idioma);
                //SECUNDARIO THENBY
                //IEnumerable<Cursos> cursos = db.Cursos.OrderBy(c => c.Idioma)
                //                                .ThenBy(c => c.Nombre);
                //SECUNDARIO THENBYDESC
                //IEnumerable<Cursos> cursos = db.Cursos.OrderBy(c => c.Idioma)
                //                                .ThenByDescending(c => c.Nombre);

                //foreach (var c in cursos)
                //{
                //    Console.WriteLine($"IDIOMA: {c.Idioma}, CURSO: {c.Nombre}");
                //}

                var continentes = db.Continentes;

                foreach (var c in continentes)
                {
                    Console.WriteLine($"ID: {c.ContinenteId}, Nombre: {c.Nombre}");
                }

                Console.WriteLine("\n");

                var continentes2 = db.Continentes.AsEnumerable().Reverse();

                foreach (var c in continentes2)
                {
                    Console.WriteLine($"ID: {c.ContinenteId}, Nombre: {c.Nombre}");
                }
            }
        }
    }
}

using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Particionador
    {
        public void Particionar()
        {
            using (var db = new CursosVirtualesEntities())
            {
                //TAKE

                var cursos = db.Cursos.Take(5);

                //TAKEWHILE

                var cursosW = db.Cursos.AsEnumerable().TakeWhile(c => c.Idioma.Equals("ingles")).ToList();

                //SKIP

                var cursosS = db.Cursos.AsEnumerable().Skip(120);

                //SKIPWHILE

                var cursosSW = db.Cursos.AsEnumerable().SkipWhile(c => c.Idioma.Equals("ingles")).ToList();

                foreach (var c in cursosSW)
                {
                    Console.WriteLine($"ID: {c.CursoId}, Nombre: {c.Nombre}, Idioma: {c.Idioma}, Precio: ${c.Precio}");
                }
            }
        }
    }
}

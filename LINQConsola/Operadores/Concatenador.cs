using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Concatenador
    {
        public void Concatenar()
        {

            //CONCAT 

            using (var db = new CursosVirtualesEntities())
            {
                var instructores = from i in db.Personas.Take(10)
                                   where i.TipoPersona.Equals("instructor")
                                   select i;
                var estudiantes = db.Personas.Where(p => p.TipoPersona.Equals("estudiante")).Take(10);

                foreach (var i in instructores)
                {
                    Console.WriteLine("Instructor: " + i.Nombre);
                }

                Console.WriteLine(Environment.NewLine);

                foreach (var e in estudiantes)
                {
                    Console.WriteLine("Estudiante: " + e.Nombre);
                }

                Console.WriteLine(Environment.NewLine);

                var instrutoresYEstudiantes = instructores.Concat(estudiantes);

                foreach (var p in instrutoresYEstudiantes)
                {
                    Console.WriteLine(p.Nombre);
                }

                Console.WriteLine(Environment.NewLine);

                var concatenarProps = instructores.Select(i => i.Nombre).Concat(estudiantes.Select(e => e.Nombre));

                foreach (var p in concatenarProps)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}

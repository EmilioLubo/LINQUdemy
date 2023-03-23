using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Combinador
    {
        public void Combinar()
        {
            IList<Curso> cursos = new List<Curso>()
            {
                new Curso(1, "POO"),
                new Curso(2, "JAVASCRIPT"),
                new Curso(3, "JAVA"),
                new Curso(4, "PATRONES DE DISEÑO")
            };

            IList<Estudiante> estudiantes = new List<Estudiante>()
            {
                new Estudiante(1, "Pedro", "Pol", 1),
                new Estudiante(2, "Ivon", "Rodriguez", 1),
                new Estudiante(3, "Micaela", "Straus", 2),
                new Estudiante(4, "Paco", "Landa", 3),
                new Estudiante(5, "Ramiro", "Etchegoyen", 4),
                new Estudiante(6, "Anastasia", "Shatova", 1),
                new Estudiante(7, "Michael", "Randall", 3),
                new Estudiante(8, "León", "Suarez", 4),
                new Estudiante(9, "María", "Leok", 4),
                new Estudiante(10, "Florencia", "Criatan", 2)
            };

            //JOIN

            //var estudiantesCursos = from e in estudiantes
            //                        join c in cursos
            //                        on e.CursoId equals c.Id
            //                        select new
            //                        {
            //                            EstudianteId = e.Id,
            //                            NombreCompleto = e.Nombre + " " + e.Apellido,
            //                            Curso = c.Nombre
            //                        };

            //var estudiantesCursos = estudiantes.Join(cursos, e => e.CursoId, c => c.Id,
            //                                         (e, c) => new
            //                                         {
            //                                             EstudianteId = e.Id,
            //                                             NombreCompleto = e.Nombre + " " + e.Apellido,
            //                                             Curso = c.Nombre
            //                                         });

            //foreach (var e in estudiantesCursos)
            //{
            //    Console.WriteLine($"Id: {e.EstudianteId}\t" +
            //        $"Nombre Completo: {e.NombreCompleto, -15}\t" +
            //        $"Curso: {e.Curso}");
            //}

            //GROUPJOIN

            //var grupo = from c in cursos
            //            join e in estudiantes
            //            on c.Id equals e.CursoId
            //            into grupoEstudiantes
            //            select new
            //            {
            //                CursoNombre = c.Nombre,
            //                Estudiantes = grupoEstudiantes
            //            };

            var grupo = cursos.GroupJoin(estudiantes, c => c.Id, e => e.CursoId,
                                            (c, e) => new
                                            {
                                                CursoNombre = c.Nombre,
                                                Estudiantes = e
                                            });

            foreach (var i in grupo.OrderBy(x => x.CursoNombre))
            {
                Console.WriteLine($"Estudiantes en: {i.CursoNombre}: ");

                foreach (var e in i.Estudiantes)
                {
                    Console.WriteLine($"Nombre: {e.Nombre} {e.Apellido}");
                }
                Console.WriteLine(Environment.NewLine);
            }

        }
    }

    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set;}

        public Curso(int id, string nombre) 
        {
            Id = id;
            Nombre = nombre;
        }
    }

    public class Estudiante
    {
        public int Id { get; set;}
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public int CursoId { get; set;}

        public Estudiante(int id, string nombre, string apellido, int cursoId)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            CursoId = cursoId;  
        }
    }
}

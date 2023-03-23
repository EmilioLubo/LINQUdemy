using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Proyector
    {
        public void Proyectar()
        {
            using (var db = new CursosVirtualesEntities())
            {
                //SELECT

                //var personas = (from p in db.Personas
                //                select p).Take(10).ToList();

                //var personas1 = (from p in db.Personas
                //                select p.Nombre).Take(10).ToList();
                //Console.WriteLine();

                //var personas2 = db.Personas.Select(p => p.Nombre).Take(10).ToList();

                //var personasConcat = (from p in db.Personas
                //                     where p.TipoPersona.Equals("instructor")
                //                     select p.Nombre + " " + p.Apellido).Take(10).ToList();

                //var personaFiltrada = db.Personas.Where(p => p.TipoPersona.Equals("instructor")).Select(p => p.Nombre + " " + p.Apellido).ToList();

                //personaFiltrada.ForEach(p =>
                //{
                //    Console.WriteLine(p);
                //});

                //var personas = (from p in db.Personas
                //                where p.Paises.Nombre.Equals("Ecuador")
                //                select new
                //                {
                //                    Id = p.PersonaId,
                //                    NombreCompleto = p.Nombre + " " + p.Apellido,
                //                    Email = p.CorreoElectronico,
                //                    Pais = p.Paises.Nombre
                //                }).ToList();

                //var personas = db.Personas.Where(p => p.Paises.Nombre.Equals("Ecuador"))
                //                            .Select(x => new
                //                            {
                //                                Id = x.PersonaId,
                //                                NombreCompleto = x.Nombre + " " + x.Apellido,
                //                                Email = x.CorreoElectronico,
                //                                Pais = x.Paises.Nombre
                //                            }).ToList()
                //                            .Select(y => new Personas
                //                            {
                //                                PersonaId = y.Id,
                //                                Nombre = y.NombreCompleto,
                //                                CorreoElectronico = y.Email
                //                            }).ToList();

                //personas.ForEach(p =>
                //{
                //    Console.WriteLine($"ID: {p.PersonaId}\t" +
                //        $"NOMBRE COMPLETO: {p.Nombre, -20}\t" +
                //        $"CORREO ELECTRONICO: {p.CorreoElectronico, -10}");
                //});

                //SELECTMANY

                //var letras = new[] { "a, b, c", "d, e", "f, g, h" };

                //var mixed = letras.SelectMany(l => l.Split(','));

                //foreach (var t in mixed)
                //{
                //    Console.Write(t + " ");
                //}
                var escuelas = new []
                {
                    new Escuela()
                    {
                        Estudiantes = new []
                        {
                            new Estudiante() { Nombre = "Pepe Anguila" },
                            new Estudiante() { Nombre = "Angela Leiva" },
                            new Estudiante() { Nombre = "Roberto Funes"}
                        }
                    },
                    new Escuela()
                    {
                        Estudiantes = new []
                        {
                            new Estudiante() { Nombre = "Romina Pietra" },
                            new Estudiante() { Nombre = "Carlos Avedutto" },
                            new Estudiante() { Nombre = "Natalia Rolla"}
                        }
                    },
                    new Escuela()
                    {
                        Estudiantes = new []
                        {
                            new Estudiante() { Nombre = "Juan Jerez" },
                            new Estudiante() { Nombre = "Nora Dalton" },
                            new Estudiante() { Nombre = "Federico Bertoloni"}
                        }
                    }
                };

                var estudiantes = escuelas.SelectMany(e => e.Estudiantes);

                foreach (var e in estudiantes)
                {
                    Console.WriteLine(e.Nombre);
                }
            }
        }
        public class Estudiante
        {
            public string Nombre { get; set; }
        }
        public class Escuela
        {
            public Estudiante[] Estudiantes { get; set; }
        }
    }
}

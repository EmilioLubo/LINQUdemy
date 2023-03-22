using LINQDataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Filtrado
    {
        public void Filtrar()
        {
            //var palabras = new string[] { "mesa", "cama", "habitación", "silla", "cocina", "patio", "casa", "mueble", "cuarto", "farol", };

            //IEnumerable<string> consulta = from p in palabras
            //                               where p.Length == 5
            //                               select p;
            //foreach (var p in consulta)
            //{
            //    Console.WriteLine(p);
            //}

            using (CursosVirtualesEntities db = new CursosVirtualesEntities())
            {
                //var paises = from p in db.Paises
                //             orderby p.ContinenteId, p.Nombre
                //             select p;

                //var paisesAmerica = from p in db.Paises
                //                    where p.Continentes.Nombre.Contains("América")
                //                    orderby p.ContinenteId, p.Nombre
                //                    select p;

                //var paisesAmericaOrEuropa = from p in db.Paises
                //                            where p.Continentes.Nombre.Contains("América") || p.Continentes.Nombre.Contains("Europa")
                //                            orderby p.ContinenteId, p.Nombre
                //                            select p;

                //var paisesAmYEuWithPop = from p in db.Paises
                //                         where p.Continentes.Nombre.Contains("América") && p.Poblacion > 10000000 && p.Establecido >= 1930
                //                         orderby p.ContinenteId, p.Nombre
                //                         select p;

                //paisesAmYEuWithPop.ToList().ForEach(p =>
                //{
                //    Console.WriteLine($"CONTINENTE: {p.Continentes.Nombre}, " +
                //        $"PAIS: {p.Nombre}, " +
                //        $"CAPITAL: {p.Capital}, " +
                //        $"ESTABLECIDO: {p.Establecido}.");
                //});

                //OFTYPE

                ArrayList mix = new ArrayList();

                mix.Add(3.14159);
                mix.Add("Rodrigo Bueno");
                mix.Add(29);
                mix.Add(new CursosVirtualesEntities().Continentes.FirstOrDefault());
                mix.Add("Juan Perez");
                mix.Add(new CursosVirtualesEntities().Continentes.AsEnumerable().Last());
                mix.Add(12);
                mix.Add("Perla Artois");
                mix.Add(19);
                mix.Add(1500.99);
                mix.Add(new Continentes
                {
                    ContinenteId = 7,
                    Nombre = "Pangea",
                    FechaRegistro = DateTime.Now,
                    FechaModificacion = DateTime.Now,
                    Estado = true
                });

                //IEnumerable<int> enteros = mix.OfType<int>();
                
                IEnumerable<int> enteros = from e in mix.OfType<int>()
                                   select e;

                //foreach (int entero in enteros)
                //{
                //    Console.WriteLine(entero);
                //}
                enteros.ToList().ForEach(e => {
                    Console.WriteLine(e);
                    });

                var continentes = (from c in mix.OfType<Continentes>()
                                  select c).ToList();

                continentes.ForEach(c =>
                {
                    Console.WriteLine(c.Nombre);
                });

            }
        }
    }
}

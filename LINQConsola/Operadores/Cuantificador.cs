using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class Cuantificador
    {
        public void Cuantificar()
        {
            //ANY

            //int[] numeros = { 6, 7, 8, 3, 23, 48 };

            //if (numeros.Any())
            //{
            //    Console.WriteLine($"El arreglo contiene datos: {numeros.Any()}");
            //}
            //else
            //{
            //    Console.WriteLine($"El arreglo no contiene datos: {numeros.Any()}");
            //}

            using (var db = new CursosVirtualesEntities())
            {
                //string idioma = "ruso";

                //bool hayCursos = db.Cursos.Any(c => c.Idioma == idioma);

                //if (hayCursos)
                //{
                //    Console.WriteLine($"Existen cursos en {idioma}");
                //}
                //else
                //{
                //    Console.WriteLine($"No existen cursos en {idioma}");
                //}

                //ALL

                //string[] palabras = new string[] { "mcasa", "mesa", "msilla" };

                //var consulta = palabras.All(p => p.StartsWith("m")) ? "Todas las palabras empiezan con 'm'." : "No todas las palabras empiezan con 'm'";

                //Console.WriteLine(consulta);

                //int limite = 5;

                //var precioBase5 = db.Cursos.All(c => c.Precio >= limite) ? "si" : "no";

                //Console.WriteLine($"¿ Todos los cursos cuestas más de ${limite} ? : {precioBase5}");

                //var idiomaPrecio = db.Cursos.All(
                //    c => c.Precio >= limite 
                //    //&& c.Idioma == "ingles"
                //    ) ?
                //    "Si" : 
                //    "No";

                //Console.WriteLine($"¿Todos los cursos de inglés son de ${limite} o más? => {idiomaPrecio}");

                //CONTAINS

                List<Cliente> clientes = new List<Cliente>()
                {
                    new Cliente { Nombre = "Juan Perez", Fruta = new string[] { "manzana", "cereza", "banana" } },
                    new Cliente { Nombre = "Ramon Diaz", Fruta = new string[] { "uva", "cereza", "durazno" } },
                    new Cliente { Nombre = "Elba Gallo", Fruta = new string[] { "manzana", "banana", "cereza" } },
                    new Cliente { Nombre = "Armando Ese", Fruta = new string[] { "banana", "mandarina", "uva" } }
                };

                string fruta = "manzana";

                var listadoClientes = from c in clientes
                                      where c.Fruta.Contains(fruta)
                                      select c.Nombre;
                listadoClientes.ToList().ForEach(c =>
                {
                    Console.WriteLine(c);
                });

            }
        }
    }

    class Cliente
    {
        public string Nombre { get; set; }
        public string[] Fruta { get; set; }
    }
}

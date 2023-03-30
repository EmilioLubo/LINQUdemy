using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public class LinqToString
    {
        public static string EliminarEspacios(string cadena)
        {
            var result = from c in cadena.ToLowerInvariant().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         select c;

            var nuevaCadena = new StringBuilder();

            foreach (var c in result)
            {
                nuevaCadena.Append(c).Append(" ");
            }

            return nuevaCadena.ToString();

        }

        public static string RepeticionPalabra (string cadena, string texto)
        {
            int repeticiones = 0;

            string[] fuente = texto.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var buscada = from p in fuente
                          where p.ToLowerInvariant() == cadena.ToLowerInvariant()
                          select p;

            repeticiones = buscada.Count();

            return $"La palabra {cadena} se repite {repeticiones} veces.";
        }

        public static void ReordenarListado(string rutaArchivo)
        {
            var lineas = File.ReadAllLines(rutaArchivo);

            foreach (var l in lineas)
            {
                Console.WriteLine(l);
            }

            Console.WriteLine(Environment.NewLine);

            var consulta = (from l in lineas
                           let col = l.Split(',')
                           orderby col[2]
                           select col[2].Trim() + "," + col[0] + "," + col[1]).ToArray();

            foreach (var l in consulta)
            {
                Console.WriteLine(l);
            }
        }
    }
}

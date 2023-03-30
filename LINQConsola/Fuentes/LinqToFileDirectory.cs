using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public class LinqToFileDirectory
    {
        public static void BuscarArchivosEnDirectorios(string carpeta, string extensión)
        {
            var dir = new DirectoryInfo(carpeta);

            IEnumerable<FileInfo> files = dir.GetFiles("*.*", SearchOption.AllDirectories);

            IEnumerable<FileInfo> query = from f in files
                                          where f.Extension.Equals(extensión)
                                          orderby f.Name
                                          select f;

            if (query.Any())
            {
                Console.WriteLine($"Se encontraron {query.Count()} archivos.\n");

                int i = 1;

                foreach (var f in query)
                {
                    Console.WriteLine($"{i++}. {f.FullName} - [{f.CreationTime}]");
                }
            }
            else
            {
                Console.WriteLine("No se enontraron archivos.");
            }
        }

        public static void ObtenerBytesEnCarpeta(string carpeta)
        {
            var files = Directory.GetFiles(carpeta, "*.*", SearchOption.AllDirectories);

            var query = from f in files
                        select ObtenerLongitudArchivo(f);

            long[] longitudArchivos = query.ToArray();

            long totalBytes = longitudArchivos.Sum();

            Console.WriteLine($"Hay {totalBytes.ToString()} bytes en {files.Count()} archivos dentro de {carpeta}.");
        }

        private static long ObtenerLongitudArchivo(string file)
        {
            long longitud;

            try
            {
                FileInfo fileI = new FileInfo(file);
                longitud = fileI.Length;
            }
            catch(FileNotFoundException ex)
            {
                longitud = 0;
            }
            return longitud;
        }

        public static void BuscarTexto(string carpeta, string busqueda, string ext)
        {
            var dir = new DirectoryInfo(carpeta);

            var files = dir.GetFiles("*.*", SearchOption.AllDirectories);

            var query = from f in files
                        where f.Extension.Equals(ext)
                        let texto = BuscarEnElArchivo(f.FullName)
                        where texto.Contains(busqueda)
                        select f.FullName;

            if (query.Any())
            {
                Console.WriteLine($"Se encontró el término {busqueda} en:\n");
                foreach(var f in query)
                {
                    Console.WriteLine(f);
                }
            }
            else
            {
                Console.WriteLine($"No se encontró coincidencia con {busqueda}");
            }
        }

        private static string BuscarEnElArchivo(string nombre)
        {
            var content = string.Empty;
            if (File.Exists(nombre))
            {
                content = File.ReadAllText(nombre);
            }
            return content;
        }
    }
}

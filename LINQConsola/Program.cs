using LINQConsola.Fuentes;
using LINQConsola.Operadores;
using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new Ordenacion().Ordenar();

            //new Conjuntos().Conjunto();

            //new Filtrado().Filtrar();

            //new Cuantificador().Cuantificar();

            //new Proyector().Proyectar();

            //new Particionador().Particionar();

            //new Combinador().Combinar();

            //new Agrupador().Agrupar();

            //new Generador().Generar();

            //new Igualador().Igualar();

            //new DeElementos().SobreElementos();

            //new ConversorDeTipo().Convertir();

            //new Concatenador().Concatenar();

            //new Agregacion().Agregar();

            //var cadena = "Hola           qué   qué      tal   qué       ,              ¿cómo     qué       estás?";

            //Console.WriteLine(LinqToString.EliminarEspacios(cadena));

            //Console.WriteLine(LinqToString.RepeticionPalabra("qué", cadena));

            //LinqToString.ReordenarListado("../../Archivos/Listado.csv");

            //var ensamblado = new LinqToReflection("MiLibreria");

            //ensamblado.GetInfo();

            //LinqToFileDirectory.BuscarArchivosEnDirectorios(@"C:\Users\Usuario\OneDrive\Documentos\CursosDev\C#.NETCORE", ".txt");

            //LinqToFileDirectory.ObtenerBytesEnCarpeta("C:\\Users\\Usuario\\OneDrive\\Documentos\\CursosDev\\C#.NETCORE");

            //LinqToFileDirectory.BuscarTexto("../../Archivos/", "Lorem", ".txt");

            //LinqToXML.LeerXML();

            //LinqToXML.CrearXML();

            //LinqToXML.Agregar();

            //LinqToXML.Eliminar();

            //LinqToXML.Actualizar();

            //LinqToObject.LinqConObjetos();

            //LinqToArrayList.ObtenerEstudiantes();

            //LinqToSql.Agregar();

            //LinqToSql.Actualizar(125);

            //LinqToSql.Eliminar(125);

            //LinqToDataSet.LinqWDataSets();

            var enteros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var elementosAlterados = enteros.AlternateElements();

            foreach (var element in elementosAlterados )
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}

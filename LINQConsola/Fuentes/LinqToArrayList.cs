using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int[] Notas { get; set; }

        public Estudiante(string nombre, string apellido, int[] notas)
        {
            Nombre = nombre;
            Apellido = apellido;
            Notas = notas;
        }
    }
    public class LinqToArrayList
    {
        public static void ObtenerEstudiantes()
        {
            var arrayEstudiantes = new ArrayList();

            arrayEstudiantes.Add(new Estudiante("Carlos", "Flores", new int[] { 9, 8, 10 }));
            arrayEstudiantes.Add(new Estudiante("Amalia", "Junco", new int[] { 6, 2, 78 }));
            arrayEstudiantes.Add(new Estudiante("Marcos", "Ramirez", new int[] { 6, 12, 23 }));
            arrayEstudiantes.Add(new Estudiante("Mateo", "Jesue", new int[] { 67, 4, 6 }));
            arrayEstudiantes.Add(new Estudiante("Nora", "Rosales", new int[] { 7, 65, 1 }));

            var estudiantes = from Estudiante estudiante in arrayEstudiantes
                              where estudiante.Notas[0] >= 7
                              select estudiante;

            foreach (var e in estudiantes)
            {
                Console.WriteLine($"{e.Nombre} {e.Apellido}, Nota 1: {e.Notas[0]}");
            }
        }
    }
}

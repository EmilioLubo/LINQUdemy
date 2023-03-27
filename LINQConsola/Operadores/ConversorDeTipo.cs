using LINQDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Operadores
{
    public class ConversorDeTipo
    {
        public void Convertir()
        {
            using (var db = new CursosVirtualesEntities())
            {
                //ASENUMERABLE

                //var persona = db.Personas.AsEnumerable().Last();

                //Console.WriteLine(persona.Nombre);

                //CAST

                //var enteros = new List<IComparable> { 3, 45, 12, 72, 5, 6, 44, 13 };

                //var resultado = enteros.Cast<int>();

                //foreach ( var e in resultado) 
                //{
                //    Console.WriteLine(e);
                //}

                //TOARRAY

                //var cursos = db.Cursos.Take(10);

                //string[] cursosNombre = cursos.Select(c => c.Nombre).ToArray();

                //for (int i = 1; i < cursosNombre.Length; i++)
                //{
                //    Console.WriteLine($"{i}. {cursosNombre[i]}");
                //}

                //TODICTIONARY

                //var continentes = db.Continentes.ToDictionary(c => c.ContinenteId, c => c.Nombre);

                //foreach (KeyValuePair<int, string> item in continentes)
                //{
                //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                //}

                //var cursos = from c in db.Cursos.Take(10)
                //             select c;

                //var cursosDict = cursos.ToDictionary(c => c.CursoId);

                //foreach (KeyValuePair<int, Cursos> c in cursosDict)
                //{
                //    Console.WriteLine($"ID: {c.Key}," +
                //        $"Nombre: {c.Value.Nombre}," +
                //        $"Precio: ${c.Value.Precio}");
                //}

                //TOLIST

                var dias = new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

                var diasList = dias.ToList();

                foreach (var d in diasList)
                {
                    Console.WriteLine(d);
                }
            }
        }
    }
}

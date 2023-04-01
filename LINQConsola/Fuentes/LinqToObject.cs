using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola.Fuentes
{
    public class LinqToObject
    {
        public static void LinqConObjetos()
        {
            //var lenguajes = new string[] { "C#", "Java", "JavaScript", "C++", "Python", "Asp.Net", "Cobol" };

            //var lista = from l in lenguajes
            //            where l.ToLower().Substring(0, 1).Equals("c")
            //            select l;

            //foreach (var l in lista)
            //{
            //    Console.WriteLine(l);
            //}

            var personas = new List<Person>
            {
                new Person(1, "Carlos"),
                new Person(2, "Lidia"),
                new Person(3, "Angela"),
                new Person(4, "Pedro")
            };

            var listaPersonas = from p in personas
                                select p;

            foreach(var p in listaPersonas )
            {
                Console.WriteLine($"{p.Id}: {p.Name}");
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
